using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo
{
    public class MoneyBack : CreditCard, ICreditCard
    {
        public int GetAnnualCharge()
        {
            return CardCharge;
        }

        public int GetCardLimit()
        {
            return CardLimit;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }
    }
}
