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
    }
}
