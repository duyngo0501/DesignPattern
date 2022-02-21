using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo
{
    public class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard cardDetails = null;
            switch(cardType)
            {
                case "MoneyBack":
                    cardDetails = new MoneyBack();
                    break;
                case "Titanium":
                    cardDetails = new Titanium();
                    break;
                case "Platinum":
                    cardDetails = new Platinum();
                    break;
                default:
                    break;
            }
            return cardDetails;
        }
    }
}
