using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace KartvizitTANIMA
{
    public partial class Kayitlar : Form
    {
        public Kayitlar()
        {
            InitializeComponent();
        }

        private void Kayitlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rehberDataSet.Kartvizit' table. You can move, or remove it, as needed.
            this.kartvizitTableAdapter.Fill(this.rehberDataSet.Kartvizit);

        }
    }
}
