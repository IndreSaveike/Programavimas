namespace uzduotis12;
class Program
{
    static void Main(string[] args)
﻿namespace uzduotis12;
class Program
{
    static void Main(string[] args)
    {
        //Liepkite įvesti tris skirtingus skaičius. Suraskite, kuris iš šių skaičių yra didžiausias.

        Console.WriteLine("Įveskite tris skirtingus skaičius:");
        Console.Write("Pirmasis skaičius: ");
        int skaicius1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Antrasis skaičius: ");
        int skaicius2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Trečiasis skaičius: ");
        int skaicius3 = Convert.ToInt32(Console.ReadLine());
        int didziausiasSkaicius = skaicius1;
        if (skaicius2 > didziausiasSkaicius)
        {
            didziausiasSkaicius = skaicius2;
        }
        if (skaicius3 > didziausiasSkaicius)
        {
            didziausiasSkaicius = skaicius3;
        }
        Console.WriteLine();
        Console.WriteLine("Didžiausias skaičius: " + didziausiasSkaicius);
        Console.WriteLine();

        //Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:ar gautas rezultatas yra [8-10];ar gautas rezultatas yra [5-8);ar gautas rezultatas yra < 5.
        Console.Write("Įveskite egzamino rezultata:");
        int rezultatas = Convert.ToInt32(Console.ReadLine());
        if (rezultatas >= 8 && rezultatas <= 10)
        {
            Console.WriteLine("Jūsų rezultatas patenką į intervalą (8-10).");
        }
        else if (rezultatas >= 5 && rezultatas < 8)
        {
            Console.WriteLine("Jūsų rezultatas patenką į intervalą (5-7).");
        }
        else if (rezultatas < 5)
        {
            Console.WriteLine("Jūsų rezultatas patenką į intervalą (<5).");
        }
        else
        {
            Console.WriteLine("Įvestas neteisingas egzamino rezultatas.");
        }
        Console.WriteLine();
        //Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us): ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.

        Console.Write("Įveskite pirmąjį skaičių: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Įveskite antrąjį skaičių: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2 || number1 == 0)
        {
            Console.WriteLine("Pirmasis skaičius yra didesnis už antrąjį arba yra lygus 0.");
        }

        if (number2 > number1 || number2 == 5)
        {
            Console.WriteLine("Antrasis skaičius yra didesnis už pirmąjį arba yra lygus 5.");
        }

        if (number1 == 20 && number1 > number2)
        {
            Console.WriteLine("Pirmasis skaičius yra didesnis už antrąjį ir yra lygus 20.");
        }

        if (number2 > number1 && number2 < 100)
        {
            Console.WriteLine("Antrasis skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.");
        }


    }
}
        Console.WriteLine("Įveskite tris skirtingus skaičius:");
        Console.Write("Pirmasis skaičius: ");
        int skaicius1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Antrasis skaičius: ");
        int skaicius2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Trečiasis skaičius: ");
        int skaicius3 = Convert.ToInt32(Console.ReadLine());
        int didziausiasSkaicius = skaicius1;
        if (skaicius2 > didziausiasSkaicius)
        {
            didziausiasSkaicius = skaicius2;
        }
        if (skaicius3 > didziausiasSkaicius)
        {
            didziausiasSkaicius = skaicius3;
        }
        Console.WriteLine();
        Console.WriteLine("Didžiausias skaičius: " + didziausiasSkaicius);
        Console.WriteLine();

        //Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:ar gautas rezultatas yra [8-10];ar gautas rezultatas yra [5-8);ar gautas rezultatas yra < 5.

        Console.Write("Įveskite egzamino rezultata:");
        int rezultatas = Convert.ToInt32(Console.ReadLine());
        if (rezultatas >= 8 && rezultatas <= 10)
        {
            Console.WriteLine("Jūsų rezultatas patenką į intervalą (8-10).");
        }
        else if (rezultatas >= 5 && rezultatas < 8)
        {
            Console.WriteLine("Jūsų rezultatas patenką į intervalą (5-7).");
        }
        else if (rezultatas < 5)
        {
            Console.WriteLine("Jūsų rezultatas patenką į intervalą (<5).");
        }
        else
        {
            Console.WriteLine("Įvestas neteisingas egzamino rezultatas.");
        }
        Console.WriteLine();

        //Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us): ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.

        Console.Write("Įveskite pirmąjį skaičių: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Įveskite antrąjį skaičių: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2 || number1 == 0)
        {
            Console.WriteLine("Pirmasis skaičius yra didesnis už antrąjį arba yra lygus 0.");
        }

        if (number2 > number1 || number2 == 5)
        {
            Console.WriteLine("Antrasis skaičius yra didesnis už pirmąjį arba yra lygus 5.");
        }

        if (number1 == 20 && number1 > number2)
        {
            Console.WriteLine("Pirmasis skaičius yra didesnis už antrąjį ir yra lygus 20.");
        }

        if (number2 > number1 && number2 < 100)
        {
            Console.WriteLine("Antrasis skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.");
        }


    }
}

    