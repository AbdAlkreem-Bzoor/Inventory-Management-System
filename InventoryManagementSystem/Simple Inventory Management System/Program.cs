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
                FormattingOutput.DisplayOptions();
                string? input = Console.ReadLine(); input = input?.Trim();
                if (input == "Exit") break;
                while (!InputValidation.IsValid(input))
                {
                    FormattingOutput.DisplayOptionsError();
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
                Console.WriteLine("__________________________________________________________________\n\n");
            }
        }
        public static void AddProduct(Inventory inventory) => inventory.Add(InputValidation.InputProduct());

        public static void DispalyProducts(Inventory inventory) => inventory.Display();
        public static void UpdateProduct(Inventory inventory)
        {
            FormattingOutput.DisplayNameForOptionsInput("Update");
            string? name = Console.ReadLine(); name = name?.Trim();
            inventory.Update(name);
        }
        public static void DeleteProduct(Inventory inventory)
        {
            FormattingOutput.DisplayNameForOptionsInput("Delete");
            string? name = Console.ReadLine(); name = name?.Trim();
            inventory.Delete(name);
        }
        public static void SearchProduct(Inventory inventory)
        {
            FormattingOutput.DisplayNameForOptionsInput("Search");
            string? name = Console.ReadLine(); name = name?.Trim();
            inventory.Search(name);
        }
    }
}
