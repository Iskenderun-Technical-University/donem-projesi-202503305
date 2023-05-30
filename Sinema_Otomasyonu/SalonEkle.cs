using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class SalonEkle : Form
    {
        public SalonEkle()
        {
            InitializeComponent();
        }
        
        private void SalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 anasayfa = new Form1(); ;
            anasayfa.ShowDialog();
            this.Hide();
        }
        sinemaTableAdapters.Salon_BilgileriTableAdapter salon=new sinemaTableAdapters.Salon_BilgileriTableAdapter();    
        private void btnSalonEkleme_Click(object sender, EventArgs e)
        {
            try
            {
                salon.Salon_Ekleme(txtSalonAdi.Text);
                MessageBox.Show("eklendi", "kayit");
            }
            catch (Exception)
            {

                MessageBox.Show("salon eklenmedi", "uyari");
            }
            txtSalonAdi.Text = "";
        }

        private void SalonEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ass = new Form1();
            ass.Show();
            this.Hide();
        }
    }
}
