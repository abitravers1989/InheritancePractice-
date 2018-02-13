using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConsoleApp.cs
{
    public class Cat: Animal  
    {
        public Cat(string name, int age, string status) : base(age, 4, name, "cat", status)
        { }

        public override string Introduce() 
        {
            return base.Introduce() + "  Meow";
           // Console.WriteLine("  Meow!");
        }


    }
}
