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
        public static void DisplayInstructionsOptions() => Console.WriteLine("Please Write a valid input!!!\nChoose one of the following : Add, Display, Update, Delete, Search, Exit");
        public static void Fun1(string s) => Console.WriteLine($"Input the Product Name that you want to {s} : ");
        public static void Fun2(string s) => Console.WriteLine($"Please Write a valid name for the {s}!!!\n");
    }
}
