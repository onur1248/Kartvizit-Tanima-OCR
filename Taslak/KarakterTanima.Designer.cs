namespace KartvizitTANIMA
{
    partial class KarakterTanima
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarakterTanima));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnResimAc = new System.Windows.Forms.Button();
            this.GoruntuAl = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pxbResimAlani = new System.Windows.Forms.PictureBox();
            this.rdAd = new System.Windows.Forms.RadioButton();
            this.rdSoyad = new System.Windows.Forms.RadioButton();
            this.rdTel = new System.Windows.Forms.RadioButton();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.rdAdres = new System.Windows.Forms.RadioButton();
            this.btnKayitlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pxbResimAlani)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnResimAc
            // 
            this.btnResimAc.Location = new System.Drawing.Point(12, 12);
            this.btnResimAc.Name = "btnResimAc";
            this.btnResimAc.Size = new System.Drawing.Size(57, 40);
            this.btnResimAc.TabIndex = 1;
            this.btnResimAc.Text = "Resim Aç";
            this.btnResimAc.UseVisualStyleBackColor = true;
            this.btnResimAc.Click += new System.EventHandler(this.btnResimAc_Click);
            // 
            // GoruntuAl
            // 
            this.GoruntuAl.Location = new System.Drawing.Point(12, 69);
            this.GoruntuAl.Name = "GoruntuAl";
            this.GoruntuAl.Size = new System.Drawing.Size(57, 40);
            this.GoruntuAl.TabIndex = 4;
            this.GoruntuAl.Text = "Görüntü Al";
            this.GoruntuAl.UseVisualStyleBackColor = true;
            this.GoruntuAl.Click += new System.EventHandler(this.GoruntuAl_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(517, 341);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(69, 30);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pxbResimAlani
            // 
            this.pxbResimAlani.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pxbResimAlani.Location = new System.Drawing.Point(75, 12);
            this.pxbResimAlani.Name = "pxbResimAlani";
            this.pxbResimAlani.Size = new System.Drawing.Size(430, 430);
            this.pxbResimAlani.TabIndex = 7;
            this.pxbResimAlani.TabStop = false;
            this.pxbResimAlani.Paint += new System.Windows.Forms.PaintEventHandler(this.pxbResimAlani_Paint);
            this.pxbResimAlani.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pxbResimAlani_MouseDown);
            this.pxbResimAlani.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxbResimAlani_MouseMove);
            this.pxbResimAlani.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pxbResimAlani_MouseUp);
            // 
            // rdAd
            // 
            this.rdAd.AutoSize = true;
            this.rdAd.Checked = true;
            this.rdAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAd.Location = new System.Drawing.Point(517, 17);
            this.rdAd.Name = "rdAd";
            this.rdAd.Size = new System.Drawing.Size(46, 21);
            this.rdAd.TabIndex = 8;
            this.rdAd.TabStop = true;
            this.rdAd.Text = "Adı";
            this.rdAd.UseVisualStyleBackColor = true;
            // 
            // rdSoyad
            // 
            this.rdSoyad.AutoSize = true;
            this.rdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdSoyad.Location = new System.Drawing.Point(517, 98);
            this.rdSoyad.Name = "rdSoyad";
            this.rdSoyad.Size = new System.Drawing.Size(69, 21);
            this.rdSoyad.TabIndex = 9;
            this.rdSoyad.Text = "Soyadı";
            this.rdSoyad.UseVisualStyleBackColor = true;
            // 
            // rdTel
            // 
            this.rdTel.AutoSize = true;
            this.rdTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTel.Location = new System.Drawing.Point(517, 179);
            this.rdTel.Name = "rdTel";
            this.rdTel.Size = new System.Drawing.Size(138, 21);
            this.rdTel.TabIndex = 10;
            this.rdTel.Text = "Telefon Numarası";
            this.rdTel.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(517, 56);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(232, 20);
            this.txtAd.TabIndex = 11;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(517, 137);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(232, 20);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(517, 218);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(232, 20);
            this.txtTel.TabIndex = 13;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(517, 299);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(232, 20);
            this.txtAdres.TabIndex = 15;
            // 
            // rdAdres
            // 
            this.rdAdres.AutoSize = true;
            this.rdAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAdres.Location = new System.Drawing.Point(517, 260);
            this.rdAdres.Name = "rdAdres";
            this.rdAdres.Size = new System.Drawing.Size(63, 21);
            this.rdAdres.TabIndex = 14;
            this.rdAdres.Text = "Adres";
            this.rdAdres.UseVisualStyleBackColor = true;
            // 
            // btnKayitlar
            // 
            this.btnKayitlar.Location = new System.Drawing.Point(12, 126);
            this.btnKayitlar.Name = "btnKayitlar";
            this.btnKayitlar.Size = new System.Drawing.Size(57, 40);
            this.btnKayitlar.TabIndex = 16;
            this.btnKayitlar.Text = "Kayıtları Listele";
            this.btnKayitlar.UseVisualStyleBackColor = true;
            this.btnKayitlar.Click += new System.EventHandler(this.btnKayitlar_Click);
            // 
            // KarakterTanima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 451);
            this.Controls.Add(this.btnKayitlar);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.rdAd);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.rdAdres);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.rdTel);
            this.Controls.Add(this.rdSoyad);
            this.Controls.Add(this.pxbResimAlani);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.GoruntuAl);
            this.Controls.Add(this.btnResimAc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(848, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(848, 490);
            this.Name = "KarakterTanima";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kartvizit Kayıt Programı";
            ((System.ComponentModel.ISupportInitialize)(this.pxbResimAlani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnResimAc;
        private System.Windows.Forms.Button GoruntuAl;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rdAd;
        private System.Windows.Forms.RadioButton rdSoyad;
        private System.Windows.Forms.RadioButton rdTel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.RadioButton rdAdres;
        public System.Windows.Forms.PictureBox pxbResimAlani;
        private System.Windows.Forms.Button btnKayitlar;
    }
}

