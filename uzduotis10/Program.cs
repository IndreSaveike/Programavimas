namespace uzduotis10;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Įveskite skaičių: ");
        int skaicius = int.Parse(Console.ReadLine());

        if (skaicius % 2 == 0)
        {
            int penktasis_laipsnis = (int)Math.Pow(skaicius, 5);
            Console.WriteLine("{0} {1}", skaicius, penktasis_laipsnis);
        }
        else if (skaicius % 4 != 0)
        {
            Console.Write("Įveskite antrąjį skaičių: ");
            int antras_skaicius = int.Parse(Console.ReadLine());

            int suma = skaicius + antras_skaicius;
            int sandauga = skaicius * antras_skaicius;
            Console.WriteLine("{0} + {1} = {2}", skaicius, antras_skaicius, suma);
            Console.WriteLine("{0} * {1} = {2}", skaicius, antras_skaicius, sandauga);
        }
    }
}

