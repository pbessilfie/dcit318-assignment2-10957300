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
            Circle myCircle = new Circle(5);
            Console.WriteLine("Area of circle: " + myCircle.GetArea());

            Rectangle myRectangle = new Rectangle(55, 36);
            Console.WriteLine("Area of rectangle: " + myRectangle.GetArea());
        }
    }
}
