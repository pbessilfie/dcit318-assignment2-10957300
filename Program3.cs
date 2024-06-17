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
    internal class Program3
    {
    }
}
