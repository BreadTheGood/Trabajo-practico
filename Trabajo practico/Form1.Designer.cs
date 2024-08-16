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
            sUp_img = new PictureBox();
            sUp_message = new Label();
            sUp_icon = new PictureBox();
            sub_Background2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)logInBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signUpBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sUp_img).BeginInit();
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
            logInBTN.Location = new Point(1034, 91);
            logInBTN.Margin = new Padding(0);
            logInBTN.Name = "logInBTN";
            logInBTN.Size = new Size(147, 62);
            logInBTN.TabIndex = 98;
            logInBTN.Text = "LOG IN";
            logInBTN.UseVisualStyleBackColor = false;
            logInBTN.Click += logInBTN_Click;
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.None;
            login_username.Location = new Point(994, 85);
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
            login_password.Location = new Point(997, 138);
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
            signUpBTN.Location = new Point(1034, 9);
            signUpBTN.Margin = new Padding(0);
            signUpBTN.Name = "signUpBTN";
            signUpBTN.Size = new Size(147, 73);
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
            subBackground.Name = "subBackground";
            subBackground.Size = new Size(1214, 749);
            subBackground.TabIndex = 2;
            subBackground.Text = "BIENVENIDO\r\nVuelos Argentina";
            subBackground.TextAlign = ContentAlignment.TopCenter;
            subBackground.Click += subBackground_Click;
            subBackground.MouseHover += subBackground_MouseHover;
            // 
            // logInBanner
            // 
            logInBanner.BackColor = SystemColors.ActiveBorder;
            logInBanner.Location = new Point(284, 0);
            logInBanner.Name = "logInBanner";
            logInBanner.Size = new Size(220, 294);
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
            logInBannerBTN.Location = new Point(1034, 9);
            logInBannerBTN.Margin = new Padding(0);
            logInBannerBTN.Name = "logInBannerBTN";
            logInBannerBTN.Size = new Size(147, 62);
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
            logInEnterBTN.Location = new Point(997, 232);
            logInEnterBTN.Margin = new Padding(0);
            logInEnterBTN.Name = "logInEnterBTN";
            logInEnterBTN.Size = new Size(220, 62);
            logInEnterBTN.TabIndex = 102;
            logInEnterBTN.Text = "ENTER";
            logInEnterBTN.UseVisualStyleBackColor = false;
            logInEnterBTN.Visible = false;
            logInEnterBTN.Click += logInEnterBTN_Click;
            // 
            // signUpBanner
            // 
            signUpBanner.BackColor = SystemColors.ActiveBorder;
            signUpBanner.Location = new Point(997, 0);
            signUpBanner.Name = "signUpBanner";
            signUpBanner.Size = new Size(220, 458);
            signUpBanner.TabIndex = 103;
            signUpBanner.TabStop = false;
            signUpBanner.Visible = false;
            // 
            // sUP_fullname
            // 
            sUP_fullname.BorderStyle = BorderStyle.None;
            sUP_fullname.Location = new Point(997, 120);
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
            sUP_phoneNumber.Location = new Point(997, 166);
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
            sUP_DNI.Location = new Point(997, 220);
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
            sUP_email.Location = new Point(997, 267);
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
            sUP_password.Location = new Point(997, 354);
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
            sUP_username.Location = new Point(997, 315);
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
            signUpEnterBTN.Location = new Point(997, 396);
            signUpEnterBTN.Margin = new Padding(0);
            signUpEnterBTN.Name = "signUpEnterBTN";
            signUpEnterBTN.Size = new Size(220, 62);
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
            signUpBannerBTN.Location = new Point(1034, 9);
            signUpBannerBTN.Margin = new Padding(0);
            signUpBannerBTN.Name = "signUpBannerBTN";
            signUpBannerBTN.Size = new Size(147, 73);
            signUpBannerBTN.TabIndex = 111;
            signUpBannerBTN.Text = "SIGN UP";
            signUpBannerBTN.UseVisualStyleBackColor = false;
            signUpBannerBTN.Visible = false;
            // 
            // sUp_img
            // 
            sUp_img.BackColor = Color.Transparent;
            sUp_img.BackgroundImage = Properties.Resources.TRAVEL22;
            sUp_img.BackgroundImageLayout = ImageLayout.Stretch;
            sUp_img.InitialImage = null;
            sUp_img.Location = new Point(567, 376);
            sUp_img.Name = "sUp_img";
            sUp_img.Size = new Size(444, 294);
            sUp_img.TabIndex = 112;
            sUp_img.TabStop = false;
            sUp_img.Visible = false;
            // 
            // sUp_message
            // 
            sUp_message.AutoSize = true;
            sUp_message.BackColor = Color.WhiteSmoke;
            sUp_message.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sUp_message.Location = new Point(666, 348);
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
            sUp_icon.Location = new Point(940, 302);
            sUp_icon.Name = "sUp_icon";
            sUp_icon.Size = new Size(70, 70);
            sUp_icon.TabIndex = 114;
            sUp_icon.TabStop = false;
            sUp_icon.Visible = false;
            // 
            // sub_Background2
            // 
            sub_Background2.BackColor = Color.Transparent;
            sub_Background2.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            sub_Background2.ForeColor = Color.BurlyWood;
            sub_Background2.Location = new Point(0, 0);
            sub_Background2.Name = "sub_Background2";
            sub_Background2.Size = new Size(1217, 749);
            sub_Background2.TabIndex = 116;
            sub_Background2.Text = "VUELOS DISPONIBLES";
            sub_Background2.TextAlign = ContentAlignment.TopCenter;
            sub_Background2.Visible = false;
            // 
            // cbaImg1
            // 
            cbaImg1.BackgroundImage = Properties.Resources.CORDOBA;
            cbaImg1.BackgroundImageLayout = ImageLayout.Stretch;
            cbaImg1.Location = new Point(530, 175);
            cbaImg1.Name = "cbaImg1";
            cbaImg1.Size = new Size(267, 267);
            cbaImg1.TabIndex = 117;
            cbaImg1.TabStop = false;
            cbaImg1.Visible = false;
            cbaImg1.Click += cbaImg1_Click;
            // 
            // bairesImg
            // 
            bairesImg.BackgroundImage = Properties.Resources.BUENOS_AIRES;
            bairesImg.BackgroundImageLayout = ImageLayout.Stretch;
            bairesImg.Location = new Point(139, 175);
            bairesImg.Name = "bairesImg";
            bairesImg.Size = new Size(267, 267);
            bairesImg.TabIndex = 118;
            bairesImg.TabStop = false;
            bairesImg.Visible = false;
            // 
            // menImg
            // 
            menImg.BackgroundImage = Properties.Resources.MENDOZA;
            menImg.BackgroundImageLayout = ImageLayout.Stretch;
            menImg.Location = new Point(922, 175);
            menImg.Name = "menImg";
            menImg.Size = new Size(267, 267);
            menImg.TabIndex = 119;
            menImg.TabStop = false;
            menImg.Visible = false;
            // 
            // bchImg
            // 
            bchImg.BackgroundImage = Properties.Resources.BARILOCHE;
            bchImg.BackgroundImageLayout = ImageLayout.Stretch;
            bchImg.Location = new Point(530, 471);
            bchImg.Name = "bchImg";
            bchImg.Size = new Size(267, 267);
            bchImg.TabIndex = 120;
            bchImg.TabStop = false;
            bchImg.Visible = false;
            // 
            // vuelo2
            // 
            vuelo2.BackColor = Color.MediumPurple;
            vuelo2.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo2.FlatAppearance.BorderSize = 0;
            vuelo2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo2.FlatStyle = FlatStyle.Flat;
            vuelo2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vuelo2.ForeColor = SystemColors.ControlLight;
            vuelo2.Location = new Point(420, 175);
            vuelo2.Margin = new Padding(0);
            vuelo2.Name = "vuelo2";
            vuelo2.Size = new Size(121, 267);
            vuelo2.TabIndex = 125;
            vuelo2.Text = "VUELO N°2\r\nBUENOS AIRES\r\n-\r\nCÓRDOBA";
            vuelo2.UseVisualStyleBackColor = false;
            vuelo2.Visible = false;
            // 
            // vuelo4
            // 
            vuelo4.BackColor = Color.MediumPurple;
            vuelo4.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo4.FlatAppearance.BorderSize = 0;
            vuelo4.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo4.FlatStyle = FlatStyle.Flat;
            vuelo4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vuelo4.ForeColor = SystemColors.ControlLight;
            vuelo4.Location = new Point(31, 471);
            vuelo4.Margin = new Padding(0);
            vuelo4.Name = "vuelo4";
            vuelo4.Size = new Size(121, 267);
            vuelo4.TabIndex = 127;
            vuelo4.Text = "VUELO N°4\r\nMENDOZA\r\n-\r\nCÓRDOBA";
            vuelo4.UseVisualStyleBackColor = false;
            vuelo4.Visible = false;
            // 
            // cbaImg2
            // 
            cbaImg2.BackgroundImage = Properties.Resources.CORDOBA;
            cbaImg2.BackgroundImageLayout = ImageLayout.Stretch;
            cbaImg2.Location = new Point(139, 471);
            cbaImg2.Name = "cbaImg2";
            cbaImg2.Size = new Size(267, 267);
            cbaImg2.TabIndex = 126;
            cbaImg2.TabStop = false;
            cbaImg2.Visible = false;
            // 
            // vuelo1
            // 
            vuelo1.BackColor = Color.MediumPurple;
            vuelo1.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo1.FlatAppearance.BorderSize = 0;
            vuelo1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo1.FlatStyle = FlatStyle.Flat;
            vuelo1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vuelo1.ForeColor = SystemColors.ControlLight;
            vuelo1.Location = new Point(31, 175);
            vuelo1.Margin = new Padding(0);
            vuelo1.Name = "vuelo1";
            vuelo1.Size = new Size(121, 267);
            vuelo1.TabIndex = 128;
            vuelo1.Text = "VUELO N°1\r\nCÓRDOBA\r\n-\r\nBUENOS AIRES";
            vuelo1.UseVisualStyleBackColor = false;
            vuelo1.Visible = false;
            // 
            // vuelo5
            // 
            vuelo5.BackColor = Color.MediumPurple;
            vuelo5.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo5.FlatAppearance.BorderSize = 0;
            vuelo5.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo5.FlatStyle = FlatStyle.Flat;
            vuelo5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vuelo5.ForeColor = SystemColors.ControlLight;
            vuelo5.Location = new Point(420, 471);
            vuelo5.Margin = new Padding(0);
            vuelo5.Name = "vuelo5";
            vuelo5.Size = new Size(121, 267);
            vuelo5.TabIndex = 129;
            vuelo5.Text = "VUELO N°5\r\nCÓRDOBA\r\n-\r\nBARILOCHE";
            vuelo5.UseVisualStyleBackColor = false;
            vuelo5.Visible = false;
            // 
            // vuelo3
            // 
            vuelo3.BackColor = Color.MediumPurple;
            vuelo3.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo3.FlatAppearance.BorderSize = 0;
            vuelo3.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo3.FlatStyle = FlatStyle.Flat;
            vuelo3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vuelo3.ForeColor = SystemColors.ControlLight;
            vuelo3.Location = new Point(813, 175);
            vuelo3.Margin = new Padding(0);
            vuelo3.Name = "vuelo3";
            vuelo3.Size = new Size(121, 267);
            vuelo3.TabIndex = 130;
            vuelo3.Text = "VUELO N°3\r\nCÓRDOBA\r\n-\r\nMENDOZA";
            vuelo3.UseVisualStyleBackColor = false;
            vuelo3.Visible = false;
            // 
            // vuelo6
            // 
            vuelo6.BackColor = Color.MediumPurple;
            vuelo6.FlatAppearance.BorderColor = Color.DarkGray;
            vuelo6.FlatAppearance.BorderSize = 0;
            vuelo6.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            vuelo6.FlatStyle = FlatStyle.Flat;
            vuelo6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vuelo6.ForeColor = SystemColors.ControlLight;
            vuelo6.Location = new Point(813, 471);
            vuelo6.Margin = new Padding(0);
            vuelo6.Name = "vuelo6";
            vuelo6.Size = new Size(121, 267);
            vuelo6.TabIndex = 132;
            vuelo6.Text = "VUELO N°6\r\nBARILOCHE\r\n-\r\nCÓRDOBA";
            vuelo6.UseVisualStyleBackColor = false;
            vuelo6.Visible = false;
            // 
            // cbaImg3
            // 
            cbaImg3.BackgroundImage = Properties.Resources.CORDOBA;
            cbaImg3.BackgroundImageLayout = ImageLayout.Stretch;
            cbaImg3.Location = new Point(922, 470);
            cbaImg3.Name = "cbaImg3";
            cbaImg3.Size = new Size(267, 267);
            cbaImg3.TabIndex = 131;
            cbaImg3.TabStop = false;
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
            logoutBTN.Location = new Point(284, 15);
            logoutBTN.Margin = new Padding(0);
            logoutBTN.Name = "logoutBTN";
            logoutBTN.Size = new Size(147, 73);
            logoutBTN.TabIndex = 133;
            logoutBTN.Text = "LOG OUT";
            logoutBTN.UseVisualStyleBackColor = false;
            logoutBTN.Visible = false;
            logoutBTN.Click += logoutBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Travel;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1214, 749);
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
            Controls.Add(vuelo5);
            Controls.Add(vuelo1);
            Controls.Add(vuelo4);
            Controls.Add(vuelo2);
            Controls.Add(logoutBTN);
            Controls.Add(cbaImg3);
            Controls.Add(cbaImg2);
            Controls.Add(bchImg);
            Controls.Add(menImg);
            Controls.Add(bairesImg);
            Controls.Add(cbaImg1);
            Controls.Add(signUpBannerBTN);
            Controls.Add(sUP_email);
            Controls.Add(signUpBTN);
            Controls.Add(sub_Background2);
            Controls.Add(sUp_img);
            Controls.Add(logInBTN);
            Controls.Add(signUpBanner);
            Controls.Add(logInBanner);
            Controls.Add(subBackground);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "VuelosAR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logInBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)signUpBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)sUp_img).EndInit();
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
        private PictureBox sUp_img;
        private Label sUp_message;
        private PictureBox sUp_icon;
        private Label sub_Background2;
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
    }
}
