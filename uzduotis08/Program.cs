namespace uzduotis08;
using System;

class Program
{
    static void Main()
    {
        // 1. Skaičiaus įvedimas ir daugybos lentelės atspausdinimas nuo 1 iki 5
        Console.Write("Įveskite bet kokį sveikąjį skaičių: ");
        int skaicius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Daugybos lentelė {skaicius}:");
        for (int i = 1; i <= 5; i++)
        {
            int rezultatas = skaicius * i;
            Console.WriteLine($"{skaicius} * {i} = {rezultatas}");
        }
        Console.WriteLine();

        // 2. Trijų skaičių įvedimas ir vidurkio atspausdinimas
        Console.Write("Įveskite pirmąjį skaičių: ");
        double sk1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Įveskite antrąjį skaičių: ");
        double sk2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Įveskite trečiąjį skaičių: ");
        double sk3 = Convert.ToDouble(Console.ReadLine());

        double vidurkis = (sk1 + sk2 + sk3) / 3;
        Console.WriteLine($"Įvestų skaičių {sk1}, {sk2}, {sk3} vidurkis: {vidurkis}");
        Console.WriteLine();

        // 3. Skaičių įvedimas, kvadratų, trečiųjų laipsnių ir dalijimo iš 2 atspausdinimas
        Console.Write("Įveskite pirmąjį skaičių: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Įveskite antrąjį skaičių: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Įveskite trečiąjį skaičių: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Skaičius {num1}: kvadratu {Math.Pow(num1, 2)}, trečiuoju laipsniu {Math.Pow(num1, 3)}, padalintas iš dviejų {num1 / 2}");
        Console.WriteLine($"Skaičius {num2}: kvadratu {Math.Pow(num2, 2)}, trečiuoju laipsniu {Math.Pow(num2, 3)}, padalintas iš dviejų {num2 / 2}");
        Console.WriteLine($"Skaičius {num3}: kvadratu {Math.Pow(num3, 2)}, trečiuoju laipsniu {Math.Pow(num3, 3)}, padalintas iš dviejų {num3 / 2}");
    }
}