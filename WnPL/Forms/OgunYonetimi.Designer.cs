namespace WinPL.Forms
{
	partial class OgunYonetimi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgunYonetimi));
			lboxYemekler = new ListBox();
			lblYag = new Label();
			lblKarbonhidrat = new Label();
			lblProtein = new Label();
			lblKalori = new Label();
			label6 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			btnYemegiEkle = new Button();
			nupdownGramaj = new NumericUpDown();
			label7 = new Label();
			btnYeniYemekDetayEkle = new Button();
			cboxYemekDetay = new ComboBox();
			label8 = new Label();
			pboxYemekResmi = new PictureBox();
			lblYemekAdi = new Label();
			btnYeniYemekEkle = new Button();
			cboxKategori = new ComboBox();
			label4 = new Label();
			label5 = new Label();
			label1 = new Label();
			cboxOgun = new ComboBox();
			textBox1 = new TextBox();
			btnTümYemekler = new Button();
			lnkAnaSayfa = new LinkLabel();
			((System.ComponentModel.ISupportInitialize)nupdownGramaj).BeginInit();
			((System.ComponentModel.ISupportInitialize)pboxYemekResmi).BeginInit();
			SuspendLayout();
			// 
			// lboxYemekler
			// 
			lboxYemekler.BackColor = Color.MediumAquamarine;
			lboxYemekler.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			lboxYemekler.ForeColor = SystemColors.ActiveCaptionText;
			lboxYemekler.FormattingEnabled = true;
			lboxYemekler.ItemHeight = 18;
			lboxYemekler.Location = new Point(14, 401);
			lboxYemekler.Margin = new Padding(3, 4, 3, 4);
			lboxYemekler.Name = "lboxYemekler";
			lboxYemekler.Size = new Size(386, 328);
			lboxYemekler.TabIndex = 100;
			lboxYemekler.DoubleClick += lboxYemekler_DoubleClick;
			// 
			// lblYag
			// 
			lblYag.AutoSize = true;
			lblYag.BackColor = Color.Transparent;
			lblYag.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblYag.ForeColor = SystemColors.ActiveCaptionText;
			lblYag.Location = new Point(755, 621);
			lblYag.Name = "lblYag";
			lblYag.Size = new Size(21, 23);
			lblYag.TabIndex = 99;
			lblYag.Text = "0";
			// 
			// lblKarbonhidrat
			// 
			lblKarbonhidrat.AutoSize = true;
			lblKarbonhidrat.BackColor = Color.Transparent;
			lblKarbonhidrat.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblKarbonhidrat.ForeColor = SystemColors.ActiveCaptionText;
			lblKarbonhidrat.Location = new Point(755, 563);
			lblKarbonhidrat.Name = "lblKarbonhidrat";
			lblKarbonhidrat.Size = new Size(21, 23);
			lblKarbonhidrat.TabIndex = 98;
			lblKarbonhidrat.Text = "0";
			// 
			// lblProtein
			// 
			lblProtein.AutoSize = true;
			lblProtein.BackColor = Color.Transparent;
			lblProtein.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblProtein.ForeColor = SystemColors.ActiveCaptionText;
			lblProtein.Location = new Point(755, 508);
			lblProtein.Name = "lblProtein";
			lblProtein.Size = new Size(21, 23);
			lblProtein.TabIndex = 97;
			lblProtein.Text = "0";
			// 
			// lblKalori
			// 
			lblKalori.AutoSize = true;
			lblKalori.BackColor = Color.Transparent;
			lblKalori.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblKalori.ForeColor = SystemColors.ActiveCaptionText;
			lblKalori.Location = new Point(755, 456);
			lblKalori.Name = "lblKalori";
			lblKalori.Size = new Size(21, 23);
			lblKalori.TabIndex = 96;
			lblKalori.Text = "0";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(538, 621);
			label6.Name = "label6";
			label6.Size = new Size(114, 23);
			label6.TabIndex = 94;
			label6.Text = "Yağ Miktarı ";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.Transparent;
			label10.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label10.ForeColor = SystemColors.ActiveCaptionText;
			label10.Location = new Point(538, 508);
			label10.Name = "label10";
			label10.Size = new Size(145, 23);
			label10.TabIndex = 93;
			label10.Text = "Protein Miktarı ";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = Color.Transparent;
			label11.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label11.ForeColor = SystemColors.ActiveCaptionText;
			label11.Location = new Point(538, 563);
			label11.Name = "label11";
			label11.Size = new Size(193, 23);
			label11.TabIndex = 92;
			label11.Text = "Karbonhidrat MiktarI";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = Color.Transparent;
			label12.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label12.ForeColor = SystemColors.ActiveCaptionText;
			label12.Location = new Point(538, 456);
			label12.Name = "label12";
			label12.Size = new Size(123, 23);
			label12.TabIndex = 91;
			label12.Text = "Kalori değeri";
			// 
			// btnYemegiEkle
			// 
			btnYemegiEkle.BackColor = Color.MediumAquamarine;
			btnYemegiEkle.FlatStyle = FlatStyle.Flat;
			btnYemegiEkle.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnYemegiEkle.ForeColor = SystemColors.ActiveCaptionText;
			btnYemegiEkle.Location = new Point(518, 687);
			btnYemegiEkle.Margin = new Padding(3, 4, 3, 4);
			btnYemegiEkle.Name = "btnYemegiEkle";
			btnYemegiEkle.Size = new Size(355, 55);
			btnYemegiEkle.TabIndex = 89;
			btnYemegiEkle.Text = "Öğüne Yemeği Ekle";
			btnYemegiEkle.UseVisualStyleBackColor = false;
			btnYemegiEkle.Click += btnYemegiEkle_Click;
			// 
			// nupdownGramaj
			// 
			nupdownGramaj.BackColor = SystemColors.Control;
			nupdownGramaj.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			nupdownGramaj.ForeColor = SystemColors.ActiveCaptionText;
			nupdownGramaj.Location = new Point(681, 357);
			nupdownGramaj.Margin = new Padding(3, 4, 3, 4);
			nupdownGramaj.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nupdownGramaj.Name = "nupdownGramaj";
			nupdownGramaj.Size = new Size(200, 22);
			nupdownGramaj.TabIndex = 88;
			nupdownGramaj.Value = new decimal(new int[] { 100, 0, 0, 0 });
			nupdownGramaj.ValueChanged += nupdownGramaj_ValueChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(526, 357);
			label7.Name = "label7";
			label7.Size = new Size(147, 23);
			label7.TabIndex = 87;
			label7.Text = "Gramaj Seçiniz:";
			// 
			// btnYeniYemekDetayEkle
			// 
			btnYeniYemekDetayEkle.BackColor = Color.Aquamarine;
			btnYeniYemekDetayEkle.FlatStyle = FlatStyle.Flat;
			btnYeniYemekDetayEkle.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnYeniYemekDetayEkle.ForeColor = SystemColors.ActiveCaptionText;
			btnYeniYemekDetayEkle.Location = new Point(526, 269);
			btnYeniYemekDetayEkle.Margin = new Padding(3, 4, 3, 4);
			btnYeniYemekDetayEkle.Name = "btnYeniYemekDetayEkle";
			btnYeniYemekDetayEkle.Size = new Size(355, 35);
			btnYeniYemekDetayEkle.TabIndex = 86;
			btnYeniYemekDetayEkle.Text = "Yeni Yemek Detay Ekle";
			btnYeniYemekDetayEkle.UseVisualStyleBackColor = false;
			btnYeniYemekDetayEkle.Click += btnYeniYemekDetayEkle_Click;
			// 
			// cboxYemekDetay
			// 
			cboxYemekDetay.BackColor = SystemColors.Control;
			cboxYemekDetay.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			cboxYemekDetay.ForeColor = SystemColors.ActiveCaptionText;
			cboxYemekDetay.FormattingEnabled = true;
			cboxYemekDetay.Location = new Point(681, 209);
			cboxYemekDetay.Margin = new Padding(3, 4, 3, 4);
			cboxYemekDetay.Name = "cboxYemekDetay";
			cboxYemekDetay.Size = new Size(199, 24);
			cboxYemekDetay.TabIndex = 85;
			cboxYemekDetay.SelectedIndexChanged += cboxYemekDetay_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label8.ForeColor = SystemColors.ActiveCaptionText;
			label8.Location = new Point(453, 209);
			label8.Name = "label8";
			label8.Size = new Size(220, 23);
			label8.TabIndex = 84;
			label8.Text = "Yemek Detayını Seçiniz:";
			// 
			// pboxYemekResmi
			// 
			pboxYemekResmi.BackColor = Color.Transparent;
			pboxYemekResmi.Location = new Point(526, 51);
			pboxYemekResmi.Margin = new Padding(3, 4, 3, 4);
			pboxYemekResmi.Name = "pboxYemekResmi";
			pboxYemekResmi.Size = new Size(359, 129);
			pboxYemekResmi.SizeMode = PictureBoxSizeMode.StretchImage;
			pboxYemekResmi.TabIndex = 83;
			pboxYemekResmi.TabStop = false;
			// 
			// lblYemekAdi
			// 
			lblYemekAdi.AutoSize = true;
			lblYemekAdi.BackColor = Color.Transparent;
			lblYemekAdi.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblYemekAdi.ForeColor = SystemColors.ActiveCaptionText;
			lblYemekAdi.Location = new Point(526, 19);
			lblYemekAdi.Name = "lblYemekAdi";
			lblYemekAdi.Size = new Size(102, 23);
			lblYemekAdi.TabIndex = 82;
			lblYemekAdi.Text = "Yemek Adı";
			// 
			// btnYeniYemekEkle
			// 
			btnYeniYemekEkle.BackColor = Color.Aquamarine;
			btnYeniYemekEkle.FlatStyle = FlatStyle.Flat;
			btnYeniYemekEkle.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnYeniYemekEkle.ForeColor = SystemColors.ActiveCaptionText;
			btnYeniYemekEkle.Location = new Point(14, 261);
			btnYeniYemekEkle.Margin = new Padding(3, 4, 3, 4);
			btnYeniYemekEkle.Name = "btnYeniYemekEkle";
			btnYeniYemekEkle.Size = new Size(383, 43);
			btnYeniYemekEkle.TabIndex = 81;
			btnYeniYemekEkle.Text = "Yeni Yemek Ekle";
			btnYeniYemekEkle.UseVisualStyleBackColor = false;
			btnYeniYemekEkle.Click += btnYeniYemekEkle_Click;
			// 
			// cboxKategori
			// 
			cboxKategori.BackColor = SystemColors.Control;
			cboxKategori.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			cboxKategori.ForeColor = SystemColors.ActiveCaptionText;
			cboxKategori.FormattingEnabled = true;
			cboxKategori.Location = new Point(159, 85);
			cboxKategori.Margin = new Padding(3, 4, 3, 4);
			cboxKategori.Name = "cboxKategori";
			cboxKategori.Size = new Size(241, 24);
			cboxKategori.TabIndex = 78;
			cboxKategori.SelectedIndexChanged += cboxKategori_SelectedIndexChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(17, 153);
			label4.Name = "label4";
			label4.Size = new Size(109, 23);
			label4.TabIndex = 77;
			label4.Text = "Yemek Ara:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(17, 85);
			label5.Name = "label5";
			label5.Size = new Size(114, 23);
			label5.TabIndex = 76;
			label5.Text = "Ketegoriler:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(14, 23);
			label1.Name = "label1";
			label1.Size = new Size(85, 23);
			label1.TabIndex = 75;
			label1.Text = "Öğünler:";
			// 
			// cboxOgun
			// 
			cboxOgun.BackColor = SystemColors.Control;
			cboxOgun.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			cboxOgun.ForeColor = SystemColors.ActiveCaptionText;
			cboxOgun.FormattingEnabled = true;
			cboxOgun.Location = new Point(159, 19);
			cboxOgun.Margin = new Padding(3, 4, 3, 4);
			cboxOgun.Name = "cboxOgun";
			cboxOgun.Size = new Size(241, 24);
			cboxOgun.TabIndex = 74;
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.Control;
			textBox1.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
			textBox1.ForeColor = SystemColors.ActiveCaptionText;
			textBox1.Location = new Point(159, 149);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(241, 27);
			textBox1.TabIndex = 106;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// btnTümYemekler
			// 
			btnTümYemekler.BackColor = Color.Aquamarine;
			btnTümYemekler.FlatStyle = FlatStyle.Flat;
			btnTümYemekler.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnTümYemekler.ForeColor = SystemColors.ActiveCaptionText;
			btnTümYemekler.Location = new Point(14, 336);
			btnTümYemekler.Margin = new Padding(3, 4, 3, 4);
			btnTümYemekler.Name = "btnTümYemekler";
			btnTümYemekler.Size = new Size(383, 48);
			btnTümYemekler.TabIndex = 107;
			btnTümYemekler.Text = "Tüm Yemekleri Lİstele";
			btnTümYemekler.UseVisualStyleBackColor = false;
			btnTümYemekler.Click += btnTümYemekler_Click;
			// 
			// lnkAnaSayfa
			// 
			lnkAnaSayfa.AutoSize = true;
			lnkAnaSayfa.BackColor = Color.Transparent;
			lnkAnaSayfa.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lnkAnaSayfa.ForeColor = Color.RoyalBlue;
			lnkAnaSayfa.LinkColor = Color.RoyalBlue;
			lnkAnaSayfa.Location = new Point(14, 733);
			lnkAnaSayfa.Name = "lnkAnaSayfa";
			lnkAnaSayfa.Size = new Size(99, 23);
			lnkAnaSayfa.TabIndex = 108;
			lnkAnaSayfa.TabStop = true;
			lnkAnaSayfa.Text = "Ana Sayfa";
			lnkAnaSayfa.LinkClicked += lnkAnaSayfa_LinkClicked;
			// 
			// OgunYonetimi
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(893, 761);
			Controls.Add(lnkAnaSayfa);
			Controls.Add(btnTümYemekler);
			Controls.Add(textBox1);
			Controls.Add(lboxYemekler);
			Controls.Add(lblYag);
			Controls.Add(lblKarbonhidrat);
			Controls.Add(lblProtein);
			Controls.Add(lblKalori);
			Controls.Add(label6);
			Controls.Add(label10);
			Controls.Add(label11);
			Controls.Add(label12);
			Controls.Add(btnYemegiEkle);
			Controls.Add(nupdownGramaj);
			Controls.Add(label7);
			Controls.Add(btnYeniYemekDetayEkle);
			Controls.Add(cboxYemekDetay);
			Controls.Add(label8);
			Controls.Add(pboxYemekResmi);
			Controls.Add(lblYemekAdi);
			Controls.Add(btnYeniYemekEkle);
			Controls.Add(cboxKategori);
			Controls.Add(label4);
			Controls.Add(label5);
			Controls.Add(label1);
			Controls.Add(cboxOgun);
			DoubleBuffered = true;
			Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Margin = new Padding(3, 4, 3, 4);
			Name = "OgunYonetimi";
			Text = "OgunYonetimi";
			Load += OgunYonetimi_Load;
			((System.ComponentModel.ISupportInitialize)nupdownGramaj).EndInit();
			((System.ComponentModel.ISupportInitialize)pboxYemekResmi).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ListBox lboxYemekler;
		private Label lblYag;
		private Label lblKarbonhidrat;
		private Label lblProtein;
		private Label lblKalori;
		private Label label6;
		private Label label10;
		private Label label11;
		private Label label12;
		private Button btnYemegiEkle;
		private NumericUpDown nupdownGramaj;
		private Label label7;
		private Button btnYeniYemekDetayEkle;
		private ComboBox cboxYemekDetay;
		private Label label8;
		private PictureBox pboxYemekResmi;
		private Label lblYemekAdi;
		private Button btnYeniYemekEkle;
		private ComboBox cboxKategori;
		private Label label4;
		private Label label5;
		private Label label1;
		private ComboBox cboxOgun;
		private TextBox textBox1;
		private Button btnTümYemekler;
		private LinkLabel lnkAnaSayfa;
	}
}