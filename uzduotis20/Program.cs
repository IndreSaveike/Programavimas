namespace uzduotis20;
class Program
{
    static void Main(string[] args)
    {
        //Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).
        //Suraskite įžambinę ir ją išveskite į ekraną.Tip: Pitagoro teorema teigia, jog stataus trikampio statinių kvadratų suma yralygi įžambinės kvadratui.
        //Jau žinome, jog Math.Pow(skaicius, laipsnis) – kintamąjį skaičius pakelia laipsniu.  Jei norime ištraukti kvadratinę šaknį, reiktų kelti 0.5 laipsniu.
        //Arba naudoti šaknies funkciją Math.Sqrt(z)

        Console.Write("Įveskite stačiojo trikampio pirmos statinės ilgį: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Įveskite stačiojo trikampio antros statinės ilgį: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("Stačiojo trikampio įžambinė: " + c);
    }

}


