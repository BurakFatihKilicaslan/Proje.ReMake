namespace WinPL.Forms
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            btnGiris = new Button();
            linklblSifremiUnuttum = new LinkLabel();
            linklblAnaSayfa = new LinkLabel();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.ButtonHighlight;
            txtSifre.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.ForeColor = SystemColors.ActiveCaptionText;
            txtSifre.Location = new Point(136, 144);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(182, 27);
            txtSifre.TabIndex = 37;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = SystemColors.ButtonHighlight;
            txtKullaniciAdi.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtKullaniciAdi.ForeColor = SystemColors.ActiveCaptionText;
            txtKullaniciAdi.Location = new Point(136, 97);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "example@bilgeadam.com";
            txtKullaniciAdi.Size = new Size(182, 26);
            txtKullaniciAdi.TabIndex = 36;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.ForeColor = SystemColors.ActiveCaptionText;
            lblSifre.Location = new Point(61, 144);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(49, 18);
            lblSifre.TabIndex = 41;
            lblSifre.Text = "Şifre :";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.Transparent;
            lblKullaniciAdi.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAdi.ForeColor = SystemColors.ActiveCaptionText;
            lblKullaniciAdi.Location = new Point(4, 101);
            lblKullaniciAdi.Margin = new Padding(4, 0, 4, 0);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(110, 18);
            lblKullaniciAdi.TabIndex = 40;
            lblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.MediumAquamarine;
            btnGiris.FlatStyle = FlatStyle.Popup;
            btnGiris.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = SystemColors.ActiveCaptionText;
            btnGiris.Location = new Point(204, 188);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(114, 33);
            btnGiris.TabIndex = 42;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // linklblSifremiUnuttum
            // 
            linklblSifremiUnuttum.ActiveLinkColor = Color.CornflowerBlue;
            linklblSifremiUnuttum.BackColor = Color.Transparent;
            linklblSifremiUnuttum.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            linklblSifremiUnuttum.ForeColor = SystemColors.ActiveCaptionText;
            linklblSifremiUnuttum.LinkColor = Color.RoyalBlue;
            linklblSifremiUnuttum.Location = new Point(219, 224);
            linklblSifremiUnuttum.Name = "linklblSifremiUnuttum";
            linklblSifremiUnuttum.Size = new Size(171, 28);
            linklblSifremiUnuttum.TabIndex = 43;
            linklblSifremiUnuttum.TabStop = true;
            linklblSifremiUnuttum.Text = "Şifremi Unuttum";
            linklblSifremiUnuttum.LinkClicked += linklblSifremiUnuttum_LinkClicked;
            // 
            // linklblAnaSayfa
            // 
            linklblAnaSayfa.ActiveLinkColor = Color.CornflowerBlue;
            linklblAnaSayfa.BackColor = Color.Transparent;
            linklblAnaSayfa.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            linklblAnaSayfa.ForeColor = SystemColors.ActiveCaptionText;
            linklblAnaSayfa.LinkColor = Color.RoyalBlue;
            linklblAnaSayfa.Location = new Point(12, 224);
            linklblAnaSayfa.Name = "linklblAnaSayfa";
            linklblAnaSayfa.Size = new Size(201, 32);
            linklblAnaSayfa.TabIndex = 44;
            linklblAnaSayfa.TabStop = true;
            linklblAnaSayfa.Text = "<-- Ana Sayfaya Dön..";
            linklblAnaSayfa.LinkClicked += linklblAnaSayfa_LinkClicked;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(452, 433);
            Controls.Add(linklblAnaSayfa);
            Controls.Add(linklblSifremiUnuttum);
            Controls.Add(btnGiris);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GirisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label lblSifre;
        private Label lblKullaniciAdi;
        private Button btnGiris;
        private LinkLabel linklblSifremiUnuttum;
        private LinkLabel linklblAnaSayfa;
    }
}