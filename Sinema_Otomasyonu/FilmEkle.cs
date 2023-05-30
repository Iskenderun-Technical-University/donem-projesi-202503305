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
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Film_BilgileriTableAdapter filmler=new sinemaTableAdapters.Film_BilgileriTableAdapter();

        private void FilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalonEkleme_Click(object sender, EventArgs e)
        {
            try
            {
                filmler.FilmEkleme(txtfilmadi.Text, txtyonetmen.Text, cmbfilmturu.Text, txtsure.Text,txtyapimyili.Text, datetarih.Text,pictureBox1.ImageLocation);
                MessageBox.Show("basariyla eklendi","kayit");
            }
            catch (Exception)
            {

                MessageBox.Show("daha once eklendi", "uyari");
            }
            
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    cmbfilmturu.Text = "";
                }
            }
        }

        private void btnafisekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ass = new Form1();
            ass.Show();
            this.Hide();
        }
    }
}
