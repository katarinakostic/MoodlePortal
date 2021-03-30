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
    public partial class NastavnikProfil : Form
    {
        Nastavnik nastavnik;
        public NastavnikProfil(Nastavnik currentTeacher)
        {
            InitializeComponent();

            this.nastavnik = currentTeacher;

            updatePnl.Visible = false;
            LoadAll();

        }
        private void LoadAll()
        {
            jmbgLbl.Text = "Jmbg: " + nastavnik.Person_id.ToString();
            imeLbl.Text = "Ime: " + nastavnik.Ime;
            prezimeLbl.Text = "Prezime: " + nastavnik.Prezime;
            emailLbl.Text = "Email adresa : " + nastavnik.Email;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izmeniBtn_Click(object sender, EventArgs e)
        {
            updatePnl.Visible = true;
        }

        private void updateSaveBtn_Click(object sender, EventArgs e)
        {
            String newName = imeBox.Text.ToString();
            String newSurname = prezimeBox.Text.ToString();
            String newEmail = emailBox.Text.ToString();
            if (String.IsNullOrEmpty(newName) && String.IsNullOrEmpty(newSurname) && String.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Nisu uneti novi podaci!");
                return;
            }
            Dictionary<String, bool> update = new Dictionary<string, bool>();
            if (String.IsNullOrEmpty(newName))
                update.Add("ime", false);
            else
                update.Add("ime", true);
            if (String.IsNullOrEmpty(newSurname))
                update.Add("prezime", false);
            else
                update.Add("prezime", true);
            if (String.IsNullOrEmpty(newEmail))
                update.Add("email", false);
            else
                update.Add("email", true);

            //if (RadSaBazomStudent.UpdateStudent(student.Person_id, update, newName, newSurname, newEmail, godinaStudija, ref student))
            if(RadSaBazomNastavnik.UpdateNastavnik(update, newName, newSurname, newEmail, ref nastavnik))
            {
                MessageBox.Show("Uspesno izmenjeni podaci!");
                LoadAll(); //pogledaj gde treba ovo da bi se update-ovala lista nakon izmene
                updatePnl.Hide();
            }
            else
                MessageBox.Show("Greska!");
        }
    }
}
