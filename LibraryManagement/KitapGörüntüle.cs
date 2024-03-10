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
    public partial class KitapGörüntüle : Form
    {
        public KitapGörüntüle()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void KitapGörüntüle_Load(object sender, EventArgs e)
        {
            pnlKitap.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int kid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                kid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            pnlKitap.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook where kid="+kid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtKitapAdı.Text = ds.Tables[0].Rows[0][1].ToString();
            txtYazarAdı.Text = ds.Tables[0].Rows[0][2].ToString();
            txtYayınevi.Text = ds.Tables[0].Rows[0][3].ToString();
            txtTarih.Text = ds.Tables[0].Rows[0][4].ToString();
            txtKitapDegeri.Text = ds.Tables[0].Rows[0][5].ToString();
            txtKitapAdedi.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            pnlKitap.Visible=false;
        }

        private void txtKitapArama_TextChanged(object sender, EventArgs e)
        {
            if(txtKitapArama.Text!= "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook where kAd LIKE '"+txtKitapArama.Text+"%' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtKitapArama.Clear();
            pnlKitap.Visible=false;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncellemek İstediğinize Emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String kad = txtKitapAdı.Text;
                String kyazar = txtYazarAdı.Text;
                String kbasim = txtYayınevi.Text;
                String ktarih = txtTarih.Text;
                Int64 kdeger = Int64.Parse(txtKitapDegeri.Text);
                Int64 kadet = Int64.Parse(txtKitapAdedi.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewBook set kAd = '" + kad + "', kYazar = '" + kyazar + "', kBasim = '" + kbasim + "', kEkleme = '" + ktarih + "', kDeger = " + kdeger + ", kAdet = " + kadet + " where kid=" + rowid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }


        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewBook where kid = "+rowid+" ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
