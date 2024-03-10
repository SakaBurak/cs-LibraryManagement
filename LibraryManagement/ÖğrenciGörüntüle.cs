using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public partial class ÖğrenciGörüntüle : Form
    {
        public ÖğrenciGörüntüle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if(txtArama.Text != "")
            {
                label2.Visible = false;
                Image img = Image.FromFile("C:/Users/bekir/Desktop/Liberay Management System/search1.gif");//olmasa da olur!
                pictureBox1.Image = img;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-V3L2HH6\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where ogNo LIKE '"+txtArama.Text+"%' ";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                label2.Visible = true;
                Image img = Image.FromFile("C:/Users/bekir/Desktop/Liberay Management System/search.gif");//olmasa da olur!
                pictureBox1.Image = img;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-V3L2HH6\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ÖğrenciGörüntüle_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-V3L2HH6\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int kid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                kid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-V3L2HH6\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where ogid = "+kid+" ";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtOgrenciAd.Text = ds.Tables[0].Rows[0][1].ToString();
            txtOgrenciNo.Text = ds.Tables[0].Rows[0][2].ToString();
            txtFak.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSinif.Text = ds.Tables[0].Rows[0][4].ToString();
            txtTel.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEposta.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            String oad = txtOgrenciAd.Text;
            String ono = txtOgrenciNo.Text;
            String fak = txtFak.Text;
            String sinif = txtSinif.Text;
            Int64 tel = Int64.Parse(txtTel.Text); //Convert.ToInt64(txtTel.Text);
            String email = txtEposta.Text;

            if (MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-V3L2HH6\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set ogAd = '" + oad + "', ogNo = '" + ono + "', ogFak = '" + fak + "', ogSınıf = '" + sinif + "', ogTel = " + tel + ", ogEmail = '" + email + "' where ogid = " + rowid + " ";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                ÖğrenciGörüntüle_Load(this, null);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ÖğrenciGörüntüle_Load(this, null);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-V3L2HH6\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where ogid = "+rowid+" ";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                ÖğrenciGörüntüle_Load(this, null);
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Dikkat Form Kapanacak!! Emin misiniz?","İptal",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
