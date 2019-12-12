using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.Properties.@class
{
    public class VendingMachine
    {
        internal static List<Products> ProductsList = new List<Products>();

        public double Money { get; set; }


        public void SortList()
        {
            var products = ProductsList.OrderBy(o => o.Location).ToList();
            ProductsList = products;
        }
        
        
        public static void DisplayProducts()
        {
            ProductsList = ProductsList.OrderBy(o => o.Location).ToList();
            foreach (var p in ProductsList)
            {
                
                Console.WriteLine("Kod produktu: {0} | {1} | {2} zł | ilość w automacie: {3} ", p.Location, p.Identify, p.Price, 
                    p.NumberOfItems);
            } 
        }
    }
}