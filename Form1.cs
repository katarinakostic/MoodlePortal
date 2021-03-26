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

            if (adminUsername.Text.Length < 1 || password.Text.Length < 1)
            {
                MessageBox.Show("Niste uneli sve podatke!");

            }
            //else if (adminUsername.Text == "admin" || password.Text == "admin")
            else if(RadSaBazom.checkUser(adminUsername.Text.ToString(), password.Text.ToString()))
            {
                MessageBox.Show("Uspesno ste se ulogovali kao admin!");

                Form forma = new AdminForm();
                this.Hide();
                forma.ShowDialog();
                this.Close(); 
                //GenSaltSHA256();

            }
            else
            {
                MessageBox.Show("Pogresan format!");
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
