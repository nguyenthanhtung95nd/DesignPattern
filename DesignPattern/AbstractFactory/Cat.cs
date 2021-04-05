using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern.AbstractFactory
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }
    }
}
