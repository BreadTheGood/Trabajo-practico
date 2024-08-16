namespace Trabajo_practico
{
    public partial class VuelosWin : Form
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

        public VuelosWin()
        {
            InitializeComponent();
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
            sUp_img.Visible = false;
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


            if (signed == false)
            {
                // hide login banner
                login_password.Visible = false;
                login_username.Visible = false;
                logInEnterBTN.Visible = false;
                logInBanner.Visible = false;
                logInBannerBTN.Visible = false;
                signUpBTN.Visible = true;

            }

            if (logged == false)
            {
                logInBTN.Visible = true;
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
                sUp_img.Visible = true;
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


        // hide banners when click or hover bg
        private void subBackground_Click(object sender, EventArgs e)
        {
            hideAll();
        }

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
                sub_Background2.Visible = true;
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
            sub_Background2.Visible = false;
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
    }
}
