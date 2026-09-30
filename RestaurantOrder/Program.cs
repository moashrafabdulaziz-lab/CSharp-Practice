namespace RestaurantOrder
{
    enum Menue_Items : byte
    {
        Pizaa = 120,
        Burger = 150,
        Juice = 40,
        Salad = 30,
        Dessert = 60
    }
    internal class Program
    {
        public static void Order(double tax, double service, params Menue_Items[] items)
        {
            while (tax < 0 || service < 0)
            {
                Console.WriteLine("Tax and Service cannot be negative!!");

                Console.Write("Enter Tax: ");
                while (!double.TryParse(Console.ReadLine(), out tax))
                {
                    Console.WriteLine("Invalid value of Tax...");
                }

                Console.Write("Enter Service: ");
                while (!double.TryParse(Console.ReadLine(), out service))
                {
                    Console.WriteLine("Invalid value of Service...");
                }
            }

            int sum = 0;
            Console.WriteLine("Order details:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]}: {(int)items[i]}");
                sum += (int)items[i];
            }


            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Total items: {sum}");
            double Tax_Amount = (sum * (tax / 100));
            Console.WriteLine($"Tax: {Tax_Amount}");

            double Service_Amount = (sum * (service / 100));
            Console.WriteLine($"Service: {Service_Amount}");
            Console.WriteLine("-----------------------------------------------------------------------");

            double Total = sum + Tax_Amount + Service_Amount;
            Console.WriteLine($"Total order: {Total}");
        }
        static void Main(string[] args)
        {
            Order(10,5, Menue_Items.Pizaa, Menue_Items.Juice, Menue_Items.Salad);
        }
    }
}
