using FridayShapes.Shapes;
using System;

namespace FridayShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //=============rectangle=========//
            Console.WriteLine("Testing rectangle area");
            Rectangle rec = new Rectangle(10,12);
            Console.WriteLine(rec.getArea(10,12));
            //=============triangle=========//
            Console.WriteLine();
            Console.WriteLine("Testing triangle area");
            Triangle tri = new Triangle(10, 12);
            Console.WriteLine(tri.getAreaTri(10, 12));


        }





    }
}
