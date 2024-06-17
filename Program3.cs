using System;

namespace ConsoleApp2
{

    public interface IMovable
    {
        void Move();
    }
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
    internal class Program3
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Move();

            Bicycle myBicycle = new Bicycle();
            myBicycle.Move();
        }
    }
}
