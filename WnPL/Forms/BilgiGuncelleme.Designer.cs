namespace WinPL.Forms
{
	partial class BilgiGuncelleme
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgiGuncelleme));
			label11 = new Label();
			btnResimEkle = new Button();
			pboxProfilFotografi = new PictureBox();
			btnGuncelle = new Button();
			cboxAktiviteSeviyesi = new ComboBox();
			txtBoy = new TextBox();
			txtKilo = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pboxProfilFotografi).BeginInit();
			SuspendLayout();
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label11.ForeColor = SystemColors.ActiveCaptionText;
			label11.Location = new Point(171, 38);
			label11.Name = "label11";
			label11.Size = new Size(202, 20);
			label11.TabIndex = 71;
			label11.Text = "Her Halin Bizce Çok Güzel..";
			// 
			// btnResimEkle
			// 
			btnResimEkle.BackColor = Color.MediumAquamarine;
			btnResimEkle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnResimEkle.ForeColor = SystemColors.ActiveCaptionText;
			btnResimEkle.Location = new Point(209, 85);
			btnResimEkle.Margin = new Padding(3, 4, 3, 4);
			btnResimEkle.Name = "btnResimEkle";
			btnResimEkle.Size = new Size(147, 48);
			btnResimEkle.TabIndex = 3;
			btnResimEkle.Text = "Resim Ekle";
			btnResimEkle.UseVisualStyleBackColor = false;
			btnResimEkle.Click += btnResimEkle_Click;
			// 
			// pboxProfilFotografi
			// 
			pboxProfilFotografi.BackColor = Color.Transparent;
			pboxProfilFotografi.Location = new Point(12, 13);
			pboxProfilFotografi.Margin = new Padding(3, 4, 3, 4);
			pboxProfilFotografi.Name = "pboxProfilFotografi";
			pboxProfilFotografi.Size = new Size(153, 138);
			pboxProfilFotografi.SizeMode = PictureBoxSizeMode.StretchImage;
			pboxProfilFotografi.TabIndex = 69;
			pboxProfilFotografi.TabStop = false;
			// 
			// btnGuncelle
			// 
			btnGuncelle.BackColor = Color.MediumAquamarine;
			btnGuncelle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnGuncelle.ForeColor = SystemColors.ActiveCaptionText;
			btnGuncelle.Location = new Point(24, 318);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(332, 65);
			btnGuncelle.TabIndex = 4;
			btnGuncelle.Text = "Bilgilerimi Güncelle";
			btnGuncelle.UseVisualStyleBackColor = false;
			btnGuncelle.Click += btnGuncelle_Click;
			// 
			// cboxAktiviteSeviyesi
			// 
			cboxAktiviteSeviyesi.BackColor = SystemColors.Control;
			cboxAktiviteSeviyesi.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			cboxAktiviteSeviyesi.ForeColor = SystemColors.ActiveCaptionText;
			cboxAktiviteSeviyesi.FormattingEnabled = true;
			cboxAktiviteSeviyesi.Location = new Point(167, 259);
			cboxAktiviteSeviyesi.Name = "cboxAktiviteSeviyesi";
			cboxAktiviteSeviyesi.Size = new Size(189, 26);
			cboxAktiviteSeviyesi.TabIndex = 2;
			// 
			// txtBoy
			// 
			txtBoy.BackColor = SystemColors.Control;
			txtBoy.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			txtBoy.ForeColor = SystemColors.ActiveCaptionText;
			txtBoy.Location = new Point(167, 216);
			txtBoy.Name = "txtBoy";
			txtBoy.Size = new Size(189, 26);
			txtBoy.TabIndex = 1;
			// 
			// txtKilo
			// 
			txtKilo.BackColor = SystemColors.Control;
			txtKilo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			txtKilo.ForeColor = SystemColors.ActiveCaptionText;
			txtKilo.Location = new Point(167, 175);
			txtKilo.Name = "txtKilo";
			txtKilo.Size = new Size(189, 26);
			txtKilo.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(12, 262);
			label3.Name = "label3";
			label3.Size = new Size(131, 18);
			label3.TabIndex = 64;
			label3.Text = "Aktivite Seviyesi:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(12, 218);
			label2.Name = "label2";
			label2.Size = new Size(39, 18);
			label2.TabIndex = 63;
			label2.Text = "Boy:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(12, 173);
			label1.Name = "label1";
			label1.Size = new Size(40, 18);
			label1.TabIndex = 62;
			label1.Text = "Kilo:";
			// 
			// BilgiGuncelleme
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(375, 405);
			Controls.Add(label11);
			Controls.Add(btnResimEkle);
			Controls.Add(pboxProfilFotografi);
			Controls.Add(btnGuncelle);
			Controls.Add(cboxAktiviteSeviyesi);
			Controls.Add(txtBoy);
			Controls.Add(txtKilo);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			DoubleBuffered = true;
			Name = "BilgiGuncelleme";
			Text = "BilgiGuncelleme";
			Load += BilgiGuncelleme_Load;
			((System.ComponentModel.ISupportInitialize)pboxProfilFotografi).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label11;
		private Button btnResimEkle;
		private PictureBox pboxProfilFotografi;
		private Button btnGuncelle;
		private ComboBox cboxAktiviteSeviyesi;
		private TextBox txtBoy;
		private TextBox txtKilo;
		private Label label3;
		private Label label2;
		private Label label1;
	}
}