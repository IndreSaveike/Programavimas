namespace uzduotis34;
class Program
{
    static void Main(string[] args)
    {
        //Įvesti du skaičius iš konsolės
        //Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: Daugybą ar  dalybą
        //Parašyti po atskirą metodą kiekvienam veiksmui(daugybai naudoti int tipą, o  dalybai double)
        //Su if patikrinti kokį veiksmą atlikti ir išsikviesti atitinkamą metodą, jei tokio  veiksmo nėra – informuoti vartotoją, jog tokio veiksmo nėra.

        Console.WriteLine("Įveskite du skaičius:");
        int skaicius1 = Convert.ToInt32(Console.ReadLine());
        int skaicius2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pasirinkite veiksmą:");
        Console.WriteLine("1. Daugyba");
        Console.WriteLine("2. Dalyba");
        int veiksmas = Convert.ToInt32(Console.ReadLine());

        if (veiksmas == 1)
        {
            int rezultatas = Daugyba(skaicius1, skaicius2);
            Console.WriteLine($"Daugyba: {rezultatas}");
        }
        else if (veiksmas == 2)
        {
            double rezultatas = Dalyba(skaicius1, skaicius2);
            Console.WriteLine($"Dalyba: {rezultatas}");
        }
        else
        {
            Console.WriteLine("Tokio veiksmo nėra!");
        }
    }

    static int Daugyba(int a, int b)
    {
        return a * b;
    }

    static double Dalyba(int a, int b)
    {
        return (double)a / b;
    }
}