using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitaplikForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KitapVT kitapVT = new KitapVT();

            dataGridView1.DataSource = kitapVT.Liste();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            KitapVT kitapVT = new KitapVT();

            k.AD = txtKitapAd.Text;
            k.YAZAR = txtYazar.Text;

            kitapVT.KitapEkle(k);

            MessageBox.Show("Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            kitapVT.Liste();
        }
    }
}
