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
    public partial class SatisListeleme : Form
    {
        public SatisListeleme()
        {
            InitializeComponent();
        }

        
        sinemaTableAdapters.Satis_BilgileriTableAdapter SatisListesi = new sinemaTableAdapters.Satis_BilgileriTableAdapter();
        private void ToplamUcretHesaplama()
        {
            int parsedValue;
           int ucret_toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                
                //ucret_toplam += int.Parse((string)dataGridView1.Rows[i].Cells["Ucret"].Value);
                ucret_toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["Ucret"].Value);

            }
            
        }
         private void SatisListeleme_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SatisListesi.SatisListesi2();
           // ToplamUcretHesaplama();
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SatisListesi.TariheGoreListele2(dateTimePicker1.Text);

            ToplamUcretHesaplama();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SatisListesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesaplama();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
