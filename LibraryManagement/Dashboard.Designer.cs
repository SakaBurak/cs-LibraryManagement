namespace LibraryManagement
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eKitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.öğrenciToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.completeBookDetailsToolStripMenuItem,
            this.eKitapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 108);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.kitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarToolStripMenuItem.Image")));
            this.kitaplarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(125, 104);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapEkleToolStripMenuItem.Image")));
            this.kitapEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(188, 56);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeleToolStripMenuItem.Image")));
            this.listeleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(188, 56);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.bilgiGörüntüleToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciToolStripMenuItem.Image")));
            this.öğrenciToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(175, 104);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciEkleToolStripMenuItem.Image")));
            this.öğrenciEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(291, 126);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // bilgiGörüntüleToolStripMenuItem
            // 
            this.bilgiGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bilgiGörüntüleToolStripMenuItem.Image")));
            this.bilgiGörüntüleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bilgiGörüntüleToolStripMenuItem.Name = "bilgiGörüntüleToolStripMenuItem";
            this.bilgiGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(291, 126);
            this.bilgiGörüntüleToolStripMenuItem.Text = "Bilgi Görüntüle";
            this.bilgiGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.bilgiGörüntüleToolStripMenuItem_Click);
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapİşlemleriToolStripMenuItem.Image")));
            this.kitapİşlemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(168, 104);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            this.kitapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapİşlemleriToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.returnBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBookToolStripMenuItem.Image")));
            this.returnBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(141, 104);
            this.returnBookToolStripMenuItem.Text = "Kitap İade";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            this.completeBookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completeBookDetailsToolStripMenuItem.Image")));
            this.completeBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            this.completeBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(172, 104);
            this.completeBookDetailsToolStripMenuItem.Text = "Kitap Detayları";
            this.completeBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.completeBookDetailsToolStripMenuItem_Click);
            // 
            // eKitapToolStripMenuItem
            // 
            this.eKitapToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.eKitapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eKitapToolStripMenuItem.Image")));
            this.eKitapToolStripMenuItem.Name = "eKitapToolStripMenuItem";
            this.eKitapToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.eKitapToolStripMenuItem.Text = "E-Kitap";
            this.eKitapToolStripMenuItem.Click += new System.EventHandler(this.eKitapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.BurlyWood;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 104);
            this.exitToolStripMenuItem.Text = "Çıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1336, 529);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eKitapToolStripMenuItem;
    }
}