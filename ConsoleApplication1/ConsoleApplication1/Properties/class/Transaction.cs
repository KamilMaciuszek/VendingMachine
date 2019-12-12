using System;

namespace ConsoleApplication1.Properties.@class
{
    public class Transaction
    {
        public static double MakeTransaction(double money)
        {
            while (true)
            {
                Console.WriteLine("Dostępny kredyt: {0} zł",money);
                Console.WriteLine();
                VendingMachine.DisplayProducts();
                Console.WriteLine();
                Console.WriteLine("Wybierz kod produktu z listy powyżej. ");
                Console.WriteLine("Aby wrócić do menu głównego, wybierz 0 oraz zatwierdź.");
                
                var loc = Console.ReadLine();

                if (loc =="0")
                {
                    break;
                }
                
                
                foreach (var items in VendingMachine.ProductsList)
                {
                    // ReSharper disable once PossibleNullReferenceException
                    if (CheckIfContains(loc.ToUpper(), items.Location) && CheckIfEnoughMoney(money,items.Price) && items.IsAvailable())
                    {
                        money -= items.Price;
                        items.RemoveItem(items.NumberOfItems);
                        Console.WriteLine("Odbierz swój produkt: {0}", items.Identify);
                        break;
                    }
                   

                    if (CheckIfContains(loc.ToUpper(), items.Location) && !CheckIfEnoughMoney(money,items.Price))
                    {
                        Console.WriteLine("Niewystarczająca ilość pieniędzy na zakup produktu. ");
                        Console.WriteLine("Wybierz inny produkt lub wrzuć więcej monet. ");
                        break;
                    }

                    if (CheckIfContains(loc.ToUpper(), items.Location) && !items.IsAvailable())
                    {
                        Console.WriteLine("Ten produkt jest już niedostępny, wybierz inny produkt.");
                    }
                }
            }

            return money;
        }

        private static bool CheckIfContains(string input, string checkedLocation)
        {
            return input == checkedLocation;
        }

        private static bool CheckIfEnoughMoney(double moneyIn, double ItemPrice)
        {
            return moneyIn >= ItemPrice;
        }
    }
}