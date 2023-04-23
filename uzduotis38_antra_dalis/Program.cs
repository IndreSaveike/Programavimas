namespace uzduotis38_antra_dalis;
public class Gyvunas
{
    protected string rusis;
    protected int amzius;
    private const string PrivateConst = "Gyvūnų klasės konstanta.";

    public Gyvunas(string rusis, int amzius)
    {
        this.rusis = rusis;
        this.amzius = amzius;
    }

    public virtual void Isvedimas()
    {
        Console.WriteLine("Base klasės išvedimo metodas.");
    }

    public void SpausdintiPrivateConst()
    {
        Console.WriteLine(PrivateConst);
    }
}

public class Gyvate : Gyvunas
{
    public Gyvate(string rusis, int amzius) : base(rusis, amzius)
    {
    }

    public override void Isvedimas()
    {
        Console.WriteLine($"Rūšis: {rusis}");
        Console.WriteLine($"Amžius: {amzius}");
        SpausdintiPrivateConst();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gyvate gyvate = new Gyvate("Gyvatė", 2);
        gyvate.Isvedimas();
    }
}
