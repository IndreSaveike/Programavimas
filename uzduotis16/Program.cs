using System;

namespace uzduotis16;
class Program
{
    static void Main(string[] args)
    {
        //Raskite visų skaičių nuo 1 iki 100 sumą.
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("Visų skaičių nuo 1 iki 100 suma: " + sum);
        Console.WriteLine();
        //Raskite visų lyginių skaičių nuo 20 iki 40 sumą.
        int sum1 = 0;
        for (int i = 20; i <= 40; i++)
        {
            if (i % 2 == 0)
            {
                sum1 += i;
            }
        }
        Console.WriteLine("Visų lyginių skaičių nuo 20 iki 40 suma: " + sum1);
        Console.WriteLine();
        //Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.
        int sum2 = 0;
        for (int i = 30; i <= 60; i++)
        {
            if (i % 2 != 0)
            {
                sum2 += i;
            }
        }
        Console.WriteLine("Visų nelyginių skaičių nuo 30 iki 60 suma: " + sum2);
        Console.WriteLine();
        //Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba5, sumą.
        int sum3 = 0;
        for (int i = 1; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum3 += i;
            }
        }
        Console.WriteLine("Visų skaičių, kurie dalinasi iš 3 arba 5 ir yra žemesni už 1000 bei didesni už 0, suma: " + sum3);

    }
}

