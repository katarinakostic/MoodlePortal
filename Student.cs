using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodlePortal
{
    public class Student : Person
    {
        long br_indeksa;
        public int godina_upisa { get; set; }
        public int godina_studija { get; set; }
        public Student(long br_indeksa) : base(br_indeksa)
        {
            this.br_indeksa = br_indeksa;
        }

        public Student(long id, string ime, string prezime, string email, byte[] foto, int godina_upisa, int godina_studija) : base(id, ime, prezime, email, foto)
        {
            this.br_indeksa = id; //?

            this.godina_upisa = godina_upisa;
            this.godina_studija = godina_studija;
        }
    }
}
