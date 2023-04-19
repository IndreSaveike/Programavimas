namespace uzduotis33;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Įveskite du skaičius:");
        double skaicius1 = Convert.ToDouble(Console.ReadLine());
        double skaicius2 = Convert.ToDouble(Console.ReadLine());

        double rezultatas = AtliktiVeiksma(skaicius1, skaicius2);

        Console.WriteLine($"Rezultatas: {rezultatas}");
    }

    static double AtliktiVeiksma(double a, double b)
    {
        Console.WriteLine("Pasirinkite veiksmą:");
        Console.WriteLine("1. Sudėtis");
        Console.WriteLine("2. Atimtis");
        Console.WriteLine("3. Kėlimas 4 laipsniu sudėjus abu skaičius");
        Console.WriteLine("4. Kvadratinė šaknis sudėjus abu skaičius");

        int veiksmas = Convert.ToInt32(Console.ReadLine());

        double rezultatas = 0;

        switch (veiksmas)
        {
            case 1:
                rezultatas = Sudetis ((int)a, (int)b);
                break;
            case 2:
                rezultatas = Atimtis((int)a, (int)b);
                break;
            case 3:
                rezultatas = KelimasKeturiais(a, b);
                break;
            case 4:
                rezultatas = KvadratineSaknis(a, b);
                break;
            default:
                Console.WriteLine("Tokio veiksmo nėra!");
                break;
        }

        return rezultatas;
    }

    static int Sudetis(int a, int b)
    {
        return a + b;
    }

    static int Atimtis(int a, int b)
    {
        return a - b;
    }

    static double KelimasKeturiais(double a, double b)
    {
        return Math.Pow(a + b, 4);
    }

    static double KvadratineSaknis(double a, double b)
    {
        return Math.Sqrt(a + b);
    }
}
