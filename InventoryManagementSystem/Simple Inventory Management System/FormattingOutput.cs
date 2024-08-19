namespace Simple_Inventory_Management_System
{
    public static class FormattingOutput
    {
        public static void DisplayInstructions()
        {
            Console.WriteLine("Please Follow the instraction bellow!\n\n\n");
            Console.WriteLine("To Add a Product, Write the word 'Add'");
            Console.WriteLine("To Display all Products, Write the word 'Display'");
            Console.WriteLine("To Update a Product, Write the word 'Update'");
            Console.WriteLine("To Delete a Product, Write the word 'Delete'");
            Console.WriteLine("To Search a Product, Write the word 'Search'");
            Console.WriteLine("To Exit from the Console App, Write the word Exit\n\n\n");
        }
        private static string Options() => "Choose one of the following options : Add, Display, Update, Delete, Search, Exit\n";
        public static void DisplayOptions() => Console.WriteLine(Options());
        public static void DisplayOptionsError() => Console.WriteLine($"Please Write a valid input!!!\n{Options()}");
        public static void DisplayProductInput() => Console.WriteLine("\n\nInput Product :\n\n");
        public static void DisplayProductPropertieInput(string propertie) => Console.WriteLine($"Input Product {propertie} : ");
        public static void DisplayProductPropertieError(string propertie) => Console.WriteLine($"Please Write a valid {propertie}!!!\n");
        public static void DisplayNameForOptionsInput(string s) => Console.WriteLine($"Input the Product Name that you want to {s} : ");
    }
}
