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
            Console.Write("Skriv in en radie av en cirkel för att räkna ut cirkelns omkrets: ");
            Console.WriteLine("Omkretsen av Cirkel 3 är : {0}",C3.GetCircumference(float.Parse(Console.ReadLine())));
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Räkna ut Arean av en triangel");
            Console.Write("Skriv in höjden på triangeln: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Skriv in basen på triangeln: ");
            float width = float.Parse(Console.ReadLine());
            Triangle T1 = new Triangle(height, width);
            Console.WriteLine("Arean av triangeln är = {0}", T1.GetArea());
            
            Console.ReadKey();
        }
    }
}
