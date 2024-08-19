using System.Xml.Linq;

namespace Simple_Inventory_Management_System
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product()
        {
            Name = string.Empty;
            Price = 0.0;
            Quantity = 0;
        }
        public Product(string? name, double price, int quantity)
        {
            Name = name ?? string.Empty;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"Name : {Name}\nPrice : ${Price}\nQuantity : {Quantity}";
        }
    }
}
