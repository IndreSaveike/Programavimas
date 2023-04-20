namespace uzduotis17;
class Program
{
    static void Main(string[] args)
    {
        //Liepkite vartotojui įvesti teigiamą skaičių. Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0. Pvz.: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.
        Console.Write("Įveskite teigiamą skaičių:");
        int skaicius = Convert.ToInt32(Console.ReadLine());
        while (skaicius >= 0)
        {
            Console.WriteLine(skaicius);
            skaicius--;
        }
        Console.WriteLine();
        //Liepkite vartotojui įvesti neigiamą skaičių. Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0. Pvz.: -4 -3 -2 -1 0.Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
        Console.Write("Įveskite neigiamą skaičių:");
        int skaicius1 = Convert.ToInt32(Console.ReadLine());
        while (skaicius1 <= 0)
        {
            Console.Write(skaicius1 + " ");
            skaicius1++;
        }
        Console.WriteLine();
        //Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius. Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai, išvedant kartu ir atliekamus veiksmus. Pvz.5 + 4 = 9, 5 - 4 = 1…Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
        bool darbas = true;
        while (darbas)
        {
            Console.Write("Įveskite pirmąjį skaičių:");
            double skaicius3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Įveskite antrąjį skaičių:");
            double skaicius4 = Convert.ToDouble(Console.ReadLine());

            double suma = skaicius3 + skaicius4;
            double skirtumas = skaicius3 - skaicius4;
            double sandauga = skaicius3 * skaicius4;
            double dalmuo = skaicius3 / skaicius4;

            Console.WriteLine(skaicius3 + " + " + skaicius4 + " = " + suma);
            Console.WriteLine(skaicius3 + " - " + skaicius4 + " = " + skirtumas);
            Console.WriteLine(skaicius3 + " * " + skaicius4 + " = " + sandauga);
            Console.WriteLine(skaicius3 + " / " + skaicius4 + " = " + dalmuo);

            Console.WriteLine("Ar norite atlikti dar vieną skaičiavimą? (taip / ne)");
            string atsakymas = Console.ReadLine();
            if (atsakymas == "ne")
            {
                darbas = false;
            }
        }
    }
}