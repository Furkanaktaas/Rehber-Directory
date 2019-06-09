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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-L0GT8MC\\FURKAN; Database=Rehber;Trusted_Connection=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsifre.Text != string.Empty && txtsifre2.Text != string.Empty)
            {
                if (txtsifre.Text == txtsifre2.Text)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Kullanici set sifre='" + txtsifre.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifre başarıyla değiştirildi");
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();

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

      


    }
}
