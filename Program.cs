using System;


namespace Som
{

    class Program
    {
        static void Main()
        {

            int getal1, getal2, getal3, som;

            Console.WriteLine("Gelieve 3 gehele getallen in te geven");

            Console.Write($"Getal 1: ");
            getal1 = int.Parse(Console.ReadLine());

            Console.Write($"Getal 2: ");
            getal2 = int.Parse(Console.ReadLine());

            Console.Write($"Getal 3: ");
            getal3 = int.Parse(Console.ReadLine());

            som = getal1 + getal2+ getal3;
            Console.WriteLine($"De som van de 3 getallen is: {som}");


        }
    }
}