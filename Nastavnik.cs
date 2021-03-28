using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodlePortal
{
    public class Nastavnik : Person
    {
        long jmbg;
        public Nastavnik(long jmbg) : base(jmbg)
        {
            this.jmbg = jmbg;
        }

        public Nastavnik(long jmbg, string ime, string prezime, string email) : base(jmbg, ime, prezime, email)
        {
            this.jmbg = jmbg;
        }
    }
}
