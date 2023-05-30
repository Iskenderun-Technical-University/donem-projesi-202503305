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
    public partial class Form1 : Form
    {
        //SqlConnection baglanti = new SqlConnection("");
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DQFKF79;Initial Catalog=Sinema_Bileti;Integrated Security=True");

        int sayac = 0;

        private void FilmveSalonGetir(ComboBox combo, string sql1, string sql2)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        private void FilmAfisiGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Film_Bilgileri where FilmAdi='" + comboBox1.SelectedItem + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                pictureBox1.ImageLocation = oku["resim"].ToString();

            }
            baglanti.Close();
        }
        private void ComboDoluKoltuklar()
        {
            comboBox5.Items.Clear();
            comboBox5.Text = "";

            foreach (Control item in groupBox4.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        comboBox5.Items.Add(item.Text);
                    }
                }
            }

        }

        private void YenidenRenklendir()
        {
            foreach (Control item in groupBox4.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }

        }

        private void VeriTabanıDoluKoltuklar()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Satis_Bilgileri Where FilmAdi='" + comboBox1.SelectedItem + "'and SalonAdi='" + comboBox2.Text + "'and Tarih='" + comboBox3.SelectedItem + "'and Saat='" + comboBox6.SelectedItem + "'", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                foreach (Control item in groupBox4.Controls)
                {
                    if (item is Button)
                    {
                        if (oku["KoltukNo"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;

                        }
                    }
                }
            }
            baglanti.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Bos_Koltuklar();
            FilmveSalonGetir(comboBox1, "select * from Film_Bilgileri", "FilmAdi");
            FilmveSalonGetir(comboBox2, "select * from Salon_Bilgileri", "SalonAdi");


        }

        private void Bos_Koltuklar()
        {
            btndolukoltuk.BackColor = Color.Red;
            btnperde.BackColor = Color.Red;
            sayac = 1;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(35, 30);
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.BackColor = Color.White;
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.groupBox4.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                textBox5.Text = b.Text;

            }
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            SalonEkle ekle = new SalonEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            FilmEkle ekle = new FilmEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            SeansEkle ekle = new SeansEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            Seans_Listele ekle = new Seans_Listele();
            ekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SatisListeleme ekle = new SatisListeleme();
            ekle.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmAfisiGoster();
            YenidenRenklendir();
            ComboDoluKoltuklar();
        }

        sinemaTableAdapters.Satis_BilgileriTableAdapter satis = new sinemaTableAdapters.Satis_BilgileriTableAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                try
                {

                    satis.SatisYap(textBox5.Text, comboBox2.Text, comboBox1.Text,
                        comboBox3.Text, comboBox6.Text, textBox4.Text, textBox7.Text,
                        comboBox4.Text, DateTime.Now.ToString());

                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                    YenidenRenklendir();
                    VeriTabanıDoluKoltuklar();
                    ComboDoluKoltuklar();



                }
                catch (Exception hata)
                {

                    MessageBox.Show("hata olustu" + hata.Message, "uyarı");
                }
            }

            else
            {

                MessageBox.Show("koltuk seçmediniz", "uyarı");

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
        }
        private void FilmTarihiGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Seans_Bilgileri where FilmAdi='" + comboBox1.SelectedItem + "' and Salon='" + comboBox2.SelectedItem + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (DateTime.Parse(oku["Tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboBox3.Items.Contains(oku["Tarih"].ToString()))
                    {
                        comboBox3.Items.Add(oku["Tarih"].ToString());
                    }
                }


            }
            baglanti.Close();

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmTarihiGetir();
        }

        private void FilmSeansiGetir()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Seans_Bilgileri where " +
                "FilmAdi='" + comboBox1.SelectedItem +
                "'and Salon='" + comboBox2.SelectedItem +
                "'and Tarih='" + comboBox3.SelectedItem + "'", baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (DateTime.Parse(oku["Tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(oku["Seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        comboBox6.Items.Add(oku["Seans"].ToString());
                    }


                }

                else if (DateTime.Parse(oku["Tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    comboBox6.Items.Add(oku["Seans"].ToString());

                }


            }
            baglanti.Close();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmSeansiGetir();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            VeriTabanıDoluKoltuklar();
            ComboDoluKoltuklar();

            
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox5.Text != "")
            {
                    try
                    {
                        satis.Satisİptal(comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox6.Text, comboBox5.Text);

                        YenidenRenklendir();
                        VeriTabanıDoluKoltuklar();
                        ComboDoluKoltuklar();

                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("koltuk seçimi yapmadınız!!!", "uyarı");

                    }
            }

            else
            {

            }
        }
    }
}
