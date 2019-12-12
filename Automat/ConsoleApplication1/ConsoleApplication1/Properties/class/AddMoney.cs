using System;
using System.Diagnostics;

namespace ConsoleApplication1.Properties.@class
{
    public class AddMoney
    {
        public double PutCoin(double credits)
        {
            Console.WriteLine("dostępne nominały: 10gr | 20gr | 50gr | 1zł | 2zł | 5zł");
            while (true)
            {
                Console.WriteLine("Dostępny kredyt: {0} zł" , credits);
                Console.WriteLine("Wrzuć monetę(10|20|50|1|2|5). Aby zakończyć wrzucanie, wybierz 0.");
                
                Console.WriteLine();
                var coin = Console.ReadLine();
                Console.WriteLine();
                
                Debug.Assert(coin != null, nameof(coin) + " != null");
                if (coin == "10")
                {
                    credits += 0.10;
                    Console.WriteLine("Wrzuciłeś 10 groszy");
                }
                 
                else if (coin == "20")
                {
                    credits += 0.2;
                    Console.WriteLine("Wrzuciłeś 20 groszy");
                }
                
                else if (coin == "50")
                {
                    credits += 0.5;
                    Console.WriteLine("Wrzuciłeś 50 groszy");
                }
                
                else if (coin == "1")
                {
                    credits += 1;
                    Console.WriteLine("Wrzuciłeś złotówkę");
                }
                
                else if (coin == "2")
                {
                    credits += 2;
                    Console.WriteLine("Wrzuciłeś 2 złote");
                }
                
                else if (coin == "5")
                {
                    credits += 5;
                    Console.WriteLine("Wrzuciłeś 5 złotych");
                }
                
                else if(coin == "0") break;
                
                else
                {
                    Console.WriteLine("Wprowadź prawidłową monetę.");
                }
            }
            return credits;
        }
    }
}