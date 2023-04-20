namespace uzduotis14;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 - Stacionarus kompiuteris");
        Console.WriteLine("2 - Nešiojamas kompiuteris");
        Console.WriteLine("3 - Planšetė");

        Console.WriteLine("Įveskite pasirinkimo numerį iš aukščiau nurodytų variantų:");
        int pasirinkimas = int.Parse(Console.ReadLine());
        switch (pasirinkimas)
        {
            case 1:
                Console.WriteLine("Stacionariuoju kompiuteriu galite naudotis tik namuose arba darbo vietoje.");
                break;
            case 2:
                Console.WriteLine("Nešiojamuoju kompiuteriu galite naudotis visur.");
                break;
            case 3:
                Console.WriteLine("Planšete galite naudotis visur.");
                break;
            default:
                Console.WriteLine("Tokio pasirinkimo nėra");
                break; ;

        }
    }
}
