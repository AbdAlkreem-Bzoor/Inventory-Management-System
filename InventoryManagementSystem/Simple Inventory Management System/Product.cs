using System.Xml.Linq;

namespace Simple_Inventory_Management_System
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public Product()
        {
            Name = string.Empty;
            Price = 0.0;
            Quantity = 0;
        }
        public Product(string? name, string? price, string? quantity) : this()
        {
            SetName(name);
            SetPrice(price);
            SetQuantity(quantity);
        }
        public void SetName(string? name)
        {
            if (name is not null && InputValidation.CheckName(name)) 
                Name = name;
            else
                Console.WriteLine("The name is not valid!\nplease input a valid name!");
        }
        public void SetPrice(string? price)
        {
            if (price is not null && InputValidation.CheckPrice(price)) 
                Price = double.Parse(price);
            else
                Console.WriteLine("The price is not valid!\nplease input a valid price!");
        }
        public void SetQuantity(string? quantity)
        {
            if (quantity is not null && InputValidation.CheckQuantity(quantity)) 
                Quantity = int.Parse(quantity);
            else
                Console.WriteLine("The quantity is not valid!\nplease input a valid quantity!");
        }
        public override string ToString()
        {
            return $"Name : {Name}\nPrice : {Price}\nQuantity : {Quantity}";
        }
    }
}
