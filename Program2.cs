using System;


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
    class Program2
    {

        static void Main()
        {
            Console.WriteLine("Hello World");
        }
    }
}
