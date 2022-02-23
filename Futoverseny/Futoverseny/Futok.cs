using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futoverseny
{
    class Futok
    {
        private int rajtszam;
        private string nev;
        private DateTime szuletesdatum;
        private string orszag;
        private string idoeredmeny;

        public int Rajtszam { get => rajtszam; set => rajtszam = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletesdatum { get => szuletesdatum; set => szuletesdatum = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public string Idoeredmeny { get => idoeredmeny; set => idoeredmeny = value; }

        public Futok(int rajtszam, string nev, DateTime szuletesdatum, string orszag, string idoeredmeny)
        {
            Rajtszam = rajtszam;
            Nev = nev;
            Szuletesdatum = szuletesdatum;
            Orszag = orszag;
            Idoeredmeny = idoeredmeny;
        }
        public Futok(string sor)
        {
            string[] adatok = sor.Split(';');
            Rajtszam = Convert.ToInt32(adatok[0]);
            Nev = adatok[1];
            Szuletesdatum = DateTime.Parse(adatok[2]);
            Orszag = adatok[3];
            Idoeredmeny = adatok[4];
        }

        public override string ToString()
        {
            return string.Format(Nev);
        }
        
    }
}
