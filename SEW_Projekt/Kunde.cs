using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Projekt
{
    class Kunde
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Verfuegernummer { get; set; }
        public string Kennwort { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public Adresse Adresse { get; set; }
        public Kunde(string vorname, string nachname, string verfuegernummer, string Kennwort, DateTime geburtsdatum, Adresse adresse)
        {
        }
    }
}
