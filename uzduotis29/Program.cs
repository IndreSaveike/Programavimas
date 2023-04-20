namespace uzduotis29;
class Program
{
    static void Main(string[] args)
    {
     PasisveikinimasSuVartotoju();
    }

    static private void PasisveikinimasSuVartotoju()
    {
        Console.WriteLine("Jūsų vardas:");
        string vardas = Console.ReadLine();
        Console.WriteLine("Jūsų amžius:");
        int amzius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hobio pavadinimas:");
        string hobis = Console.ReadLine();

        Console.WriteLine("Labas, {0} ({1}m.).\nJūsų įrašytas hobis: {2}.", vardas, amzius, hobis);

    }
}

