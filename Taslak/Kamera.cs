using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace KartvizitTANIMA
{
    public partial class Kamera : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public Kamera()
        {
            InitializeComponent();
        }

        private void Kamera_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cbKameralar.Items.Add(Device.Name);
            }
            cbKameralar.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbKameralar.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pxbKamera.Image=(Bitmap)eventArgs.Frame.Clone();
        }

        private void Kamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning==true)
            {
                FinalFrame.Stop();
            }
            if (pxbCekilenResim.Image!=null) {
                KarakterTanima KarakterTanima = (KarakterTanima)Application.OpenForms["KarakterTanima"];
                KarakterTanima.pxbResimAlani.Image = pxbCekilenResim.Image;
                if (pxbCekilenResim.Image.Height > pxbCekilenResim.Image.Width)
                {
                    KarakterTanima.pxbResimAlani.Size = new System.Drawing.Size(KarakterTanima.pxbResimAlani.Image.Width * 430 / KarakterTanima.pxbResimAlani.Image.Height, 430);
                }
                if (KarakterTanima.pxbResimAlani.Image.Height < KarakterTanima.pxbResimAlani.Image.Width)
                {
                    KarakterTanima.pxbResimAlani.Size = new System.Drawing.Size(430, KarakterTanima.pxbResimAlani.Image.Height * 430 / KarakterTanima.pxbResimAlani.Image.Width);
                }
                KarakterTanima.pxbResimAlani.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGoruntuAl_Click(object sender, EventArgs e)
        {
            pxbCekilenResim.Image = (Bitmap)pxbKamera.Image.Clone();
        }
    }
}
