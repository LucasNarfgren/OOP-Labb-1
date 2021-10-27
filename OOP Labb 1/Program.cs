using System;

namespace OOP_Labb_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle C1 = new Circle(0);
            Console.WriteLine("Area av Cirkel 1: {0} ",C1.GetArea(5));

            Console.WriteLine();

            Circle C2 = new Circle(0);
            Console.WriteLine("Area av Cirkel 2: {0}",C2.GetArea(6));
            Console.WriteLine();
            Circle C3 = new Circle(0);

            Console.Write("Skriv in en Radie för att räkna ut en cirkels Omkrets: ");
            Console.WriteLine("Omkretsen av Cirkel 3 är : {0}",C3.GetCircumference(float.Parse(Console.ReadLine())));

            Console.ReadKey();
        }
    }
}
