using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Trabajo_practico
{
    public partial class Form1 : Form
    {




        //variables 
        Boolean logged = false;
        Boolean signed = false;
        string fullname = "";
        string username = "";
        string password = "";
        string email = "";
        int dni = 0;
        int phoneNumber = 0;

        //main bg size
        readonly int bgWidth = 1214;
        readonly int bgHeight = 700;

        // banners size
        readonly int anyBannerWidth = 220;
        readonly int suBannerHeight = 460;
        readonly int liBannerHeight = 200;

        // buttons size
        readonly int anyButtonHeight = 40;

        //images size
        readonly int anyImageWidth = 375;
        readonly int anyImageHeight = 240;


        public Form1()
        {
            InitializeComponent();
            ComponentLocation();
            ComponentSize();


        }

        private void ComponentSize()
        {
            //background
            subBackground.Size = new Size(bgWidth, bgHeight);
            subBackground2.Size = new Size(bgWidth, bgHeight);

            //banners
            signUpBanner.Size = new Size(anyBannerWidth, suBannerHeight);
            logInBanner.Size = new Size(anyBannerWidth, liBannerHeight);

            //buttons
            logInEnterBTN.Size = new Size(anyBannerWidth, anyButtonHeight);
            logInBannerBTN.Size = new Size(anyBannerWidth, anyButtonHeight);
            logInBTN.Size = new Size(anyBannerWidth, anyButtonHeight);
            signUpBannerBTN.Size = new Size(anyBannerWidth, anyButtonHeight);
            signUpBTN.Size = new Size(anyBannerWidth, anyButtonHeight);
            vuelo1.Size = new Size(anyImageWidth, anyButtonHeight);
            vuelo2.Size = new Size(anyImageWidth, anyButtonHeight);
            vuelo3.Size = new Size(anyImageWidth, anyButtonHeight);
            vuelo4.Size = new Size(anyImageWidth, anyButtonHeight);
            vuelo5.Size = new Size(anyImageWidth, anyButtonHeight);
            vuelo6.Size = new Size(anyImageWidth, anyButtonHeight);
            details1.Size = new Size(anyImageWidth, 20);
            details2.Size = new Size(anyImageWidth, 20);
            details3.Size = new Size(anyImageWidth, 20);
            details4.Size = new Size(anyImageWidth, 20);
            details5.Size = new Size(anyImageWidth, 20);
            details6.Size = new Size(anyImageWidth, 20);


            //cart buttons
            cartBTN1.Size = new Size(100, 30);
            cartBTN2.Size = new Size(100, 30);
            cartBTN3.Size = new Size(100, 30);
            cartBTN4.Size = new Size(100, 30);
            cartBTN5.Size = new Size(100, 30);
            cartBTN6.Size = new Size(100, 30);
            RoundedBTN(cartBTN1);
            RoundedBTN(cartBTN2);
            RoundedBTN(cartBTN3);
            RoundedBTN(cartBTN4);
            RoundedBTN(cartBTN5);
            RoundedBTN(cartBTN6);

            //images
            bairesImg.Size = new Size(anyImageWidth, anyImageHeight);
            cbaImg1.Size = new Size(anyImageWidth, anyImageHeight);
            cbaImg2.Size = new Size(anyImageWidth, anyImageHeight);
            cbaImg3.Size = new Size(anyImageWidth, anyImageHeight);
            menImg.Size = new Size(anyImageWidth, anyImageHeight);
            bchImg.Size = new Size(anyImageWidth, anyImageHeight);
        }

        private void RoundedBTN(Button button)
        {
            //rounded cart button
            Rectangle Rect = new Rectangle(0, 0, button.Width, button.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 30, button.Height, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 31, Rect.Y, 30, button.Height, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 31, Rect.Y + Rect.Height - 30, 30, button.Height, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 30, 30, button.Height, 90, 90);
            button.Region = new Region(GraphPath);
        }

        private int AlingCenter(int obj1, int obj2)
        {
            return (obj1 - obj2) / 2;
        }

        private int AlingRight(int obj1, int obj2)
        {
            return obj1 - obj2;
        }
        private void ComponentLocation()
        {
            //background
            subBackground.Location = new Point(0, 0);
            subBackground2.Location = new Point(0, 0);

            //log banners and buttons
            logoutBTN.Location = new Point(0, 0);
            logInBTN.Location = new Point(AlingRight(bgWidth, anyBannerWidth), anyButtonHeight);
            logInBanner.Location = new Point(AlingRight(bgWidth, anyBannerWidth), 0);
            logInBannerBTN.Location = new Point(AlingRight(bgWidth, anyBannerWidth), signUpBannerBTN.Height + liBannerHeight);
            logInEnterBTN.Location = new Point(AlingRight(bgWidth, anyBannerWidth), liBannerHeight - logInEnterBTN.Height);

            //sign up banners and buttons
            signUpBanner.Location = new Point(AlingRight(bgWidth, anyBannerWidth), 0);
            signUpBannerBTN.Location = new Point(AlingRight(bgWidth, anyBannerWidth), 0);
            signUpBTN.Location = new Point(AlingRight(bgWidth, anyBannerWidth), 0);
            signUpEnterBTN.Location = new Point(AlingRight(bgWidth, anyBannerWidth), suBannerHeight - signUpEnterBTN.Height);

            //log textbox
            login_username.Location = new Point(AlingRight(bgWidth, anyBannerWidth), 90);
            login_password.Location = new Point(AlingRight(bgWidth, anyBannerWidth), login_username.Location.Y + login_password.Height * 3);

            //sign up textbox
            sUP_fullname.Location = new Point(AlingRight(bgWidth, anyBannerWidth), 90);
            sUP_phoneNumber.Location = new Point(AlingRight(bgWidth, anyBannerWidth), sUP_fullname.Location.Y + (sUP_phoneNumber.Height * 3));
            sUP_DNI.Location = new Point(AlingRight(bgWidth, anyBannerWidth), sUP_phoneNumber.Location.Y + sUP_DNI.Height * 3);
            sUP_email.Location = new Point(AlingRight(bgWidth, anyBannerWidth), sUP_DNI.Location.Y + sUP_email.Height * 3);
            sUP_username.Location = new Point(AlingRight(bgWidth, anyBannerWidth), sUP_email.Location.Y + sUP_username.Height * 3);
            sUP_password.Location = new Point(AlingRight(bgWidth, anyBannerWidth), sUP_username.Location.Y + sUP_password.Height * 3);

            //sign up confirmation message
            sUp_icon.Location = new Point(AlingCenter(bgWidth, sUp_icon.Width), AlingCenter(bgHeight, sUp_icon.Height));
            sUp_message.Location = new Point(AlingCenter(bgWidth, sUp_message.Width), sUp_icon.Height + AlingCenter(bgHeight, sUp_message.Height));

            //images
            //row1
            bairesImg.Location = new Point(30, 110);
            cbaImg1.Location = new Point(45 + anyImageWidth, 110);
            menImg.Location = new Point(60 + anyImageWidth * 2, 110);

            //row2
            cbaImg2.Location = new Point(30, 125 + anyImageHeight);
            bchImg.Location = new Point(45 + anyImageWidth, 125 + anyImageHeight);
            cbaImg3.Location = new Point(60 + anyImageWidth * 2, 125 + anyImageHeight);

            //image buttons
            //row1
            vuelo1.Location = new Point(30, 70 + anyImageHeight);
            vuelo2.Location = new Point(45 + anyImageWidth, 70 + anyImageHeight);
            vuelo3.Location = new Point(60 + anyImageWidth * 2, 70 + anyImageHeight);
            details1.Location = new Point(30, 50 + anyImageHeight);
            details2.Location = new Point(45 + anyImageWidth, 50 + anyImageHeight);
            details3.Location = new Point(60 + anyImageWidth * 2, 50 + anyImageHeight);
            cartBTN1.Location=new Point(bairesImg.Location.X, bairesImg.Location.Y-10);
            cartBTN2.Location = new Point(cbaImg1.Location.X, cbaImg1.Location.Y - 10);
            cartBTN3.Location = new Point(menImg.Location.X, menImg.Location.Y - 10);

            //row2
            vuelo4.Location = new Point(30, 85 + anyImageHeight * 2);
            vuelo5.Location = new Point(45 + anyImageWidth, 85 + anyImageHeight * 2);
            vuelo6.Location = new Point(60 + anyImageWidth * 2, 85 + anyImageHeight * 2);
            details4.Location = new Point(30, 65 + anyImageHeight * 2);
            details5.Location = new Point(45 + anyImageWidth, 65 + anyImageHeight * 2);
            details6.Location = new Point(60 + anyImageWidth * 2, 65 + anyImageHeight * 2);
            cartBTN4.Location = new Point(cbaImg2.Location.X, cbaImg2.Location.Y - 10);
            cartBTN5.Location = new Point(bchImg.Location.X,bchImg.Location.Y - 10);
            cartBTN6.Location = new Point(cbaImg3.Location.X, cbaImg3.Location.Y - 10);


        }

        private void signUp_Banner()
        {
            //show sign up banner
            logInBTN.Visible = false;
            signUpBTN.Visible = false;
            signUpBanner.Visible = true;
            signUpBannerBTN.Visible = true;
            signUpEnterBTN.Visible = true;
            sUP_DNI.Visible = true;
            sUP_email.Visible = true;
            sUP_fullname.Visible = true;
            sUP_password.Visible = true;
            sUP_phoneNumber.Visible = true;
            sUP_username.Visible = true;
        }

        private void logIn_Banner()
        {
            //fix login banner button
            logInBannerBTN.Location = new Point(AlingRight(bgWidth, anyBannerWidth), 0);

            //show log in banner
            signUpBTN.Visible = false;
            logInBTN.Visible = false;
            logInBanner.Visible = true;
            logInBannerBTN.Visible = true;
            login_username.Visible = true;
            login_password.Visible = true;
            logInEnterBTN.Visible = true;

            //hide signup confirmation
            sUp_icon.Visible = false;
            sUp_message.Visible = false;

        }

        private void hideAll()
        {
            //hide signup banner
            signUpBanner.Visible = false;
            signUpBannerBTN.Visible = false;
            signUpEnterBTN.Visible = false;
            sUP_DNI.Visible = false;
            sUP_email.Visible = false;
            sUP_fullname.Visible = false;
            sUP_password.Visible = false;
            sUP_phoneNumber.Visible = false;
            sUP_username.Visible = false;

            // hide login banner
            login_password.Visible = false;
            login_username.Visible = false;
            logInEnterBTN.Visible = false;
            logInBanner.Visible = false;
            logInBannerBTN.Visible = false;

            signUpBTN.Visible = true;

            if (logged == false)
            {
                logInBTN.Visible = true;
            }
            else
            {
                signUpBTN.Visible = false;
            }
        }

        private void logInBTN_Click(object sender, EventArgs e)
        {
            logIn_Banner();
        }

        private void signUpBTN_Click(object sender, EventArgs e)
        {
            signUp_Banner();
        }
        private void signUpEnterBTN_Click(object sender, EventArgs e)
        {

            //textbox validation
            if (sUP_phoneNumber.TextLength > 0 &&
                sUP_fullname.TextLength > 0 &&
                sUP_username.TextLength > 0 &&
                sUP_password.TextLength > 0 &&
                sUP_email.TextLength > 0 &&
                sUP_DNI.TextLength > 0)
            {
                //signed status
                signed = true;

                //registration
                fullname = sUP_fullname.Text;
                username = sUP_username.Text;
                password = sUP_password.Text;
                email = sUP_email.Text;
                dni = int.Parse(sUP_DNI.Text);
                phoneNumber = int.Parse(sUP_phoneNumber.Text);

                //hide banner
                hideAll();

                //show confirmation
                sUp_icon.Visible = true;
                sUp_message.Visible = true;
            }
            else
            {
                //do nothing :)
            }

        }

        private void logInBTN2_Click(object sender, EventArgs e)
        {
            logIn_Banner();
        }


        // hide banners hover bg        
        private void subBackground_MouseHover(object sender, EventArgs e)
        {
            hideAll();
        }

        private void logInEnterBTN_Click(object sender, EventArgs e)
        {


            //user and passwprd validation
            if (username == login_username.Text && password == login_password.Text)
            {
                //log status
                logged = true;

                //show selection menu
                details1.Visible = true;
                details2.Visible = true;
                details3.Visible = true;
                details4.Visible = true;
                details5.Visible = true;
                details6.Visible = true;
                cartBTN1.Visible = true;
                cartBTN2.Visible = true;
                cartBTN3.Visible = true;
                cartBTN4.Visible = true;
                cartBTN5.Visible = true;
                cartBTN6.Visible = true;
                openCart.Visible = true;
                displayName.Visible = true;
                subBackground2.Visible = true;
                logoutBTN.Visible = true;
                vuelo1.Visible = true;
                vuelo2.Visible = true;
                vuelo3.Visible = true;
                vuelo4.Visible = true;
                vuelo5.Visible = true;
                vuelo6.Visible = true;
                bairesImg.Visible = true;
                cbaImg1.Visible = true;
                cbaImg2.Visible = true;
                cbaImg3.Visible = true;
                menImg.Visible = true;
                bchImg.Visible = true;

                //hide main interface
                hideAll();
            }
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            // hide menu
            details1.Visible = false;
            details2.Visible = false;
            details3.Visible = false;
            details4.Visible = false;
            details5.Visible = false;
            details6.Visible = false;
            subBackground2.Visible = false;
            logoutBTN.Visible = false;
            vuelo1.Visible = false;
            vuelo2.Visible = false;
            vuelo3.Visible = false;
            vuelo4.Visible = false;
            vuelo5.Visible = false;
            vuelo6.Visible = false;
            bairesImg.Visible = false;
            cbaImg1.Visible = false;
            cbaImg2.Visible = false;
            cbaImg3.Visible = false;
            menImg.Visible = false;
            bchImg.Visible = false;
            cartBTN1.Visible = false;

            //delete user
            fullname = "";
            logged = false;
            signed = false;
            username = "";
            password = "";
            email = "";
            dni = 0;
            phoneNumber = 0;
        }

        private void cbaImg1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
