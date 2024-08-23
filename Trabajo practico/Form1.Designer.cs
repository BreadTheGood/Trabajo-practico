using System.Drawing.Drawing2D;

namespace Trabajo_practico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logInBTN = new Button();
            login_username = new TextBox();
            login_password = new TextBox();
            signUpBTN = new Button();
            subBackground = new Label();
            logInBanner = new PictureBox();
            logInBannerBTN = new Button();
            logInEnterBTN = new Button();
            signUpBanner = new PictureBox();
            sUP_fullname = new TextBox();
            sUP_phoneNumber = new TextBox();
            sUP_DNI = new TextBox();
            sUP_email = new TextBox();
            sUP_password = new TextBox();
            sUP_username = new TextBox();
            signUpEnterBTN = new Button();
            signUpBannerBTN = new Button();
            sUp_message = new Label();
            sUp_icon = new PictureBox();
            subBackground2 = new Label();
            cbaImg1 = new PictureBox();
            bairesImg = new PictureBox();
            menImg = new PictureBox();
            bchImg = new PictureBox();
            vuelo2 = new Button();
            vuelo4 = new Button();
            cbaImg2 = new PictureBox();
            vuelo1 = new Button();
            vuelo5 = new Button();
            vuelo3 = new Button();
            vuelo6 = new Button();
            cbaImg3 = new PictureBox();
            logoutBTN = new Button();
            details1 = new Button();
            details2 = new Button();
            details3 = new Button();
            details4 = new Button();
            details5 = new Button();
            details6 = new Button();
            cartBTN1 = new Button();
            cartBTN3 = new Button();
            cartBTN4 = new Button();
            cartBTN5 = new Button();
            cartBTN6 = new Button();
            openCart = new Button();
            displayName = new Label();
            cartBTN2 = new Button();
            vueloMenu = new Label();
            vAmount = new Label();
            vFecha = new Label();
            vPasajes = new Label();
            vueloText = new TextBox();
            fechaText = new TextBox();
            pasajesText = new TextBox();
            agregarBTN = new Button();
            compraMenu = new Label();
            pagarBTN = new Button();
            montoPesos = new Label();
            nPasajes = new Label();
            iva = new Label();
            invalidMsg = new Label();
            paidMsg = new Label();
            exitMsg = new Label();
            exitYES = new Button();
            exitNO = new Button();
            ((System.ComponentModel.ISupportInitialize)logInBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signUpBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sUp_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbaImg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bairesImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bchImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbaImg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbaImg3).BeginInit();
            SuspendLayout();
            // 
            // logInBTN
            // 
            logInBTN.BackColor = Color.Transparent;
            logInBTN.FlatAppearance.BorderSize = 0;
            logInBTN.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            logInBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            logInBTN.FlatStyle = FlatStyle.Flat;
            logInBTN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInBTN.ForeColor = SystemColors.Control;
            logInBTN.Location = new Point(100, 85);
            logInBTN.Margin = new Padding(0);
            logInBTN.Name = "logInBTN";
            logInBTN.Size = new Size(501, 200);
            logInBTN.TabIndex = 98;
            logInBTN.Text = "LOG IN";
            logInBTN.UseVisualStyleBackColor = false;
            logInBTN.Click += logInBTN_Click;
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.None;
            login_username.Location = new Point(223, 218);
            login_username.Name = "login_username";
            login_username.PlaceholderText = "USER NAME";
            login_username.Size = new Size(220, 16);
            login_username.TabIndex = 9;
            login_username.TextAlign = HorizontalAlignment.Center;
            login_username.Visible = false;
            // 
            // login_password
            // 
            login_password.BorderStyle = BorderStyle.None;
            login_password.Location = new Point(-536, 10);
            login_password.Name = "login_password";
            login_password.PlaceholderText = "PASSWORD";
            login_password.Size = new Size(220, 16);
            login_password.TabIndex = 10;
            login_password.TextAlign = HorizontalAlignment.Center;
            login_password.UseSystemPasswordChar = true;
            login_password.Visible = false;
            // 
            // signUpBTN
            // 
            signUpBTN.BackColor = Color.Transparent;
            signUpBTN.FlatAppearance.BorderColor = Color.DarkGray;
            signUpBTN.FlatAppearance.BorderSize = 0;
            signUpBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            signUpBTN.FlatStyle = FlatStyle.Flat;
            signUpBTN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpBTN.ForeColor = SystemColors.AppWorkspace;
            signUpBTN.Location = new Point(0, 110);
            signUpBTN.Margin = new Padding(0);
            signUpBTN.Name = "signUpBTN";
            signUpBTN.Size = new Size(71, 23);
            signUpBTN.TabIndex = 99;
            signUpBTN.Text = "SIGN UP";
            signUpBTN.UseVisualStyleBackColor = false;
            signUpBTN.Click += signUpBTN_Click;
            // 
            // subBackground
            // 
            subBackground.BackColor = Color.Transparent;
            subBackground.Dock = DockStyle.Fill;
            subBackground.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            subBackground.ForeColor = SystemColors.ButtonFace;
            subBackground.Location = new Point(0, 0);
            subBackground.Margin = new Padding(0);
            subBackground.Name = "subBackground";
            subBackground.Size = new Size(1214, 621);
            subBackground.TabIndex = 100;
            subBackground.Text = "BIENVENIDO\r\nVuelos Argentina";
            subBackground.TextAlign = ContentAlignment.TopCenter;
            subBackground.MouseHover += subBackground_MouseHover;
            // 
            // logInBanner
            // 
            logInBanner.BackColor = SystemColors.ActiveBorder;
            logInBanner.Location = new Point(0, 110);
            logInBanner.Name = "logInBanner";
            logInBanner.Size = new Size(10, 290);
            logInBanner.TabIndex = 100;
            logInBanner.TabStop = false;
            logInBanner.Visible = false;
            // 
            // logInBannerBTN
            // 
            logInBannerBTN.BackColor = SystemColors.ActiveBorder;
            logInBannerBTN.Enabled = false;
            logInBannerBTN.FlatAppearance.BorderSize = 0;
            logInBannerBTN.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            logInBannerBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            logInBannerBTN.FlatStyle = FlatStyle.Flat;
            logInBannerBTN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInBannerBTN.ForeColor = SystemColors.Control;
            logInBannerBTN.Location = new Point(0, 25);
            logInBannerBTN.Margin = new Padding(0);
            logInBannerBTN.Name = "logInBannerBTN";
            logInBannerBTN.Size = new Size(71, 29);
            logInBannerBTN.TabIndex = 101;
            logInBannerBTN.Text = "LOG IN";
            logInBannerBTN.UseVisualStyleBackColor = false;
            logInBannerBTN.Visible = false;
            // 
            // logInEnterBTN
            // 
            logInEnterBTN.BackColor = Color.RosyBrown;
            logInEnterBTN.FlatAppearance.BorderSize = 0;
            logInEnterBTN.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            logInEnterBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            logInEnterBTN.FlatStyle = FlatStyle.Flat;
            logInEnterBTN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInEnterBTN.ForeColor = SystemColors.Control;
            logInEnterBTN.Location = new Point(184, 129);
            logInEnterBTN.Margin = new Padding(0);
            logInEnterBTN.Name = "logInEnterBTN";
            logInEnterBTN.Size = new Size(220, 10);
            logInEnterBTN.TabIndex = 102;
            logInEnterBTN.Text = "ENTER";
            logInEnterBTN.UseVisualStyleBackColor = false;
            logInEnterBTN.Visible = false;
            logInEnterBTN.Click += logInEnterBTN_Click;
            // 
            // signUpBanner
            // 
            signUpBanner.BackColor = SystemColors.ActiveBorder;
            signUpBanner.Location = new Point(64, 40);
            signUpBanner.Name = "signUpBanner";
            signUpBanner.Size = new Size(220, 10);
            signUpBanner.TabIndex = 103;
            signUpBanner.TabStop = false;
            signUpBanner.Visible = false;
            // 
            // sUP_fullname
            // 
            sUP_fullname.BorderStyle = BorderStyle.None;
            sUP_fullname.Location = new Point(438, 62);
            sUP_fullname.Name = "sUP_fullname";
            sUP_fullname.PlaceholderText = "FULL NAME";
            sUP_fullname.Size = new Size(220, 16);
            sUP_fullname.TabIndex = 112;
            sUP_fullname.TextAlign = HorizontalAlignment.Center;
            sUP_fullname.Visible = false;
            // 
            // sUP_phoneNumber
            // 
            sUP_phoneNumber.BorderStyle = BorderStyle.None;
            sUP_phoneNumber.Location = new Point(212, 67);
            sUP_phoneNumber.Name = "sUP_phoneNumber";
            sUP_phoneNumber.PlaceholderText = "PHONE NUMBER";
            sUP_phoneNumber.Size = new Size(220, 16);
            sUP_phoneNumber.TabIndex = 113;
            sUP_phoneNumber.TextAlign = HorizontalAlignment.Center;
            sUP_phoneNumber.Visible = false;
            // 
            // sUP_DNI
            // 
            sUP_DNI.BorderStyle = BorderStyle.None;
            sUP_DNI.Location = new Point(282, 108);
            sUP_DNI.Name = "sUP_DNI";
            sUP_DNI.PlaceholderText = "DNI OR PASSPORT";
            sUP_DNI.Size = new Size(220, 16);
            sUP_DNI.TabIndex = 114;
            sUP_DNI.TextAlign = HorizontalAlignment.Center;
            sUP_DNI.Visible = false;
            // 
            // sUP_email
            // 
            sUP_email.BorderStyle = BorderStyle.None;
            sUP_email.Location = new Point(410, 45);
            sUP_email.Name = "sUP_email";
            sUP_email.PlaceholderText = "EMAIL ADRESS";
            sUP_email.Size = new Size(220, 16);
            sUP_email.TabIndex = 115;
            sUP_email.TextAlign = HorizontalAlignment.Center;
            sUP_email.Visible = false;
            // 
            // sUP_password
            // 
            sUP_password.BorderStyle = BorderStyle.None;
            sUP_password.Location = new Point(136, 110);
            sUP_password.Name = "sUP_password";
            sUP_password.PlaceholderText = "PASSWORD";
            sUP_password.Size = new Size(220, 16);
            sUP_password.TabIndex = 117;
            sUP_password.TextAlign = HorizontalAlignment.Center;
            sUP_password.UseSystemPasswordChar = true;
            sUP_password.Visible = false;
            // 
            // sUP_username
            // 
            sUP_username.BorderStyle = BorderStyle.None;
            sUP_username.Location = new Point(258, 88);
            sUP_username.Name = "sUP_username";
            sUP_username.PlaceholderText = "USER NAME";
            sUP_username.Size = new Size(220, 16);
            sUP_username.TabIndex = 116;
            sUP_username.TextAlign = HorizontalAlignment.Center;
            sUP_username.Visible = false;
            // 
            // signUpEnterBTN
            // 
            signUpEnterBTN.BackColor = Color.FromArgb(128, 128, 255);
            signUpEnterBTN.FlatAppearance.BorderSize = 0;
            signUpEnterBTN.FlatAppearance.MouseDownBackColor = Color.SlateBlue;
            signUpEnterBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            signUpEnterBTN.FlatStyle = FlatStyle.Flat;
            signUpEnterBTN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpEnterBTN.ForeColor = SystemColors.Control;
            signUpEnterBTN.Location = new Point(184, 175);
            signUpEnterBTN.Margin = new Padding(0);
            signUpEnterBTN.Name = "signUpEnterBTN";
            signUpEnterBTN.Size = new Size(220, 40);
            signUpEnterBTN.TabIndex = 118;
            signUpEnterBTN.Text = "ENTER";
            signUpEnterBTN.UseVisualStyleBackColor = false;
            signUpEnterBTN.Visible = false;
            signUpEnterBTN.Click += signUpEnterBTN_Click;
            // 
            // signUpBannerBTN
            // 
            signUpBannerBTN.BackColor = SystemColors.ActiveBorder;
            signUpBannerBTN.Enabled = false;
            signUpBannerBTN.FlatAppearance.BorderColor = Color.DarkGray;
            signUpBannerBTN.FlatAppearance.BorderSize = 0;
            signUpBannerBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            signUpBannerBTN.FlatStyle = FlatStyle.Flat;
            signUpBannerBTN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpBannerBTN.ForeColor = SystemColors.ControlText;
            signUpBannerBTN.Location = new Point(0, 54);
            signUpBannerBTN.Margin = new Padding(0);
            signUpBannerBTN.Name = "signUpBannerBTN";
            signUpBannerBTN.Size = new Size(71, 31);
            signUpBannerBTN.TabIndex = 111;
            signUpBannerBTN.Text = "SIGN UP";
            signUpBannerBTN.UseVisualStyleBackColor = false;
            signUpBannerBTN.Visible = false;
            // 
            // sUp_message
            // 
            sUp_message.AutoSize = true;
            sUp_message.BackColor = Color.WhiteSmoke;
            sUp_message.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sUp_message.Location = new Point(85, 27);
            sUp_message.Name = "sUp_message";
            sUp_message.Size = new Size(168, 37);
            sUp_message.TabIndex = 113;
            sUp_message.Text = "SIGNED UP!";
            sUp_message.Visible = false;
            // 
            // sUp_icon
            // 
            sUp_icon.BackColor = Color.Transparent;
            sUp_icon.BackgroundImage = Properties.Resources.GREENCHECK;
            sUp_icon.BackgroundImageLayout = ImageLayout.Stretch;
            sUp_icon.InitialImage = null;
            sUp_icon.Location = new Point(85, 0);
            sUp_icon.Margin = new Padding(0);
            sUp_icon.Name = "sUp_icon";
            sUp_icon.Size = new Size(10, 10);
            sUp_icon.TabIndex = 114;
            sUp_icon.TabStop = false;
            sUp_icon.Visible = false;
            // 
            // subBackground2
            // 
            subBackground2.BackColor = Color.Transparent;
            subBackground2.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            subBackground2.ForeColor = Color.BurlyWood;
            subBackground2.Location = new Point(0, 0);
            subBackground2.Name = "subBackground2";
            subBackground2.Size = new Size(10, 749);
            subBackground2.TabIndex = 116;
            subBackground2.Text = "VUELOS DISPONIBLES";
            subBackground2.TextAlign = ContentAlignment.TopCenter;
            subBackground2.Visible = false;
            // 
            // cbaImg1
            // 
            cbaImg1.BackgroundImage = Properties.Resources.CORDOBA;
            cbaImg1.BackgroundImageLayout = ImageLayout.Stretch;
            cbaImg1.Location = new Point(501, 288);
            cbaImg1.Name = "cbaImg1";
            cbaImg1.Size = new Size(375, 239);
            cbaImg1.TabIndex = 117;
            cbaImg1.TabStop = false;
            cbaImg1.Tag = "";
            cbaImg1.Visible = false;
            // 
            // bairesImg
            // 
            bairesImg.BackgroundImage = Properties.Resources.BUENOS_AIRES;
            bairesImg.BackgroundImageLayout = ImageLayout.Stretch;
            bairesImg.Location = new Point(44, 199);
            bairesImg.Margin = new Padding(0);
            bairesImg.Name = "bairesImg";
            bairesImg.Size = new Size(375, 239);
            bairesImg.TabIndex = 118;
            bairesImg.TabStop = false;
            bairesImg.Tag = "";
            bairesImg.Visible = false;
            // 
            // menImg
            // 
            menImg.BackgroundImage = Properties.Resources.MENDOZA;
            menImg.BackgroundImageLayout = ImageLayout.Stretch;
            menImg.Location = new Point(810, 110);
            menImg.Name = "menImg";
            menImg.Size = new Size(375, 239);
            menImg.TabIndex = 119;
            menImg.TabStop = false;
            menImg.Tag = "";
            menImg.Visible = false;
            // 
            // bchImg
            // 
            bchImg.BackgroundImage = Properties.Resources.BARILOCHE;
            bchImg.BackgroundImageLayout = ImageLayout.Stretch;
            bchImg.Location = new Point(762, 338);
            bchImg.Name = "bchImg";
            bchImg.Size = new Size(375, 239);
            bchImg.TabIndex = 120;
            bchImg.TabStop = false;
            bchImg.Tag = "";
            bchImg.Visible = false;
            // 
            // vuelo2
            // 
            vuelo2.BackColor = Color.MediumPurple;
            vuelo2.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo2.FlatAppearance.BorderSize = 0;
            vuelo2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo2.FlatStyle = FlatStyle.Flat;
            vuelo2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            vuelo2.ForeColor = SystemColors.ControlLight;
            vuelo2.Location = new Point(212, 269);
            vuelo2.Margin = new Padding(0);
            vuelo2.Name = "vuelo2";
            vuelo2.Size = new Size(375, 40);
            vuelo2.TabIndex = 125;
            vuelo2.Text = "VUELO N°2\r\nBUENOS AIRES - CÓRDOBA";
            vuelo2.UseVisualStyleBackColor = false;
            vuelo2.Visible = false;
            vuelo2.Click += vuelo2_Click;
            // 
            // vuelo4
            // 
            vuelo4.BackColor = Color.MediumPurple;
            vuelo4.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo4.FlatAppearance.BorderSize = 0;
            vuelo4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo4.FlatStyle = FlatStyle.Flat;
            vuelo4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            vuelo4.ForeColor = SystemColors.ControlLight;
            vuelo4.Location = new Point(30, 565);
            vuelo4.Margin = new Padding(0);
            vuelo4.Name = "vuelo4";
            vuelo4.Size = new Size(375, 40);
            vuelo4.TabIndex = 127;
            vuelo4.Text = "VUELO N°4\r\nMENDOZA - CÓRDOBA";
            vuelo4.UseVisualStyleBackColor = false;
            vuelo4.Visible = false;
            vuelo4.Click += vuelo4_Click;
            // 
            // cbaImg2
            // 
            cbaImg2.BackgroundImage = Properties.Resources.CORDOBA;
            cbaImg2.BackgroundImageLayout = ImageLayout.Stretch;
            cbaImg2.Location = new Point(632, 453);
            cbaImg2.Name = "cbaImg2";
            cbaImg2.Size = new Size(375, 239);
            cbaImg2.TabIndex = 126;
            cbaImg2.TabStop = false;
            cbaImg2.Tag = "";
            cbaImg2.Visible = false;
            // 
            // vuelo1
            // 
            vuelo1.BackColor = Color.MediumPurple;
            vuelo1.FlatAppearance.BorderColor = Color.MediumPurple;
            vuelo1.FlatAppearance.BorderSize = 0;
            vuelo1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo1.FlatStyle = FlatStyle.Flat;
            vuelo1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            vuelo1.ForeColor = SystemColors.ControlLight;
            vuelo1.Location = new Point(223, 348);
            vuelo1.Margin = new Padding(0);
            vuelo1.Name = "vuelo1";
            vuelo1.Size = new Size(375, 40);
            vuelo1.TabIndex = 128;
            vuelo1.Text = "VUELO N°1\r\nCÓRDOBA - BUENOS AIRES";
            vuelo1.UseVisualStyleBackColor = false;
            vuelo1.Visible = false;
            vuelo1.Click += vuelo1_Click;
            // 
            // vuelo5
            // 
            vuelo5.BackColor = Color.MediumPurple;
            vuelo5.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo5.FlatAppearance.BorderSize = 0;
            vuelo5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo5.FlatStyle = FlatStyle.Flat;
            vuelo5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            vuelo5.ForeColor = SystemColors.ControlLight;
            vuelo5.Location = new Point(29, 558);
            vuelo5.Margin = new Padding(0);
            vuelo5.Name = "vuelo5";
            vuelo5.Size = new Size(375, 40);
            vuelo5.TabIndex = 129;
            vuelo5.Text = "VUELO N°5\r\nCÓRDOBA - BARILOCHE";
            vuelo5.UseVisualStyleBackColor = false;
            vuelo5.Visible = false;
            vuelo5.Click += vuelo5_Click;
            // 
            // vuelo3
            // 
            vuelo3.BackColor = Color.MediumPurple;
            vuelo3.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo3.FlatAppearance.BorderSize = 0;
            vuelo3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo3.FlatStyle = FlatStyle.Flat;
            vuelo3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            vuelo3.ForeColor = SystemColors.ControlLight;
            vuelo3.Location = new Point(810, 309);
            vuelo3.Margin = new Padding(0);
            vuelo3.Name = "vuelo3";
            vuelo3.Size = new Size(375, 40);
            vuelo3.TabIndex = 130;
            vuelo3.Text = "VUELO N°3\r\nCÓRDOBA - MENDOZA";
            vuelo3.UseVisualStyleBackColor = false;
            vuelo3.Visible = false;
            vuelo3.Click += vuelo3_Click;
            // 
            // vuelo6
            // 
            vuelo6.BackColor = Color.MediumPurple;
            vuelo6.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo6.FlatAppearance.BorderSize = 0;
            vuelo6.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo6.FlatStyle = FlatStyle.Flat;
            vuelo6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            vuelo6.ForeColor = SystemColors.ControlLight;
            vuelo6.Location = new Point(810, 565);
            vuelo6.Margin = new Padding(0);
            vuelo6.Name = "vuelo6";
            vuelo6.Size = new Size(375, 40);
            vuelo6.TabIndex = 132;
            vuelo6.Text = "VUELO N°6\r\nBARILOCHE - CÓRDOBA";
            vuelo6.UseVisualStyleBackColor = false;
            vuelo6.Visible = false;
            vuelo6.Click += vuelo6_Click;
            // 
            // cbaImg3
            // 
            cbaImg3.BackgroundImage = Properties.Resources.CORDOBA;
            cbaImg3.BackgroundImageLayout = ImageLayout.Stretch;
            cbaImg3.Location = new Point(812, 365);
            cbaImg3.Name = "cbaImg3";
            cbaImg3.Size = new Size(375, 239);
            cbaImg3.TabIndex = 131;
            cbaImg3.TabStop = false;
            cbaImg3.Tag = "";
            cbaImg3.Visible = false;
            // 
            // logoutBTN
            // 
            logoutBTN.BackColor = Color.IndianRed;
            logoutBTN.FlatAppearance.BorderColor = Color.DarkGray;
            logoutBTN.FlatAppearance.BorderSize = 0;
            logoutBTN.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            logoutBTN.FlatStyle = FlatStyle.Flat;
            logoutBTN.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBTN.ForeColor = SystemColors.ControlText;
            logoutBTN.Location = new Point(0, 0);
            logoutBTN.Margin = new Padding(0);
            logoutBTN.Name = "logoutBTN";
            logoutBTN.Size = new Size(71, 25);
            logoutBTN.TabIndex = 133;
            logoutBTN.Text = "LOG OUT";
            logoutBTN.UseVisualStyleBackColor = false;
            logoutBTN.Visible = false;
            logoutBTN.Click += logoutBTN_Click;
            // 
            // details1
            // 
            details1.BackColor = Color.DarkSlateBlue;
            details1.CausesValidation = false;
            details1.Enabled = false;
            details1.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            details1.FlatAppearance.BorderSize = 0;
            details1.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            details1.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            details1.FlatStyle = FlatStyle.Flat;
            details1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            details1.Location = new Point(0, 240);
            details1.Name = "details1";
            details1.Size = new Size(375, 20);
            details1.TabIndex = 134;
            details1.Text = "21:50 - 23:10     |     Precio 43.700";
            details1.TextAlign = ContentAlignment.TopCenter;
            details1.TextImageRelation = TextImageRelation.ImageAboveText;
            details1.UseVisualStyleBackColor = false;
            details1.Visible = false;
            // 
            // details2
            // 
            details2.BackColor = Color.DarkSlateBlue;
            details2.CausesValidation = false;
            details2.Enabled = false;
            details2.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            details2.FlatAppearance.BorderSize = 0;
            details2.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            details2.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            details2.FlatStyle = FlatStyle.Flat;
            details2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            details2.Location = new Point(-74, 303);
            details2.Name = "details2";
            details2.Size = new Size(375, 20);
            details2.TabIndex = 135;
            details2.Text = "19:50 - 21:10     |     Precio 43.700";
            details2.TextAlign = ContentAlignment.TopCenter;
            details2.TextImageRelation = TextImageRelation.ImageAboveText;
            details2.UseVisualStyleBackColor = false;
            details2.Visible = false;
            // 
            // details3
            // 
            details3.BackColor = Color.DarkSlateBlue;
            details3.CausesValidation = false;
            details3.Enabled = false;
            details3.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            details3.FlatAppearance.BorderSize = 0;
            details3.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            details3.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            details3.FlatStyle = FlatStyle.Flat;
            details3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            details3.Location = new Point(810, 289);
            details3.Name = "details3";
            details3.Size = new Size(375, 20);
            details3.TabIndex = 136;
            details3.Text = "16:45 - 17:55     |     Precio 52.000";
            details3.TextAlign = ContentAlignment.TopCenter;
            details3.TextImageRelation = TextImageRelation.ImageAboveText;
            details3.UseVisualStyleBackColor = false;
            details3.Visible = false;
            // 
            // details4
            // 
            details4.BackColor = Color.DarkSlateBlue;
            details4.CausesValidation = false;
            details4.Enabled = false;
            details4.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            details4.FlatAppearance.BorderSize = 0;
            details4.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            details4.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            details4.FlatStyle = FlatStyle.Flat;
            details4.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            details4.Location = new Point(29, 545);
            details4.Name = "details4";
            details4.Size = new Size(375, 20);
            details4.TabIndex = 137;
            details4.Text = "21:50 - 23:10     |     Precio 52.000";
            details4.TextAlign = ContentAlignment.TopCenter;
            details4.TextImageRelation = TextImageRelation.ImageAboveText;
            details4.UseVisualStyleBackColor = false;
            details4.Visible = false;
            // 
            // details5
            // 
            details5.BackColor = Color.DarkSlateBlue;
            details5.CausesValidation = false;
            details5.Enabled = false;
            details5.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            details5.FlatAppearance.BorderSize = 0;
            details5.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            details5.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            details5.FlatStyle = FlatStyle.Flat;
            details5.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            details5.Location = new Point(29, 538);
            details5.Name = "details5";
            details5.Size = new Size(375, 20);
            details5.TabIndex = 138;
            details5.Text = "21:50 - 07:35    |     Precio 183.000";
            details5.TextAlign = ContentAlignment.TopCenter;
            details5.TextImageRelation = TextImageRelation.ImageAboveText;
            details5.UseVisualStyleBackColor = false;
            details5.Visible = false;
            // 
            // details6
            // 
            details6.BackColor = Color.DarkSlateBlue;
            details6.CausesValidation = false;
            details6.Enabled = false;
            details6.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            details6.FlatAppearance.BorderSize = 0;
            details6.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            details6.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            details6.FlatStyle = FlatStyle.Flat;
            details6.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            details6.Location = new Point(810, 545);
            details6.Name = "details6";
            details6.Size = new Size(375, 20);
            details6.TabIndex = 139;
            details6.Text = "13:00 - 15:00     |     Precio 183.000";
            details6.TextAlign = ContentAlignment.TopCenter;
            details6.TextImageRelation = TextImageRelation.ImageAboveText;
            details6.UseVisualStyleBackColor = false;
            details6.Visible = false;
            // 
            // cartBTN1
            // 
            cartBTN1.BackColor = Color.Black;
            cartBTN1.BackgroundImage = Properties.Resources.cartBTN1;
            cartBTN1.BackgroundImageLayout = ImageLayout.Stretch;
            cartBTN1.FlatAppearance.BorderSize = 0;
            cartBTN1.FlatStyle = FlatStyle.Flat;
            cartBTN1.ForeColor = Color.Transparent;
            cartBTN1.Location = new Point(30, 100);
            cartBTN1.Name = "cartBTN1";
            cartBTN1.Size = new Size(100, 30);
            cartBTN1.TabIndex = 140;
            cartBTN1.UseVisualStyleBackColor = false;
            cartBTN1.Visible = false;
            cartBTN1.Click += cartBTN1_Click;
            // 
            // cartBTN3
            // 
            cartBTN3.BackColor = Color.Black;
            cartBTN3.BackgroundImage = Properties.Resources.cartBTN1;
            cartBTN3.BackgroundImageLayout = ImageLayout.Stretch;
            cartBTN3.FlatAppearance.BorderSize = 0;
            cartBTN3.FlatStyle = FlatStyle.Flat;
            cartBTN3.ForeColor = Color.Transparent;
            cartBTN3.Location = new Point(810, 100);
            cartBTN3.Name = "cartBTN3";
            cartBTN3.Size = new Size(100, 30);
            cartBTN3.TabIndex = 142;
            cartBTN3.UseVisualStyleBackColor = false;
            cartBTN3.Visible = false;
            cartBTN3.Click += cartBTN3_Click;
            // 
            // cartBTN4
            // 
            cartBTN4.BackColor = Color.Black;
            cartBTN4.BackgroundImage = Properties.Resources.cartBTN1;
            cartBTN4.BackgroundImageLayout = ImageLayout.Stretch;
            cartBTN4.FlatAppearance.BorderSize = 0;
            cartBTN4.FlatStyle = FlatStyle.Flat;
            cartBTN4.ForeColor = Color.Transparent;
            cartBTN4.Location = new Point(30, 356);
            cartBTN4.Name = "cartBTN4";
            cartBTN4.Size = new Size(100, 30);
            cartBTN4.TabIndex = 143;
            cartBTN4.UseVisualStyleBackColor = false;
            cartBTN4.Visible = false;
            cartBTN4.Click += cartBTN4_Click;
            // 
            // cartBTN5
            // 
            cartBTN5.BackColor = Color.Black;
            cartBTN5.BackgroundImage = Properties.Resources.cartBTN1;
            cartBTN5.BackgroundImageLayout = ImageLayout.Stretch;
            cartBTN5.FlatAppearance.BorderSize = 0;
            cartBTN5.FlatStyle = FlatStyle.Flat;
            cartBTN5.ForeColor = Color.Transparent;
            cartBTN5.Location = new Point(29, 349);
            cartBTN5.Name = "cartBTN5";
            cartBTN5.Size = new Size(100, 30);
            cartBTN5.TabIndex = 144;
            cartBTN5.UseVisualStyleBackColor = false;
            cartBTN5.Visible = false;
            cartBTN5.Click += cartBTN5_Click;
            // 
            // cartBTN6
            // 
            cartBTN6.BackColor = Color.Black;
            cartBTN6.BackgroundImage = Properties.Resources.cartBTN1;
            cartBTN6.BackgroundImageLayout = ImageLayout.Stretch;
            cartBTN6.FlatAppearance.BorderSize = 0;
            cartBTN6.FlatStyle = FlatStyle.Flat;
            cartBTN6.ForeColor = Color.Transparent;
            cartBTN6.Location = new Point(812, 356);
            cartBTN6.Name = "cartBTN6";
            cartBTN6.Size = new Size(100, 30);
            cartBTN6.TabIndex = 145;
            cartBTN6.UseVisualStyleBackColor = false;
            cartBTN6.Visible = false;
            cartBTN6.Click += cartBTN6_Click;
            // 
            // openCart
            // 
            openCart.BackColor = Color.Transparent;
            openCart.BackgroundImage = Properties.Resources.cartimg;
            openCart.BackgroundImageLayout = ImageLayout.Stretch;
            openCart.FlatAppearance.BorderSize = 0;
            openCart.FlatStyle = FlatStyle.Flat;
            openCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            openCart.Location = new Point(969, 9);
            openCart.Name = "openCart";
            openCart.Size = new Size(35, 35);
            openCart.TabIndex = 147;
            openCart.UseVisualStyleBackColor = false;
            openCart.Visible = false;
            openCart.Click += openCart_Click;
            // 
            // displayName
            // 
            displayName.BackColor = Color.DarkSlateBlue;
            displayName.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayName.ForeColor = SystemColors.ButtonFace;
            displayName.Location = new Point(1010, 0);
            displayName.Name = "displayName";
            displayName.Size = new Size(204, 50);
            displayName.TabIndex = 149;
            displayName.Text = "Hola, krakencio!";
            displayName.TextAlign = ContentAlignment.MiddleCenter;
            displayName.Visible = false;
            // 
            // cartBTN2
            // 
            cartBTN2.BackColor = Color.Black;
            cartBTN2.BackgroundImage = Properties.Resources.cartBTN1;
            cartBTN2.BackgroundImageLayout = ImageLayout.Stretch;
            cartBTN2.FlatAppearance.BorderSize = 0;
            cartBTN2.FlatStyle = FlatStyle.Flat;
            cartBTN2.ForeColor = Color.Transparent;
            cartBTN2.Location = new Point(212, 159);
            cartBTN2.Name = "cartBTN2";
            cartBTN2.Size = new Size(100, 30);
            cartBTN2.TabIndex = 150;
            cartBTN2.UseVisualStyleBackColor = false;
            cartBTN2.Visible = false;
            cartBTN2.Click += cartBTN2_Click;
            // 
            // vueloMenu
            // 
            vueloMenu.BackColor = Color.SlateBlue;
            vueloMenu.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            vueloMenu.ForeColor = Color.BurlyWood;
            vueloMenu.Location = new Point(536, 110);
            vueloMenu.Name = "vueloMenu";
            vueloMenu.Size = new Size(266, 394);
            vueloMenu.TabIndex = 100;
            vueloMenu.Text = "ELIGE TU VUELO";
            vueloMenu.TextAlign = ContentAlignment.TopCenter;
            vueloMenu.Visible = false;
            // 
            // vAmount
            // 
            vAmount.BackColor = Color.DarkSlateGray;
            vAmount.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            vAmount.ForeColor = Color.SeaShell;
            vAmount.Location = new Point(374, 154);
            vAmount.Name = "vAmount";
            vAmount.Size = new Size(266, 35);
            vAmount.TabIndex = 152;
            vAmount.Text = "NÚMERO DE VUELO";
            vAmount.TextAlign = ContentAlignment.MiddleCenter;
            vAmount.Visible = false;
            // 
            // vFecha
            // 
            vFecha.BackColor = Color.DarkSlateGray;
            vFecha.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            vFecha.ForeColor = Color.SeaShell;
            vFecha.Location = new Point(212, 413);
            vFecha.Name = "vFecha";
            vFecha.Size = new Size(266, 35);
            vFecha.TabIndex = 153;
            vFecha.Text = "FECHA DE VUELO";
            vFecha.TextAlign = ContentAlignment.MiddleCenter;
            vFecha.Visible = false;
            // 
            // vPasajes
            // 
            vPasajes.BackColor = Color.DarkSlateGray;
            vPasajes.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            vPasajes.ForeColor = Color.SeaShell;
            vPasajes.Location = new Point(303, 570);
            vPasajes.Name = "vPasajes";
            vPasajes.Size = new Size(266, 35);
            vPasajes.TabIndex = 154;
            vPasajes.Text = "CANTIDAD DE PASAJES";
            vPasajes.TextAlign = ContentAlignment.MiddleCenter;
            vPasajes.Visible = false;
            // 
            // vueloText
            // 
            vueloText.BorderStyle = BorderStyle.None;
            vueloText.Location = new Point(536, 293);
            vueloText.Name = "vueloText";
            vueloText.PlaceholderText = "DEL 1 AL 6";
            vueloText.Size = new Size(142, 16);
            vueloText.TabIndex = 155;
            vueloText.TextAlign = HorizontalAlignment.Center;
            vueloText.Visible = false;
            // 
            // fechaText
            // 
            fechaText.BorderStyle = BorderStyle.None;
            fechaText.Location = new Point(531, 387);
            fechaText.Name = "fechaText";
            fechaText.PlaceholderText = "DIA/MES/AÑO";
            fechaText.Size = new Size(142, 16);
            fechaText.TabIndex = 156;
            fechaText.TextAlign = HorizontalAlignment.Center;
            fechaText.Visible = false;
            // 
            // pasajesText
            // 
            pasajesText.BorderStyle = BorderStyle.None;
            pasajesText.Location = new Point(536, 486);
            pasajesText.Name = "pasajesText";
            pasajesText.PlaceholderText = "MAX . 10";
            pasajesText.Size = new Size(142, 16);
            pasajesText.TabIndex = 157;
            pasajesText.TextAlign = HorizontalAlignment.Center;
            pasajesText.Visible = false;
            // 
            // agregarBTN
            // 
            agregarBTN.BackColor = Color.MidnightBlue;
            agregarBTN.FlatAppearance.BorderColor = Color.MediumPurple;
            agregarBTN.FlatAppearance.BorderSize = 0;
            agregarBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            agregarBTN.FlatStyle = FlatStyle.Flat;
            agregarBTN.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            agregarBTN.ForeColor = SystemColors.ControlLight;
            agregarBTN.Location = new Point(549, 453);
            agregarBTN.Margin = new Padding(0);
            agregarBTN.Name = "agregarBTN";
            agregarBTN.Size = new Size(266, 40);
            agregarBTN.TabIndex = 158;
            agregarBTN.Text = "AGREGAR";
            agregarBTN.UseVisualStyleBackColor = false;
            agregarBTN.Visible = false;
            agregarBTN.Click += agregarBTN_Click;
            // 
            // compraMenu
            // 
            compraMenu.BackColor = Color.Orange;
            compraMenu.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            compraMenu.ForeColor = Color.SeaShell;
            compraMenu.Location = new Point(549, 41);
            compraMenu.Name = "compraMenu";
            compraMenu.Size = new Size(266, 394);
            compraMenu.TabIndex = 159;
            compraMenu.Text = "CONFIRMA TU COMPRA";
            compraMenu.TextAlign = ContentAlignment.TopCenter;
            compraMenu.Visible = false;
            // 
            // pagarBTN
            // 
            pagarBTN.BackColor = Color.OrangeRed;
            pagarBTN.FlatAppearance.BorderColor = Color.MediumPurple;
            pagarBTN.FlatAppearance.BorderSize = 0;
            pagarBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            pagarBTN.FlatStyle = FlatStyle.Flat;
            pagarBTN.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            pagarBTN.ForeColor = SystemColors.ControlLight;
            pagarBTN.Location = new Point(205, 359);
            pagarBTN.Margin = new Padding(0);
            pagarBTN.Name = "pagarBTN";
            pagarBTN.Size = new Size(266, 44);
            pagarBTN.TabIndex = 160;
            pagarBTN.Text = "PAGAR";
            pagarBTN.UseVisualStyleBackColor = false;
            pagarBTN.Visible = false;
            pagarBTN.Click += pagarBTN_Click;
            // 
            // montoPesos
            // 
            montoPesos.BackColor = Color.DarkSlateGray;
            montoPesos.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            montoPesos.ForeColor = Color.SeaShell;
            montoPesos.Location = new Point(549, 305);
            montoPesos.Name = "montoPesos";
            montoPesos.Size = new Size(266, 79);
            montoPesos.TabIndex = 161;
            montoPesos.Text = "MONTO A PAGAR EN PESOS\r\n\r\n\r\n";
            montoPesos.TextAlign = ContentAlignment.MiddleCenter;
            montoPesos.Visible = false;
            // 
            // nPasajes
            // 
            nPasajes.BackColor = Color.DarkSlateGray;
            nPasajes.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            nPasajes.ForeColor = Color.SeaShell;
            nPasajes.Location = new Point(549, 154);
            nPasajes.Name = "nPasajes";
            nPasajes.Size = new Size(266, 131);
            nPasajes.TabIndex = 162;
            nPasajes.Text = "CANTIDAD DE PASAJES";
            nPasajes.TextAlign = ContentAlignment.MiddleCenter;
            nPasajes.Visible = false;
            // 
            // iva
            // 
            iva.BackColor = Color.Orange;
            iva.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            iva.ForeColor = Color.SeaShell;
            iva.Location = new Point(549, 413);
            iva.Name = "iva";
            iva.Size = new Size(266, 25);
            iva.TabIndex = 163;
            iva.Text = "ESTE MONTO INCLUYE 10,5% DE IVA\r\n";
            iva.TextAlign = ContentAlignment.MiddleCenter;
            iva.Visible = false;
            // 
            // invalidMsg
            // 
            invalidMsg.BackColor = Color.Red;
            invalidMsg.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            invalidMsg.ForeColor = Color.SeaShell;
            invalidMsg.Location = new Point(119, 240);
            invalidMsg.Name = "invalidMsg";
            invalidMsg.Size = new Size(300, 150);
            invalidMsg.TabIndex = 164;
            invalidMsg.Text = "Fecha no valida";
            invalidMsg.TextAlign = ContentAlignment.MiddleCenter;
            invalidMsg.Visible = false;
            invalidMsg.Click += invalidDate_Click;
            // 
            // paidMsg
            // 
            paidMsg.BackColor = Color.ForestGreen;
            paidMsg.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            paidMsg.ForeColor = Color.SeaShell;
            paidMsg.Location = new Point(48, 249);
            paidMsg.Name = "paidMsg";
            paidMsg.Size = new Size(300, 150);
            paidMsg.TabIndex = 165;
            paidMsg.Text = "TU COMPRA FUE REALIZADA EXITOSAMENTE!";
            paidMsg.TextAlign = ContentAlignment.MiddleCenter;
            paidMsg.Visible = false;
            paidMsg.Click += paidMsg_Click;
            // 
            // exitMsg
            // 
            exitMsg.BackColor = Color.BlueViolet;
            exitMsg.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            exitMsg.ForeColor = Color.SeaShell;
            exitMsg.Location = new Point(737, 84);
            exitMsg.Name = "exitMsg";
            exitMsg.Size = new Size(300, 150);
            exitMsg.TabIndex = 166;
            exitMsg.Text = "\r\nDESEAS SALIR?";
            exitMsg.TextAlign = ContentAlignment.TopCenter;
            exitMsg.Visible = false;
            // 
            // exitYES
            // 
            exitYES.BackColor = Color.MidnightBlue;
            exitYES.FlatAppearance.BorderColor = Color.MediumPurple;
            exitYES.FlatAppearance.BorderSize = 0;
            exitYES.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            exitYES.FlatStyle = FlatStyle.Flat;
            exitYES.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            exitYES.ForeColor = SystemColors.ControlLight;
            exitYES.Location = new Point(443, 324);
            exitYES.Margin = new Padding(0);
            exitYES.Name = "exitYES";
            exitYES.Size = new Size(103, 40);
            exitYES.TabIndex = 167;
            exitYES.Text = "SI";
            exitYES.UseVisualStyleBackColor = false;
            exitYES.Visible = false;
            exitYES.Click += exitYES_Click;
            // 
            // exitNO
            // 
            exitNO.BackColor = Color.MidnightBlue;
            exitNO.FlatAppearance.BorderColor = Color.MediumPurple;
            exitNO.FlatAppearance.BorderSize = 0;
            exitNO.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            exitNO.FlatStyle = FlatStyle.Flat;
            exitNO.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            exitNO.ForeColor = SystemColors.ControlLight;
            exitNO.Location = new Point(598, 319);
            exitNO.Margin = new Padding(0);
            exitNO.Name = "exitNO";
            exitNO.Size = new Size(103, 40);
            exitNO.TabIndex = 168;
            exitNO.Text = "NO";
            exitNO.UseVisualStyleBackColor = false;
            exitNO.Visible = false;
            exitNO.Click += exitNO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Travel;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1214, 621);
            Controls.Add(exitNO);
            Controls.Add(exitYES);
            Controls.Add(exitMsg);
            Controls.Add(paidMsg);
            Controls.Add(invalidMsg);
            Controls.Add(pasajesText);
            Controls.Add(fechaText);
            Controls.Add(vueloText);
            Controls.Add(vPasajes);
            Controls.Add(vFecha);
            Controls.Add(vAmount);
            Controls.Add(agregarBTN);
            Controls.Add(vueloMenu);
            Controls.Add(iva);
            Controls.Add(nPasajes);
            Controls.Add(montoPesos);
            Controls.Add(pagarBTN);
            Controls.Add(compraMenu);
            Controls.Add(cartBTN2);
            Controls.Add(cartBTN5);
            Controls.Add(details5);
            Controls.Add(details2);
            Controls.Add(vuelo5);
            Controls.Add(vuelo2);
            Controls.Add(bchImg);
            Controls.Add(cbaImg1);
            Controls.Add(displayName);
            Controls.Add(openCart);
            Controls.Add(cartBTN6);
            Controls.Add(cartBTN4);
            Controls.Add(cartBTN3);
            Controls.Add(cartBTN1);
            Controls.Add(details6);
            Controls.Add(details4);
            Controls.Add(details3);
            Controls.Add(details1);
            Controls.Add(vuelo1);
            Controls.Add(logInEnterBTN);
            Controls.Add(logInBannerBTN);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(signUpEnterBTN);
            Controls.Add(sUP_password);
            Controls.Add(sUP_username);
            Controls.Add(sUP_DNI);
            Controls.Add(sUP_phoneNumber);
            Controls.Add(sUP_fullname);
            Controls.Add(sUp_message);
            Controls.Add(sUp_icon);
            Controls.Add(vuelo6);
            Controls.Add(vuelo3);
            Controls.Add(vuelo4);
            Controls.Add(logoutBTN);
            Controls.Add(cbaImg3);
            Controls.Add(cbaImg2);
            Controls.Add(menImg);
            Controls.Add(bairesImg);
            Controls.Add(signUpBannerBTN);
            Controls.Add(sUP_email);
            Controls.Add(signUpBTN);
            Controls.Add(logInBTN);
            Controls.Add(signUpBanner);
            Controls.Add(logInBanner);
            Controls.Add(subBackground2);
            Controls.Add(subBackground);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VuelosAR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logInBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)signUpBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)sUp_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbaImg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bairesImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)menImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)bchImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbaImg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbaImg3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button logInBTN;
        private TextBox login_username;
        private TextBox login_password;
        private Button signUpBTN;
        private Label subBackground;
        private PictureBox logInBanner;
        private Button logInBannerBTN;
        private Button logInEnterBTN;
        private PictureBox signUpBanner;
        private TextBox sUP_fullname;
        private TextBox sUP_phoneNumber;
        private TextBox sUP_DNI;
        private TextBox sUP_email;
        private TextBox sUP_password;
        private TextBox sUP_username;
        private Button signUpEnterBTN;
        private Button signUpBannerBTN;
        private Label sUp_message;
        private PictureBox sUp_icon;
        private Label subBackground2;
        private PictureBox cbaImg1;
        private PictureBox bairesImg;
        private PictureBox menImg;
        private PictureBox bchImg;
        private Button vuelo2;
        private Button vuelo4;
        private PictureBox cbaImg2;
        private Button vuelo1;
        private Button vuelo5;
        private Button vuelo3;
        private Button vuelo6;
        private PictureBox cbaImg3;
        private Button logoutBTN;
        private Button details1;
        private Button details2;
        private Button details3;
        private Button details4;
        private Button details5;
        private Button details6;
        private Button cartBTN1;
        private Button cartBTN3;
        private Button cartBTN4;
        private Button cartBTN5;
        private Button cartBTN6;
        private Button openCart;
        private Label displayName;
        private Button cartBTN2;
        private Label vueloMenu;
        private Label vAmount;
        private Label vFecha;
        private Label vPasajes;
        private TextBox vueloText;
        private TextBox fechaText;
        private TextBox pasajesText;
        private Button agregarBTN;
        private Label compraMenu;
        private Button pagarBTN;
        private Label montoPesos;
        private Label nPasajes;
        private Label iva;
        private Label invalidMsg;
        private Label paidMsg;
        private Label exitMsg;
        private Button exitYES;
        private Button exitNO;
    }
}
