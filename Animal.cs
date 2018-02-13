using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConsoleApp.cs
{
    public abstract class Animal
    {
        public int _age;
        public int _legs;
        public string _name;
        public string _species;
        public string _status;

        public Animal(int age, int legs, string name, string species, string status)
        {
            this._age = age;
            this._legs = legs;
            this._name = name;
            this._species = species;
            this._status = status;
        }
        //the virtual keyword allows you to override the property in sub-classes 
        public virtual string Introduce()
        {
            return $"Hello my name is {this._name} and I am {this._age} years old.";
        }
    }
}
