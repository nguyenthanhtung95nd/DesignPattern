using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern.AbstractFactory
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}
