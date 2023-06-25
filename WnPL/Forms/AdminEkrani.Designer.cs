namespace WnPL.Forms
{
    partial class AdminEkrani
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
            gboxTumMusteriler = new GroupBox();
            lstMusteriler = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnMusteriDetay = new Button();
            btnYemekYonetimi = new Button();
            gboxTumMusteriler.SuspendLayout();
            SuspendLayout();
            // 
            // gboxTumMusteriler
            // 
            gboxTumMusteriler.BackColor = SystemColors.ActiveCaptionText;
            gboxTumMusteriler.Controls.Add(btnYemekYonetimi);
            gboxTumMusteriler.Controls.Add(lstMusteriler);
            gboxTumMusteriler.Controls.Add(btnMusteriDetay);
            gboxTumMusteriler.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gboxTumMusteriler.ForeColor = SystemColors.ButtonHighlight;
            gboxTumMusteriler.Location = new Point(12, 2);
            gboxTumMusteriler.Name = "gboxTumMusteriler";
            gboxTumMusteriler.Size = new Size(622, 424);
            gboxTumMusteriler.TabIndex = 22;
            gboxTumMusteriler.TabStop = false;
            gboxTumMusteriler.Text = "Müşteriler";
            // 
            // lstMusteriler
            // 
            lstMusteriler.BackColor = SystemColors.ActiveCaptionText;
            lstMusteriler.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lstMusteriler.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstMusteriler.ForeColor = SystemColors.ButtonHighlight;
            lstMusteriler.FullRowSelect = true;
            lstMusteriler.GridLines = true;
            lstMusteriler.Location = new Point(0, 66);
            lstMusteriler.Name = "lstMusteriler";
            lstMusteriler.Size = new Size(616, 349);
            lstMusteriler.TabIndex = 18;
            lstMusteriler.UseCompatibleStateImageBehavior = false;
            lstMusteriler.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ad";
            columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Soyad";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kullanıcı Adı";
            columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Aktivite Seviyesi";
            columnHeader8.Width = 180;
            // 
            // btnMusteriDetay
            // 
            btnMusteriDetay.BackColor = SystemColors.ActiveCaptionText;
            btnMusteriDetay.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriDetay.ForeColor = SystemColors.ButtonHighlight;
            btnMusteriDetay.Location = new Point(377, 27);
            btnMusteriDetay.Name = "btnMusteriDetay";
            btnMusteriDetay.Size = new Size(245, 33);
            btnMusteriDetay.TabIndex = 19;
            btnMusteriDetay.Text = "Müşteri Detayını Görüntüle";
            btnMusteriDetay.UseVisualStyleBackColor = false;
            btnMusteriDetay.Click += btnMusteriDetay_Click;
            // 
            // btnYemekYonetimi
            // 
            btnYemekYonetimi.BackColor = SystemColors.ActiveCaptionText;
            btnYemekYonetimi.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnYemekYonetimi.ForeColor = SystemColors.ButtonHighlight;
            btnYemekYonetimi.Location = new Point(0, 27);
            btnYemekYonetimi.Name = "btnYemekYonetimi";
            btnYemekYonetimi.Size = new Size(144, 33);
            btnYemekYonetimi.TabIndex = 20;
            btnYemekYonetimi.Text = "Yemek Yönetimi";
            btnYemekYonetimi.UseVisualStyleBackColor = false;
            btnYemekYonetimi.Click += btnYemekYonetimi_Click;
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(646, 438);
            Controls.Add(gboxTumMusteriler);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "AdminEkrani";
            Text = "AdminEkrani";
            Load += AdminEkrani_Load;
            gboxTumMusteriler.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxTumMusteriler;
        public ListView lstMusteriler;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnMusteriDetay;
        private Button btnYemekYonetimi;
    }
}