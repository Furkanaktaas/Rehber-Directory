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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-L0GT8MC\\FURKAN; Database=Rehber;Trusted_Connection=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==string.Empty || ipucu.Text==string.Empty)
            {
                MessageBox.Show("Boş Geçilemez","DİKKAT");
            }

            else{
             if (MessageBox.Show("Değiştirmek İstediğinize emin misiniz ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Kullanici set soru='" + textBox1.Text + "',ipucu='"+ipucu.Text+"'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Cevap ve İpucu Başarıyla Değiştirildi");
                textBox1.Clear();
                ipucu.Clear();


            }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Kullanici set sifre='" + textBox2.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifre başarıyla değiştirildi");
                    textBox2.Clear();
                    textBox3.Clear();

                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Değil", "DİKKAT");

                }

            }

            else
            {
                MessageBox.Show("Şifre Boş olamaz", "DİKKAT");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
