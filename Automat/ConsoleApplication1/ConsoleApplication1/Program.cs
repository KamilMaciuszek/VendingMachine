using ConsoleApplication1.Properties.@class;

namespace ConsoleApplication1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Add products to machine.
            var cocaCola03 = new Products
            {
                Identify = "Coca Cola 0.3", Location = "A1", Price = 2.0, NumberOfItems = 10
            };
            
            var cocaCola05 = new Products
            {
                Identify = "Coca Cola 0.5", Location = "A2", Price = 3.0, NumberOfItems = 10
            };
            
            var twix = new Products
            {
                Identify = "Twix", Location = "A3", Price = 1.5, NumberOfItems = 10
            };
            
            var bounty = new Products
            {
                Identify = "Bounty", Location = "B1", Price = 1.5, NumberOfItems = 10
            };
            
            var lays130G = new Products
            {
                Identify = "Lays 130g", Location = "B2", Price = 2.5, NumberOfItems = 10
            };
            
            var redBull03 = new Products
            {
                Identify = "Red Bull 0.3", Location = "B3", Price = 4.0, NumberOfItems = 10
            };
            
            var kinderBueno = new Products
            {
                Identify = "Kinder Bueno", Location = "C1", Price = 2.8, NumberOfItems = 10
            };
            
            var mars = new Products
            {
                Identify = "Mars", Location = "C2", Price = 2.5, NumberOfItems = 0
            };
            
            VendingMachine.ProductsList.Add(cocaCola03);
            VendingMachine.ProductsList.Add(cocaCola05);
            VendingMachine.ProductsList.Add(bounty);
            VendingMachine.ProductsList.Add(mars);
            VendingMachine.ProductsList.Add(kinderBueno);
            VendingMachine.ProductsList.Add(redBull03);
            VendingMachine.ProductsList.Add(lays130G);
            VendingMachine.ProductsList.Add(twix);
            
            //start the machine.
            var menu = new Menu();
            menu.MenuDisplay();
        }
    }
}