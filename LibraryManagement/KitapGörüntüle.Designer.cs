namespace LibraryManagement
{
    partial class KitapGörüntüle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapGörüntüle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKitaplar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapArama = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlKitap = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtKitapAdı = new System.Windows.Forms.TextBox();
            this.txtYazarAdı = new System.Windows.Forms.TextBox();
            this.txtYayınevi = new System.Windows.Forms.TextBox();
            this.txtKitapDegeri = new System.Windows.Forms.TextBox();
            this.txtKitapAdedi = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlKitap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblKitaplar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblKitaplar
            // 
            this.lblKitaplar.AutoSize = true;
            this.lblKitaplar.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitaplar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKitaplar.Location = new System.Drawing.Point(499, 23);
            this.lblKitaplar.Name = "lblKitaplar";
            this.lblKitaplar.Size = new System.Drawing.Size(129, 41);
            this.lblKitaplar.TabIndex = 1;
            this.lblKitaplar.Text = "Kitaplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(216, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtKitapArama
            // 
            this.txtKitapArama.Location = new System.Drawing.Point(327, 117);
            this.txtKitapArama.Name = "txtKitapArama";
            this.txtKitapArama.Size = new System.Drawing.Size(229, 22);
            this.txtKitapArama.TabIndex = 2;
            this.txtKitapArama.TextChanged += new System.EventHandler(this.txtKitapArama_TextChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYenile.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(562, 110);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(94, 31);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 288);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pnlKitap
            // 
            this.pnlKitap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlKitap.Controls.Add(this.txtTarih);
            this.pnlKitap.Controls.Add(this.txtKitapAdedi);
            this.pnlKitap.Controls.Add(this.txtKitapDegeri);
            this.pnlKitap.Controls.Add(this.txtYayınevi);
            this.pnlKitap.Controls.Add(this.txtYazarAdı);
            this.pnlKitap.Controls.Add(this.txtKitapAdı);
            this.pnlKitap.Controls.Add(this.btnİptal);
            this.pnlKitap.Controls.Add(this.btnSil);
            this.pnlKitap.Controls.Add(this.btnGüncelle);
            this.pnlKitap.Controls.Add(this.label7);
            this.pnlKitap.Controls.Add(this.label6);
            this.pnlKitap.Controls.Add(this.label5);
            this.pnlKitap.Controls.Add(this.label4);
            this.pnlKitap.Controls.Add(this.label3);
            this.pnlKitap.Controls.Add(this.label2);
            this.pnlKitap.Location = new System.Drawing.Point(12, 457);
            this.pnlKitap.Name = "pnlKitap";
            this.pnlKitap.Size = new System.Drawing.Size(944, 381);
            this.pnlKitap.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yazar Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yayınevi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(514, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alım Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(514, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kitap Değeri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(514, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kitap Adedi";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGüncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(618, 315);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(98, 27);
            this.btnGüncelle.TabIndex = 6;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(733, 315);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 27);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnİptal
            // 
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnİptal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Location = new System.Drawing.Point(834, 315);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(85, 27);
            this.btnİptal.TabIndex = 8;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtKitapAdı
            // 
            this.txtKitapAdı.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdı.Location = new System.Drawing.Point(124, 52);
            this.txtKitapAdı.Name = "txtKitapAdı";
            this.txtKitapAdı.Size = new System.Drawing.Size(250, 28);
            this.txtKitapAdı.TabIndex = 9;
            // 
            // txtYazarAdı
            // 
            this.txtYazarAdı.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarAdı.Location = new System.Drawing.Point(124, 132);
            this.txtYazarAdı.Name = "txtYazarAdı";
            this.txtYazarAdı.Size = new System.Drawing.Size(250, 28);
            this.txtYazarAdı.TabIndex = 10;
            // 
            // txtYayınevi
            // 
            this.txtYayınevi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayınevi.Location = new System.Drawing.Point(124, 222);
            this.txtYayınevi.Name = "txtYayınevi";
            this.txtYayınevi.Size = new System.Drawing.Size(250, 28);
            this.txtYayınevi.TabIndex = 11;
            // 
            // txtKitapDegeri
            // 
            this.txtKitapDegeri.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapDegeri.Location = new System.Drawing.Point(631, 135);
            this.txtKitapDegeri.Name = "txtKitapDegeri";
            this.txtKitapDegeri.Size = new System.Drawing.Size(247, 28);
            this.txtKitapDegeri.TabIndex = 13;
            // 
            // txtKitapAdedi
            // 
            this.txtKitapAdedi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdedi.Location = new System.Drawing.Point(631, 221);
            this.txtKitapAdedi.Name = "txtKitapAdedi";
            this.txtKitapAdedi.Size = new System.Drawing.Size(247, 28);
            this.txtKitapAdedi.TabIndex = 14;
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(631, 52);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(247, 28);
            this.txtTarih.TabIndex = 15;
            // 
            // KitapGörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(989, 465);
            this.Controls.Add(this.pnlKitap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtKitapArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "KitapGörüntüle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapGörüntüle";
            this.Load += new System.EventHandler(this.KitapGörüntüle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlKitap.ResumeLayout(false);
            this.pnlKitap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKitaplar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapArama;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlKitap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapAdedi;
        private System.Windows.Forms.TextBox txtKitapDegeri;
        private System.Windows.Forms.TextBox txtYayınevi;
        private System.Windows.Forms.TextBox txtYazarAdı;
        private System.Windows.Forms.TextBox txtKitapAdı;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTarih;
    }
}