namespace WinPL.Forms
{
	partial class ProfilBilgileri
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilBilgileri));
			groupBoxBilgilerim = new GroupBox();
			btnGuncelle = new Button();
			txtAktiviteSeviyesi = new TextBox();
			label3 = new Label();
			txtKilo = new TextBox();
			txtBoy = new TextBox();
			pboxProfilFotografi = new PictureBox();
			label1 = new Label();
			label7 = new Label();
			label2 = new Label();
			txtCinsiyet = new TextBox();
			txtAd = new TextBox();
			txtYas = new TextBox();
			txtSoyad = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			groupBoxBilgilerim.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pboxProfilFotografi).BeginInit();
			SuspendLayout();
			// 
			// groupBoxBilgilerim
			// 
			groupBoxBilgilerim.BackColor = Color.Transparent;
			groupBoxBilgilerim.Controls.Add(btnGuncelle);
			groupBoxBilgilerim.Controls.Add(txtAktiviteSeviyesi);
			groupBoxBilgilerim.Controls.Add(label3);
			groupBoxBilgilerim.Controls.Add(txtKilo);
			groupBoxBilgilerim.Controls.Add(txtBoy);
			groupBoxBilgilerim.Controls.Add(pboxProfilFotografi);
			groupBoxBilgilerim.Controls.Add(label1);
			groupBoxBilgilerim.Controls.Add(label7);
			groupBoxBilgilerim.Controls.Add(label2);
			groupBoxBilgilerim.Controls.Add(txtCinsiyet);
			groupBoxBilgilerim.Controls.Add(txtAd);
			groupBoxBilgilerim.Controls.Add(txtYas);
			groupBoxBilgilerim.Controls.Add(txtSoyad);
			groupBoxBilgilerim.Controls.Add(label4);
			groupBoxBilgilerim.Controls.Add(label5);
			groupBoxBilgilerim.Controls.Add(label6);
			groupBoxBilgilerim.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBoxBilgilerim.ForeColor = SystemColors.ActiveCaptionText;
			groupBoxBilgilerim.Location = new Point(12, 12);
			groupBoxBilgilerim.Name = "groupBoxBilgilerim";
			groupBoxBilgilerim.Size = new Size(376, 606);
			groupBoxBilgilerim.TabIndex = 79;
			groupBoxBilgilerim.TabStop = false;
			groupBoxBilgilerim.Text = "Profil Bilgilerim";
			// 
			// btnGuncelle
			// 
			btnGuncelle.BackColor = Color.MediumAquamarine;
			btnGuncelle.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnGuncelle.ForeColor = SystemColors.ActiveCaptionText;
			btnGuncelle.Location = new Point(21, 522);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(338, 65);
			btnGuncelle.TabIndex = 82;
			btnGuncelle.Text = "Bilgilerimi Güncellemek İstiyorum";
			btnGuncelle.UseVisualStyleBackColor = false;
			btnGuncelle.Click += btnGuncelle_Click;
			// 
			// txtAktiviteSeviyesi
			// 
			txtAktiviteSeviyesi.BorderStyle = BorderStyle.None;
			txtAktiviteSeviyesi.Enabled = false;
			txtAktiviteSeviyesi.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
			txtAktiviteSeviyesi.Location = new Point(170, 460);
			txtAktiviteSeviyesi.Name = "txtAktiviteSeviyesi";
			txtAktiviteSeviyesi.Size = new Size(189, 17);
			txtAktiviteSeviyesi.TabIndex = 81;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(27, 460);
			label3.Name = "label3";
			label3.Size = new Size(131, 18);
			label3.TabIndex = 80;
			label3.Text = "Aktivite Seviyesi:";
			// 
			// txtKilo
			// 
			txtKilo.BorderStyle = BorderStyle.None;
			txtKilo.Enabled = false;
			txtKilo.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
			txtKilo.ForeColor = SystemColors.ActiveCaptionText;
			txtKilo.Location = new Point(170, 415);
			txtKilo.Name = "txtKilo";
			txtKilo.Size = new Size(189, 17);
			txtKilo.TabIndex = 79;
			// 
			// txtBoy
			// 
			txtBoy.BorderStyle = BorderStyle.None;
			txtBoy.Enabled = false;
			txtBoy.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
			txtBoy.ForeColor = SystemColors.ActiveCaptionText;
			txtBoy.Location = new Point(170, 368);
			txtBoy.Name = "txtBoy";
			txtBoy.Size = new Size(189, 17);
			txtBoy.TabIndex = 77;
			// 
			// pboxProfilFotografi
			// 
			pboxProfilFotografi.Location = new Point(27, 27);
			pboxProfilFotografi.Margin = new Padding(3, 4, 3, 4);
			pboxProfilFotografi.Name = "pboxProfilFotografi";
			pboxProfilFotografi.Size = new Size(153, 138);
			pboxProfilFotografi.SizeMode = PictureBoxSizeMode.StretchImage;
			pboxProfilFotografi.TabIndex = 69;
			pboxProfilFotografi.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(27, 189);
			label1.Name = "label1";
			label1.Size = new Size(31, 18);
			label1.TabIndex = 62;
			label1.Text = "Ad:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(27, 415);
			label7.Name = "label7";
			label7.Size = new Size(40, 18);
			label7.TabIndex = 76;
			label7.Text = "Kilo:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(27, 234);
			label2.Name = "label2";
			label2.Size = new Size(56, 18);
			label2.TabIndex = 63;
			label2.Text = "Soyad:";
			// 
			// txtCinsiyet
			// 
			txtCinsiyet.BorderStyle = BorderStyle.None;
			txtCinsiyet.Enabled = false;
			txtCinsiyet.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
			txtCinsiyet.ForeColor = SystemColors.ActiveCaptionText;
			txtCinsiyet.Location = new Point(170, 278);
			txtCinsiyet.Name = "txtCinsiyet";
			txtCinsiyet.Size = new Size(189, 17);
			txtCinsiyet.TabIndex = 74;
			// 
			// txtAd
			// 
			txtAd.BorderStyle = BorderStyle.None;
			txtAd.Enabled = false;
			txtAd.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
			txtAd.ForeColor = SystemColors.ActiveCaptionText;
			txtAd.Location = new Point(170, 189);
			txtAd.Name = "txtAd";
			txtAd.Size = new Size(189, 17);
			txtAd.TabIndex = 65;
			// 
			// txtYas
			// 
			txtYas.BorderStyle = BorderStyle.None;
			txtYas.Enabled = false;
			txtYas.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
			txtYas.ForeColor = SystemColors.ActiveCaptionText;
			txtYas.Location = new Point(170, 325);
			txtYas.Name = "txtYas";
			txtYas.Size = new Size(189, 17);
			txtYas.TabIndex = 73;
			// 
			// txtSoyad
			// 
			txtSoyad.BorderStyle = BorderStyle.None;
			txtSoyad.Enabled = false;
			txtSoyad.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
			txtSoyad.ForeColor = SystemColors.ActiveCaptionText;
			txtSoyad.Location = new Point(170, 230);
			txtSoyad.Name = "txtSoyad";
			txtSoyad.Size = new Size(189, 17);
			txtSoyad.TabIndex = 66;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(27, 368);
			label4.Name = "label4";
			label4.Size = new Size(39, 18);
			label4.TabIndex = 72;
			label4.Text = "Boy:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(27, 282);
			label5.Name = "label5";
			label5.Size = new Size(70, 18);
			label5.TabIndex = 71;
			label5.Text = "Cinsiyet:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(27, 328);
			label6.Name = "label6";
			label6.Size = new Size(38, 18);
			label6.TabIndex = 70;
			label6.Text = "Yaş:";
			// 
			// ProfilBilgileri
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(396, 630);
			Controls.Add(groupBoxBilgilerim);
			DoubleBuffered = true;
			Name = "ProfilBilgileri";
			Text = "ProfilBilgileri";
			Load += ProfilBilgileri_Load;
			groupBoxBilgilerim.ResumeLayout(false);
			groupBoxBilgilerim.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pboxProfilFotografi).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBoxBilgilerim;
		private TextBox txtAktiviteSeviyesi;
		private Label label3;
		private TextBox txtKilo;
		private TextBox txtBoy;
		private PictureBox pboxProfilFotografi;
		private Label label1;
		private Label label7;
		private Label label2;
		private TextBox txtCinsiyet;
		private TextBox txtAd;
		private TextBox txtYas;
		private TextBox txtSoyad;
		private Label label4;
		private Label label5;
		private Label label6;
		private Button btnGuncelle;
	}
}