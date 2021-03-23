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
    public partial class UCAdminPocetna : UserControl
    {
        AdminForm forma;
        public UCAdminPocetna(AdminForm forma)
        {
            InitializeComponent();
            this.forma = forma;
        }

        private void nazadBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

            forma.Hide();
            f.ShowDialog();
            forma.Close();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            forma.Controls.Remove(this);
            forma.Controls.Add(new UCStudent(forma));
        }

        /*
           private void nazadBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {

        }
         */
    }
}
