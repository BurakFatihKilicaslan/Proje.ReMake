namespace WinPL.Forms
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            label11 = new Label();
            lboxAksam = new ListBox();
            label17 = new Label();
            pBargeriyeKalanKalori = new ProgressBar();
            label1 = new Label();
            lblAraToplamYag = new Label();
            lboxToplamAraOgunler = new ListBox();
            lblAraToplamProtein = new Label();
            lblAraToplamKarbonhidrat = new Label();
            lblAksamYag = new Label();
            label22 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            menuStrip1 = new MenuStrip();
            hesabımToolStripMenuItem = new ToolStripMenuItem();
            profilimToolStripMenuItem = new ToolStripMenuItem();
            şifreDeğiştirToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            lblAraToplamKalori = new Label();
            btnOgunEkle = new Button();
            lblAksamProtein = new Label();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            lblAksamKarbonhidrat = new Label();
            label15 = new Label();
            lblAksamKalori = new Label();
            label13 = new Label();
            label16 = new Label();
            label14 = new Label();
            groupBox2 = new GroupBox();
            lblOgleYag = new Label();
            lblOgleProtein = new Label();
            lblOgleKarbonhidrat = new Label();
            lblOgleKalori = new Label();
            lboxOgle = new ListBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            lblSabahYag = new Label();
            label18 = new Label();
            lblSabahKarbonhidrat = new Label();
            lblSabahKalori = new Label();
            lboxSabah = new ListBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(8, 44);
            label11.Name = "label11";
            label11.Size = new Size(137, 23);
            label11.TabIndex = 9;
            label11.Text = "Toplam Kalori:";
            // 
            // lboxAksam
            // 
            lboxAksam.BackColor = Color.MediumAquamarine;
            lboxAksam.Dock = DockStyle.Bottom;
            lboxAksam.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lboxAksam.ForeColor = SystemColors.ActiveCaptionText;
            lboxAksam.FormattingEnabled = true;
            lboxAksam.ItemHeight = 23;
            lboxAksam.Location = new Point(4, 174);
            lboxAksam.Name = "lboxAksam";
            lboxAksam.Size = new Size(331, 165);
            lboxAksam.TabIndex = 14;
            lboxAksam.SelectedIndexChanged += lboxAksam_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(457, 81);
            label17.Name = "label17";
            label17.Size = new Size(96, 19);
            label17.TabIndex = 27;
            label17.Text = "Yemek Ekle";
            // 
            // pBargeriyeKalanKalori
            // 
            pBargeriyeKalanKalori.Location = new Point(15, 80);
            pBargeriyeKalanKalori.Margin = new Padding(4);
            pBargeriyeKalanKalori.Name = "pBargeriyeKalanKalori";
            pBargeriyeKalanKalori.Size = new Size(278, 31);
            pBargeriyeKalanKalori.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(11, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(324, 33);
            label1.TabIndex = 23;
            label1.Text = "Kişisel Tüketim Verileri";
            // 
            // lblAraToplamYag
            // 
            lblAraToplamYag.AutoSize = true;
            lblAraToplamYag.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAraToplamYag.ForeColor = SystemColors.ActiveCaptionText;
            lblAraToplamYag.Location = new Point(224, 129);
            lblAraToplamYag.Name = "lblAraToplamYag";
            lblAraToplamYag.Size = new Size(21, 23);
            lblAraToplamYag.TabIndex = 21;
            lblAraToplamYag.Text = "0";
            lblAraToplamYag.Click += lblAraToplamYag_Click;
            // 
            // lboxToplamAraOgunler
            // 
            lboxToplamAraOgunler.BackColor = Color.MediumAquamarine;
            lboxToplamAraOgunler.Dock = DockStyle.Bottom;
            lboxToplamAraOgunler.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lboxToplamAraOgunler.ForeColor = SystemColors.ActiveCaptionText;
            lboxToplamAraOgunler.FormattingEnabled = true;
            lboxToplamAraOgunler.ItemHeight = 23;
            lboxToplamAraOgunler.Location = new Point(4, 174);
            lboxToplamAraOgunler.Name = "lboxToplamAraOgunler";
            lboxToplamAraOgunler.Size = new Size(331, 165);
            lboxToplamAraOgunler.TabIndex = 14;
            lboxToplamAraOgunler.SelectedIndexChanged += lboxToplamAraOgunler_SelectedIndexChanged;
            // 
            // lblAraToplamProtein
            // 
            lblAraToplamProtein.AutoSize = true;
            lblAraToplamProtein.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAraToplamProtein.ForeColor = SystemColors.ActiveCaptionText;
            lblAraToplamProtein.Location = new Point(224, 98);
            lblAraToplamProtein.Name = "lblAraToplamProtein";
            lblAraToplamProtein.Size = new Size(21, 23);
            lblAraToplamProtein.TabIndex = 20;
            lblAraToplamProtein.Text = "0";
            lblAraToplamProtein.Click += lblAraToplamProtein_Click;
            // 
            // lblAraToplamKarbonhidrat
            // 
            lblAraToplamKarbonhidrat.AutoSize = true;
            lblAraToplamKarbonhidrat.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAraToplamKarbonhidrat.ForeColor = SystemColors.ActiveCaptionText;
            lblAraToplamKarbonhidrat.Location = new Point(224, 67);
            lblAraToplamKarbonhidrat.Name = "lblAraToplamKarbonhidrat";
            lblAraToplamKarbonhidrat.Size = new Size(21, 23);
            lblAraToplamKarbonhidrat.TabIndex = 19;
            lblAraToplamKarbonhidrat.Text = "0";
            lblAraToplamKarbonhidrat.Click += lblAraToplamKarbonhidrat_Click;
            // 
            // lblAksamYag
            // 
            lblAksamYag.AutoSize = true;
            lblAksamYag.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAksamYag.ForeColor = SystemColors.ActiveCaptionText;
            lblAksamYag.Location = new Point(217, 139);
            lblAksamYag.Name = "lblAksamYag";
            lblAksamYag.Size = new Size(21, 23);
            lblAksamYag.TabIndex = 21;
            lblAksamYag.Text = "0";
            lblAksamYag.Click += lblAksamYag_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ActiveCaptionText;
            label22.Location = new Point(8, 67);
            label22.Name = "label22";
            label22.Size = new Size(201, 23);
            label22.TabIndex = 15;
            label22.Text = "Toplam Karbonhidrat:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ActiveCaptionText;
            label24.Location = new Point(8, 129);
            label24.Name = "label24";
            label24.Size = new Size(118, 23);
            label24.TabIndex = 17;
            label24.Text = "Toplam Yağ:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ActiveCaptionText;
            label25.Location = new Point(8, 34);
            label25.Name = "label25";
            label25.Size = new Size(137, 23);
            label25.TabIndex = 14;
            label25.Text = "Toplam Kalori:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ActiveCaptionText;
            label26.Location = new Point(8, 98);
            label26.Name = "label26";
            label26.Size = new Size(149, 23);
            label26.TabIndex = 16;
            label26.Text = "Toplam Protein:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hesabımToolStripMenuItem, raporlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(680, 26);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hesabımToolStripMenuItem
            // 
            hesabımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profilimToolStripMenuItem, şifreDeğiştirToolStripMenuItem, çıkışYapToolStripMenuItem });
            hesabımToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            hesabımToolStripMenuItem.Name = "hesabımToolStripMenuItem";
            hesabımToolStripMenuItem.Size = new Size(83, 22);
            hesabımToolStripMenuItem.Text = "Hesabım";
            // 
            // profilimToolStripMenuItem
            // 
            profilimToolStripMenuItem.BackColor = Color.Transparent;
            profilimToolStripMenuItem.BackgroundImageLayout = ImageLayout.Center;
            profilimToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            profilimToolStripMenuItem.Name = "profilimToolStripMenuItem";
            profilimToolStripMenuItem.Size = new Size(180, 22);
            profilimToolStripMenuItem.Text = "Profilim";
            profilimToolStripMenuItem.Click += profilimToolStripMenuItem_Click;
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            şifreDeğiştirToolStripMenuItem.BackColor = Color.Transparent;
            şifreDeğiştirToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            şifreDeğiştirToolStripMenuItem.Size = new Size(180, 22);
            şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            şifreDeğiştirToolStripMenuItem.Click += şifreDeğiştirToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.BackColor = Color.Transparent;
            çıkışYapToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(180, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(82, 22);
            raporlarToolStripMenuItem.Text = "Raporlar";
            raporlarToolStripMenuItem.Click += raporlarToolStripMenuItem_Click;
            // 
            // lblAraToplamKalori
            // 
            lblAraToplamKalori.AutoSize = true;
            lblAraToplamKalori.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAraToplamKalori.ForeColor = SystemColors.ActiveCaptionText;
            lblAraToplamKalori.Location = new Point(224, 34);
            lblAraToplamKalori.Name = "lblAraToplamKalori";
            lblAraToplamKalori.Size = new Size(21, 23);
            lblAraToplamKalori.TabIndex = 18;
            lblAraToplamKalori.Text = "0";
            lblAraToplamKalori.Click += lblAraToplamKalori_Click;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = Color.Aquamarine;
            btnOgunEkle.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgunEkle.ForeColor = Color.Black;
            btnOgunEkle.Location = new Point(561, 56);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(75, 68);
            btnOgunEkle.TabIndex = 28;
            btnOgunEkle.Text = "+";
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // lblAksamProtein
            // 
            lblAksamProtein.AutoSize = true;
            lblAksamProtein.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAksamProtein.ForeColor = SystemColors.ActiveCaptionText;
            lblAksamProtein.Location = new Point(217, 108);
            lblAksamProtein.Name = "lblAksamProtein";
            lblAksamProtein.Size = new Size(21, 23);
            lblAksamProtein.TabIndex = 20;
            lblAksamProtein.Text = "0";
            lblAksamProtein.Click += lblAksamProtein_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(lblAraToplamYag);
            groupBox4.Controls.Add(lboxToplamAraOgunler);
            groupBox4.Controls.Add(lblAraToplamProtein);
            groupBox4.Controls.Add(lblAraToplamKarbonhidrat);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(lblAraToplamKalori);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(label25);
            groupBox4.Controls.Add(label26);
            groupBox4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Red;
            groupBox4.Location = new Point(337, 494);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(339, 343);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Toplam Ara Öğün Değerleri";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(lblAksamYag);
            groupBox3.Controls.Add(lboxAksam);
            groupBox3.Controls.Add(lblAksamProtein);
            groupBox3.Controls.Add(lblAksamKarbonhidrat);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(lblAksamKalori);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label14);
            groupBox3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(3, 494);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(339, 343);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Akşam Öğünü";
            // 
            // lblAksamKarbonhidrat
            // 
            lblAksamKarbonhidrat.AutoSize = true;
            lblAksamKarbonhidrat.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAksamKarbonhidrat.ForeColor = SystemColors.ActiveCaptionText;
            lblAksamKarbonhidrat.Location = new Point(217, 77);
            lblAksamKarbonhidrat.Name = "lblAksamKarbonhidrat";
            lblAksamKarbonhidrat.Size = new Size(21, 23);
            lblAksamKarbonhidrat.TabIndex = 19;
            lblAksamKarbonhidrat.Text = "0";
            lblAksamKarbonhidrat.Click += lblAksamKarbonhidrat_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(8, 77);
            label15.Name = "label15";
            label15.Size = new Size(201, 23);
            label15.TabIndex = 15;
            label15.Text = "Toplam Karbonhidrat:";
            // 
            // lblAksamKalori
            // 
            lblAksamKalori.AutoSize = true;
            lblAksamKalori.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAksamKalori.ForeColor = SystemColors.ActiveCaptionText;
            lblAksamKalori.Location = new Point(217, 44);
            lblAksamKalori.Name = "lblAksamKalori";
            lblAksamKalori.Size = new Size(21, 23);
            lblAksamKalori.TabIndex = 18;
            lblAksamKalori.Text = "0";
            lblAksamKalori.Click += lblAksamKalori_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(8, 139);
            label13.Name = "label13";
            label13.Size = new Size(118, 23);
            label13.TabIndex = 17;
            label13.Text = "Toplam Yağ:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(8, 44);
            label16.Name = "label16";
            label16.Size = new Size(137, 23);
            label16.TabIndex = 14;
            label16.Text = "Toplam Kalori:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(8, 108);
            label14.Name = "label14";
            label14.Size = new Size(149, 23);
            label14.TabIndex = 16;
            label14.Text = "Toplam Protein:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lblOgleYag);
            groupBox2.Controls.Add(lblOgleProtein);
            groupBox2.Controls.Add(lblOgleKarbonhidrat);
            groupBox2.Controls.Add(lblOgleKalori);
            groupBox2.Controls.Add(lboxOgle);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(341, 141);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(338, 345);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öğle Öğünü";
            // 
            // lblOgleYag
            // 
            lblOgleYag.AutoSize = true;
            lblOgleYag.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgleYag.ForeColor = SystemColors.ActiveCaptionText;
            lblOgleYag.Location = new Point(222, 139);
            lblOgleYag.Name = "lblOgleYag";
            lblOgleYag.Size = new Size(21, 23);
            lblOgleYag.TabIndex = 17;
            lblOgleYag.Text = "0";
            lblOgleYag.Click += lblOgleYag_Click;
            // 
            // lblOgleProtein
            // 
            lblOgleProtein.AutoSize = true;
            lblOgleProtein.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgleProtein.ForeColor = SystemColors.ActiveCaptionText;
            lblOgleProtein.Location = new Point(222, 108);
            lblOgleProtein.Name = "lblOgleProtein";
            lblOgleProtein.Size = new Size(21, 23);
            lblOgleProtein.TabIndex = 16;
            lblOgleProtein.Text = "0";
            lblOgleProtein.Click += lblOgleProtein_Click;
            // 
            // lblOgleKarbonhidrat
            // 
            lblOgleKarbonhidrat.AutoSize = true;
            lblOgleKarbonhidrat.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgleKarbonhidrat.ForeColor = SystemColors.ActiveCaptionText;
            lblOgleKarbonhidrat.Location = new Point(222, 77);
            lblOgleKarbonhidrat.Name = "lblOgleKarbonhidrat";
            lblOgleKarbonhidrat.Size = new Size(21, 23);
            lblOgleKarbonhidrat.TabIndex = 15;
            lblOgleKarbonhidrat.Text = "0";
            lblOgleKarbonhidrat.Click += lblOgleKarbonhidrat_Click;
            // 
            // lblOgleKalori
            // 
            lblOgleKalori.AutoSize = true;
            lblOgleKalori.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOgleKalori.ForeColor = SystemColors.ActiveCaptionText;
            lblOgleKalori.Location = new Point(222, 44);
            lblOgleKalori.Name = "lblOgleKalori";
            lblOgleKalori.Size = new Size(21, 23);
            lblOgleKalori.TabIndex = 14;
            lblOgleKalori.Text = "0";
            lblOgleKalori.Click += lblOgleKalori_Click;
            // 
            // lboxOgle
            // 
            lboxOgle.BackColor = Color.MediumAquamarine;
            lboxOgle.Dock = DockStyle.Bottom;
            lboxOgle.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lboxOgle.ForeColor = SystemColors.ActiveCaptionText;
            lboxOgle.FormattingEnabled = true;
            lboxOgle.ItemHeight = 23;
            lboxOgle.Location = new Point(4, 176);
            lboxOgle.Name = "lboxOgle";
            lboxOgle.Size = new Size(330, 165);
            lboxOgle.TabIndex = 9;
            lboxOgle.SelectedIndexChanged += lboxOgle_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(8, 139);
            label8.Name = "label8";
            label8.Size = new Size(118, 23);
            label8.TabIndex = 12;
            label8.Text = "Toplam Yağ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(8, 108);
            label9.Name = "label9";
            label9.Size = new Size(149, 23);
            label9.TabIndex = 11;
            label9.Text = "Toplam Protein:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(8, 77);
            label10.Name = "label10";
            label10.Size = new Size(201, 23);
            label10.TabIndex = 10;
            label10.Text = "Toplam Karbonhidrat:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblSabahYag);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(lblSabahKarbonhidrat);
            groupBox1.Controls.Add(lblSabahKalori);
            groupBox1.Controls.Add(lboxSabah);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(2, 141);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(339, 345);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sabah Öğünü";
            // 
            // lblSabahYag
            // 
            lblSabahYag.AutoSize = true;
            lblSabahYag.BackColor = Color.Transparent;
            lblSabahYag.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSabahYag.ForeColor = SystemColors.ActiveCaptionText;
            lblSabahYag.Location = new Point(218, 139);
            lblSabahYag.Name = "lblSabahYag";
            lblSabahYag.Size = new Size(21, 23);
            lblSabahYag.TabIndex = 12;
            lblSabahYag.Text = "0";
            lblSabahYag.Click += lblSabahYag_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(218, 108);
            label18.Name = "label18";
            label18.Size = new Size(21, 23);
            label18.TabIndex = 11;
            label18.Text = "0";
            label18.Click += label18_Click;
            // 
            // lblSabahKarbonhidrat
            // 
            lblSabahKarbonhidrat.AutoSize = true;
            lblSabahKarbonhidrat.BackColor = Color.Transparent;
            lblSabahKarbonhidrat.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSabahKarbonhidrat.ForeColor = SystemColors.ActiveCaptionText;
            lblSabahKarbonhidrat.Location = new Point(218, 77);
            lblSabahKarbonhidrat.Name = "lblSabahKarbonhidrat";
            lblSabahKarbonhidrat.Size = new Size(21, 23);
            lblSabahKarbonhidrat.TabIndex = 10;
            lblSabahKarbonhidrat.Text = "0";
            lblSabahKarbonhidrat.Click += lblSabahKarbonhidrat_Click;
            // 
            // lblSabahKalori
            // 
            lblSabahKalori.AutoSize = true;
            lblSabahKalori.BackColor = Color.Transparent;
            lblSabahKalori.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSabahKalori.ForeColor = SystemColors.ActiveCaptionText;
            lblSabahKalori.Location = new Point(218, 44);
            lblSabahKalori.Name = "lblSabahKalori";
            lblSabahKalori.Size = new Size(21, 23);
            lblSabahKalori.TabIndex = 9;
            lblSabahKalori.Text = "0";
            lblSabahKalori.Click += lblSabahKalori_Click;
            // 
            // lboxSabah
            // 
            lboxSabah.BackColor = Color.MediumAquamarine;
            lboxSabah.Dock = DockStyle.Bottom;
            lboxSabah.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lboxSabah.ForeColor = SystemColors.ActiveCaptionText;
            lboxSabah.FormattingEnabled = true;
            lboxSabah.ItemHeight = 23;
            lboxSabah.Location = new Point(4, 176);
            lboxSabah.Name = "lboxSabah";
            lboxSabah.Size = new Size(331, 165);
            lboxSabah.TabIndex = 4;
            lboxSabah.SelectedIndexChanged += lboxSabah_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(13, 139);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 7;
            label5.Text = "Toplam Yağ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(13, 108);
            label4.Name = "label4";
            label4.Size = new Size(149, 23);
            label4.TabIndex = 6;
            label4.Text = "Toplam Protein:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 77);
            label3.Name = "label3";
            label3.Size = new Size(201, 23);
            label3.TabIndex = 5;
            label3.Text = "Toplam Karbonhidrat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(13, 44);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 4;
            label2.Text = "Toplam Kalori:";
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 838);
            Controls.Add(label17);
            Controls.Add(pBargeriyeKalanKalori);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(btnOgunEkle);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaEkran";
            Text = "AnaEkran";
            Load += AnaEkran_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private ListBox lboxAksam;
        private Label label17;
        private ProgressBar pBargeriyeKalanKalori;
        private Label label1;
        private Label lblAraToplamYag;
        private ListBox lboxToplamAraOgunler;
        private Label lblAraToplamProtein;
        private Label lblAraToplamKarbonhidrat;
        private Label lblAksamYag;
        private Label label22;
        private Label label24;
        private Label label25;
        private Label label26;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hesabımToolStripMenuItem;
        private ToolStripMenuItem profilimToolStripMenuItem;
        private ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private Label lblAraToplamKalori;
        private Button btnOgunEkle;
        private Label lblAksamProtein;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label lblAksamKarbonhidrat;
        private Label label15;
        private Label lblAksamKalori;
        private Label label13;
        private Label label16;
        private Label label14;
        private GroupBox groupBox2;
        private Label lblOgleYag;
        private Label lblOgleProtein;
        private Label lblOgleKarbonhidrat;
        private Label lblOgleKalori;
        private ListBox lboxOgle;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private Label lblSabahYag;
        private Label label18;
        private Label lblSabahKarbonhidrat;
        private Label lblSabahKalori;
        private ListBox lboxSabah;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}