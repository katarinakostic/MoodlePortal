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
    public partial class UCKursCrud : UserControl
    {
        private Kurs currentKurs = null;
        private AdminForm forma;
        List<Kurs> kursevi;

        public UCKursCrud(AdminForm forma)
        {
            InitializeComponent();
            this.forma = forma;
        }

        private void LoadAll()
        {
            kursevi = RadSaBazomKursevi.SpisakKurseva();

            if (listViewKurs.Visible == true)
                listViewKurs.Clear();

            if (kursevi.Count > 0)
            {
                listViewKurs.Show();
                foreach(Kurs k in kursevi)
                {
                    ListViewItem item = new ListViewItem(k.Sifra_kursa + ", " + k.Naziv + ", " + k.Izborni + ", " + k.Godina.ToString() + ", " + k.Pristupni_kod);
                    item.Tag = k;
                    listViewKurs.Items.Add(item);

                    //listViewStudenti.Items.Add(podaci);
                    //MessageBox.Show(prepisaniLekoviRecnik.Keys[0]);
                }
            }
            else
            {
                MessageBox.Show("Nema kurseva!");
                //forma.Controls.Add(prethodniProzor);

            }
        }
        private void showBtn_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {            
            String sifra, naziv, pr_kod;
            byte izborni;
            int godina;

            kursevi = RadSaBazomKursevi.SpisakKurseva();
            if (sifraKursaBox.Text.Length > 0)
                sifra = sifraKursaBox.Text.ToString();
            //if (long.TryParse(jmbgBox.Text.ToString()))
            // jmbg = long.TryParse(jmbgBox.Text.ToString());
            else
            {
                MessageBox.Show("Unesite sifru kursa!");
                return;
            }
            naziv = nazivBox.Text.ToString();
            izborni = byte.Parse(izborniBox.Text.ToString());
            godina = int.Parse(godinaStudijaBox.Text.ToString());
            pr_kod = Kurs.GenerateCode(8);

            if (RadSaBazomKursevi.nadjiKurs(sifra))
            {
                MessageBox.Show("Ovaj kurs postoji!");
                return;
            }

            if (RadSaBazomKursevi.AddKurs(new Kurs(sifra, naziv, godina, izborni, pr_kod)))
            {
                        
                currentKurs = new Kurs(sifra, naziv, godina, izborni, pr_kod);
                MessageBox.Show("Uspesno uneti podaci!");
                if (!listViewKurs.Visible)
                    listViewKurs.Show();
                
                LoadAll();
            }           
            else
                MessageBox.Show("Greska!");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String sifra;

            if (sifraDeleteTxt.Text.Length > 0)
                sifra = sifraDeleteTxt.Text.ToString();
            else
            {
                MessageBox.Show("Unesite sifru kursa!");
                return;
            }
            if (RadSaBazomKursevi.nadjiKurs(sifra))
            {
                if (RadSaBazomKursevi.Obrisi(sifra))
                {
                    MessageBox.Show("Uspesno obrisan kurs!");
                    LoadAll();
                }
                else
                {
                    MessageBox.Show("Doslo je do greske prilikom brisanja kursa iz baze!");
                    return;
                }
            }
            else
                MessageBox.Show("Kurs sa ovom sifrom ne postoji!");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            listViewKurs.Clear();
            String sifra;

            if (sifraSearchBox.Text.Length > 0)
                sifra = sifraSearchBox.Text.ToString();
            else
            {
                MessageBox.Show("Sifra kursa nije uneta!");
                return;
            }
            if (RadSaBazomKursevi.nadjiKurs(sifra))
            {
                kursevi = RadSaBazomKursevi.SpisakKurseva();
                foreach (Kurs k in kursevi)
                    if (k.Sifra_kursa == sifra)
                    {
                        listViewKurs.Items.Add(k.Sifra_kursa + ", " + k.Naziv + ", " + k.Izborni + ", " + k.Godina.ToString() + ", " + k.Pristupni_kod);
                        break;
                    }

            }
            else
                MessageBox.Show("Ne postoji kurs sa tom sifrom!");
        }

        private void listViewKurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKurs.SelectedItems.Count == 0)
                return;

            ListViewItem item = listViewKurs.SelectedItems[0];
            currentKurs = (Kurs)item.Tag;

            Form forma = new KursProfil(currentKurs);
            forma.ShowDialog();
        }
    }
}
