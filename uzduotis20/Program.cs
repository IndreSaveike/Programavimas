namespace uzduotis20;
class Program
{
    static void Main(string[] args)
    {
        //Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).
        Console.Write("Įveskite stačiojo trikampio pirmos statinės ilgį: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Įveskite stačiojo trikampio antros statinės ilgį: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("Stačiojo trikampio įžambinė: " + c);
    }
}

