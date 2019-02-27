namespace KartvizitTANIMA
{
    partial class Kamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kamera));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pxbKamera = new System.Windows.Forms.PictureBox();
            this.pxbCekilenResim = new System.Windows.Forms.PictureBox();
            this.btnGoruntuAl = new System.Windows.Forms.Button();
            this.cbKameralar = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbKamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbCekilenResim)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pxbKamera, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pxbCekilenResim, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 231);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pxbKamera
            // 
            this.pxbKamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxbKamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxbKamera.Location = new System.Drawing.Point(3, 3);
            this.pxbKamera.Name = "pxbKamera";
            this.pxbKamera.Size = new System.Drawing.Size(300, 225);
            this.pxbKamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxbKamera.TabIndex = 0;
            this.pxbKamera.TabStop = false;
            // 
            // pxbCekilenResim
            // 
            this.pxbCekilenResim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pxbCekilenResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxbCekilenResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxbCekilenResim.Location = new System.Drawing.Point(309, 3);
            this.pxbCekilenResim.Name = "pxbCekilenResim";
            this.pxbCekilenResim.Size = new System.Drawing.Size(300, 225);
            this.pxbCekilenResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxbCekilenResim.TabIndex = 1;
            this.pxbCekilenResim.TabStop = false;
            // 
            // btnGoruntuAl
            // 
            this.btnGoruntuAl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGoruntuAl.Location = new System.Drawing.Point(417, 249);
            this.btnGoruntuAl.Name = "btnGoruntuAl";
            this.btnGoruntuAl.Size = new System.Drawing.Size(96, 23);
            this.btnGoruntuAl.TabIndex = 1;
            this.btnGoruntuAl.Text = "Görüntü Al";
            this.btnGoruntuAl.UseVisualStyleBackColor = true;
            this.btnGoruntuAl.Click += new System.EventHandler(this.btnGoruntuAl_Click);
            // 
            // cbKameralar
            // 
            this.cbKameralar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbKameralar.FormattingEnabled = true;
            this.cbKameralar.Location = new System.Drawing.Point(37, 251);
            this.cbKameralar.Name = "cbKameralar";
            this.cbKameralar.Size = new System.Drawing.Size(278, 21);
            this.cbKameralar.TabIndex = 2;
            // 
            // Kamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 292);
            this.Controls.Add(this.cbKameralar);
            this.Controls.Add(this.btnGoruntuAl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kamera";
            this.Text = "Kamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kamera_FormClosing);
            this.Load += new System.EventHandler(this.Kamera_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxbKamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbCekilenResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pxbKamera;
        private System.Windows.Forms.Button btnGoruntuAl;
        private System.Windows.Forms.ComboBox cbKameralar;
        public System.Windows.Forms.PictureBox pxbCekilenResim;
    }
}