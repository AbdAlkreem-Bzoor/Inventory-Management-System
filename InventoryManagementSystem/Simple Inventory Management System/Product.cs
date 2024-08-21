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

        public static Product InputProduct()
        {
            FormattingOutput.DisplayProductInput();
            FormattingOutput.DisplayProductPropertieInput("Name");
            string? name = Console.ReadLine();
            while (!InputValidation.CheckName(name))
            {
                FormattingOutput.DisplayProductPropertieError("name");
                FormattingOutput.DisplayProductPropertieInput("Name");
                name = Console.ReadLine();
            }
            FormattingOutput.DisplayProductPropertieInput("Price");
            string? price = Console.ReadLine();
            while (!InputValidation.CheckPrice(price))
            {
                FormattingOutput.DisplayProductPropertieError("price");
                FormattingOutput.DisplayProductPropertieInput("Price");
                price = Console.ReadLine();
            }
            FormattingOutput.DisplayProductPropertieInput("Quantity");
            string? quantity = Console.ReadLine();
            while (!InputValidation.CheckQuantity(quantity))
            {
                FormattingOutput.DisplayProductPropertieError("quantity");
                FormattingOutput.DisplayProductPropertieInput("Quantity");
                quantity = Console.ReadLine();
            }
            return new(name, double.Parse(price ?? "0"), int.Parse(quantity ?? "0"));
        }

        public override string ToString()
        {
            return $"Name : {Name}\nPrice : ${Price}\nQuantity : {Quantity}";
        }
    }
}
