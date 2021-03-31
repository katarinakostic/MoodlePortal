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

            izborniComboBox.Items.Add("Da");
            izborniComboBox.Items.Add("Ne");

            LoadData();
        }

        private void LoadData()
        {
            sifraKursaLbl.Text = "Sifra kursa: " + currentKurs.Sifra_kursa.ToString();
            nazivLbl.Text = "Naziv: " + currentKurs.Naziv;
            godinaLbl.Text = "Godina na kojoj se slusa: " + currentKurs.Godina.ToString();
            if(currentKurs.Izborni == 1)
                izborniLbl.Text = "Izborni: Da" ;
            else if (currentKurs.Izborni == 0)
                izborniLbl.Text = "Izborni: Ne";
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

        private void updateSaveBtn_Click(object sender, EventArgs e)
        {
            //`sifra_kursa`, `naziv_kursa`, `godina_studija`, `izborni`, `pristupni_kod`
            String newName = nazivBox.Text.ToString();
            String newCode = kodBox.Text.ToString();
            int godinaStudija;
            int.TryParse(godinaBox.Text.ToString(), out godinaStudija);
            byte izborni;
            Dictionary<String, bool> update = new Dictionary<string, bool>();

            if (!String.IsNullOrEmpty(godinaBox.Text.ToString()))
            {
                if (!int.TryParse(godinaBox.Text.ToString(), out godinaStudija))
                    MessageBox.Show("Pogresan format ");
                
            }

            if (izborniComboBox.Text.ToString().Equals("Da"))
                izborni = 1;
            else
                izborni = 0;

            if (String.IsNullOrEmpty(newName) && String.IsNullOrEmpty(newCode) && !int.TryParse(godinaBox.Text.ToString(), out godinaStudija) && currentKurs.Izborni==izborni)
            {
                MessageBox.Show("Nisu uneti novi podaci!");
                return;
            }           

            if (String.IsNullOrEmpty(newName))
                update.Add("naziv_kursa", false);
            else
                update.Add("naziv_kursa", true);          
         
            if (currentKurs.Izborni == izborni)
                update.Add("izborni", false);
            else
                update.Add("izborni", true);

            if (!int.TryParse(godinaBox.Text.ToString(), out godinaStudija))
                update.Add("godina_studija", false);
            else
                update.Add("godina_studija", true);

            if (String.IsNullOrEmpty(newCode))
                update.Add("pristupni_kod", false);
            else
                update.Add("pristupni_kod", true);


            if (RadSaBazomKursevi.Update(update, newName, godinaStudija, izborni, newCode, ref currentKurs))
            {
                MessageBox.Show("Uspesno izmenjeni podaci!");
                LoadData();
                updatePnl.Hide();
            }
            else
                MessageBox.Show("Greska!");

        }
    }
}

