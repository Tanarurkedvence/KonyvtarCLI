using System;
using System.Collections.Generic;
using System.Text;

namespace KonyvtarCLI
{
    internal class Kolcsonzes
    {
        static int counter = 1;
        public Kolcsonzes(string l)
        {
            var r = l.Split(";");
            KolcsonzesID = int.Parse(r[0]);
            Olvaso = new Olvaso
            {
                OlvasoID = int.Parse(r[1]),
                Nev = r[2],
                Eletkor = int.Parse(r[3]),
                Nem = r[4],
                Varos = r[5],
                Regio = r[6],
                TagsagTipus = r[7],
            };
            Konyv = new Konyv()
            {
                KonyvCim = r[8],
                KonyvID = counter++,
                Mufaj = r[9],
                KiadasiEv = int.Parse(r[10]),
                Oldalszam = int.Parse(r[11])
            };
            KolcsonzesNapja = int.Parse((string)r[12]);
            Visszahozva = r[13];
        }

        public int KolcsonzesID { get; set; }
        public Olvaso Olvaso { get; set; }
        public Konyv Konyv { get; set; }
        public int KolcsonzesNapja { get; set; }
        public string Visszahozva { get; set; }

        public double Average()
        {
           return Math.Round(((double)Olvaso.Eletkor + Konyv.Oldalszam) / 2, 2);
        }
        public override string ToString()
        {
            return $"Kolcsonzes ID: {KolcsonzesID}\n" +
                   $"Olvaso ID: {Olvaso.OlvasoID}\n" +
                   $"Nev: {Olvaso.Nev}\n" +
                   $"Eletkor: {Olvaso.Eletkor}\n" +
                   $"Nem: {Olvaso.Nem}\n" +
                   $"Varos: {Olvaso.Varos}\n" +
                   $"Regio: {Olvaso.Regio}\n" +
                   $"TagsagTipus: {Olvaso.TagsagTipus}\n" +
                   $"KonyvCim: {Konyv.KonyvCim}\n" +
                   $"Mufaj: {Konyv.Mufaj}\n" +
                   $"KiadasiEv: {Konyv.KiadasiEv}\n" +
                   $"Oldalszam: {Konyv.Oldalszam}\n" +
                   $"KolcsonzesNapja: {KolcsonzesNapja}\n" +
                   $"Visszahozva: {Visszahozva}\n" +
                   $"Average: {Average():F2}\n";
        }
    }
}
