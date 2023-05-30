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

namespace Sinema_Otomasyonu
{
    public partial class Seans_Listele : Form
    {
        public Seans_Listele()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DQFKF79;Initial Catalog=Sinema_Bileti;Integrated Security=True");
        DataTable tablo=new DataTable();


        private void seans_listesi(string sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr=new SqlDataAdapter(sql,baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }
        private void Seans_Listele_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            seans_listesi("select * from Seans_Bilgileri where tarih like'" + dateTimePicker1.Text+"'");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            seans_listesi("select * from Seans_Bilgileri where tarih like'" + dateTimePicker1.Text + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seans_listesi("select * from Seans_Bilgileri ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ass = new Form1();
            ass.Show();
            this.Hide();
        }
    }
}
