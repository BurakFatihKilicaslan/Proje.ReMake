namespace WinPL.Forms
{
    partial class RaporForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporForm));
            btnRaporAylik = new Button();
            btnRaporEnCokYenenYemek = new Button();
            btnRaporRastgeleGun = new Button();
            btnRaporYemekCesidi = new Button();
            btnRaporKiyas = new Button();
            btnRaporGunluk = new Button();
            linkLabel1 = new LinkLabel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            dateTimePicker = new DateTimePicker();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            listView4 = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnRaporAylik
            // 
            btnRaporAylik.BackColor = Color.MediumAquamarine;
            btnRaporAylik.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporAylik.ForeColor = SystemColors.ActiveCaptionText;
            btnRaporAylik.Location = new Point(10, 46);
            btnRaporAylik.Name = "btnRaporAylik";
            btnRaporAylik.Size = new Size(642, 35);
            btnRaporAylik.TabIndex = 22;
            btnRaporAylik.Text = "Aylık Rapor Oluştur";
            btnRaporAylik.UseVisualStyleBackColor = false;
            btnRaporAylik.Click += btnRaporAylik_Click;
            // 
            // btnRaporEnCokYenenYemek
            // 
            btnRaporEnCokYenenYemek.BackColor = Color.MediumAquamarine;
            btnRaporEnCokYenenYemek.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporEnCokYenenYemek.ForeColor = SystemColors.ActiveCaptionText;
            btnRaporEnCokYenenYemek.Location = new Point(10, 170);
            btnRaporEnCokYenenYemek.Name = "btnRaporEnCokYenenYemek";
            btnRaporEnCokYenenYemek.Size = new Size(642, 39);
            btnRaporEnCokYenenYemek.TabIndex = 21;
            btnRaporEnCokYenenYemek.Text = "En Çok Yenen Yemek";
            btnRaporEnCokYenenYemek.UseVisualStyleBackColor = false;
            btnRaporEnCokYenenYemek.Click += btnRaporEnCokYenenYemek_Click;
            // 
            // btnRaporRastgeleGun
            // 
            btnRaporRastgeleGun.BackColor = Color.MediumAquamarine;
            btnRaporRastgeleGun.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporRastgeleGun.ForeColor = SystemColors.ActiveCaptionText;
            btnRaporRastgeleGun.Location = new Point(237, 218);
            btnRaporRastgeleGun.Name = "btnRaporRastgeleGun";
            btnRaporRastgeleGun.Size = new Size(415, 36);
            btnRaporRastgeleGun.TabIndex = 19;
            btnRaporRastgeleGun.Text = ".... Günlük rapor oluştur";
            btnRaporRastgeleGun.UseVisualStyleBackColor = false;
            btnRaporRastgeleGun.Click += btnRaporRastgeleGun_Click;
            // 
            // btnRaporYemekCesidi
            // 
            btnRaporYemekCesidi.BackColor = Color.MediumAquamarine;
            btnRaporYemekCesidi.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporYemekCesidi.ForeColor = SystemColors.ActiveCaptionText;
            btnRaporYemekCesidi.Location = new Point(10, 129);
            btnRaporYemekCesidi.Name = "btnRaporYemekCesidi";
            btnRaporYemekCesidi.Size = new Size(642, 35);
            btnRaporYemekCesidi.TabIndex = 18;
            btnRaporYemekCesidi.Text = "Yemek Çeşidi";
            btnRaporYemekCesidi.UseVisualStyleBackColor = false;
            btnRaporYemekCesidi.Click += btnRaporYemekCesidi_Click;
            // 
            // btnRaporKiyas
            // 
            btnRaporKiyas.BackColor = Color.MediumAquamarine;
            btnRaporKiyas.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporKiyas.ForeColor = SystemColors.ActiveCaptionText;
            btnRaporKiyas.Location = new Point(10, 88);
            btnRaporKiyas.Name = "btnRaporKiyas";
            btnRaporKiyas.Size = new Size(642, 35);
            btnRaporKiyas.TabIndex = 17;
            btnRaporKiyas.Text = "Kıyas Raporu Oluştur";
            btnRaporKiyas.UseVisualStyleBackColor = false;
            btnRaporKiyas.Click += btnRaporKiyas_Click;
            // 
            // btnRaporGunluk
            // 
            btnRaporGunluk.BackColor = Color.MediumAquamarine;
            btnRaporGunluk.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporGunluk.ForeColor = SystemColors.ActiveCaptionText;
            btnRaporGunluk.Location = new Point(10, 5);
            btnRaporGunluk.Name = "btnRaporGunluk";
            btnRaporGunluk.Size = new Size(642, 35);
            btnRaporGunluk.TabIndex = 16;
            btnRaporGunluk.Text = "Günlük Rapor Oluştur";
            btnRaporGunluk.UseVisualStyleBackColor = false;
            btnRaporGunluk.Click += btnRaporGunluk_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.RoyalBlue;
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(12, 767);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(99, 23);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ana Sayfa";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.GridLines = true;
            listView1.Location = new Point(25, 273);
            listView1.Name = "listView1";
            listView1.Size = new Size(605, 481);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "KullanıcıID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sabah (Kalori T.)";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Öğle (Kalori T.)";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Akşam (Kalori T.)";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ara (Kalori T.)";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Toplam Alınan Kalori";
            columnHeader6.Width = 100;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(12, 222);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 26;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader9 });
            listView2.GridLines = true;
            listView2.Location = new Point(160, 273);
            listView2.Name = "listView2";
            listView2.Size = new Size(304, 481);
            listView2.TabIndex = 27;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Açıklamalar";
            columnHeader7.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Toplam Kalori";
            columnHeader9.Width = 150;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader10 });
            listView3.GridLines = true;
            listView3.Location = new Point(160, 273);
            listView3.Name = "listView3";
            listView3.Size = new Size(304, 481);
            listView3.TabIndex = 28;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Açıklamalar";
            columnHeader8.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Toplam Kalori";
            columnHeader10.Width = 150;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView4.GridLines = true;
            listView4.Location = new Point(104, 273);
            listView4.Name = "listView4";
            listView4.Size = new Size(405, 481);
            listView4.TabIndex = 29;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Yiyecek Adı";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Haftalık Toplam Kalori";
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Aylık Toplam Kalori";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Toplam Kalori";
            columnHeader14.Width = 100;
            // 
            // RaporForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(664, 799);
            Controls.Add(listView4);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(dateTimePicker);
            Controls.Add(listView1);
            Controls.Add(linkLabel1);
            Controls.Add(btnRaporAylik);
            Controls.Add(btnRaporEnCokYenenYemek);
            Controls.Add(btnRaporRastgeleGun);
            Controls.Add(btnRaporYemekCesidi);
            Controls.Add(btnRaporKiyas);
            Controls.Add(btnRaporGunluk);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RaporForm";
            Text = "Rapor";
            Load += RaporForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRaporAylik;
        private Button btnRaporEnCokYenenYemek;
        private Button btnRaporRastgeleGun;
        private Button btnRaporYemekCesidi;
        private Button btnRaporKiyas;
        private Button btnRaporGunluk;
        private LinkLabel linkLabel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private DateTimePicker dateTimePicker;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader9;
        private ListView listView3;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader10;
        private ListView listView4;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
    }
}