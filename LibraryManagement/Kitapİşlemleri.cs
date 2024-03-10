using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Kitapİşlemleri : Form
    {
        public Kitapİşlemleri()
        {
            InitializeComponent();
        }

        private void Kitapİşlemleri_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select kAd from NewBook",con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                for(int i = 0; i<dr.FieldCount;i++)
                {
                    txtKitapadı.Items.Add(dr.GetSqlString(i));
                }
            }
            dr.Close();
            con.Close();
        }


        int sayac;
        private void btnAra_Click(object sender, EventArgs e)
        {
            if(txtArama.Text != "")
            {
                String edi = txtArama.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where ogNo = '"+edi+"' ";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);




                //sayma
                cmd.CommandText = "select count(ogNo) from IRBook where ogNo = '" + edi + "' and alisTarih is null ";
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1);

                sayac = int.Parse(ds1.Tables[0].Rows[0][0].ToString());



                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtogrAd.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtFak.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSınıf.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtTel.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEposta.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtogrAd.Clear();
                    txtFak.Clear();
                    txtSınıf.Clear();
                    txtTel.Clear();
                    txtEposta.Clear();
                    MessageBox.Show("Geçersiz numara girdiniz!","Hata!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(txtogrAd.Text !="")
            {
                if(txtKitapadı.SelectedIndex != -1 && sayac<=2)
                {
                    String no = txtArama.Text;
                    String ad = txtogrAd.Text;
                    String fak = txtFak.Text;
                    String sinif = txtSınıf.Text;
                    Int64 tel = Int64.Parse(txtTel.Text);  //Convert.ToInt64(txtTel.Text);
                    String email = txtEposta.Text;
                    String kitap = txtKitapadı.Text;
                    String tarih = dateTimePicker1.Text;

                    String edi = txtArama.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-V3L2HH6\\SQLEXPRESS; database = LibraryManagement; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "insert into IRBook (ogNo,ogad,ogFak,ogSınıf,ogTel,ogEposta,kitapAdi,verisTarih) values ('"+no+"','"+ad+"','"+fak+"','"+sinif+"',"+tel+",'"+email+"','"+kitap+"','"+tarih+"') ";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Kitap Verildi!","İşlem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kitap Seçmediniz YADA Maksimum Kitap sayısına ulaştınız!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Geçersiz Öğrenci Numarası!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);         
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if(txtArama.Text == "")
            {
                txtogrAd.Clear();
                txtEposta.Clear();
                txtFak.Clear();
                txtSınıf.Clear();
                txtTel.Clear();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtArama.Clear();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Form Kapanacak Emin Misiniz?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
