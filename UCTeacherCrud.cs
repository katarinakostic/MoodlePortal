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
        public Dictionary<long, string> nastavnici = new Dictionary<long, string>();
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
                if (RadSaBazomNastavnik.Insert(jmbg, ime, prezime, email))
                    if (RadSaBazomLogin.InsertLoginData(username, secLog.GenSaltSHA256(username), 3, jmbg))
                        MessageBox.Show("Uspesno uneti podaci!");
            }
            else
                MessageBox.Show("Greska!");

            if (listViewNastavnici.Visible == true)
            {
                String podacionastavniku = RadSaBazomNastavnik.podaciONastavniku(jmbg);
                listViewNastavnici.Items.Add(podacionastavniku);
            }
        }

        private void prikaziNastavnikeBtn_Click(object sender, EventArgs e)
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
                foreach (String podaci in nastavnici.Values)
                {

                    listViewNastavnici.Items.Add(podaci);
                    //MessageBox.Show(prepisaniLekoviRecnik.Keys[0]);
                }
            }
            else
            {
                MessageBox.Show("Nema nastavnika!");
                //forma.Controls.Add(prethodniProzor);

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
                Dictionary<long, String> nastavnici = RadSaBazomNastavnik.SpisakNastavnika();
                foreach (var v in nastavnici)
                    if (v.Key == jmbg)
                    {
                        listViewNastavnici.Items.Add(v.Value);
                        break;
                    }

                //String podaciOStudentu = RadSaBazom.podaciOStudentu(br_indeksa);
                //listViewStudenti.Items.Add(podaciOStudentu);

            }
            else
                MessageBox.Show("Ne postoji nastavnik sa ovim jmbg-om!");
        }
    }
}
