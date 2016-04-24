using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOTProjekt
{
    class Booking
    {
        public string  Lokale  { get; set; }
        public string Kursus { get; set; }

        public Booking(string lokale, string kursus)
        {
            Lokale = lokale;
            Kursus = kursus;
        }
    }
}
