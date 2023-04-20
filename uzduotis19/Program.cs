namespace uzduotis19;
class Program
{
    static void Main(string[] args)
    {
        //Parašyti For ciklą, kuris suskaičiuotų, kiek skaičių intervale [0 – 1000) dalinasi iš 16.

        int count = 0;
        for (int i = 0; i < 1000; i++)
        {
            if (i % 16 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("Skaičių intervale [0 - 1000), kurie dalijasi iš 16, yra: " + count);
        //Liepkite vartotojui įvesti teigiamą skaičių. While ciklo viduje skaičių kelkite vis
        //didesniu laipsniu ir jį išveskite į ekraną, kol skaičius netaps didesnis už 1500.
        Console.Write("Įveskite teigiamą skaičių: ");
        int input = Convert.ToInt32(Console.ReadLine());

        // Kelkite skaičių vis didesniu laipsniu, kol jis pasiekia 1500.
        int number = input;
        while (number <= 1500)
        {
            Console.WriteLine(number);
            number *= input;
        }
    }

}