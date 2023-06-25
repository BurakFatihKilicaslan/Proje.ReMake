namespace WinPL.Forms
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblSoyad = new Label();
            lblAd = new Label();
            btnSifreDegistir = new Button();
            txtYeniSifreTekrar = new TextBox();
            txtYeniSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            lblYeniSifreTekrar = new Label();
            lblYeniSifre = new Label();
            lblKullaniciAdi = new Label();
            SuspendLayout();
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Control;
            txtSoyad.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyad.ForeColor = SystemColors.ActiveCaptionText;
            txtSoyad.Location = new Point(160, 62);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 22);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Control;
            txtAd.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAd.ForeColor = SystemColors.ActiveCaptionText;
            txtAd.Location = new Point(160, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 22);
            txtAd.TabIndex = 0;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.BackColor = Color.Transparent;
            lblSoyad.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoyad.ForeColor = SystemColors.ActiveCaptionText;
            lblSoyad.Location = new Point(16, 65);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(51, 16);
            lblSoyad.TabIndex = 40;
            lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.BackColor = Color.Transparent;
            lblAd.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAd.ForeColor = SystemColors.ActiveCaptionText;
            lblAd.Location = new Point(16, 15);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 16);
            lblAd.TabIndex = 39;
            lblAd.Text = "Ad:";
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.BackColor = Color.MediumAquamarine;
            btnSifreDegistir.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifreDegistir.ForeColor = SystemColors.ActiveCaptionText;
            btnSifreDegistir.Location = new Point(16, 250);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(344, 38);
            btnSifreDegistir.TabIndex = 5;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = false;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.BackColor = SystemColors.Control;
            txtYeniSifreTekrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtYeniSifreTekrar.ForeColor = SystemColors.ActiveCaptionText;
            txtYeniSifreTekrar.Location = new Point(160, 207);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.PasswordChar = '*';
            txtYeniSifreTekrar.Size = new Size(200, 22);
            txtYeniSifreTekrar.TabIndex = 4;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.BackColor = SystemColors.Control;
            txtYeniSifre.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtYeniSifre.ForeColor = SystemColors.ActiveCaptionText;
            txtYeniSifre.Location = new Point(160, 160);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.Size = new Size(200, 22);
            txtYeniSifre.TabIndex = 3;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = SystemColors.Control;
            txtKullaniciAdi.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtKullaniciAdi.ForeColor = SystemColors.ActiveCaptionText;
            txtKullaniciAdi.Location = new Point(160, 110);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(200, 22);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // lblYeniSifreTekrar
            // 
            lblYeniSifreTekrar.AutoSize = true;
            lblYeniSifreTekrar.BackColor = Color.Transparent;
            lblYeniSifreTekrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblYeniSifreTekrar.ForeColor = SystemColors.ActiveCaptionText;
            lblYeniSifreTekrar.Location = new Point(16, 210);
            lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            lblYeniSifreTekrar.Size = new Size(120, 16);
            lblYeniSifreTekrar.TabIndex = 34;
            lblYeniSifreTekrar.Text = "Yeni Şİfre Tekrar :";
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.BackColor = Color.Transparent;
            lblYeniSifre.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblYeniSifre.ForeColor = SystemColors.ActiveCaptionText;
            lblYeniSifre.Location = new Point(16, 163);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(72, 16);
            lblYeniSifre.TabIndex = 33;
            lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.Transparent;
            lblKullaniciAdi.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAdi.ForeColor = SystemColors.ActiveCaptionText;
            lblKullaniciAdi.Location = new Point(16, 113);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(92, 16);
            lblKullaniciAdi.TabIndex = 32;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(379, 296);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(btnSifreDegistir);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblYeniSifreTekrar);
            Controls.Add(lblYeniSifre);
            Controls.Add(lblKullaniciAdi);
            DoubleBuffered = true;
            Name = "SifremiUnuttum";
            Text = "SifremiUnuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblSoyad;
        private Label lblAd;
        private Button btnSifreDegistir;
        private TextBox txtYeniSifreTekrar;
        private TextBox txtYeniSifre;
        private TextBox txtKullaniciAdi;
        private Label lblYeniSifreTekrar;
        private Label lblYeniSifre;
        private Label lblKullaniciAdi;
    }
}