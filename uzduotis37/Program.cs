namespace uzduotis37;
//1.Sukurti klasę Salis su kintamaisiais: Pavadinimas, Prezidentas, Plotas,  GyventojuSkaicius,
//VidutinisAtlyginimas ir masyvu Augimas, kur saugosime 5  metų rodmenis, kiek gyventojų gimė kasmet.
//2.Sukurti 4 skirtingus konstruktorius.
//3.Klasės viduje sukurti metodą, kad išvestų visą informaciją apie šalį.
//4.Susikurti 4 objektus, jiems priskirti reikšmes su skirtingais konstruktoriais ir
//naudojant sukurtą metodą išvesti kiekvienos šalies informaciją.
//5.Klasės viduje sukurti void tipo metodą, kuris pagal duotą reikšmę iš consolės
//(masyvo indeksą / elemento vietą masyve), išvestų į ekraną masyvo elemento reikšmę ir
//jei reikšmė didesnė už sekančią reikšmę(n + 1) - išvesti ir tą
//reikšmę.
class Salis
{
    public string Pavadinimas;
    public string Prezidentas;
    public double Plotas;
    public int GyventojuSkaicius;
    public double VidutinisAtlyginimas;
    public int[] Augimas = new int[5];

    public Salis(string pavadinimas, string prezidentas, double plotas, int gyventojuSkaicius, double vidutinisAtlyginimas)
    {
        Pavadinimas = pavadinimas;
        Prezidentas = prezidentas;
        Plotas = plotas;
        GyventojuSkaicius = gyventojuSkaicius;
        VidutinisAtlyginimas = vidutinisAtlyginimas;
    }

    public Salis(string pavadinimas, string prezidentas) : this(pavadinimas, prezidentas, 0, 0, 0) { }

    public Salis(string pavadinimas, string prezidentas, double plotas, int gyventojuSkaicius) : this(pavadinimas, prezidentas, plotas, gyventojuSkaicius, 0) { }

    public void IvestiAugima(int[] augimas)
    {
        Augimas = augimas;
    }

    public void Info()
    {
        Console.WriteLine($"Pavadinimas: {Pavadinimas}\nPrezidentas: {Prezidentas}\nPlotas: {Plotas}\nGyventojų skaičius: {GyventojuSkaicius}\nVidutinis atlyginimas: {VidutinisAtlyginimas}");
        Console.Write("Augimas per 5 metus: ");
        foreach (int augimas in Augimas)
        {
            Console.Write($"{augimas} ");
        }
        Console.WriteLine("\n");
    }

    public void AugimoAnalize(int indeksas)
    {
        if (indeksas >= 0 && indeksas < Augimas.Length - 1)
        {
            Console.WriteLine($"Masyvo elemento reikšmė: {Augimas[indeksas]}");
            if (Augimas[indeksas] > Augimas[indeksas + 1])
            {
                Console.WriteLine($"Sekanti reikšmė: {Augimas[indeksas + 1]}");
            }
        }
        else
        {
            Console.WriteLine("Indeksas yra už masyvo ribų.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Salis salis1 = new Salis("Lietuva", "Gitanas Nausėda", 65300, 2793000, 1450);
        salis1.IvestiAugima(new int[] { 5000, 6000, 5500, 5800, 6300 });
        Salis salis2 = new Salis("Latvija", "Egils Levits", 64589, 1900000, 1300);
        salis2.IvestiAugima(new int[] { 4000, 4500, 4200, 4600, 4800 });
        Salis salis3 = new Salis("Estija", "Alar Karis", 45227, 1335000, 1400);
        salis3.IvestiAugima(new int[] { 3000, 3200, 3500, 3300, 3400 });
        Salis salis4 = new Salis("Didžioji Britanija", "Borisas Džonsonas", 242495, 67215293, 3168);
        salis4.IvestiAugima(new int[] { 70000, 71000, 72000, 73000, 74000 });

        salis1.Info();
        salis2.Info();
        salis3.Info();
        salis4.Info();

        Console.WriteLine("Įveskite masyvo indeksą: ");
        int indeksas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Analizuojamas masyvo elementas su indeksu {indeksas}:\n");

        Console.WriteLine("Salis 1:");
        salis1.AugimoAnalize(indeksas);
        Console.WriteLine("Salis 2:");
        salis2.AugimoAnalize(indeksas);
        Console.WriteLine("Salis 3:");
        salis3.AugimoAnalize(indeksas);
        Console.WriteLine("Salis 4:");
        salis4.AugimoAnalize(indeksas);
        Console.ReadKey();
    }
}