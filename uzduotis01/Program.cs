
internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Indre";
        Console.WriteLine("Labas, " + name);

        Console.Write("Įvestas amžius:");

        int age = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();

        int num = 25;
        Console.Write(num);
        Console.Write(num);
        Console.Write(num);
        Console.Write(num);
        Console.Write(num + "\n");

        Console.WriteLine(+num + " " + num + " " + num + " " + num + " " + num);
    }
}