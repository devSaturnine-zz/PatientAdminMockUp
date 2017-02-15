namespace FEH_mockup
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lnkSettings = new MetroFramework.Controls.MetroLink();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnLogIn = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txUsername = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSettings = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpConnection = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtpTheme = new MetroFramework.Controls.MetroTabPage();
            this.mrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.mrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flpoSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.mtcSettings.SuspendLayout();
            this.mtpConnection.SuspendLayout();
            this.mtpTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkSettings
            // 
            this.lnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSettings.Image = ((System.Drawing.Image)(resources.GetObject("lnkSettings.Image")));
            this.lnkSettings.ImageSize = 32;
            this.lnkSettings.Location = new System.Drawing.Point(1129, 34);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.Size = new System.Drawing.Size(34, 37);
            this.lnkSettings.TabIndex = 0;
            this.lnkSettings.UseSelectable = true;
            this.lnkSettings.Click += new System.EventHandler(this.lnkSettings_Click);
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(503, 542);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(293, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "All Rights Reserved ©  2017 | Developed By: Neil";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel3.Location = new System.Drawing.Point(445, 313);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(183, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Log in to your account";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.Location = new System.Drawing.Point(680, 448);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(97, 33);
            this.btnLogIn.TabIndex = 15;
            this.btnLogIn.Text = "&Login";
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(239, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(512, 402);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(265, 28);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txUsername
            // 
            this.txUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txUsername.CustomButton.Image = null;
            this.txUsername.CustomButton.Location = new System.Drawing.Point(239, 2);
            this.txUsername.CustomButton.Name = "";
            this.txUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txUsername.CustomButton.TabIndex = 1;
            this.txUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txUsername.CustomButton.UseSelectable = true;
            this.txUsername.CustomButton.Visible = false;
            this.txUsername.DisplayIcon = true;
            this.txUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txUsername.Icon")));
            this.txUsername.Lines = new string[0];
            this.txUsername.Location = new System.Drawing.Point(512, 355);
            this.txUsername.MaxLength = 32767;
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '\0';
            this.txUsername.PromptText = "Username";
            this.txUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txUsername.SelectedText = "";
            this.txUsername.SelectionLength = 0;
            this.txUsername.SelectionStart = 0;
            this.txUsername.ShortcutsEnabled = true;
            this.txUsername.Size = new System.Drawing.Size(265, 28);
            this.txUsername.TabIndex = 13;
            this.txUsername.UseSelectable = true;
            this.txUsername.WaterMark = "Username";
            this.txUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 158);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.Controls.Add(this.panel1);
            this.pnlSettings.Controls.Add(this.mtcSettings);
            this.pnlSettings.Controls.Add(this.lnkBack);
            this.pnlSettings.HorizontalScrollbarBarColor = true;
            this.pnlSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSettings.HorizontalScrollbarSize = 10;
            this.pnlSettings.Location = new System.Drawing.Point(925, 5);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(276, 698);
            this.pnlSettings.TabIndex = 17;
            this.pnlSettings.VerticalScrollbarBarColor = true;
            this.pnlSettings.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSettings.VerticalScrollbarSize = 10;
            this.pnlSettings.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 692);
            this.panel1.TabIndex = 4;
            // 
            // mtcSettings
            // 
            this.mtcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcSettings.Controls.Add(this.mtpConnection);
            this.mtcSettings.Controls.Add(this.mtpTheme);
            this.mtcSettings.Location = new System.Drawing.Point(12, 68);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 1;
            this.mtcSettings.Size = new System.Drawing.Size(245, 627);
            this.mtcSettings.TabIndex = 3;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpConnection
            // 
            this.mtpConnection.Controls.Add(this.metroButton1);
            this.mtpConnection.Controls.Add(this.metroTextBox5);
            this.mtpConnection.Controls.Add(this.metroLabel8);
            this.mtpConnection.Controls.Add(this.metroTextBox4);
            this.mtpConnection.Controls.Add(this.metroLabel7);
            this.mtpConnection.Controls.Add(this.metroTextBox3);
            this.mtpConnection.Controls.Add(this.metroLabel6);
            this.mtpConnection.Controls.Add(this.metroTextBox2);
            this.mtpConnection.Controls.Add(this.metroLabel5);
            this.mtpConnection.Controls.Add(this.metroTextBox1);
            this.mtpConnection.Controls.Add(this.metroLabel4);
            this.mtpConnection.HorizontalScrollbarBarColor = true;
            this.mtpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConnection.HorizontalScrollbarSize = 10;
            this.mtpConnection.Location = new System.Drawing.Point(4, 38);
            this.mtpConnection.Name = "mtpConnection";
            this.mtpConnection.Size = new System.Drawing.Size(237, 584);
            this.mtpConnection.TabIndex = 0;
            this.mtpConnection.Text = "&connection";
            this.mtpConnection.VerticalScrollbarBarColor = true;
            this.mtpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConnection.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(7, 311);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(215, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "&test connection";
            this.metroButton1.UseSelectable = true;
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[] {
        "123456"};
            this.metroTextBox5.Location = new System.Drawing.Point(7, 270);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '*';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(215, 23);
            this.metroTextBox5.TabIndex = 11;
            this.metroTextBox5.Text = "123456";
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 248);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(67, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "password:";
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[] {
        "admin"};
            this.metroTextBox4.Location = new System.Drawing.Point(7, 222);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(215, 23);
            this.metroTextBox4.TabIndex = 9;
            this.metroTextBox4.Text = "admin";
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 200);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "username:";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "FEH_DB"};
            this.metroTextBox3.Location = new System.Drawing.Point(7, 174);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(215, 23);
            this.metroTextBox3.TabIndex = 7;
            this.metroTextBox3.Text = "FEH_DB";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 152);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(102, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "database name:";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "3306"};
            this.metroTextBox2.Location = new System.Drawing.Point(7, 126);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(215, 23);
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.Text = "3306";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 104);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "port:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "192.168.1.1"};
            this.metroTextBox1.Location = new System.Drawing.Point(7, 78);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(215, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "192.168.1.1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 56);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "server name:";
            // 
            // mtpTheme
            // 
            this.mtpTheme.Controls.Add(this.mrbLight);
            this.mtpTheme.Controls.Add(this.mrbDark);
            this.mtpTheme.Controls.Add(this.metroLabel2);
            this.mtpTheme.Controls.Add(this.metroLabel1);
            this.mtpTheme.Controls.Add(this.flpoSettings);
            this.mtpTheme.HorizontalScrollbarBarColor = true;
            this.mtpTheme.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpTheme.HorizontalScrollbarSize = 10;
            this.mtpTheme.Location = new System.Drawing.Point(4, 38);
            this.mtpTheme.Name = "mtpTheme";
            this.mtpTheme.Size = new System.Drawing.Size(237, 585);
            this.mtpTheme.TabIndex = 1;
            this.mtpTheme.Text = "&theme";
            this.mtpTheme.VerticalScrollbarBarColor = true;
            this.mtpTheme.VerticalScrollbarHighlightOnWheel = false;
            this.mtpTheme.VerticalScrollbarSize = 10;
            // 
            // mrbLight
            // 
            this.mrbLight.AutoSize = true;
            this.mrbLight.Checked = true;
            this.mrbLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbLight.Location = new System.Drawing.Point(84, 56);
            this.mrbLight.Name = "mrbLight";
            this.mrbLight.Size = new System.Drawing.Size(56, 19);
            this.mrbLight.TabIndex = 7;
            this.mrbLight.TabStop = true;
            this.mrbLight.Text = "&Light";
            this.mrbLight.UseSelectable = true;
            this.mrbLight.CheckedChanged += new System.EventHandler(this.mrbLight_CheckedChanged);
            // 
            // mrbDark
            // 
            this.mrbDark.AutoSize = true;
            this.mrbDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbDark.Location = new System.Drawing.Point(4, 56);
            this.mrbDark.Name = "mrbDark";
            this.mrbDark.Size = new System.Drawing.Size(54, 19);
            this.mrbDark.TabIndex = 6;
            this.mrbDark.Text = "&Dark";
            this.mrbDark.UseSelectable = true;
            this.mrbDark.CheckedChanged += new System.EventHandler(this.mrbDark_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-4, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Style";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Theme";
            // 
            // flpoSettings
            // 
            this.flpoSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpoSettings.Location = new System.Drawing.Point(0, 115);
            this.flpoSettings.Name = "flpoSettings";
            this.flpoSettings.Size = new System.Drawing.Size(232, 474);
            this.flpoSettings.TabIndex = 3;
            // 
            // lnkBack
            // 
            this.lnkBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkBack.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.lnkBack.Image = ((System.Drawing.Image)(resources.GetObject("lnkBack.Image")));
            this.lnkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBack.ImageSize = 32;
            this.lnkBack.Location = new System.Drawing.Point(12, 3);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(144, 47);
            this.lnkBack.TabIndex = 2;
            this.lnkBack.Text = "&Settings";
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 702);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkSettings);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.mtcSettings.ResumeLayout(false);
            this.mtpConnection.ResumeLayout(false);
            this.mtpConnection.PerformLayout();
            this.mtpTheme.ResumeLayout(false);
            this.mtpTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkSettings;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnLogIn;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel pnlSettings;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroTabPage mtpConnection;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabPage mtpTheme;
        private MetroFramework.Controls.MetroRadioButton mrbLight;
        private MetroFramework.Controls.MetroRadioButton mrbDark;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flpoSettings;
        private MetroFramework.Controls.MetroLink lnkBack;
    }
}