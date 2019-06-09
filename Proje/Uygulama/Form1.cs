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
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-L0GT8MC\\FURKAN; Database=Rehber;Trusted_Connection=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goster();
        }


        void goster()
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from Bilgi", baglanti);
                komut2.ExecuteNonQuery();
                SqlDataAdapter adap = new SqlDataAdapter(komut2);
                DataSet ds = new DataSet();
                adap.Fill(ds, "Bilgi");
                dataGridView1.DataSource = ds.Tables["Bilgi"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
                
            }
        }

             private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                goster();

            }
            else
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Bilgi where ad like '" + txt1.Text + "%'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter ase = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                ase.Fill(ds, "Bilgi");
                baglanti.Close();
                dataGridView1.DataSource = ds.Tables["Bilgi"];
            }
            }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text == "")
            {
                goster();

            }
            else
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Bilgi where soyad like '" + txt2.Text + "%'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter ase = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                ase.Fill(ds, "Bilgi");
                baglanti.Close();
                dataGridView1.DataSource = ds.Tables["Bilgi"];
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (txt3.Text == "")
            {
                goster();

            }
            else
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Bilgi where birim like '" + txt3.Text + "%'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter ase = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                ase.Fill(ds, "Bilgi");
                baglanti.Close();
                dataGridView1.DataSource = ds.Tables["Bilgi"];
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            if (txt4.Text == "")
            {
                goster();

            }
            else
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Bilgi where dahili like '" + txt4.Text + "%'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter ase = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                ase.Fill(ds, "Bilgi");
                baglanti.Close();
                dataGridView1.DataSource = ds.Tables["Bilgi"];
            }
        }
        private void txt5_TextChanged(object sender, EventArgs e)
        {
            if (txt5.Text == "")
            {
                goster();

            }
            else
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Bilgi where cep like '" + txt5.Text + "%'", baglanti);
                komut.ExecuteNonQuery();
                SqlDataAdapter ase = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                ase.Fill(ds, "Bilgi");
                baglanti.Close();
                dataGridView1.DataSource = ds.Tables["Bilgi"];
            }
        }

       
        private void temiz_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || txtsoyad.Text == "" || txtbirim.Text == "" || txtdahili.Text == "" )
            {

                MessageBox.Show("Cep Telefonu Hariç Boş Geçilemez");

            }
            else {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Bilgi (ad,soyad,birim,dahili,cep) values ('" + txtad.Text.ToLower().Trim() + "','" + txtsoyad.Text.ToLower().Trim() + "','" + txtbirim.Text.ToLower().Trim() + "','" + txtdahili.Text.Trim() + "','" + txtcep.Text.Trim() + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                goster();
                MessageBox.Show("Kayıt Başarıyla Tamamlanmıştır");
                txtad.Clear();
                txtbirim.Clear();
                txtcep.Clear();
                txtdahili.Clear();
                txtsoyad.Clear();
            }
                                    
        }

            private void button1_Click(object sender, EventArgs e)
            {
            
            if(dataGridView1[0,0].Value==null){
                MessageBox.Show("Güncellenecek veri bulunmamaktadır");
            }
                            
             else {
                 if (txtad.Text == string.Empty || txtsoyad.Text == string.Empty || txtbirim.Text == string.Empty || txtdahili.Text == string.Empty)
                 {

                     MessageBox.Show("Cep Telefonu Hariç Boş Geçilemez");

                 }

                 else
                 {
                     baglanti.Open();
                     SqlCommand komut3 = new SqlCommand("update Bilgi set ad='" + txtad.Text.ToLower().Trim() + "',soyad='" + txtsoyad.Text.ToLower().Trim() 
                     + "', birim='" + txtbirim.Text.ToLower().Trim() + "',dahili='" + txtdahili.Text.Trim() + "',cep='" + txtcep.Text.Trim() + "' where bilgiID=@numara", baglanti);
                     komut3.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                     komut3.ExecuteNonQuery();
                     baglanti.Close();
                     MessageBox.Show("Kayıt Güncellenmiştir.");
                     goster();
                 }
                }
             
            
           
              
             }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1[0, 0].Value == null)
            {
                MessageBox.Show("Sİlinecek veri bulunmamaktadır");
            }

            else
            {
                if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("delete from Bilgi where bilgiID=@numara", baglanti);
                        komut2.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        goster();
                        MessageBox.Show("Kayıt Silinmiştir");
                        txtad.Clear();
                        txtsoyad.Clear();
                        txtbirim.Clear();
                        txtdahili.Clear();
                        txtcep.Clear();
                    }
                }
            }          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            txtbirim.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
            txtdahili.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            txtcep.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtbirim.Clear();
            txtcep.Clear();
            txtdahili.Clear();
            txtsoyad.Clear();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (char.IsLetter(e.KeyChar)==false && e.KeyChar!=(char)08 && e.KeyChar!=(char)32) 
            {
                e.Handled = true;
                label11.Text="Lütfen harf giriniz";
            }
            else{
            e.Handled =false;
            label11.Text = "*";

            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label12.Text = "Lütfen harf giriniz";
            }
            else
            {
                e.Handled = false;
                label12.Text = "*";
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label13.Text = "Lütfen harf giriniz";
            }
            else
            {
                e.Handled = false;
                label13.Text = "*";
            }
        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label16.Text = "Lütfen harf giriniz";
            }
            else
            {
                e.Handled = false;
                label16.Text = "*";

            }
        }

        private void txtsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label17.Text = "Lütfen harf giriniz";
            }
            else
            {
                e.Handled = false;
                label17.Text = "*";

            }
        }

        private void txtbirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label18.Text = "Lütfen harf giriniz";
            }
            else
            {
                e.Handled = false;
                label18.Text = "*";

            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label14.Text = "Lütfen rakam giriniz";
            }
            else
            {
                e.Handled = false;

                label14.Text = "*";
            }
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label15.Text = "Lütfen rakam giriniz";
            }
            else
            {
                e.Handled = false;
                label15.Text = "*";

            }

        }

        private void txtdahili_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label19.Text = "Lütfen rakam giriniz";
            }
            else
            {
                e.Handled = false;
                label19.Text = "*";

            }
        }

        private void txtcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
                label20.Text = "Lütfen rakam giriniz";
            }
            else
            {
                e.Handled = false;

                label20.Text = "*";
            }
        }

      

      


    
    
    }
}
