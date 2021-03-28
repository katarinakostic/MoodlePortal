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
    public partial class StudentProfil : Form
    {
        Student student;
        public StudentProfil(Student currentStudent)
        {
            InitializeComponent();

            this.student = currentStudent;

            updatePnl.Visible = false;

            brindeksaLbl.Text = "Broj indeksa: " + student.Person_id.ToString();
            imeLbl.Text = "Ime: " + student.Ime;
            prezimeLbl.Text = "Prezime: " + student.Prezime;
            emailLbl.Text = "Email adresa : " + student.Email;
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

        }
    }
}
