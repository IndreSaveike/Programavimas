namespace uzduotis13;
class Program
{
    static void Main(string[] args)
    {
        //Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:ar jis lygus 1: išveskite visų trijų skaičių sumą;ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
        Console.WriteLine("Įveskite tris skaičius: ");
        Console.Write("Įveskite pirmąjį skaičių: ");
        int skaicius1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Įveskite antrąjį skaičių: ");
        int skaicius2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Įveskite trečiąjį skaičių: ");
        int skaicius3 = Convert.ToInt32(Console.ReadLine());
        switch (skaicius1)
        {
            case 1:
                int suma = skaicius1 + skaicius2 + skaicius3;
                Console.WriteLine("Visų trijų skaičių suma yra {0}.", suma);
                break;
            case 2:
                int skirtumas = skaicius1 - skaicius3;
                Console.WriteLine("Pirmo ir trečio skaičių skirtumas yra {0}.", skirtumas);
                break;
            case 3:
                int sandauga = skaicius2 * skaicius3;
                Console.WriteLine("Antro ir trečio skaičių sandauga yra {0}.", sandauga);
                break;
            default:
                Console.WriteLine("Įvestas netinkamas pirmasis skaičius.");
                break;
        }
        Console.WriteLine();
        //Liepkite vartotojui įvesti gyvūno rūšį. Su switch patikrinkite:ar įvestas gyvūnas yra šuo;ar įvestas gyvūnas yra katė;ar įvestas gyvūnas yra žiurkėnas.
        Console.Write("Įveskite gyvūno rūšį: ");
        string gyvunas = Console.ReadLine();


        switch (gyvunas)
        {
            case "šuo":
                Console.WriteLine("Įvestas gyvūnas yra šuo.");
                break;
            case "katė":
                Console.WriteLine("Įvestas gyvūnas yra katė.");
                break;
            case "žiurkėnas":
                Console.WriteLine("Įvestas gyvūnas yra žiurkėnas.");
                break;
            default:
                Console.WriteLine("Įvestas gyvūnas yra nežinomas.");
                break;


        }
    }
}
