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
        public Student currentStudent = null;
        byte[] img = null;

        //public Dictionary<int, string> studenti = new Dictionary<int, string>();
        AdminForm forma;

        public UCStudent(AdminForm forma)
        {
            InitializeComponent();
            this.forma = forma;
            listViewStudenti.Hide();
        }

        private void LoadAll()
        {
            List<Student> studenti = RadSaBazomStudent.SpisakStudenata();

            if (listViewStudenti.Visible == true)
                listViewStudenti.Clear();

            /* if (RadSaBazom.nadjiStudenta(639))
                MessageBox.Show("639 Postojii"); //PROVERA
            else
                MessageBox.Show("639 Ne postoji"); */
            if (studenti.Count > 0)
            {
                listViewStudenti.Show();
                foreach (Student s in studenti)
                {
                    ListViewItem item = new ListViewItem(s.Person_id.ToString() + ", " + s.Ime + ", " + s.Prezime + ", " + s.Email);
                    item.Tag = s;
                    listViewStudenti.Items.Add(item);

                    //listViewStudenti.Items.Add(podaci);
                    //MessageBox.Show(prepisaniLekoviRecnik.Keys[0]);
                }
            }
            else
            {
                MessageBox.Show("Nema studenata!");
                //forma.Controls.Add(prethodniProzor);

            }
        }
        private void prikaziStudenteBtn_Click(object sender, EventArgs e)
        {

            LoadAll();           
            
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

            if(RadSaBazomStudent.nadjiStudenta(br_indeksa))
            {
                MessageBox.Show("Ovaj student je vec u bazi!");
                return;
            }
            //if (RadSaBazom.Insert(br_indeksa, ime, prezime, email))
            //    MessageBox.Show("Uspesno uneti podaci!");
            String username = ime + br_indeksa; //PROMENI
            SecurityLogin secLog = new SecurityLogin();
            if (RadSaBazom.InsertPerson(br_indeksa))
            {
                if (RadSaBazomStudent.Insert(br_indeksa, ime, prezime, email))
                    if (RadSaBazomLogin.InsertLoginData(username, secLog.GenSaltSHA256(username), 2, br_indeksa))
                    {
                        if (img != null)
                            RadSaBazomStudent.sacuvajFotografiju(img, br_indeksa);
                        currentStudent = new Student(br_indeksa, ime, prezime, email);
                        MessageBox.Show("Uspesno uneti podaci!");
                        if (!listViewStudenti.Visible)
                            listViewStudenti.Show();
                        LoadAll();
                    }
            }
            else
                MessageBox.Show("Greska!");

         /*   if (listViewStudenti.Visible == true)
            {
                Student s = RadSaBazomStudent.podaciOStudentu(br_indeksa);
                listViewStudenti.Items.Add(s.Person_id.ToString() + ", " + s.Ime + ", " + s.Prezime + ", " + s.Email);
            } */
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
            if (RadSaBazomStudent.nadjiStudenta(br_indeksa))
            {
                if (RadSaBazom.Obrisi(br_indeksa))
                {
                    MessageBox.Show("Uspesno obrisan student!");
                    LoadAll();
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
            if (RadSaBazomStudent.nadjiStudenta(br_indeksa))
            {
                List<Student> studenti = RadSaBazomStudent.SpisakStudenata();
                foreach(Student s in studenti)
                    if(s.Person_id==br_indeksa)
                    {
                listViewStudenti.Items.Add(s.Person_id.ToString() + ", " + s.Ime + ", " + s.Prezime + ", " + s.Email);
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
                img = ms.ToArray();

              /*  int br_indeksa;
                if (brindeksaBox.Text.Length > 0)
                    br_indeksa = int.Parse(brindeksaBox.Text.ToString());
                else
                {
                    MessageBox.Show("Unesite broj indeksa!");
                    return;
                }          */     
                //RadSaBazomStudent.sacuvajFotografiju(img, br_indeksa);
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            forma.Controls.Remove(this);
            forma.Controls.Add(new UCTeacherCrud(forma));
        }

        private void listViewStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudenti.SelectedItems.Count == 0)
                return;

            ListViewItem item = listViewStudenti.SelectedItems[0];
            currentStudent = (Student)item.Tag;

            Form forma = new StudentProfil(currentStudent);
            forma.ShowDialog();

            /*       String u = currentuser.Username;
                   String p = currentuser.Password;

                   usernameTxt.Text = u;
                   passTxt.Text = p; */
        }
    }
}
