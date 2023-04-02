namespace uzduotis09;
class Program
{
    static void Main(string[] args)
    {
        // Tikriname ar vartotojas gali balsuoti
        Console.Write("Įveskite savo amžių: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Jūs galite balsuoti");
        }
        else
        {
            Console.WriteLine("Deja, jūs negalite balsuoti.");
        }

        // Patikriname įvestą skaičių
        Console.Write("Įveskite bet kokį skaičių: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Negalima vesti neigiamo skaičiaus :)");
        }
        else if (number > 0)
        {
            Console.WriteLine("Sveikiname! Jūsų skaičius yra teigiamas.");
        }
        else
        {
            Console.WriteLine("Jūsų skaičius yra lygus 0.");
        }

        if (number % 2 == 0)
        {
            Console.WriteLine("Taip, skaičius yra lyginis.");
        }

        if (number % 4 == 0)
        {
            Console.WriteLine("Taip, skaičius dalinasi iš 4.");
        }

        if (number > 10)
        {
            Console.WriteLine("Taip, skaičius yra didesnis už 10.");
        }

        // Pažymių vidurkio skaičiavimas ir tikrinimas
        Console.Write("Įveskite du savo pažymius, atskirtus kableliu: ");
        string[] grades = Console.ReadLine().Split(',');
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            double parsedGrade;
            if (double.TryParse(grades[i], out parsedGrade))
            {
                sum += parsedGrade;
            }
            else
            {
                Console.WriteLine("Netinkamas pažymio formatas: {0}", grades[i]);
            }
        }
        double average = sum / grades.Length;
        Console.WriteLine("Pažymių vidurkis: {0}", average);
        if (average >= 2)
        {
            Console.WriteLine("Valio!!!");
        }
    }
}