namespace Jason_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath= "C:\\Users\\Administrator\\Desktop\\Day11-12_Jason\\Jason_Inventory\\InventoryData.json";

            fetchforjasonRiceData fetchforjasonRiceData = new fetchforjasonRiceData();
            Rice data = fetchforjasonRiceData.Read(filepath);

            //Console.WriteLine(data.typeofRice.Name);
            //Console.WriteLine(data.typeofRice.price);
            //Console.WriteLine(data.typeofRice.weight);
            Console.WriteLine("data for Rice");

            for (int i = 0; i < data.typeofRice.Count; i++)
            {
                Console.WriteLine(data.typeofRice[i].Name);
                Console.WriteLine(data.typeofRice[i].price);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("Data for Pulses");

            for (int i = 0; i < data.typeofPulse.Count; i++)
            {
                Console.WriteLine(data.typeofPulse[i].Name);
                Console.WriteLine(data.typeofPulse[i].price);
                Console.WriteLine(data.typeofPulse[i].weight);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("Data for Wheat");

            for (int i = 0; i < data.typeofWheat.Count; i++)
            {
                Console.WriteLine(data.typeofWheat[i].Name);
                Console.WriteLine(data.typeofWheat[i].price);
                Console.WriteLine(data.typeofWheat[i].weight);
                Console.WriteLine("-----------------");
            }
            Console.ReadLine();
        }
    }
}
    