using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitapİşlemleri ki = new Kitapİşlemleri();
            ki.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle abs = new KitapEkle();
            abs.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapGörüntüle list = new KitapGörüntüle();
            list.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖğrenciEkle ogekle = new ÖğrenciEkle();
            ogekle.Show();
        }

        private void bilgiGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖğrenciGörüntüle ogrGor = new ÖğrenciGörüntüle();
            ogrGor.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitapİade ki = new Kitapİade();
            ki.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapDetayları kd = new KitapDetayları();
            kd.Show();
        }

        private void eKitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hattusa.club/");
        }
    }
}
