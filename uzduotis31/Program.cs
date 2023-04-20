namespace uzduotis31;
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        int suma = program.Suma(2, 3, 4);
        double dalmuo = program.Dalmuo(10, 3);

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Dalmuo: " + dalmuo);
    }

    private int Suma(int a, int b, int c)
    {
        return a + b + c;
    }

    private double Dalmuo(int a, int b)
    {
        return (double)a / b;
    }
}

