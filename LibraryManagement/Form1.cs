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

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if(txtUsername.Text =="Kullanıcı Adı")
            {
                txtUsername.Clear();
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Kullanıcı Adı")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Parola")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/bekir-burak-saka-157705254");
        }

        

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from loginTable where KullaniciAdi = '" + txtUsername.Text + "' and sifre = '" + txtPassword.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Yanlış!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO loginTable (KullaniciAdi, sifre) VALUES (@kullaniciAdi, @sifre)";
            cmd.Parameters.AddWithValue("@kullaniciAdi", txtUsername.Text);
            cmd.Parameters.AddWithValue("@sifre", txtPassword.Text);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı kaydedilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
