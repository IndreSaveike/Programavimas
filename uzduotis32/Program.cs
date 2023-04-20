using System;

namespace uzduotis32
{
    class Program
    {
        //Paprašyti įvesti vartotojo vardą.
        //Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
        //Išvesti šią frazę į konsolę.

        static void Main(string[] args)
        {
            Pasisveikinimas();
        }

        static private void Pasisveikinimas()
        {
            Console.WriteLine("Įveskite savo vardą:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Sveiki, " + vardas + "!");
        }
    }
}