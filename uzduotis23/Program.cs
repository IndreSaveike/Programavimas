namespace uzduotis23;
using System;
//Susikurkite kintamąjį, kuris pasakytų kiek automobilis vidutiniškai sunaudoja degalų 100 – ui km.Susikurkite masyvą, kuriame saugotumėte skirtingose
//kelionėse nuvažiuotų kilometrų rodmenis.Raskite:
//rumpiausią kelionę;
//ilgiausią kelionę;
//kiek kuro sąnaudų sunaudojo automobilis(skaičiavimui reikės rasti visus  nuvažiuotus km).

class Program
{
    static void Main(string[] args)
    {
        // Kintamasis, parodantis vidutinį degalų sąnaudą 100 km
        double degaluSanaudos = 6.5;

        // Masyvas su nuvažiuotų kilometrų rodmenimis
        double[] keliones = { 80, 350, 50, 220, 150, 90, 470 };

        double trumpiausia = keliones[0];
        double ilgiausia = keliones[0];
        double bendrasKilometrazas = 0;

        foreach (double kelione in keliones)
        {
            if (kelione < trumpiausia)
                trumpiausia = kelione;
            if (kelione > ilgiausia)
                ilgiausia = kelione;
            bendrasKilometrazas += kelione;
        }

        double kuroSanaudos = (bendrasKilometrazas / 100) * degaluSanaudos;

        Console.WriteLine($"Trumpiausia kelionė: {trumpiausia} km");
        Console.WriteLine($"Ilgiausia kelionė: {ilgiausia} km");
        Console.WriteLine($"Kuro sąnaudos visoms kelionėms: {kuroSanaudos} l");
    }
}