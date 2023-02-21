namespace InventoryManagment
{
    class prgram
    {
        public static void Main(String[] args)
        {
            string path = "D:\\Work\\Bridgelabz\\.net repo\\InventoryManagment\\InventoryManagment\\Inventory.json";
            FetchInventory fetchInventory = new FetchInventory();

            InventoryDetails data = fetchInventory.Read(path);
            
            Console.WriteLine("Type of Rice");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].price);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine("******************************");

            }
            Console.WriteLine("******************************");
            Console.WriteLine("Type of Pulse");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            for (int i = 0; i < data.typesOfPulse.Count; i++)
            {
                Console.WriteLine(data.typesOfPulse[i].name);
                Console.WriteLine(data.typesOfPulse[i].price);
                Console.WriteLine(data.typesOfPulse[i].weight);

                Console.WriteLine("******************************");



            }
            Console.WriteLine("******************************");
            Console.WriteLine("Type of Wheat");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].price);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine("******************************");
            }
        }
    }
}