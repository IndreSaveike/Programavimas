namespace uzduotis11;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Įveskite tris skaičius, atskirtus tarpais: ");
        string[] skaiciai = Console.ReadLine().Split(' ');
        int pirmas_skaicius = int.Parse(skaiciai[0]);
        int antras_skaicius = int.Parse(skaiciai[1]);
        int trecias_skaicius = int.Parse(skaiciai[2]);

        if (pirmas_skaicius > antras_skaicius)
        {
            Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį.");
        }
        else if (antras_skaicius > trecias_skaicius)
        {
            Console.WriteLine("Antras skaičius yra didesnis už trečiąjį.");
        }
        else if (trecias_skaicius > pirmas_skaicius && trecias_skaicius > antras_skaicius)
        {
            Console.WriteLine("Trečias skaičius yra didesnis už pirmąjį ir antrąjį.");
        }
        else if (pirmas_skaicius == antras_skaicius && antras_skaicius == trecias_skaicius)
        {
            Console.WriteLine("Visi trys skaičiai yra lygūs.");
        }
        else if (pirmas_skaicius == antras_skaicius)
        {
            Console.WriteLine("Pirmas ir antras skaičiai yra lygūs.");
        }
        else if (antras_skaicius == trecias_skaicius)
        {
            Console.WriteLine("Antras ir trečias skaičiai yra lygūs.");
        }
        else if (trecias_skaicius == pirmas_skaicius)
        {
            Console.WriteLine("Pirmas ir trečias skaičiai yra lygūs.");
        }

        Console.Write("Įveskite šios dienos oro temperatūrą: ");
        int temperatura = int.Parse(Console.ReadLine());

        if (temperatura < 0)
        {
            Console.WriteLine("Žiauriai šalta.");
        }
        else if (temperatura < 10)
        {
            Console.WriteLine("Labai šalta.");
        }
        else if (temperatura < 20)
        {
            Console.WriteLine("Šalta.");
        }
        else if (temperatura < 30)
        {
            Console.WriteLine("Normali temperatūra.");
        }
        else if (temperatura < 40)
        {
            Console.WriteLine("Karšta.");
        }
        else
        {
            Console.WriteLine("Visiškai degina.");
        }
    }
}

