using System;
namespace uzduotis38;
//1.Sukurkite bazinę klasę Gyvunas su protected kintamaisiais ir paveldinčia
//klasę Gyvate.Paveldinčioje klasėje turi būti metodas, kuris išveda visus klasės  kintamuosius į ekraną.
//2.Bazinės klasės konstruktorių panaudokite paveldinčioje klasėje.
//3.Išveskite paveldinčios klasės kintamuosius į ekraną.
public class Gyvunas
{
    protected string rusis;
    protected int amzius;

    public Gyvunas(string rusis, int amzius)
    {
        this.rusis = rusis;
        this.amzius = amzius;
    }
}

public class Gyvate : Gyvunas
{
    public Gyvate(string rusis, int amzius) : base(rusis, amzius)
    {
    }

    public void IsvestiInformacija()
    {
        Console.WriteLine($"Rūšis: {rusis}");
        Console.WriteLine($"Amžius: {amzius}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gyvate gyvate = new Gyvate("Gyvatė", 2);
        gyvate.IsvestiInformacija();
    }
}
