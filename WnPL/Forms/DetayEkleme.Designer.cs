namespace WinPL.Forms
{
    partial class DetayEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetayEkleme));
            nupdownYag = new NumericUpDown();
            nupdownKarbonhidrat = new NumericUpDown();
            nupdownProtein = new NumericUpDown();
            nupdownKalori = new NumericUpDown();
            txtIcerik = new TextBox();
            txtYemekAdı = new TextBox();
            btnKaydet = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pboxDetayEkleme = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            btnResimEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)nupdownYag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdownKarbonhidrat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdownProtein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdownKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxDetayEkleme).BeginInit();
            SuspendLayout();
            // 
            // nupdownYag
            // 
            nupdownYag.BackColor = SystemColors.Control;
            nupdownYag.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownYag.ForeColor = SystemColors.ActiveCaptionText;
            nupdownYag.Location = new Point(180, 409);
            nupdownYag.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupdownYag.Name = "nupdownYag";
            nupdownYag.Size = new Size(188, 26);
            nupdownYag.TabIndex = 5;
            // 
            // nupdownKarbonhidrat
            // 
            nupdownKarbonhidrat.BackColor = SystemColors.Control;
            nupdownKarbonhidrat.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownKarbonhidrat.ForeColor = SystemColors.ActiveCaptionText;
            nupdownKarbonhidrat.Location = new Point(180, 365);
            nupdownKarbonhidrat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupdownKarbonhidrat.Name = "nupdownKarbonhidrat";
            nupdownKarbonhidrat.Size = new Size(188, 26);
            nupdownKarbonhidrat.TabIndex = 4;
            // 
            // nupdownProtein
            // 
            nupdownProtein.BackColor = SystemColors.Control;
            nupdownProtein.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownProtein.ForeColor = SystemColors.ActiveCaptionText;
            nupdownProtein.Location = new Point(180, 324);
            nupdownProtein.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupdownProtein.Name = "nupdownProtein";
            nupdownProtein.Size = new Size(188, 26);
            nupdownProtein.TabIndex = 3;
            // 
            // nupdownKalori
            // 
            nupdownKalori.BackColor = SystemColors.Control;
            nupdownKalori.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nupdownKalori.ForeColor = SystemColors.ActiveCaptionText;
            nupdownKalori.Location = new Point(180, 285);
            nupdownKalori.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupdownKalori.Name = "nupdownKalori";
            nupdownKalori.Size = new Size(188, 26);
            nupdownKalori.TabIndex = 2;
            // 
            // txtIcerik
            // 
            txtIcerik.BackColor = SystemColors.Control;
            txtIcerik.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIcerik.ForeColor = SystemColors.ActiveCaptionText;
            txtIcerik.Location = new Point(180, 202);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik";
            txtIcerik.Size = new Size(188, 77);
            txtIcerik.TabIndex = 1;
            // 
            // txtYemekAdı
            // 
            txtYemekAdı.BackColor = SystemColors.Control;
            txtYemekAdı.Enabled = false;
            txtYemekAdı.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtYemekAdı.ForeColor = SystemColors.ActiveCaptionText;
            txtYemekAdı.Location = new Point(180, 154);
            txtYemekAdı.Name = "txtYemekAdı";
            txtYemekAdı.Size = new Size(188, 26);
            txtYemekAdı.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MediumAquamarine;
            btnKaydet.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = SystemColors.ActiveCaptionText;
            btnKaydet.Location = new Point(12, 461);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(356, 38);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(12, 408);
            label7.Name = "label7";
            label7.Size = new Size(93, 18);
            label7.TabIndex = 40;
            label7.Text = "Yağ Miktarı ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(12, 325);
            label6.Name = "label6";
            label6.Size = new Size(118, 18);
            label6.TabIndex = 39;
            label6.Text = "Protein Miktarı ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(12, 366);
            label5.Name = "label5";
            label5.Size = new Size(158, 18);
            label5.TabIndex = 38;
            label5.Text = "Karbonhidrat Miktarı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 284);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 37;
            label4.Text = "Kalori değeri";
            // 
            // pboxDetayEkleme
            // 
            pboxDetayEkleme.BackColor = Color.Transparent;
            pboxDetayEkleme.Location = new Point(12, 12);
            pboxDetayEkleme.Name = "pboxDetayEkleme";
            pboxDetayEkleme.Size = new Size(156, 122);
            pboxDetayEkleme.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxDetayEkleme.TabIndex = 36;
            pboxDetayEkleme.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 35;
            label3.Text = "İçerik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 157);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 34;
            label2.Text = "Yemek Adı";
            // 
            // btnResimEkle
            // 
            btnResimEkle.BackColor = Color.MediumAquamarine;
            btnResimEkle.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnResimEkle.Location = new Point(197, 94);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(171, 40);
            btnResimEkle.TabIndex = 6;
            btnResimEkle.Text = "Resim Ekle ";
            btnResimEkle.UseVisualStyleBackColor = false;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // DetayEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(380, 511);
            Controls.Add(btnResimEkle);
            Controls.Add(nupdownYag);
            Controls.Add(nupdownKarbonhidrat);
            Controls.Add(nupdownProtein);
            Controls.Add(nupdownKalori);
            Controls.Add(txtIcerik);
            Controls.Add(txtYemekAdı);
            Controls.Add(btnKaydet);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pboxDetayEkleme);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "DetayEkleme";
            Text = "DetayEkleme";
            Load += DetayEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)nupdownYag).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdownKarbonhidrat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdownProtein).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdownKalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxDetayEkleme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nupdownYag;
        private NumericUpDown nupdownKarbonhidrat;
        private NumericUpDown nupdownProtein;
        private NumericUpDown nupdownKalori;
        private TextBox txtIcerik;
        private TextBox txtYemekAdı;
        private Button btnKaydet;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pboxDetayEkleme;
        private Label label3;
        private Label label2;
        private Button btnResimEkle;
    }
}