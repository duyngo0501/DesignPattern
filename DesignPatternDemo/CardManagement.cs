using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo
{
    public class CardManagement
    {
        private List<CreditCard> list;
        public CardManagement()
        {
            list = new List<CreditCard>();
        }
        //public  void AddCard()
        //{
        //    Console.WriteLine("Enter your card type (MoneyBack,Titaninum,Platinum): ");
        //    string type = Console.ReadLine();
        //    CreditCard card = CreditCardFactory.GetCreditCard(type);
        //    card.InputInfor();
        //    list.Add(card);
        //}
        public void AddCard(string CardType)
        {
            CreditCard card = CreditCardFactory.GetCreditCard(CardType);
            card.InputInfor(CardType);
            list.Add(card);
        }
        public void ShowAll()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("There is no card in here!!!\n");
            }
            else
            {
                foreach(var c in list )
                {
                    c.OutPut();
                }
            }
        }
        public void ShowPlatium()
        {
            foreach(var c in list)
            {
                if (c is Platinum)
                {
                    c.OutPut();
                }
            }
        }
        public void SearchCardByName(string CardName)
        {
            foreach(var s in list)
            {
                if (CardName == s.CardName)
                {
                    s.OutPut();
                }
            }
        }
        public void DeleteByCard(string CardName)
        {
            foreach(var d in list)
            {
                if (CardName == d.CardName)
                {
                    list.Remove(d);
                    return;
                }
            }
        }
        public void UpdateCardByName(string CardName)
        {
            foreach(var u in list)
            {
                if (u.CardName == CardName )
                {
                    if (u is MoneyBack)
                    {
                        MoneyBack m = u as MoneyBack;
                        try
                        {
                            Console.WriteLine("Input card type: ");
                            m.CardType = Console.ReadLine();
                            Console.WriteLine("Input limit of card: ");
                            m.CardLimit = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input card charging: ");
                            m.CardCharge = int.Parse(Console.ReadLine());
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    else if(u is Platinum)
                    {
                        Platinum p = u as Platinum;
                        try
                        {
                            Console.WriteLine("Input card type: ");
                            p.CardType = Console.ReadLine();
                            Console.WriteLine("Input limit of card: ");
                            p.CardLimit = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input card charging: ");
                            p.CardCharge = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                    else
                    {
                        Titanium t = u as Titanium;
                        try
                        {
                            Console.WriteLine("Input card type: ");
                            t.CardType = Console.ReadLine();
                            Console.WriteLine("Input limit of card: ");
                            t.CardLimit = int.Parse(Console.ReadLine());
                            Console.WriteLine("Input card charging: ");
                            t.CardCharge = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.StackTrace);
                        }
                    }
                }
            }
        }
        public int Menu()
        {
            int option = 0;
            Console.WriteLine("\n1. Add new card\n2. Show all card\n3. Show Platinum card\n4. Search card by name\n5. Delete card by name\n6. Update card by name\n7. Exit");
            Console.Write("Please enter your choice: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
