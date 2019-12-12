using System;

namespace ConsoleApplication1.Properties.@class
{
    public class Change
    {
        public static double MakeChange(double money)
        {
            double result = (int) (money / 5);
            
            Console.WriteLine();
            Console.WriteLine("Wydano {0} pięciozłotówek.",result);

            var x = money % 5;
            money = x;
            result = (int) (money / 2);
            
            Console.WriteLine("Wydano {0} dwuzłotówek", result);
            
            x = money % 2;
            money = x;
            result = (int) (money / 1);
            
            Console.WriteLine("Wydano {0} złotówek", result);
            
            x = money % 1;
            money = x;
            result = (int) (money / 0.5);

            Console.WriteLine("Wydano {0} pięćdziesięciogroszówek.", result);
            
            x = money % 0.5;
            money = x;
            result = (int) (money / 0.2);

            Console.WriteLine("Wydano {0} dwudziestogroszówek.", result);
            
            x = money % 0.2;
            money = x;
            result = (int) (money / 0.1);

            Console.WriteLine("Wydano {0} dziesięciogroszówek.", result);
            
            x = money % 0.1;
            money = x;
            
            Console.WriteLine();
            Console.WriteLine("W kasie zostało {0:N2} złotych kredytu.", money);
            
            return money;
        }
    }
}