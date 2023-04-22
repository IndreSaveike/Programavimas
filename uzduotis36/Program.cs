namespace uzduotis36;
     //Sukurti klasę Mokinys su kintamaisiais: vardas, pavardė, amžius, klasė ir  pažymių sąrašą, kur saugosime 5 pažymius.
     //Sukurti konstruktorių, kad priskirtų reikšmes.
     //Klasės viduje sukurti metodą, kad išvestų visą informaciją apie mokinį.
     //Susikurti 3 objektus, jiems priskirti reikšmes ir naudojant sukurtą metodą išvesti kiekvieno mokinio informaciją.

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
    }

class Program
{
    static void Main(string[] args)
    {
        Mokinys mokinys1 = new Mokinys("Jonas", "Jonaitis", 15, "9a", new List<int> { 8, 9, 10, 7, 8 });
        Mokinys mokinys2 = new Mokinys("Petras", "Petraitis", 16, "10b", new List<int> { 9, 7, 8, 6, 10 });
        Mokinys mokinys3 = new Mokinys("Ona", "Onaityte", 14, "8c", new List<int> { 10, 10, 9, 8, 9 });

        mokinys1.IsvestiInformacija();
        Console.WriteLine("-----------------");
        mokinys2.IsvestiInformacija();
        Console.WriteLine("-----------------");
        mokinys3.IsvestiInformacija();
    }
}
