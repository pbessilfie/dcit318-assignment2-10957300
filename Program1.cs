using System;
class Program1
{

    public class Animal
    {
        public virtual void MakeSound() { 
        Console.WriteLine("Roar");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound() { 
        Console.WriteLine("Bark");
        }
    }   
    public class Cat : Animal
    {
        public override void MakeSound() { 
        Console.WriteLine("Meow");
        }
    }
    static void Main()
    {
       
    }
}