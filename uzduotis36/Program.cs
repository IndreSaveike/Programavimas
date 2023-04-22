namespace uzduotis36;
//1. Klasės viduje sukurti void tipo metodą, kuris išvestų į ekraną už,
//kiek metų  mokinys baigs mokyklą, jei atsakymas 0 – tuomet išvesti
//„Mokinys mokyklą  baigs šiais metais“. Iškviesti metodą Main‘o viduje visiems objektams.
//2. Main‘o viduje naudojant Sąrašo komandas Max() ir Min() išvesti į ekraną
//kiekvieno mokinio geriausią ir blogiausią pažymį.
//3.Sukurti int tipo metodą (pagrindinės klasės viduje), kuriam paduosim kintamąjį,
//kurio tipas yra Mokinys.  Metodas turi apskaičiuoti, kiek yra mokinio pažymių,
//didesnių už 4. Išvesti šią informaciją apie kiekvieną mokinį.

class Mokinys
{
    public string Vardas;
    public string Pavarde;
    public int Amzius;
    public string Klase;
    public List<int> Pazymiai;

    public Mokinys(string vardas, string pavarde, int amzius, string klase, List<int> pazymiai)
    {
        Vardas = vardas;
        Pavarde = pavarde;
        Amzius = amzius;
        Klase = klase;
        Pazymiai = pazymiai;
    }

    public void IsvestiInformacija()
    {
        Console.WriteLine($"Vardas: {Vardas}");
        Console.WriteLine($"Pavarde: {Pavarde}");
        Console.WriteLine($"Amzius: {Amzius}");
        Console.WriteLine($"Klase: {Klase}");
        Console.WriteLine("Pažymiai:");

        foreach (int pazymys in Pazymiai)
        {
            Console.WriteLine(pazymys);
        }
    }

    public void MetaiIkiBaigimo()
    {
        int metai = 12 - int.Parse(Klase.Substring(0, Klase.Length - 1));

        if (metai == 0)
        {
            Console.WriteLine("Mokinys mokyklą baigs šiais metais");
        }
        else
        {
            Console.WriteLine($"Mokinys mokyklą baigs už {metai} metų");
        }
    }

    public int PazymiuDidesniuUz4()
    {
        return Pazymiai.Count(pazymys => pazymys > 4);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mokinys mokinys1 = new Mokinys("Jonas", "Jonaitis", 15, "9a", new List<int> { 8, 9, 10, 7, 8 });
        Mokinys mokinys2 = new Mokinys("Petras", "Petraitis", 16, "10b", new List<int> { 9, 7, 8, 6, 10 });
        Mokinys mokinys3 = new Mokinys("Ona", "Onaityte", 14, "8c", new List<int> { 10, 10, 9, 8, 9 });

        var mokiniai = new List<Mokinys> { mokinys1, mokinys2, mokinys3 };

        foreach (var mokinys in mokiniai)
        {
            mokinys.IsvestiInformacija();
            mokinys.MetaiIkiBaigimo();
            Console.WriteLine($"Geriausias pažymys: {mokinys.Pazymiai.Max()}");
            Console.WriteLine($"Blogiausias pažymys: {mokinys.Pazymiai.Min()}");
            Console.WriteLine($"Pažymių didesnių už 4: {mokinys.PazymiuDidesniuUz4()}");
            Console.WriteLine("-----------------");
        }
    }
}




