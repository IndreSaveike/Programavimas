using System;

namespace uzduotis18;
class Program
{
    static void Main(string[] args)
    {
        //Tikslas:
        //Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
        //Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
        //Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.
        //Iš anksto žinoma informacija:
        //Darbo valandų per dieną -8 val.
        //Vartotojo įvedama informacija:
        //Kiek darbuotojas gali iškepti kepalų per valandą.
        //Kiek darbuotojų turi kepykla.
        //Vieno kepalo savikaina.
         //Vieno kepalo pardavimo kaina.
         //Kiek kepykla turi tą dieną iškepti kepalų(užsakymai).
        int kiekDarbuotojasGaliIškeptiPerValandą = 10;
        int kiekDarbuotojųTuriKepykla = 3;
        double vienoKepaloSavikaina = 1.5;
        double vienoKepaloPardavimoKaina = 3.0;
        int kiekKepalųTuriIškepti = 100;
        int kepalųPerValandą = kiekDarbuotojasGaliIškeptiPerValandą * kiekDarbuotojųTuriKepykla;
        int kepalųPerDieną = kepalųPerValandą * 8;

        if (kepalųPerDieną >= kiekKepalųTuriIškepti)
        {
            Console.WriteLine("Kepykla spės iškepti visus užsakymus.");
        }
        else
        {
            int nespetaIškepti = kiekKepalųTuriIškepti - kepalųPerDieną;
            Console.WriteLine($"Kepykla nespės iškepti {nespetaIškepti} kepalų.");
        }

        double pelnasVienamKepalui = vienoKepaloPardavimoKaina - vienoKepaloSavikaina;
        double bendrasPelnas = pelnasVienamKepalui * kepalųPerDieną;

        Console.WriteLine($"Kepykla uždirbs {bendrasPelnas} eur pelno iš visų iškeptų kepalų.");
    }
}

