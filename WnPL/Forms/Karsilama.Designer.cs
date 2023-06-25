namespace WinPL.Forms
{
    partial class KarsilamaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarsilamaForm));
            btnKaydol = new Button();
            btnGiris = new Button();
            lblAciklama = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = Color.Transparent;
            btnKaydol.BackgroundImageLayout = ImageLayout.None;
            btnKaydol.Cursor = Cursors.Hand;
            btnKaydol.FlatAppearance.BorderSize = 0;
            btnKaydol.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKaydol.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKaydol.FlatStyle = FlatStyle.Flat;
            btnKaydol.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydol.ForeColor = Color.Black;
            btnKaydol.Location = new Point(375, 275);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(167, 499);
            btnKaydol.TabIndex = 7;
            btnKaydol.Text = "Kaydol";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Transparent;
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGiris.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.Black;
            btnGiris.Location = new Point(129, 275);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(154, 499);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.BackColor = Color.Transparent;
            lblAciklama.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAciklama.ForeColor = SystemColors.ActiveCaptionText;
            lblAciklama.Location = new Point(150, 846);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(392, 31);
            lblAciklama.TabIndex = 9;
            lblAciklama.Text = "Kilo Kontrolü İçin Doğru Yerdesiniz..";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 51);
            label1.TabIndex = 10;
            label1.Text = "HUB'a hoş geldiniz";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.Cyan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(637, 836);
            button1.Name = "button1";
            button1.Size = new Size(47, 41);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // KarsilamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(696, 877);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblAciklama);
            Controls.Add(btnKaydol);
            Controls.Add(btnGiris);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KarsilamaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydol;
        private Button btnGiris;
        private Label lblAciklama;
        private Label label1;
        private Button button1;
    }
}