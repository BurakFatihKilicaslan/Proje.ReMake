namespace WinPL.Forms
{
    partial class YemekEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YemekEkleme));
            label8 = new Label();
            nupdownKarbonhidrat = new NumericUpDown();
            nupdownProtein = new NumericUpDown();
            nupdownKalori = new NumericUpDown();
            nupdownYag = new NumericUpDown();
            txtIcerik = new TextBox();
            txtYemekAdi = new TextBox();
            btnYemekKaydet = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnYemekResmiEkle = new Button();
            pboxYemekResmi = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboxKategori = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nupdownKarbonhidrat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdownProtein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdownKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdownYag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxYemekResmi).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(126, 38);
            label8.Name = "label8";
            label8.Size = new Size(312, 20);
            label8.TabIndex = 52;
            label8.Text = "Eklenecek Yemeğin Lezzetinden Şüphemiz Yok..";
            // 
            // nupdownKarbonhidrat
            // 
            nupdownKarbonhidrat.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownKarbonhidrat.Location = new Point(203, 409);
            nupdownKarbonhidrat.Margin = new Padding(3, 2, 3, 2);
            nupdownKarbonhidrat.Name = "nupdownKarbonhidrat";
            nupdownKarbonhidrat.Size = new Size(235, 26);
            nupdownKarbonhidrat.TabIndex = 51;
            // 
            // nupdownProtein
            // 
            nupdownProtein.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownProtein.Location = new Point(203, 368);
            nupdownProtein.Margin = new Padding(3, 2, 3, 2);
            nupdownProtein.Name = "nupdownProtein";
            nupdownProtein.Size = new Size(235, 26);
            nupdownProtein.TabIndex = 50;
            // 
            // nupdownKalori
            // 
            nupdownKalori.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownKalori.Location = new Point(203, 329);
            nupdownKalori.Margin = new Padding(3, 2, 3, 2);
            nupdownKalori.Name = "nupdownKalori";
            nupdownKalori.Size = new Size(235, 26);
            nupdownKalori.TabIndex = 49;
            // 
            // nupdownYag
            // 
            nupdownYag.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownYag.Location = new Point(203, 452);
            nupdownYag.Margin = new Padding(3, 2, 3, 2);
            nupdownYag.Name = "nupdownYag";
            nupdownYag.Size = new Size(235, 26);
            nupdownYag.TabIndex = 48;
            // 
            // txtIcerik
            // 
            txtIcerik.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIcerik.Location = new Point(203, 244);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik";
            txtIcerik.Size = new Size(235, 77);
            txtIcerik.TabIndex = 47;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtYemekAdi.Location = new Point(203, 199);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(235, 26);
            txtYemekAdi.TabIndex = 46;
            // 
            // btnYemekKaydet
            // 
            btnYemekKaydet.BackColor = Color.MediumAquamarine;
            btnYemekKaydet.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnYemekKaydet.ForeColor = SystemColors.ActiveCaptionText;
            btnYemekKaydet.Location = new Point(4, 495);
            btnYemekKaydet.Name = "btnYemekKaydet";
            btnYemekKaydet.Size = new Size(434, 48);
            btnYemekKaydet.TabIndex = 44;
            btnYemekKaydet.Text = "Yemeğimi Kaydet";
            btnYemekKaydet.UseVisualStyleBackColor = false;
            btnYemekKaydet.Click += btnYemekKaydet_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(4, 453);
            label7.Name = "label7";
            label7.Size = new Size(93, 18);
            label7.TabIndex = 43;
            label7.Text = "Yağ Miktarı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(4, 368);
            label6.Name = "label6";
            label6.Size = new Size(122, 18);
            label6.TabIndex = 42;
            label6.Text = "Protein Miktarı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(4, 409);
            label5.Name = "label5";
            label5.Size = new Size(162, 18);
            label5.TabIndex = 41;
            label5.Text = "Karbonhidrat Miktarı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(5, 330);
            label4.Name = "label4";
            label4.Size = new Size(106, 18);
            label4.TabIndex = 40;
            label4.Text = "Kalori Değeri:";
            // 
            // btnYemekResmiEkle
            // 
            btnYemekResmiEkle.BackColor = Color.MediumAquamarine;
            btnYemekResmiEkle.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnYemekResmiEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnYemekResmiEkle.Location = new Point(169, 87);
            btnYemekResmiEkle.Name = "btnYemekResmiEkle";
            btnYemekResmiEkle.Size = new Size(269, 40);
            btnYemekResmiEkle.TabIndex = 39;
            btnYemekResmiEkle.Text = "Yemeğin Resmini Ekle";
            btnYemekResmiEkle.UseVisualStyleBackColor = false;
            btnYemekResmiEkle.Click += btnYemekResmiEkle_Click;
            // 
            // pboxYemekResmi
            // 
            pboxYemekResmi.BackColor = Color.Transparent;
            pboxYemekResmi.Location = new Point(5, 13);
            pboxYemekResmi.Name = "pboxYemekResmi";
            pboxYemekResmi.Size = new Size(116, 114);
            pboxYemekResmi.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxYemekResmi.TabIndex = 38;
            pboxYemekResmi.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(4, 247);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 37;
            label3.Text = "İçerik:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(4, 202);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 36;
            label2.Text = "Yemek Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(4, 157);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 35;
            label1.Text = "Kategori:";
            // 
            // cboxKategori
            // 
            cboxKategori.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboxKategori.FormattingEnabled = true;
            cboxKategori.Location = new Point(203, 154);
            cboxKategori.Name = "cboxKategori";
            cboxKategori.Size = new Size(227, 26);
            cboxKategori.TabIndex = 53;
            // 
            // YemekEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(442, 557);
            Controls.Add(cboxKategori);
            Controls.Add(label8);
            Controls.Add(nupdownKarbonhidrat);
            Controls.Add(nupdownProtein);
            Controls.Add(nupdownKalori);
            Controls.Add(nupdownYag);
            Controls.Add(txtIcerik);
            Controls.Add(txtYemekAdi);
            Controls.Add(btnYemekKaydet);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnYemekResmiEkle);
            Controls.Add(pboxYemekResmi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "YemekEkleme";
            Text = "YemekEkleme";
            Load += YemekEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)nupdownKarbonhidrat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdownProtein).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdownKalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdownYag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxYemekResmi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private NumericUpDown nupdownKarbonhidrat;
        private NumericUpDown nupdownProtein;
        private NumericUpDown nupdownKalori;
        private NumericUpDown nupdownYag;
        private TextBox txtIcerik;
        private TextBox txtYemekAdi;
        private Button btnYemekKaydet;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnYemekResmiEkle;
        private PictureBox pboxYemekResmi;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboxKategori;
    }
}