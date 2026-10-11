namespace KonyvtarCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>(); 
          using(StreamReader o = new StreamReader("../../../forras/konyvtar.txt"))
            {
             o.ReadLine();
                while (!o.EndOfStream)
                {
                    string line = o.ReadLine();
                    kolcsonzesek.Add(new Kolcsonzes(line));
                }
            }
            Console.WriteLine("5. feladat");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(kolcsonzesek[i].ToString());
            }
            Console.WriteLine("6. feladat");
            Console.WriteLine();
            var f6 = kolcsonzesek.Where(x => x.Olvaso.Regio == "Dunántúl"
            && x.Olvaso.TagsagTipus == "Felnőtt"
            && x.Olvaso.Nem == "Female"
            && x.Visszahozva == "Yes"
            && x.Konyv.Oldalszam >= 200
            && x.Konyv.Oldalszam <= 500);

            if (f6.Any())
            {
                foreach (var item in f6)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine($"A leszűrt kölcsönzések maximális oldalszáma: {f6.Max(x => x.Konyv.Oldalszam)}");
            }
            Console.WriteLine();
            Console.WriteLine("7. feladat: Fájlba írás");

            var f7 = kolcsonzesek.Where(x => x.Olvaso.Eletkor >= 20 && x.Olvaso.Eletkor <= 25
            && x.Olvaso.Regio == "Alföld"
            && x.Olvaso.TagsagTipus == "Diák").OrderBy(x => x.Olvaso.Eletkor);

            using(StreamWriter i = new StreamWriter("../../../forras/alfold.txt"))
            {
                foreach(var item in f7)
                {
                    i.WriteLine($"{item.Olvaso.Nev} { item.Olvaso.Eletkor} {item.Konyv.KonyvCim} {item.Konyv.Mufaj}");
                }
            }
        }
    }
}
