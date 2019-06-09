using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace staj
{
    public partial class Form2 : Form
    {

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-L0GT8MC\\FURKAN; Database=Rehber;Trusted_Connection=True;");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            geri.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanici where soru='" + txtsoru.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                groupBox1.Hide();
                this.Hide();

            }
            else
            {
                dr.Close();
                MessageBox.Show("Güvenlik Cevabı Yanlış", "DİKKAT");
                SqlCommand komuts = new SqlCommand("select ipucu from Kullanici", baglanti);
                SqlDataReader oku = komuts.ExecuteReader(); oku.Read();
                ipucu.Text = "ipucu : " + oku["ipucu"].ToString();
            }

            baglanti.Close();
        }

        private void lbk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;
            geri.Visible = true;
            lbk.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanici where kad='" + txtkad.Text + "' and sifre='" + txtsifre.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Şifre Hatalı", "DİKKAT");

            }
            baglanti.Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            geri.Hide();
            lbk.Visible = true;
        }








    }
}
