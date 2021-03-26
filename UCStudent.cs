using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

using System.Security.Cryptography;

namespace MoodlePortal
{
    public partial class UCStudent : UserControl
    {
        public Dictionary<int, string> studenti = new Dictionary<int, string>();
        AdminForm forma;

        public UCStudent(AdminForm forma)
        {
            InitializeComponent();
            this.forma = forma;
            listViewStudenti.Hide();
        }

        private void prikaziStudenteBtn_Click(object sender, EventArgs e)
        {
            if (listViewStudenti.Visible == true)
                listViewStudenti.Clear();
            
            studenti = RadSaBazom.SpisakStudenata();
            /* if (RadSaBazom.nadjiStudenta(639))
                MessageBox.Show("639 Postojii"); //PROVERA
            else
                MessageBox.Show("639 Ne postoji"); */
            if (studenti.Count > 0)
            {
                listViewStudenti.Show();
                foreach (String podaci in studenti.Values)
                {

                     listViewStudenti.Items.Add(podaci);
                     //MessageBox.Show(prepisaniLekoviRecnik.Keys[0]);
                }
            }
            else
            {
                 MessageBox.Show("Nema studenata!");
                    //forma.Controls.Add(prethodniProzor);

            }
            
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            int br_indeksa;
            String ime, prezime, email;
            if (brindeksaBox.Text.Length > 0)
                br_indeksa = int.Parse(brindeksaBox.Text.ToString());
            else
            {
                MessageBox.Show("Unesite broj indeksa!");
                return;
            }
            ime = imeBox.Text.ToString();
            prezime = prezimeBox.Text.ToString();
            email = emailBox.Text.ToString();

            if(RadSaBazom.nadjiStudenta(br_indeksa))
            {
                MessageBox.Show("Ovaj student je vec u bazi!");
                return;
            }
            //if (RadSaBazom.Insert(br_indeksa, ime, prezime, email))
            //    MessageBox.Show("Uspesno uneti podaci!");
            String username = ime + br_indeksa; //PROMENI
            SecurityLogin secLog = new SecurityLogin();

            if (RadSaBazom.Insert(br_indeksa, ime, prezime, email) && RadSaBazom.InsertLoginData(br_indeksa, username, secLog.GenSaltSHA256(username), 2))
                MessageBox.Show("Uspesno uneti podaci!");
            else
                        MessageBox.Show("Greska!");

            if (listViewStudenti.Visible == true)
            {
                String podaciostudentu = RadSaBazom.podaciOStudentu(br_indeksa);
                listViewStudenti.Items.Add(podaciostudentu);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int br_indeksa;

            if (indeksDeleteTxt.Text.Length>0)
                br_indeksa = int.Parse(indeksDeleteTxt.Text.ToString());
            else
            {
                MessageBox.Show("Unesite broj indeksa!");
                return;
            }
            if (RadSaBazom.nadjiStudenta(br_indeksa))
            {
                if (RadSaBazom.Obrisi(br_indeksa))
                {
                    MessageBox.Show("Uspesno obrisan student!");
                }
                else
                {
                    MessageBox.Show("Doslo je do greske prilikom brisanja studenta iz baze!");
                    return;
                }
            }
            else
                MessageBox.Show("Ne postoji student sa tim brojem indeksa!");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
            listViewStudenti.Clear();
            int br_indeksa;

            if (indeksSearchBox.Text.Length > 0)
                br_indeksa = int.Parse(indeksSearchBox.Text.ToString());
            else
            {
                MessageBox.Show("Unesite broj indeksa!");
                return;
            }
            if (RadSaBazom.nadjiStudenta(br_indeksa))
            {
                Dictionary<int, String> studenti = RadSaBazom.SpisakStudenata();
                foreach(var v in studenti)
                    if(v.Key==br_indeksa)
                    {
                listViewStudenti.Items.Add(v.Value);
                         break;
                     }

                //String podaciOStudentu = RadSaBazom.podaciOStudentu(br_indeksa);
                //listViewStudenti.Items.Add(podaciOStudentu);

            }
            else
                MessageBox.Show("Ne postoji student sa tim brojem indeksa!");
            
        }

        private void imageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                int br_indeksa;
                if (brindeksaBox.Text.Length > 0)
                    br_indeksa = int.Parse(brindeksaBox.Text.ToString());
                else
                {
                    MessageBox.Show("Unesite broj indeksa!");
                    return;
                }

                RadSaBazom.sacuvajFotografiju(img, br_indeksa);
            }
        }
        
        /*
        private String GenSaltSHA256(String pass_input)
        {
            String salt = CreateSalt(10);
            String hashed_password = salt.Substring(0,8)+GenerateSHA256Hash(pass_input, salt)+salt.Substring(8,8);

            //saltBox.Text = salt;
            //hashBox.Text = hashed_password;

            return hashed_password;
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
