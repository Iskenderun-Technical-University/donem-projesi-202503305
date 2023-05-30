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
    public partial class SeansEkle : Form
    {
        sinemaTableAdapters.Seans_BilgileriTableAdapter film_seansi=new sinemaTableAdapters.Seans_BilgileriTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DQFKF79;Initial Catalog=Sinema_Bileti;Integrated Security=True");
        public SeansEkle()
        {
            InitializeComponent();
        }


       

        private void datetarih_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
            }

            DateTime bugun=DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni=DateTime.Parse(datetarih.Text);

            if(yeni==bugun)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;

                    }
                }
               //karsilastir();
            }
            else if (yeni>bugun)
            {
               // karsilastir();
            }
            else if (yeni<bugun)
            {
                MessageBox.Show("geri donuk işlem secilemez","uyari");
                datetarih.Text=DateTime.Now.ToShortDateString();

            }
        }/*
 private void karsilastir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Seans_Bilgileri where Salon='" + cmbsalonadi.Text + "'and Tarih'" + datetarih.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read() == true)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    if (oku["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }*/
        
private void filmvesalonugoster(ComboBox combo,string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql,baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read()==true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }
        sinemaTableAdapters.Seans_BilgileriTableAdapter seanslar = new sinemaTableAdapters.Seans_BilgileriTableAdapter();
        string seans = "";

        private void radiobuttonseciliyse()
        {
                 if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {  
            radiobuttonseciliyse();
            
            if(seans!="")
            {
              
                seanslar.seansekleme(cmbfilmadi.Text, cmbsalonadi.Text, datetarih.Text, seans);
                MessageBox.Show("seans basariyla eklendi");
            }
            else if(seans=="")
            {
                MessageBox.Show("seans kısmi hatali");
            }

            cmbsalonadi.Text = "";
            cmbfilmadi.Text = "";
            datetarih.Text=DateTime.Now.ToShortDateString();

        }

        private void SeansEkle_Load(object sender, EventArgs e)
        {
            filmvesalonugoster(cmbfilmadi, "select * from Film_Bilgileri", "FilmAdi");
            filmvesalonugoster(cmbsalonadi, "select * from Salon_Bilgileri", "SalonAdi");
        }

        private void cmbsalonadi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SeansEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 anasayfa = new Form1(); ;
            anasayfa.ShowDialog();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ass = new Form1();
            ass.Show();
            this.Hide();
        }
    }
}
