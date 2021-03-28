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
    public partial class LongTestObrisi : Form
    {
        public LongTestObrisi()
        {
            InitializeComponent();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
            int m;
            if (int.TryParse(textBox1.Text.ToString(), out m))
                textBox2.Text = m.ToString(); */ // radi samo za maks 10 unetih cifara

            long m;
            if (Int64.TryParse(textBox1.Text.ToString(), out m))
                textBox2.Text = m.ToString();
        }
    }
}
