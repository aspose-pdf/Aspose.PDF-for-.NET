namespace Aspose.PDF.Invoicer
{
    public class ProductItem
    {
        public string Id;
        public string Name;
        public decimal Price;
        public int Quantity;
        public decimal Total => Price * Quantity;

        public ProductItem(string id, string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}