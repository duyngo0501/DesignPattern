using System;

namespace DesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cardType = "MoneyBack";
            //CreditCard myCard = null;
            //if (cardType.Equals("Money"))
            //    myCard = new MoneyBack();
            //else if (cardType.Equals("Titaninum"))
            //    myCard = new Titanium();
            //else if (cardType.Equals("Platinum"))
            //    myCard = new Platinum();
            //else
            //    Console.WriteLine("Invalid Card");
            //Console.WriteLine("Enter your card type: ");
            //string cardType = Console.ReadLine();

            //CreditCard card = CreditCardFactory.GetCreditCard(cardType);
            //card.InputInfor();
            //card.OutPut();
            CardManagement manage = new CardManagement();
            {
                int option = 0;
                bool check = false;
                do
                {
                    option = manage.Menu();
                    string name;
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Input the type of card(MoneyBack/Titanium/Platinum): ");
                            string CardType = Console.ReadLine();
                            manage.AddCard(CardType);
                            break;
                        case 2:
                            manage.ShowAll();
                            break;
                        case 3:
                            manage.ShowPlatium();
                            break;
                        case 4:
                            Console.Write("Input the card name you want to search: ");
                            name = Console.ReadLine();
                            manage.SearchCardByName(name);
                            break;
                        case 5:
                            Console.Write("Input the card name you want to delete: ");
                            name = Console.ReadLine();
                            manage.DeleteByCard(name);
                            break;
                        case 6:
                            Console.Write("Input the card name you want to update: ");
                            name = Console.ReadLine();
                            manage.UpdateCardByName(name);
                            break;
                        case 7:
                            Console.WriteLine("Exit Succesfully!!!");
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Wrong Input!!!");
                            break;
                    }
                } while (check == false);
            }

        }
    }
}

