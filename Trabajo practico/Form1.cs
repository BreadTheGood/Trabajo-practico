using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Trabajo_practico
{
    public partial class Form1 : Form
    {
        //variables        
        Boolean logged = false;        
        string fullname = ""; //no se usa pero es necesaria para el registro
        string username = "";
        string password = "";
        string email = "";//no se usa pero es necesaria para el registro       
        string dni = "0";//no se usa pero es necesaria para el registro
        string phoneNumber="";//no se usa pero es necesaria para el registro     
        double precioPesos = 0;
        int puntos = 0;
        int arroba = 0;
        int logTries = 0;

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
            ComponentSize();
            ComponentLocation();


        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            exitNO.Size = new Size(100,40);
            exitYES.Size = exitNO.Size;

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

            sUp_icon.Size = new Size(150, 150);

            //cart menu
            vueloMenu.Size = new Size(266, 473);
            vAmount.Size = new Size(vueloMenu.Width, 35);
            vFecha.Size = new Size(vueloMenu.Width, 35);
            vPasajes.Size = new Size(vueloMenu.Width, 35);
            agregarBTN.Size = new Size(vueloMenu.Width, 40);
            vueloText.Size = new Size(142, 16);
            fechaText.Size = new Size(142, 16);
            pasajesText.Size = new Size(142, 16);

            //compra menu 
            compraMenu.Size = vueloMenu.Size;
            nPasajes.Size = new Size(compraMenu.Width, 70);
            montoPesos.Size = new Size(compraMenu.Width, 80);
            iva.Size = new Size(compraMenu.Width, 25);
            pagarBTN.Size = new Size(compraMenu.Width, 40);

            //messages
            invalidMsg.Size = new Size(400, 200);
            paidMsg.Size = new Size(300, 150);
            exitMsg.Size = new Size(300, 150);

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
            login_username.Location = new Point(AlingRight(bgWidth, anyBannerWidth), 60);
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
            cartBTN1.Location = new Point(bairesImg.Location.X, bairesImg.Location.Y - 10);
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
            cartBTN5.Location = new Point(bchImg.Location.X, bchImg.Location.Y - 10);
            cartBTN6.Location = new Point(cbaImg3.Location.X, cbaImg3.Location.Y - 10);

            //cart menu
            vueloMenu.Location = new Point(474, 69);
            vAmount.Location = new Point(474, 250);
            vFecha.Location = new Point(474, 350);
            vPasajes.Location = new Point(474, 450);
            agregarBTN.Location = new Point(474, 542);
            vueloText.Location = new Point(vueloMenu.Location.X + AlingCenter(vueloMenu.Width, vueloText.Width), vAmount.Height + vAmount.Location.Y);
            fechaText.Location = new Point(vueloMenu.Location.X + AlingCenter(vueloMenu.Width, fechaText.Width), vFecha.Height + vFecha.Location.Y);
            pasajesText.Location = new Point(vueloMenu.Location.X + AlingCenter(vueloMenu.Width, pasajesText.Width), vPasajes.Height + vPasajes.Location.Y);

            //pagar menu
            compraMenu.Location = new Point(474, 69);
            nPasajes.Location = new Point(compraMenu.Location.X, 240);
            montoPesos.Location = new Point(compraMenu.Location.X, 370);
            iva.Location = new Point(compraMenu.Location.X, 542 - iva.Height);
            pagarBTN.Location = new Point(474, 542);

            //messages
            invalidMsg.Location = new Point(AlingCenter(subBackground.Width, invalidMsg.Width), AlingCenter(subBackground.Height, invalidMsg.Height));
            paidMsg.Location = new Point(AlingCenter(subBackground.Width, paidMsg.Width), AlingCenter(subBackground.Height, paidMsg.Height));
            exitMsg.Location = new Point(AlingCenter(subBackground.Width, exitMsg.Width), AlingCenter(subBackground.Height, exitMsg.Height));

            //yes/no btn
            exitYES.Location = new Point(exitMsg.Location.X + 15, exitMsg.Location.Y + (exitMsg.Height - exitYES.Height - 15));
            exitNO.Location = new Point(exitMsg.Location.X +(exitMsg.Width-exitNO.Width- 15), exitMsg.Location.Y + (exitMsg.Height - exitNO.Height - 15));
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

        private void hideCart()
        {
            vueloMenu.Visible = false;
            vAmount.Visible = false;
            vFecha.Visible = false;
            vPasajes.Visible = false;
            agregarBTN.Visible = false;
            vueloText.Visible = false;
            fechaText.Visible = false;
            pasajesText.Visible = false;

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

            invalidMsg.Visible = false;
        }

        private void hideVuelo()
        {
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
            cartBTN2.Visible = false;
            cartBTN3.Visible = false;
            cartBTN4.Visible = false;
            cartBTN5.Visible = false;
            cartBTN6.Visible = false;
            openCart.Visible = false;
        }

        private void DisplayCart()
        {
            invalidMsg.Text = "";
            vAmount.Visible = true;
            vFecha.Visible = true;
            vPasajes.Visible = true;
            agregarBTN.Visible = true;
            vueloText.Visible = true;
            fechaText.Visible = true;
            pasajesText.Visible = true;
            vueloMenu.Visible = true;

            vuelo1.Visible = false;
            vuelo2.Visible = false;
            vuelo3.Visible = false;
            vuelo4.Visible = false;
            vuelo5.Visible = false;
            vuelo6.Visible = false;

            cbaImg1.Visible = false;
            cbaImg2.Visible = false;
            cbaImg3.Visible = false;
            bairesImg.Visible = false;
            menImg.Visible = false;
            bchImg.Visible = false;

            cartBTN1.Visible = false;
            cartBTN2.Visible = false;
            cartBTN3.Visible = false;
            cartBTN4.Visible = false;
            cartBTN5.Visible = false;
            cartBTN6.Visible = false;

            details1.Visible = false;
            details2.Visible = false;
            details3.Visible = false;
            details4.Visible = false;
            details5.Visible = false;
            details6.Visible = false;

        }
        
        private void Validos(string vuelo, string fecha, string pasaje)
        {

            string vuelos = "";
            string fechas = "";
            string pasajes = "";


            if (int.Parse(vuelo) < 1 || int.Parse(vuelo) > 6)
            {
                vuelos ="Número de vuelo no válido";
            }

            if (fecha != "" && fecha.Length >= 8)
            {
                if (DateTime.Parse(fecha) < DateTime.Now)
                {
                    fechas = "\nFecha ingresada no válida";
                }
            }

            if (int.Parse(pasaje) > 10)
            {
                pasajes = "\nCantidad de pasajes no válida";

            } else if(int.Parse(pasaje) == 0 || pasaje =="")
            {
                pasajes = "\nNo has agregado ningún pasaje";
            }



            invalidMsg.Text = vuelos + fechas + pasajes;
        }

        private double precioPasajes(string destino, string cantidad)
        {
            switch (int.Parse(destino))
            {

                case 1:

                    precioPesos = 43700 * int.Parse(cantidad) + ((43700 * int.Parse(cantidad)) / 100) * 10.5;

                    break;

                case 2:

                    precioPesos = 43700 * int.Parse(cantidad) + ((43700 * int.Parse(cantidad)) / 100) * 10.5;

                    break;

                case 3:

                    precioPesos = 52000 * int.Parse(cantidad) + ((52000 * int.Parse(cantidad)) / 100) * 10.5;

                    break;

                case 4:

                    precioPesos = 52000 * int.Parse(cantidad) + ((52000 * int.Parse(cantidad)) / 100) * 10.5;

                    break;

                case 5:

                    precioPesos = 183000 * int.Parse(cantidad) + ((183000 * int.Parse(cantidad)) / 100) * 10.5;

                    break;

                case 6:

                    precioPesos = 183000 * int.Parse(cantidad) + ((183000 * int.Parse(cantidad)) / 100) * 10.5;

                    break;

            }



            return precioPesos;
        }

        private int AlingCenter(int obj1, int obj2)
        {
            return (obj1 - obj2) / 2;
        }

        private int AlingRight(int obj1, int obj2)
        {
            return obj1 - obj2;
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

        private void logInBTN_Click(object sender, EventArgs e)
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

            hideCart();
        }

        private void signUpBTN_Click(object sender, EventArgs e)
        {
            signUp_Banner();
        }

        private void validMail()
        {            
            foreach (char letra in sUP_email.Text)
            {
                if(letra == '.')
                {
                    puntos++;
                }

                if(letra == '@')
                {
                    arroba++;
                }                               
            }
        }

        private void signUpEnterBTN_Click(object sender, EventArgs e)
        {
            validMail();

            //textbox validation
            if (puntos>0 && arroba>0)
            {
                //registration
                fullname = sUP_fullname.Text;
                username = sUP_username.Text;
                password = sUP_password.Text;
                email = sUP_email.Text;
                dni = sUP_DNI.Text;
                phoneNumber = sUP_phoneNumber.Text;

                //hide banner
                hideAll();

                //show confirmation
                sUp_icon.Visible = true;
                sUp_message.Visible = true;

                displayName.Text = $"Hola,{username}!";
            }
            else
            {
                invalidMsg.Text = "Mail no valido";
                invalidMsg.Visible = true;
            }
        }
             
        private void subBackground_MouseHover(object sender, EventArgs e)
        {
            hideAll();
        }

        private void DisplayVuelos()
        {
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
            invalidMsg.Visible = false;
        }

        private void logInEnterBTN_Click(object sender, EventArgs e)
        {
            logTries++;
            //user and password validation
            if (login_password.Text != "" && login_username.Text != "")
            {

                if (username == login_username.Text && password == login_password.Text)
                {
                    //log status
                    logged = true;

                    DisplayVuelos();

                    //hide main interface
                    hideAll();
                }
                
                
            }             
            
            if (logTries > 3)
            {
                invalidMsg.Text = "Has superado el limite de intentos";
                invalidMsg.Visible = true;
            }

            if (logTries <= 3 && username != login_username.Text)
            {
                invalidMsg.Text = "El usuario ingresado no se encuentra registrado";
                invalidMsg.Visible = true;
            }
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            // hide vuelos menu

            displayName.Visible = false;

            hideVuelo();

            //hide cart menu

            hideCart();

            nPasajes.Visible = false;
            iva.Visible = false;
            montoPesos.Visible = false;
            pagarBTN.Visible = false;
            compraMenu.Visible = false;

            //delete user
            fullname = "";
            logged = false;
            username = "";
            password = "";
            email = "";
            dni = "";
            phoneNumber = "";
            puntos = 0;
            arroba = 0;
            logTries = 0;
        }            
               
        private void vuelo1_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void cartBTN1_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void vuelo4_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void vuelo2_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void vuelo5_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void vuelo3_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void vuelo6_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void cartBTN3_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void cartBTN2_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void cartBTN5_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void cartBTN6_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void cartBTN4_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void openCart_Click(object sender, EventArgs e)
        {
            DisplayCart();
        }

        private void pagarBTN_Click(object sender, EventArgs e)
        {
            paidMsg.Visible = true;
            nPasajes.Visible = false;
            iva.Visible = false;
            montoPesos.Visible = false;
            pagarBTN.Visible = false;
            compraMenu.Visible = false;

        }

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            Validos(vueloText.Text, fechaText.Text, pasajesText.Text);

            if (invalidMsg.Text == "")
            {
                hideCart();
                invalidMsg.Visible = false;
                nPasajes.Visible = true;
                iva.Visible = true;
                montoPesos.Visible = true;
                pagarBTN.Visible = true;
                compraMenu.Visible = true;

                nPasajes.Text = "CANTIDAD DE PASAJES: " + pasajesText.Text;
                montoPesos.Text = "MONTO A PAGAR EN PESOS: " + precioPasajes(vueloText.Text, pasajesText.Text);
            }
            else
            {
                hideCart();
                invalidMsg.Visible = true;
            }

        }

        private void invalidDate_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                vueloText.Text = string.Empty;
                pasajesText.Text = string.Empty;
                fechaText.Text = string.Empty;
                DisplayCart();
            }
            
            invalidMsg.Visible = false;
        }

        private void paidMsg_Click(object sender, EventArgs e)
        {
            paidMsg.Visible = false;
            exitNO.Visible = true;
            exitYES.Visible = true;
            exitMsg.Visible = true;
        }

        private void exitYES_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitNO_Click(object sender, EventArgs e)
        {
            exitYES.Visible = false;
            exitNO.Visible = false;
            exitMsg.Visible=false;

            DisplayVuelos();

            fechaText.Text= string.Empty;
            pasajesText.Text = string.Empty;
            vueloText.Text = string.Empty;

        }
    }
}
