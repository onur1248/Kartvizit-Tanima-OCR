using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KartvizitTANIMA
{
    public partial class KarakterTanima : Form
    {


        #region    ***** Değişkenler *****
        private bool _selecting;
        private Rectangle _selection;
        private Point ilkKonum, sonKonum;
        Bitmap CropGecici;
        
        public KarakterTanima()
        {
            InitializeComponent();
        }

        #endregion    ***** Değişkenler *****

        /*---------------------------------------------------------------------------------------------------*/

        #region    ***** Kamera ve Resim Açma Fonksiyonları *****
        private void btnResimAc_Click(object sender, EventArgs e)
        {
            //Dosya aç dialog pencerisini aç.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")  //Dosya adı boş değilse
                {
                    pxbResimAlani.Image = Image.FromFile(openFileDialog1.FileName);
                    if (pxbResimAlani.Image.Height > pxbResimAlani.Image.Width)
                    {
                        pxbResimAlani.Size = new Size(pxbResimAlani.Image.Width*430/pxbResimAlani.Image.Height , 430);
                    }
                    if (pxbResimAlani.Image.Height < pxbResimAlani.Image.Width)
                    {
                        pxbResimAlani.Size = new Size(430,pxbResimAlani.Image.Height * 430 / pxbResimAlani.Image.Width);
                    }
                    pxbResimAlani.SizeMode = PictureBoxSizeMode.StretchImage;
                    pxbResimAlani.Refresh(); //pxbResim_Paint Metodunu çağırır.
                }
            }
        }
        private void GoruntuAl_Click(object sender, EventArgs e)
        {
            Kamera Resim = new Kamera();
            Resim.Show();
        }
        private void btnKayitlar_Click(object sender, EventArgs e)
        {
            Kayitlar kayit = new Kayitlar();
            kayit.Show();
        }


        #endregion    ***** Kamera ve Resim Açma Fonksiyonları *****

        /*---------------------------------------------------------------------------------------------------*/

        #region    ***** Seçilen Resim Parçasını Alma *****

        private void rdAyarla()
        {
            Crop();
            if (CropGecici != null)
            {
                OCR oku = new OCR(CropGecici);

                if (rdAd.Checked)
                {
                    txtAd.Text = oku.kop();
                }
                else if (rdSoyad.Checked)
                {
                    txtSoyad.Text = oku.kop();
                }
                else if (rdTel.Checked)
                {
                    txtTel.Text = oku.kop();
                }
                else if (rdAdres.Checked)
                {
                    txtAdres.Text = oku.kop();
                }
            }
        }
        private void Crop()
        {
            try
            {
                float orIm = pxbResimAlani.Image.Width;
                float grIm = pxbResimAlani.Width;
                float buyumeOrani = orIm / grIm;
                

                ilkKonum.X = (int)(ilkKonum.X * buyumeOrani);
                ilkKonum.Y=(int)(ilkKonum.Y*buyumeOrani);
                sonKonum.X = (int)(sonKonum.X*buyumeOrani);
                sonKonum.Y= (int)(sonKonum.Y*buyumeOrani);
                Rectangle rt = rec(ilkKonum, sonKonum);
                int cropX = rt.X;
                int cropY = rt.Y;
                int cropWidth = rt.Width;
                int cropHeight = rt.Height;
                if (cropWidth < 1)
                {
                    return;
                }
                Bitmap _img = new Bitmap(cropWidth, cropHeight);
                // for cropinf image
                Graphics g = Graphics.FromImage(_img);
                // create graphics
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //set image attributes
                g.DrawImage(pxbResimAlani.Image, 0, 0, rt, GraphicsUnit.Pixel);

                CropGecici = new Bitmap(cropWidth, cropHeight);
                CropGecici = _img;
                //pxbResimAlani.Image = CropGecici;
            }
            catch (Exception)
            {
                MessageBox.Show("Kesme işleminde hata oluştu.Lütfen resim yükleyiniz.","Uyarı");
            }
        }


        #endregion    ***** Seçilen Resim Parçasını Alma *****

        /*---------------------------------------------------------------------------------------------------*/

        #region    ***** Resimden Seçim yapma İşlemleri *****

        private Rectangle rec(Point p1,Point p2)
        {
            //Dikdörtgensel bir yapı tut.
            Rectangle rec = new Rectangle();
            rec.X = (p1.X > p2.X ? p2.X : p1.X); //x koordinatı
            rec.Y = (p1.Y > p2.Y ? p2.Y : p1.Y); //y koordinatı
            rec.Width = Math.Abs(p1.X - p2.X);   //genişlik
            rec.Height = Math.Abs(p1.Y - p2.Y);  //Yükseklik
            return rec;
        }
        private void pxbResimAlani_Paint(object sender, PaintEventArgs e)
        {
            if (_selecting)
            {
                Pen pen = Pens.Green;
                e.Graphics.DrawRectangle(pen, rec(ilkKonum, sonKonum));
            }
        }
        private void pxbResimAlani_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Cross;
            if (e.Button == MouseButtons.Left)
            {
                ilkKonum = e.Location; //Fare tuşuna basıldığı andaki koordinatı tut.
                _selecting = true;
                _selection = new Rectangle(new Point(ilkKonum.X, ilkKonum.Y), new Size());
            }
        }
        private void pxbResimAlani_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sonKonum = e.Location;
                pxbResimAlani.Refresh();
            }
        }
        private void pxbResimAlani_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            sonKonum = e.Location;
            rdAyarla();
        }

        

        #endregion    ***** Resimden Seçim yapma İşlemleri *****

        /*---------------------------------------------------------------------------------------------------*/

        #region     ***** Veritabanı İşlemleri *****

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=ONUR;Integrated Security=TRUE;Initial Catalog=Rehber");
                SqlCommand cmd = new SqlCommand();
                con.Open();

                SqlParameterCollection param = cmd.Parameters;
                param.AddWithValue("@Adi", txtAd.Text);
                param.AddWithValue("@Soyadi", txtSoyad.Text);
                param.AddWithValue("@TelNo", txtTel.Text.Trim());
                param.AddWithValue("@Adres", txtAdres.Text);
                cmd.CommandText = "Insert into Kartvizit(Adi,Soyadi,TelNo,Adres) values (@Adi,@Soyadi,@TelNo,@Adres)";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Telefon numarasına ait kayıt bulunmaktadır.","Uyarı");
            }
        }


        #endregion    ***** Veritabanı İşlemleri *****

    }
}