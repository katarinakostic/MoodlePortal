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
    public partial class KursProfil : Form
    {
        private Kurs currentKurs;

        public KursProfil(Kurs currentKurs)
        {
            InitializeComponent();
            this.currentKurs = currentKurs;
            updatePnl.Hide();

            LoadData();
        }

        private void LoadData()
        {
            sifraKursaLbl.Text = "Sifra kursa: " + currentKurs.Sifra_kursa.ToString();
            nazivLbl.Text = "Naziv: " + currentKurs.Naziv;
            godinaLbl.Text = "Godina na kojoj se slusa: " + currentKurs.Godina.ToString();
            if(currentKurs.Izborni == 1)
                izborniLbl.Text = "Izborni: DA" ;
            else if (currentKurs.Izborni == 0)
                izborniLbl.Text = "Izborni: NE";
            pristupniKodLbl.Text = "Pristupni kod: " + currentKurs.Pristupni_kod;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izmeniBtn_Click(object sender, EventArgs e)
        {
            updatePnl.Show();
        }
    }
}
