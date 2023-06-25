namespace WinPL.Forms
{
    partial class SifreDegistirmeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistirmeForm));
            btnSifreDegistir = new Button();
            txtYeniSifreTekrar = new TextBox();
            txtYeniSifre = new TextBox();
            txtEskiSifre = new TextBox();
            lblYeniSifreTekrar = new Label();
            lblYeniSifre = new Label();
            lblEskiSifre = new Label();
            SuspendLayout();
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.BackColor = Color.MediumAquamarine;
            btnSifreDegistir.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifreDegistir.ForeColor = SystemColors.ActiveCaptionText;
            btnSifreDegistir.Location = new Point(15, 152);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(344, 38);
            btnSifreDegistir.TabIndex = 3;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = false;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.BackColor = SystemColors.Control;
            txtYeniSifreTekrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtYeniSifreTekrar.ForeColor = SystemColors.ActiveCaptionText;
            txtYeniSifreTekrar.Location = new Point(159, 109);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.PasswordChar = '*';
            txtYeniSifreTekrar.Size = new Size(200, 22);
            txtYeniSifreTekrar.TabIndex = 2;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.BackColor = SystemColors.Control;
            txtYeniSifre.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtYeniSifre.ForeColor = SystemColors.ActiveCaptionText;
            txtYeniSifre.Location = new Point(159, 62);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.Size = new Size(200, 22);
            txtYeniSifre.TabIndex = 1;
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.BackColor = SystemColors.Control;
            txtEskiSifre.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtEskiSifre.ForeColor = SystemColors.ActiveCaptionText;
            txtEskiSifre.Location = new Point(159, 12);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.PasswordChar = '*';
            txtEskiSifre.Size = new Size(200, 22);
            txtEskiSifre.TabIndex = 0;
            // 
            // lblYeniSifreTekrar
            // 
            lblYeniSifreTekrar.AutoSize = true;
            lblYeniSifreTekrar.BackColor = Color.Transparent;
            lblYeniSifreTekrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblYeniSifreTekrar.ForeColor = SystemColors.ActiveCaptionText;
            lblYeniSifreTekrar.Location = new Point(15, 112);
            lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            lblYeniSifreTekrar.Size = new Size(120, 16);
            lblYeniSifreTekrar.TabIndex = 23;
            lblYeniSifreTekrar.Text = "Yeni Şİfre Tekrar :";
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.BackColor = Color.Transparent;
            lblYeniSifre.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblYeniSifre.ForeColor = SystemColors.ActiveCaptionText;
            lblYeniSifre.Location = new Point(15, 65);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(76, 16);
            lblYeniSifre.TabIndex = 22;
            lblYeniSifre.Text = "Yeni Şifre :";
            // 
            // lblEskiSifre
            // 
            lblEskiSifre.AutoSize = true;
            lblEskiSifre.BackColor = Color.Transparent;
            lblEskiSifre.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEskiSifre.ForeColor = SystemColors.ActiveCaptionText;
            lblEskiSifre.Location = new Point(15, 15);
            lblEskiSifre.Name = "lblEskiSifre";
            lblEskiSifre.Size = new Size(74, 16);
            lblEskiSifre.TabIndex = 21;
            lblEskiSifre.Text = "Eski Şifre :";
            // 
            // SifreDegistirmeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(382, 202);
            Controls.Add(btnSifreDegistir);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtEskiSifre);
            Controls.Add(lblYeniSifreTekrar);
            Controls.Add(lblYeniSifre);
            Controls.Add(lblEskiSifre);
            DoubleBuffered = true;
            Name = "SifreDegistirmeForm";
            Text = "SifreDegistirme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSifreDegistir;
        private TextBox txtYeniSifreTekrar;
        private TextBox txtYeniSifre;
        private TextBox txtEskiSifre;
        private Label lblYeniSifreTekrar;
        private Label lblYeniSifre;
        private Label lblEskiSifre;
    }
}