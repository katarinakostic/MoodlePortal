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
        public Student(long br_indeksa) : base(br_indeksa)
        {
            this.br_indeksa = br_indeksa;
        }

        public Student(long id, string ime, string prezime, string email) : base(id, ime, prezime, email)
        {
            this.br_indeksa = id;
        }
    }
}
