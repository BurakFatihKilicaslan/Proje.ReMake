namespace WinPL.Forms
{
    partial class KaydolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaydolForm));
            btnResimEkle = new Button();
            pboxProfilFotografi = new PictureBox();
            cboxAktiviteSeviyesi = new ComboBox();
            lblAktiviteSeviyesi = new Label();
            gboxCinsiyetler = new GroupBox();
            rbKadin = new RadioButton();
            rbErkek = new RadioButton();
            lblCinsiyet = new Label();
            txtKullaniciAdi = new TextBox();
            lblBoy = new Label();
            lblKilo = new Label();
            lblKullaniciAdi = new Label();
            btnSingInKayıtOl = new Button();
            txtSifreTekrar = new TextBox();
            txtSifre = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            lblSifre = new Label();
            lblDogumTarihi = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            lblMesaj = new Label();
            nupdownBoy = new NumericUpDown();
            nupdownKilo = new NumericUpDown();
            linkLabel = new LinkLabel();
            dtpDogumTarihi = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pboxProfilFotografi).BeginInit();
            gboxCinsiyetler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupdownBoy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdownKilo).BeginInit();
            SuspendLayout();
            // 
            // btnResimEkle
            // 
            btnResimEkle.BackColor = Color.MediumAquamarine;
            btnResimEkle.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnResimEkle.Location = new Point(167, 121);
            btnResimEkle.Margin = new Padding(3, 4, 3, 4);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(107, 41);
            btnResimEkle.TabIndex = 10;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = false;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // pboxProfilFotografi
            // 
            pboxProfilFotografi.BackColor = Color.Transparent;
            pboxProfilFotografi.Location = new Point(36, 31);
            pboxProfilFotografi.Margin = new Padding(3, 4, 3, 4);
            pboxProfilFotografi.Name = "pboxProfilFotografi";
            pboxProfilFotografi.Size = new Size(113, 131);
            pboxProfilFotografi.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxProfilFotografi.TabIndex = 79;
            pboxProfilFotografi.TabStop = false;
            // 
            // cboxAktiviteSeviyesi
            // 
            cboxAktiviteSeviyesi.BackColor = SystemColors.Control;
            cboxAktiviteSeviyesi.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cboxAktiviteSeviyesi.ForeColor = SystemColors.ActiveCaptionText;
            cboxAktiviteSeviyesi.FormattingEnabled = true;
            cboxAktiviteSeviyesi.Location = new Point(222, 581);
            cboxAktiviteSeviyesi.Margin = new Padding(3, 4, 3, 4);
            cboxAktiviteSeviyesi.Name = "cboxAktiviteSeviyesi";
            cboxAktiviteSeviyesi.Size = new Size(194, 25);
            cboxAktiviteSeviyesi.TabIndex = 5;
            // 
            // lblAktiviteSeviyesi
            // 
            lblAktiviteSeviyesi.AutoSize = true;
            lblAktiviteSeviyesi.BackColor = Color.Transparent;
            lblAktiviteSeviyesi.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAktiviteSeviyesi.ForeColor = SystemColors.ActiveCaptionText;
            lblAktiviteSeviyesi.Location = new Point(36, 580);
            lblAktiviteSeviyesi.Name = "lblAktiviteSeviyesi";
            lblAktiviteSeviyesi.Size = new Size(167, 23);
            lblAktiviteSeviyesi.TabIndex = 77;
            lblAktiviteSeviyesi.Text = "Aktivite Seviyesi :";
            // 
            // gboxCinsiyetler
            // 
            gboxCinsiyetler.BackColor = Color.Transparent;
            gboxCinsiyetler.Controls.Add(rbKadin);
            gboxCinsiyetler.Controls.Add(rbErkek);
            gboxCinsiyetler.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gboxCinsiyetler.Location = new Point(221, 288);
            gboxCinsiyetler.Margin = new Padding(3, 4, 3, 4);
            gboxCinsiyetler.Name = "gboxCinsiyetler";
            gboxCinsiyetler.Padding = new Padding(3, 4, 3, 4);
            gboxCinsiyetler.Size = new Size(195, 112);
            gboxCinsiyetler.TabIndex = 76;
            gboxCinsiyetler.TabStop = false;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbKadin.ForeColor = SystemColors.ActiveCaptionText;
            rbKadin.Location = new Point(16, 75);
            rbKadin.Margin = new Padding(3, 4, 3, 4);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(62, 20);
            rbKadin.TabIndex = 1;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Checked = true;
            rbErkek.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbErkek.ForeColor = SystemColors.ActiveCaptionText;
            rbErkek.Location = new Point(16, 22);
            rbErkek.Margin = new Padding(3, 4, 3, 4);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(60, 20);
            rbErkek.TabIndex = 0;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.BackColor = Color.Transparent;
            lblCinsiyet.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCinsiyet.ForeColor = SystemColors.ActiveCaptionText;
            lblCinsiyet.Location = new Point(36, 286);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(91, 23);
            lblCinsiyet.TabIndex = 75;
            lblCinsiyet.Text = "Cinsiyet :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = SystemColors.Control;
            txtKullaniciAdi.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtKullaniciAdi.ForeColor = SystemColors.ActiveCaptionText;
            txtKullaniciAdi.Location = new Point(222, 642);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "example@bilgeadam.com";
            txtKullaniciAdi.Size = new Size(194, 22);
            txtKullaniciAdi.TabIndex = 6;
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.BackColor = Color.Transparent;
            lblBoy.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBoy.ForeColor = SystemColors.ActiveCaptionText;
            lblBoy.Location = new Point(36, 468);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(87, 23);
            lblBoy.TabIndex = 71;
            lblBoy.Text = "Boy(cm):";
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.BackColor = Color.Transparent;
            lblKilo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKilo.ForeColor = SystemColors.ActiveCaptionText;
            lblKilo.Location = new Point(36, 525);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(54, 23);
            lblKilo.TabIndex = 70;
            lblKilo.Text = "Kilo :";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.Transparent;
            lblKullaniciAdi.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAdi.ForeColor = SystemColors.ActiveCaptionText;
            lblKullaniciAdi.Location = new Point(36, 641);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(130, 23);
            lblKullaniciAdi.TabIndex = 69;
            lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // btnSingInKayıtOl
            // 
            btnSingInKayıtOl.BackColor = Color.MediumAquamarine;
            btnSingInKayıtOl.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSingInKayıtOl.ForeColor = SystemColors.ActiveCaptionText;
            btnSingInKayıtOl.Location = new Point(36, 817);
            btnSingInKayıtOl.Margin = new Padding(3, 4, 3, 4);
            btnSingInKayıtOl.Name = "btnSingInKayıtOl";
            btnSingInKayıtOl.Size = new Size(381, 35);
            btnSingInKayıtOl.TabIndex = 9;
            btnSingInKayıtOl.Text = "Kayıt Ol";
            btnSingInKayıtOl.UseVisualStyleBackColor = false;
            btnSingInKayıtOl.Click += btnSingInKayıtOl_Click;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.BackColor = SystemColors.Control;
            txtSifreTekrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifreTekrar.ForeColor = SystemColors.ActiveCaptionText;
            txtSifreTekrar.Location = new Point(222, 753);
            txtSifreTekrar.Margin = new Padding(3, 4, 3, 4);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(194, 22);
            txtSifreTekrar.TabIndex = 8;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.Control;
            txtSifre.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.ForeColor = SystemColors.ActiveCaptionText;
            txtSifre.Location = new Point(222, 699);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(194, 22);
            txtSifre.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Control;
            txtSoyad.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyad.ForeColor = SystemColors.ActiveCaptionText;
            txtSoyad.Location = new Point(221, 239);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(194, 22);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Control;
            txtAd.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAd.ForeColor = SystemColors.ActiveCaptionText;
            txtAd.Location = new Point(221, 191);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(194, 22);
            txtAd.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(36, 753);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 62;
            label5.Text = "Şifre Tekrar :";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.ForeColor = SystemColors.ActiveCaptionText;
            lblSifre.Location = new Point(36, 698);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(61, 23);
            lblSifre.TabIndex = 61;
            lblSifre.Text = "Şifre :";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.BackColor = Color.Transparent;
            lblDogumTarihi.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDogumTarihi.ForeColor = SystemColors.ActiveCaptionText;
            lblDogumTarihi.Location = new Point(36, 423);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(136, 23);
            lblDogumTarihi.TabIndex = 60;
            lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.BackColor = Color.Transparent;
            lblSoyad.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoyad.ForeColor = SystemColors.ActiveCaptionText;
            lblSoyad.Location = new Point(36, 239);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(75, 23);
            lblSoyad.TabIndex = 59;
            lblSoyad.Text = "Soyad :";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.BackColor = Color.Transparent;
            lblAd.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAd.ForeColor = SystemColors.ActiveCaptionText;
            lblAd.Location = new Point(36, 191);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(43, 23);
            lblAd.TabIndex = 58;
            lblAd.Text = "Ad :";
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.BackColor = Color.Transparent;
            lblMesaj.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMesaj.ForeColor = SystemColors.ActiveCaptionText;
            lblMesaj.Location = new Point(184, 52);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(248, 27);
            lblMesaj.TabIndex = 81;
            lblMesaj.Text = "Her Halin Bizce Çok Güzel..";
            // 
            // nupdownBoy
            // 
            nupdownBoy.BackColor = SystemColors.ButtonFace;
            nupdownBoy.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownBoy.ForeColor = SystemColors.ActiveCaptionText;
            nupdownBoy.Location = new Point(222, 474);
            nupdownBoy.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nupdownBoy.Name = "nupdownBoy";
            nupdownBoy.Size = new Size(195, 24);
            nupdownBoy.TabIndex = 3;
            // 
            // nupdownKilo
            // 
            nupdownKilo.BackColor = SystemColors.ButtonFace;
            nupdownKilo.DecimalPlaces = 2;
            nupdownKilo.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownKilo.ForeColor = SystemColors.ActiveCaptionText;
            nupdownKilo.Location = new Point(221, 527);
            nupdownKilo.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nupdownKilo.Name = "nupdownKilo";
            nupdownKilo.Size = new Size(195, 24);
            nupdownKilo.TabIndex = 4;
            // 
            // linkLabel
            // 
            linkLabel.BackColor = Color.Transparent;
            linkLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel.LinkColor = Color.RoyalBlue;
            linkLabel.Location = new Point(260, 879);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(172, 26);
            linkLabel.TabIndex = 85;
            linkLabel.TabStop = true;
            linkLabel.Text = "AnaSayfaya Dön";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.CalendarForeColor = SystemColors.ControlLight;
            dtpDogumTarihi.CalendarTrailingForeColor = SystemColors.ActiveCaptionText;
            dtpDogumTarihi.CausesValidation = false;
            dtpDogumTarihi.Location = new Point(221, 423);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(195, 23);
            dtpDogumTarihi.TabIndex = 2;
            // 
            // KaydolForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(470, 954);
            ControlBox = false;
            Controls.Add(dtpDogumTarihi);
            Controls.Add(linkLabel);
            Controls.Add(nupdownKilo);
            Controls.Add(nupdownBoy);
            Controls.Add(lblMesaj);
            Controls.Add(btnResimEkle);
            Controls.Add(pboxProfilFotografi);
            Controls.Add(cboxAktiviteSeviyesi);
            Controls.Add(lblAktiviteSeviyesi);
            Controls.Add(gboxCinsiyetler);
            Controls.Add(lblCinsiyet);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblBoy);
            Controls.Add(lblKilo);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(btnSingInKayıtOl);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(lblSifre);
            Controls.Add(lblDogumTarihi);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "KaydolForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kaydol";
            Load += KaydolForm_Load;
            ((System.ComponentModel.ISupportInitialize)pboxProfilFotografi).EndInit();
            gboxCinsiyetler.ResumeLayout(false);
            gboxCinsiyetler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupdownBoy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdownKilo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResimEkle;
        private PictureBox pboxProfilFotografi;
        private ComboBox cboxAktiviteSeviyesi;
        private Label lblAktiviteSeviyesi;
        private GroupBox gboxCinsiyetler;
        private RadioButton rbKadin;
        private RadioButton rbErkek;
        private Label lblCinsiyet;
        private TextBox txtKullaniciAdi;
        private Label lblBoy;
        private Label lblKilo;
        private Label lblKullaniciAdi;
        private Button btnSingInKayıtOl;
        private TextBox txtSifreTekrar;
        private TextBox txtSifre;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label5;
        private Label lblSifre;
        private Label lblDogumTarihi;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblMesaj;
        private NumericUpDown nupdownBoy;
        private NumericUpDown nupdownKilo;
        private LinkLabel linkLabel;
        private DateTimePicker dtpDogumTarihi;
    }
}