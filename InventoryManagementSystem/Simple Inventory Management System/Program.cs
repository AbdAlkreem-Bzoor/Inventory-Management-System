using System.Diagnostics;

namespace Simple_Inventory_Management_System
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Inventory inventory = new();
            FormattingOutput.DisplayInstructions();
            while (true)
            {
                string? input = Console.ReadLine(); input = input?.Trim();
                if (input == "Exit") break;
                while (!InputValidation.IsValid(input))
                {
                    FormattingOutput.DisplayInstructionsOptions();
                    input = Console.ReadLine(); input = input?.Trim();
                }
                switch (input)
                {
                    case "Add": AddProduct(inventory); break;
                    case "Display": DispalyProducts(inventory); break;
                    case "Update": UpdateProduct(inventory); break;
                    case "Delete": DeleteProduct(inventory); break;
                    case "Search": SearchProduct(inventory); break;
                }
                Console.WriteLine("__________________________________________________________________");
            }
        }
        public static void AddProduct(Inventory inventory) => inventory.Add(InputValidation.InputProduct());

        public static void DispalyProducts(Inventory inventory) => inventory.Display();

    }
}
