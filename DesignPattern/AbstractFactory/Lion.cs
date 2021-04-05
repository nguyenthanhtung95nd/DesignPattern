using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern.AbstractFactory
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
