using System;
using System.Diagnostics.Contracts;


namespace ConsoleApp2
{
    public abstract class Shape
    {
        public abstract int GetArea();
    }

   public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override int GetArea()
        {
            return (22 / 7) * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public override int GetArea()
        {
            return Length * Breadth;
        }
    }
    class Program2
    {

        static void Main()
        {
            Console.WriteLine("Hello World");
        }
    }
}
