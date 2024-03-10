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
    public partial class ÖğrenciEkle : Form
    {
        public ÖğrenciEkle()
        {
            InitializeComponent();
        }

        private void ÖğrenciEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtNo.Clear();
            txtFakülte.Clear();
            txtSınıf.Clear();
            txtTel.Clear();
            txtEposta.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtNo.Text != "" && txtFakülte.Text != "" && txtSınıf.Text != "" && txtTel.Text != "" && txtEposta.Text != "")
            {


                String ad = txtAd.Text;
                String no = txtNo.Text;
                String fak = txtFakülte.Text;
                String sin = txtSınıf.Text;
                Int64 tel = Int64.Parse(txtTel.Text);
                String mail = txtEposta.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent (ogAd,ogNo,ogFak,ogSınıf,ogTel,ogEmail) values ('" + ad + "','" + no + "','" + fak + "','" + sin + "'," + tel + ",'" + mail + "') ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!","Dikkat",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
