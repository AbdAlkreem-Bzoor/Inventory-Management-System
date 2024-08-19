namespace Simple_Inventory_Management_System
{
    public static class InputValidation
    {
        public static bool IsValid(string? input)
        {
            switch (input)
            {
                case "Add": return true;
                case "Display": return true;
                case "Update": return true;
                case "Delete": return true;
                case "Search": return true;
                default: return false;
            }
        }

        public static bool IsLetter(char c) => (c >= 65 && c <= 90) || (c >= 97 && c <= 122);
        public static bool IsNumber(char c) => (c >= 48 && c <= 57);
        public static bool CheckName(string? name)
        {
            if (name is null) return false;
            if (name.Length < 3 || name.Length > 50) return false; // check the length of the name
            foreach (char c in name) // check the characters in the name
            {
                if (c != ' ' && !IsLetter(c) && !IsNumber(c) && c != '-' && c != '_') return false;
            }
            if (!IsLetter(name[0])) return false; // check the first charater of the name(has to be letter)
            return true;
        }
        public static bool CheckPrice(string? price)
        {
            if (!double.TryParse(price, out double _price) || _price < 0) return false;
            return true;
        }
        public static bool CheckQuantity(string? quantity)
        {
            if (!int.TryParse(quantity, out int _quantity) || _quantity < 0) return false;
            return true;
        }
        public static Product InputProduct()
        {
            Console.WriteLine("Input Product :\n\n\n");
            Console.WriteLine("Input Product Name : ");
            string? name = Console.ReadLine();
            while (!CheckName(name))
            {
                Console.WriteLine("Please Write a valid name!!!\n");
                name = Console.ReadLine();
            }
            Console.WriteLine("Input Product Price : ");
            string? price = Console.ReadLine();
            while (!CheckPrice(price))
            {
                Console.WriteLine("Please Write a valid price!!!\n");
                price = Console.ReadLine();
            }
            Console.WriteLine("Input Product Quantity : ");
            string? quantity = Console.ReadLine();
            while (!CheckQuantity(quantity))
            {
                Console.WriteLine("Please Write a valid quantity!!!\n");
                quantity = Console.ReadLine();
            }
            return new(name, price, quantity);
        }
    }
}
