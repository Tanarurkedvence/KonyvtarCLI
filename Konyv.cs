using System;
using System.Collections.Generic;
using System.Text;

namespace KonyvtarCLI
{
    internal class Konyv
    {
        public int KonyvID { get; set; }
        public string KonyvCim { get; set; }
        public string Mufaj { get; set; }
        public int KiadasiEv { get; set; }
        public int Oldalszam { get; set; }
    }
}
