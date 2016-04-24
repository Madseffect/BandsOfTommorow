using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOTProjekt
{
    internal class Booking
    {
        //Test for commit's
        public string Lokale { get; set; }
        public string Kursus { get; set; }
        

        // Test's for Commits
        public string Test { get; set; }

        //Test for commit's
        public Booking()
        {
            
        }
        //Test for commit's
        public Booking(string lokale, string kursus)
        {
            Lokale = lokale;
            Kursus = kursus;


        }
        //Test for commit's
        public override string ToString()
        {
            return $"Lokale: {Lokale}, Kursus: {Kursus}";
        }
    }
}
