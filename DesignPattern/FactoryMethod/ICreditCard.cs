using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern.FactoryMethod
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
