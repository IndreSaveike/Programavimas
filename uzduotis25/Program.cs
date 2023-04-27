namespace uzduotis25;
//Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant tarpu.Rasti didžiausią pažymį.
//Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant kableliu.Rasti
//mažiausią pažymį.
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Įveskite 5 pažymius atskiriant tarpu:");
        string[] pazymiaiSuTarpu = Console.ReadLine().Split(' ');

        int[] pazymiaiSuTarpuSkaiciai = Array.ConvertAll(pazymiaiSuTarpu, int.Parse);
        int didziausiasPazymys = pazymiaiSuTarpuSkaiciai.Max();
        Console.WriteLine("Didžiausias pažymys: " + didziausiasPazymys);

        Console.WriteLine("Įveskite 5 pažymius atskiriant kableliu:");
        string[] pazymiaiSuKableliu = Console.ReadLine().Split(',');

        int[] pazymiaiSuKableliuSkaiciai = Array.ConvertAll(pazymiaiSuKableliu, int.Parse);
        int maziausiasPazymys = pazymiaiSuKableliuSkaiciai.Min();
        Console.WriteLine("Mažiausias pažymys: " + maziausiasPazymys);
    }
}

