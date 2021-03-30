using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodlePortal
{
    public partial class StudentProfil : Form
    {
        Student student;
        public StudentProfil(Student currentStudent)
        {
            InitializeComponent();

            this.student = currentStudent;

            updatePnl.Visible = false;

            LoadAll();
         //   MemoryStream stream = new MemoryStream(student.Fotogtafija);
         //   pictureBox1.Image = System.Drawing.Image.FromStream(stream);
            //stream.Position = 0;
            //pictureBox1.Image = Image.FromStream(stream);
        }

        private void LoadAll()
        {
            brindeksaLbl.Text = "Broj indeksa: " + student.Person_id.ToString();
            imeLbl.Text = "Ime: " + student.Ime;
            prezimeLbl.Text = "Prezime: " + student.Prezime;
            emailLbl.Text = "Email adresa : " + student.Email;
            godinaUpisaLbl.Text = "Godina upisa : " + student.godina_upisa.ToString();
            upisanaGodinaLbl.Text = "Upisana godina : " + student.godina_studija.ToString();
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
            int godinaStudija;
            int.TryParse(godinaStudijaBox.Text.ToString(), out godinaStudija);

            if (String.IsNullOrEmpty(newName) && String.IsNullOrEmpty(newSurname) && String.IsNullOrEmpty(newEmail) && !int.TryParse(godinaStudijaBox.Text.ToString(), out godinaStudija))
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
            if(!int.TryParse(godinaStudijaBox.Text.ToString(), out godinaStudija))
                update.Add("godinaStudija", false);
            else
                update.Add("godinaStudija", true);
            /*
            String provera = "";
            if (update["ime"])
            {
                provera +=newName;
            }
            if (update["prezime"])
            {
                provera +=newSurname;
            }
            if (update["email"])
            {
                provera +=newEmail;
            }
            if (update["godinaStudija"])
            {
                provera +=godinaStudija.ToString();
            }
            MessageBox.Show(provera); */

                      if (RadSaBazomStudent.UpdateStudent(student.Person_id, update, newName, newSurname, newEmail, godinaStudija, ref student))
                      {
                          MessageBox.Show("Uspesno izmenjeni podaci!");
                          LoadAll();
                          updatePnl.Hide();
                      } else
                          MessageBox.Show("Greska!"); 

        }
    }
}
