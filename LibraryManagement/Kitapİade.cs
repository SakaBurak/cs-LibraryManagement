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
    public partial class Kitapİade : Form
    {
        public Kitapİade()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where ogNo = '" + txtNoArama.Text + "' and alisTarih IS NULL ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0 )
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Hatalı İşlem!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Kitapİade_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtNoArama.Clear();
        }


        String kitap;
        String tarih;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                kitap = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                tarih = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtKitapadı.Text = kitap;
            txtAlışTarihi.Text = tarih;
        }

        private void btnİade_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set alisTarih = '" + dateTimePicker1.Text + "' where ogNo = '"+txtNoArama.Text+"' and id = "+rowid+" ";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kitap İadesi Başarılı!","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Kitapİade_Load(this, null);
            
        }

        private void txtNoArama_TextChanged(object sender, EventArgs e)
        {
            if(txtNoArama.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtNoArama.Clear();
            //Kitapİade_Load(this, null);
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }
    }
}
