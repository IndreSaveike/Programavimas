namespace uzduotis07;
using System;

class Program
{
    static void Main()
    {
        // 1. Vartotojo vardo ir amžiaus įvedimas
        Console.Write("Įveskite savo vardą: ");
        string vardas = Console.ReadLine();

        Console.Write("Įveskite savo amžių: ");
        int amzius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Jūsų vardas {vardas}, o amžius {amzius}.");
        Console.WriteLine();

        // 2. Simbolio įvedimas ir 3x3 kvadrato atspausdinimas
        Console.Write("Įveskite bet kokį simbolį: ");
        char simbolis = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
        Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
        Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
        Console.WriteLine();

        // 3. Skaičiaus įvedimas ir kvadrato atspausdinimas
        Console.Write("Įveskite bet kokį skaičių: ");
        double skaicius = Convert.ToDouble(Console.ReadLine());
        double kvadratas = Math.Pow(skaicius, 2);
        Console.WriteLine($"Skaičiaus {skaicius} kvadratas: {kvadratas}");
        Console.WriteLine();

        // 4. Trijų skaičių įvedimas ir operacijų atlikimas
        Console.Write("Įveskite pirmąjį skaičių: ");
        double sk1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Įveskite antrąjį skaičių: ");
        double sk2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Įveskite trečiąjį skaičių: ");
        double sk3 = Convert.ToDouble(Console.ReadLine());

        double suma = sk1 + sk2 + sk3;
        double skirtumas = sk1 - sk2 - sk3;
        double sandauga = sk1 * sk2 * sk3;
        double dalmuo = sk1 / sk2 / sk3;

        Console.WriteLine($"{sk1} + {sk2} + {sk3} = {suma}");
        Console.WriteLine($"{sk1} - {sk2} - {sk3} = {skirtumas}");
        Console.WriteLine($"{sk1} * {sk2} * {sk3} = {sandauga}");
        Console.WriteLine($"{sk1} / {sk2} / {sk3} = {dalmuo}");
    }
}