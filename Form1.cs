using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MoodlePortal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginAsAdmin_Click(object sender, EventArgs e)
        {
            SecurityLogin secLog = new SecurityLogin();

            String uname_input = adminUsername.Text.ToString();
            String pass_input = password.Text.ToString();
            //String check_pass = secLog.CheckValue(uname_input, pass_input); //na osnovu unetog passworda, generise se hash vrednost koja se spaja sa salt-om iz baze i proverava se da li se ta vrednost poklapa sa passwordom u bazi
            //MessageBox.Show(check_pass + "uneti pass - hash"); //ovo radi


            if (uname_input.Length < 1 || pass_input.Length < 1)
            {
                MessageBox.Show("Niste uneli sve podatke!");

            }

            else if(RadSaBazom.checkUser(uname_input, secLog.CheckValue(uname_input, pass_input)))
            {
                //provera tipa naloga : da li se ulogovao admin, student ili nastavnik (1, 2, 3)
                //zameni za switch posle
                Form forma;

                switch (RadSaBazom.GetAccountType(adminUsername.Text.ToString()))
                {
                    case 1: //ovo treba da bude 1, promeni vr u bazi
                        MessageBox.Show("Uspesno ste se ulogovali kao admin!");

                        forma = new AdminForm();
                        this.Hide();
                        forma.ShowDialog();
                        this.Close();
                        break;
                    case 2:
                        MessageBox.Show("Uspesno ste se ulogovali kao student!");
                        break;
                    case 3:
                        MessageBox.Show("Uspesno ste se ulogovali kao nastavnik!");
                        break;
                    default:
                        MessageBox.Show("Greska!");
                        break;
                }

                //GenSaltSHA256();

            }
            else
            {
                MessageBox.Show("Netacan username ili password!");
            }
        }

        bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }

        private void izlazBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
/*        private void GenSaltSHA256()
        {
            String salt = CreateSalt(10);
            String hashed_password = GenerateSHA256Hash(password.Text.ToString(), salt);

            saltBox.Text = salt.Length.ToString();
            hashBox.Text = hashed_password;
        }

        public String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public String GenerateSHA256Hash(String input, String salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();

            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
            //return hash.ToString();
        }
        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        } */
    }
}
