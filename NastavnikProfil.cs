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
    }
}
