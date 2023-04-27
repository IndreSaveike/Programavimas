namespace uzduotis24;
 //Paklausti vartotojo, kiek duomenų nori įvesti į masyvą Pagal tai sukursime tokio dydžio masyvą
//Iš konsolės įvesti duomenis į masyvą
//Surasti 2 sumas:
//Suma1 – kai masyvo elementas yra lyginis skaičius
//Suma2 – kai masyvo indeksas nėra lyginis skaičius
   using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Įveskite masyvo dydį:");
        int masyvoDydis = int.Parse(Console.ReadLine());

        int[] masyvas = new int[masyvoDydis];

        Console.WriteLine("Įveskite masyvo elementus:");
        for (int i = 0; i < masyvoDydis; i++)
        {
                masyvas[i] = int.Parse(Console.ReadLine());
        }
        int suma1 = 0; // Suma1 – kai masyvo elementas yra lyginis skaičius
        int suma2 = 0; // Suma2 – kai masyvo indeksas nėra lyginis skaičius

        for (int i = 0; i < masyvoDydis; i++)
        {
            if (masyvas[i] % 2 == 0)
            {
                suma1 += masyvas[i];
            }
            if (i % 2 != 0)
            {
                suma2 += masyvas[i];
            }
        }
        Console.WriteLine("Suma1 (elementai yra lyginiai skaičiai): " + suma1);
        Console.WriteLine("Suma2 (indeksai nėra lyginiai skaičiai): " + suma2);
    }
}