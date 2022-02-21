using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo
{
    public abstract class CreditCard
    {
        public string CardType { get; set; }
        public string CardName { get; set; }
        public int CardLimit { get; set; }
        public int CardCharge { get; set; }
        public CreditCard()
        {

        }
        public CreditCard(string CardType, string CardName, int CardLimit, int CardCharge)
        {
            this.CardType = CardType;
            this.CardName = CardName;
            this.CardLimit = CardLimit;
            this.CardCharge = CardCharge;
        }
        public virtual void InputInfor(string cardtype)
        {
            CardType = cardtype;
            Console.Write("Input card name: ");
            CardName = Console.ReadLine();
            Console.Write("Input limit of card: ");
            CardLimit = int.Parse(Console.ReadLine());
            Console.Write("Input card charging: ");
            CardCharge = int.Parse(Console.ReadLine());
        }
        public virtual void OutPut()
        {
            Console.WriteLine("\n");
            Console.WriteLine(CardType + " - " + CardName + " - " + CardLimit + " - " + CardCharge);
        }
    }
}
