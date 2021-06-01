using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Projekt
{
    class Konto
    {
        public string IBAN { get; set; }
        public Kunde Inhaber { get; set; }
        public decimal Kontostand { get; set; }
        public DateTime kontoSeit { get; set; }
        public Konto(string IBAN, Kunde inhaber, decimal kontostand, DateTime kontoSeit)
        {
            this.IBAN = IBAN;
            this.Inhaber = inhaber;
            this.Kontostand = kontostand;
            this.kontoSeit = kontoSeit;
        }
    }
}
