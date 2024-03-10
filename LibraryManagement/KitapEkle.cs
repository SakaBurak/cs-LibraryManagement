using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKitapAdı.Text != "" && txtYazar.Text != "" && txtYayınevi.Text != "" && txtKİtapDeger.Text != "" && txtAdet.Text != "")
            {

                String kAd = txtKitapAdı.Text;
                String kYazar = txtYazar.Text;
                String kBasim = txtYayınevi.Text;
                String date = dateTimePicker1.Text;
                Int64 deger = Int64.Parse(txtKİtapDeger.Text);
                Int64 adet = Int64.Parse(txtAdet.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database=LibraryManagement; integrated security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (kAd,kYazar,kBasim,kEkleme,kDeger,kAdet) values ('" + kAd + "','" + kYazar + "','" + kBasim + "','" + date + "'," + deger + "," + adet + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kaydedildi!", "Kitap Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKitapAdı.Clear();
                txtYazar.Clear();
                txtYayınevi.Clear();
                txtKİtapDeger.Clear();
                txtAdet.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt Ekranından Çıkış yapacağına emin misin? Kayıt Edilmeyen veriler SİLİNECEKTİR!", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Close();
            }
            
            
        }
    }
}
