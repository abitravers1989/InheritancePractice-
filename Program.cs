using System;

namespace AnimalConsoleApp.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myshark = new Shark("Sam", 88, "badass");
            Console.WriteLine(myshark.Introduce());

            Cat example = new Cat("Example", 10, "Happy");
            Console.WriteLine(example.Introduce());


            Console.ReadLine();
        }
    }
}
