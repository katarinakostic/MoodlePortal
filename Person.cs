using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodlePortal
{
    public class Person
    {
        public long Person_id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Email { get; set; }
        public Person(long id, String ime, String prezime, String email)
        {
            Person_id = id;
            Ime = ime;
            Prezime = prezime;
            Email = email;
        }
        public Person(long id)
        {
            Person_id = id;

        }
    }
}
