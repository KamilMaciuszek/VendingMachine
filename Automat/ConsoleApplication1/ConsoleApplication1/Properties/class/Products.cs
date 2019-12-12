namespace ConsoleApplication1.Properties.@class
{
    public class Products
    {
        public int NumberOfItems { get; set; }

        public string Location { get; set; }

        public string Identify { get; set; }

        public double Price { get; set; }
        

        public bool IsAvailable()
        {
            return NumberOfItems > 0;
        }

        public void RemoveItem(int availableItems)
        {
            NumberOfItems--;
        }
    }
}