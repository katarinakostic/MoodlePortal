using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodlePortal
{
    public partial class UCTeacherCrud : UserControl
    {
        AdminForm form;
        //public Dictionary<long, string> nastavnici = new Dictionary<long, string>();
        List<Nastavnik> nastavnici = new List<Nastavnik>();
        public Nastavnik currentTeacher = null;
        byte[] img = null;
        public UCTeacherCrud(AdminForm form)
        {
            InitializeComponent();
            this.form = form;
            listViewNastavnici.Hide();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            long jmbg;
            String ime, prezime, email;
            nastavnici = RadSaBazomNastavnik.SpisakNastavnika();
            if (jmbgBox.Text.Length > 0)
                jmbg = Int64.Parse(jmbgBox.Text.ToString());
                //if (long.TryParse(jmbgBox.Text.ToString()))
                   // jmbg = long.TryParse(jmbgBox.Text.ToString());
                else
                {
                    MessageBox.Show("Unesite jmbg!");
                    return;
                }
            ime = imeBox.Text.ToString();
            prezime = prezimeBox.Text.ToString();
            email = emailBox.Text.ToString();

            if (RadSaBazomNastavnik.nadjiNastavnika(jmbg))
            {
                MessageBox.Show("Ovaj nastavnik je vec u bazi!");
                return;
            }
            //if (RadSaBazom.Insert(jmbg, ime, prezime, email))
            //    MessageBox.Show("Uspesno uneti podaci!");
            String username = ime + jmbg; //PROMENI
            SecurityLogin secLog = new SecurityLogin();


            if (RadSaBazom.InsertPerson(jmbg))
            {
                if (RadSaBazomNastavnik.Insert(jmbg, ime, prezime, email, img))
                    if (RadSaBazomLogin.InsertLoginData(username, secLog.GenSaltSHA256(username), 3, jmbg))
                    {
                        //if (img != null)
                        //    RadSaBazomNastavnik.sacuvajFotografiju(img, jmbg);
                        currentTeacher = new Nastavnik(jmbg, ime, prezime, email, img);
                        MessageBox.Show("Uspesno uneti podaci!");
                        if (!listViewNastavnici.Visible)
                            listViewNastavnici.Show();
                        LoadAll();
                    }
            }
            else
                MessageBox.Show("Greska!");

        }

        private void prikaziNastavnikeBtn_Click(object sender, EventArgs e)
        {
            LoadAll();            
        }

        private void LoadAll()
        {
            if (listViewNastavnici.Visible == true)
                listViewNastavnici.Clear();

            nastavnici = RadSaBazomNastavnik.SpisakNastavnika();
            /* if (RadSaBazom.nadjiStudenta(639))
                MessageBox.Show("639 Postojii"); //PROVERA
            else
                MessageBox.Show("639 Ne postoji"); */
            if (nastavnici.Count > 0)
            {
                listViewNastavnici.Show();
                foreach (Nastavnik n in nastavnici)
                {

                    ListViewItem item = new ListViewItem(n.Person_id.ToString() + ", " + n.Ime + ", " + n.Prezime + ", " + n.Email);
                    item.Tag = n;
                    listViewNastavnici.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nema nastavnika!");

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            long jmbg;

            if (jmbgDeleteTxt.Text.Length > 0)
                jmbg = Int64.Parse(jmbgDeleteTxt.Text.ToString());
            else
            {
                MessageBox.Show("Unesite jmbg!");
                return;
            }
            if (RadSaBazomNastavnik.nadjiNastavnika(jmbg))
            {
                if (RadSaBazom.Obrisi(jmbg))
                {
                    MessageBox.Show("Uspesno obrisan nastavnik!");
                    LoadAll();
                }
                else
                {
                    MessageBox.Show("Doslo je do greske prilikom brisanja nastavnika iz baze!");
                    return;
                }
            }
            else
                MessageBox.Show("Ne postoji nastavnik sa ovim jbmg-om!");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            listViewNastavnici.Clear();
            long jmbg;

            if (jmbgSearchBox.Text.Length > 0)
                jmbg = Int64.Parse(jmbgSearchBox.Text.ToString());
            else
            {
                MessageBox.Show("Unesite jmbg!");
                return;
            }
            if (RadSaBazomNastavnik.nadjiNastavnika(jmbg))
            {
                nastavnici = RadSaBazomNastavnik.SpisakNastavnika();
                foreach (Nastavnik n in nastavnici)
                    if (n.Person_id == jmbg)
                    {
                        listViewNastavnici.Items.Add(n.Person_id.ToString() + ", " + n.Ime + ", " + n.Prezime + ", " + n.Email);
                        break;
                    }

                //String podaciOStudentu = RadSaBazom.podaciOStudentu(br_indeksa);
                //listViewStudenti.Items.Add(podaciOStudentu);

            }
            else
                MessageBox.Show("Ne postoji nastavnik sa ovim jmbg-om!");
        }

        private void listViewNastavnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNastavnici.SelectedItems.Count == 0)
                return;

            ListViewItem item = listViewNastavnici.SelectedItems[0];
            currentTeacher = (Nastavnik)item.Tag;


            Form forma = new NastavnikProfil(currentTeacher);
            forma.ShowDialog();
        }
    }
}
