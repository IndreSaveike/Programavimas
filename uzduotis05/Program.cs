namespace uzduotis05;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pirma užduotis");
        Console.WriteLine();

        double a = 4;
        double b = 5;
   

        double suma = a + b;
        double skirtumas = a - b;
        double sandauga = a * b;
        double dalmuo = a / b;


        Console.WriteLine($"{a} + {b} = {suma}");
        Console.WriteLine($"{a} - {b} = {skirtumas}");
        Console.WriteLine($"{a} * {b} = {sandauga}");
        Console.WriteLine($"{a} / {b} = {dalmuo}");

        Console.WriteLine();
        Console.WriteLine( "Antra užduotis");
        Console.WriteLine();


        double kvadratas = Math.Pow(a, 2);
        double treciojoLaipsnio = Math.Pow(a, 3);

        
        Console.WriteLine($"Skaičius: {a}");
        Console.WriteLine($"Kvadratu: {kvadratas}");
        Console.WriteLine($"Trečiuoju laipsniu: {treciojoLaipsnio}");

        Console.WriteLine();
        Console.WriteLine("Trečia užduotis");
        Console.WriteLine();

        double c = 6;

        double sandauga1 = a * b * c;
        Console.WriteLine($"Sandauga: {a} * {b} * {c} = {sandauga1}");







    }
}