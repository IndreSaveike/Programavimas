namespace uzduotis21;

class Program
    //Susikurti 2 masyvus su duomenimis, išbandant abu kūrimo būdus(iškart su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
    //pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
   //skirtą studentų pažymiams saugoti;
   //skirtą mašinų markėms saugoti.
   //Papildyti praeitos užduoties kodą.Išvesti narių skaičių, pirmą narį ir paskutinį  narį bent iš vieno pasirinkto masyvo.
{
    static void Main(string[] args)
    {
        int[] studentuPazymiai = { 5, 8, 9, 6, 7 };
        string[] masinuMarkes = { "Toyota", "Honda", "BMW", "Audi", "Volkswagen" };

        int[] studentuPazymiai2 = new int[5];
        studentuPazymiai2[0] = 5;
        studentuPazymiai2[1] = 8;
        studentuPazymiai2[2] = 9;
        studentuPazymiai2[3] = 6;
        studentuPazymiai2[4] = 7;

        string[] masinuMarkes2 = new string[5];
        masinuMarkes2[0] = "Toyota";
        masinuMarkes2[1] = "Honda";
        masinuMarkes2[2] = "BMW";
        masinuMarkes2[3] = "Audi";
        masinuMarkes2[4] = "Volkswagen";

        Console.WriteLine("Studentų pažymiai:");
        foreach (int pazymys in studentuPazymiai)
        {
            Console.WriteLine(pazymys);
        }

        Console.WriteLine("Mašinų markės:");
        foreach (string marke in masinuMarkes)
        {
            Console.WriteLine(marke);
        }
        Console.WriteLine("\nStudentų pažymių masyvo informacija:");
        Console.WriteLine($"Narių skaičius: {studentuPazymiai.Length}");
        Console.WriteLine($"Pirmas pažymys: {studentuPazymiai[0]}");
        Console.WriteLine($"Paskutinis pažymys: {studentuPazymiai[studentuPazymiai.Length - 1]}");
    }
}