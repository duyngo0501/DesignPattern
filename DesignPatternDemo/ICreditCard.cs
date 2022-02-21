using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCardLimit();
        int GetAnnualCharge();

    }
}
