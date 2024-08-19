namespace Simple_Inventory_Management_System
{
    public class Inventory
    {
        Dictionary<string, Product> inventory;

        public Inventory()
        {
            inventory = [];
        }

        public void Add(Product product)
        {
            if (inventory.ContainsKey(product.Name))
            {
                string s = Convert.ToString(inventory[product.Name].Quantity + product.Quantity);
                inventory[product.Name].SetQuantity(s);
            }
            else inventory.Add(product.Name, product);
        }

        public void Display()
        {
            foreach (var m in inventory)
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine(m.Value.ToString());
                Console.WriteLine("----------------------------------------------------------------------");
            }
        }
        public void Update(string? name)
        {
            if (name is null) return;
            if (inventory.ContainsKey(name))
            {
                Product product = InputValidation.InputProduct();
                inventory.Remove(name);
                Add(product);
            }
        }
        public void Delete(string? name)
        {
            if (name is null) return;
            inventory.Remove(name);
        }
        public void Search(string? name)
        {
            if(name is null) return;
            if (inventory.ContainsKey(name)) Console.WriteLine(inventory[name].ToString());
            else
                Console.WriteLine("There is no such Product");
        }
    }
}
