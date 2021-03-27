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
        public UCTeacherCrud(AdminForm form)
        {
            InitializeComponent();
            this.form = form;
            listViewNastavnici.Hide();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            int jmbg;
            String ime, prezime, email;
            if (jmbgBox.Text.Length > 0)
                jmbg = int.Parse(jmbgBox.Text.ToString());
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

            if (RadSaBazomNastavnik.Insert(jmbg, ime, prezime, email) && RadSaBazomNastavnik.InsertLoginData(jmbg, username, secLog.GenSaltSHA256(username), 3))
                MessageBox.Show("Uspesno uneti podaci!");
            else
                MessageBox.Show("Greska!");

            if (listViewNastavnici.Visible == true)
            {
                String podacionastavniku = RadSaBazomNastavnik.podaciONastavniku(jmbg);
                listViewNastavnici.Items.Add(podacionastavniku);
            }
        }
    }
}
