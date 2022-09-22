using System;

namespace Geom.Con // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle(10);
            Console.WriteLine(cir.ToString());
            cir.Radius = 15;
            Console.WriteLine(cir.ToString());
            Console.WriteLine(Circle.CircleCount);
            Cylinder phallus = new Cylinder(3, 15);
            Console.WriteLine(phallus.ToString());
            Console.WriteLine(cir.ToString());
        }
    }
}
