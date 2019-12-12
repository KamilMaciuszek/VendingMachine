using System;


namespace ConsoleApplication1.Properties.@class
{
    public class Menu
    {
        private readonly AddMoney _addMoney = new AddMoney();

        public void MenuDisplay()
        {
            var vm = new VendingMachine();

            while (true)
            {
                Console.Clear();

                VendingMachine.DisplayProducts();

                Console.WriteLine();
                Console.WriteLine("Dostępny kredyt: {0} zł",vm.Money);
                Console.WriteLine("Dokonaj transakcji- D");
                Console.WriteLine("Wrzuć monetę- W");
                Console.WriteLine("Koniec. - K");
                Console.WriteLine();
                
                var x = Console.ReadLine();
                
                // ReSharper disable once PossibleNullReferenceException
                
                if (x.ToUpper() == "D")
                {
                    vm.Money=Transaction.MakeTransaction(vm.Money);
                }

                else if (x.ToUpper()=="K")
                {
                    Console.WriteLine("Smacznego, zapraszamy ponownie.");
                    Change.MakeChange(vm.Money);
                    break;
                }
                
                else if(x.ToUpper()=="W")
                {
                 vm.Money=_addMoney.PutCoin(vm.Money);
                }
                
                else
                {
                    Console.WriteLine("Użyj jednej z dostępnych opcji:");
                }
                
                Console.ReadLine();
            }
        }
    }
}