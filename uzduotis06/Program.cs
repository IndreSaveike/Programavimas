namespace uzduotis06;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pirma užduotis:");


        int skaicius = 5;

        Console.WriteLine($"Daugybos lentelė {skaicius}:");

        for (int i = 0; i <= 10; i++)
        {
            int rezultatas = skaicius * i;
            Console.WriteLine($"{skaicius} x {i} = {rezultatas}");
        }

        
        Console.WriteLine();
        Console.WriteLine("antra užduotis:");
        Console.WriteLine();


        int skaicius1 = 37;

        int pirmasSkaitmuo1 = skaicius1 / 10;
        int antrasSkaitmuo1 = skaicius1 % 10;
        int sandauga = pirmasSkaitmuo1 * antrasSkaitmuo1;

        
        Console.WriteLine($"Dviženklis skaičius: {skaicius1}");
        Console.WriteLine($"Skaitmenų sandauga: {pirmasSkaitmuo1} * {antrasSkaitmuo1} = {sandauga}");
    }
}