using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Projekt
{
    class Adresse
    {
        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public string Stadt { get; set; }
        public string PLZ { get; set; }
        public string Land { get; set; }

        public Adresse(string straße, string hausnummer, string stadt, string plz, string land)
        {
            this.Straße = straße;
            this.Hausnummer = hausnummer;
            this.Stadt = stadt;
            this.PLZ = plz;
            this.Land = land;
        }
    }
}
