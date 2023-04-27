namespace uzduotis22;
using System;
//Susikurkite savaitės temperatūrų rodmenų masyvą.Raskite:
//1.žemiausią temperatūrą;
//2.didžiausią temperatūrą;
//3.vidurkį;
//4.temperatūrų, esančių žemiau už vidurkį, kiekį;
//5.Temperatūrų, esančių aukščiau už vidurkį, kiekį.
//Susikurkite studentų pažymių masyvą.Raskite:
//1.geriausią pažymį;
//2.kiek mokinių yra gavę dešimtukus;
//3.kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);
//4.pažymių vidurkį.

class Program
{
    static void Main(string[] args)
    {
        // Savaitės temperatūrų rodmenų masyvas
        double[] temperatura = { -3.5, 1.8, 3.9, 6.1, 2.2, -1.5, 7.4 };

        double zemiausia = temperatura[0];
        double auksciausia = temperatura[0];
        double suma = 0;
        int zemiauVidurkio = 0;
        int auksciauVidurkio = 0;

        foreach (double temp in temperatura)
        {
            if (temp < zemiausia)
                zemiausia = temp;
            if (temp > auksciausia)
                auksciausia = temp;
            suma += temp;
        }

        double vidurkis = suma / temperatura.Length;

        foreach (double temp in temperatura)
        {
            if (temp < vidurkis)
                zemiauVidurkio++;
            if (temp > vidurkis)
                auksciauVidurkio++;
        }

        Console.WriteLine($"Žemiausia temperatūra: {zemiausia}");
        Console.WriteLine($"Aukščiausia temperatūra: {auksciausia}");
        Console.WriteLine($"Vidurkis: {vidurkis}");
        Console.WriteLine($"Temperatūrų, esančių žemiau vidurkio, kiekis: {zemiauVidurkio}");
        Console.WriteLine($"Temperatūrų, esančių aukščiau vidurkio, kiekis: {auksciauVidurkio}");

        // Studentų pažymių masyvas
        int[] pazymiai = { 10, 4, 8, 3, 5, 9, 7, 2 };

        int geriausias = pazymiai[0];
        int desimtukai = 0;
        int neigiami = 0;
        suma = 0;

        foreach (int pazymys in pazymiai)
        {
            if (pazymys > geriausias)
                geriausias = pazymys;
            if (pazymys == 10)
                desimtukai++;
            if (pazymys < 4)
                neigiami++;
            suma += pazymys;
        }

        vidurkis = (double)suma / pazymiai.Length;

        Console.WriteLine($"\nGeriausias pažymys: {geriausias}");
        Console.WriteLine($"Kiek mokinių yra gavę dešimtukus: {desimtukai}");
        Console.WriteLine($"Kiek mokinių yra gavę neigiamą pažymį (žemiau nei 4): {neigiami}");
        Console.WriteLine($"Pažymių vidurkis: {vidurkis}");
    }
}