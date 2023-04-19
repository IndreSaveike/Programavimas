using System;

namespace uzduotis35;
class Program
{
    static void Main(string[] args)
    {
        //Sukurti void tipo metodą, kuriam paduosim masyvą.
        //Metodas turi išvesti masyvo sumą(sumai skaičiuoti naudoti for ciklą ir .Sum()  funkciją.
        //Tuomet metodas išves į konsolę 2 tokias pačias sumas suskaičiuotas  skirtingais būdais)
        //Išsikviesti metodą.

        int[] masyvas = { 1, 2, 3, 4, 5 };
        IsvestiSuma(masyvas);
    }

    static void IsvestiSuma(int[] masyvas)
    {
        int suma1 = 0;
        for (int i = 0; i < masyvas.Length; i++)
        {
            suma1 += masyvas[i];
        }

        int suma2 = masyvas.Sum();

        Console.WriteLine($"Suma: {suma1}");
        Console.WriteLine($"Suma: {suma2}");
    }
}
   
