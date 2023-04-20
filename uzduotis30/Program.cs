namespace uzduotis30;
class Program
{
    static void Main(string[] args)
    {
        SveikųjųSkaičiųĮvedimas();
    }
    static private void SveikųjųSkaičiųĮvedimas()
    {
    Console.WriteLine("Įveskite du skaičius:");
        int skaičius1 = Convert.ToInt32(Console.ReadLine());
        int skaičius2 = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();
        Console.WriteLine("{0} + {1} = {2}", skaičius1, skaičius2, Suma(skaičius1, skaičius2));
        Console.WriteLine("{0} - {1} = {2}", skaičius1, skaičius2, Skirtumas(skaičius1, skaičius2));
        Console.WriteLine("{0} * {1} = {2}", skaičius1, skaičius2, Sandauga(skaičius1, skaičius2));
        Console.WriteLine("{0} / {1} = {2}", skaičius1, skaičius2, Dalmuo(skaičius1, skaičius2));
    }
    static private int Suma(int skaičius1, int skaičius2)
    {
        return skaičius1 + skaičius2;
    }

    static private int Skirtumas(int skaičius1, int skaičius2)
    {
        return skaičius1 - skaičius2;
    }

    static private int Sandauga(int skaičius1, int skaičius2)
    {
        return skaičius1 * skaičius2;
    }

    static private double Dalmuo(int skaičius1, int skaičius2)
    {
        return (double)skaičius1 / skaičius2;
    }

}


