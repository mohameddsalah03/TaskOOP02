namespace TaskOOP02
{
    internal class Program
    {

        public static IOrderProcessor OrderType(string Type)
        {
            if (Type.ToUpper() == "online")
            {
                return new OnlineOrderProcessor();
            }
            if (Type.ToUpper() == "inStore")
            {
                return new InStoreOrderProcessor();
            }
            else
                return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Type Of Order : ");
            string? typeOrder=Console.ReadLine();
            IOrderProcessor order=  OrderType(typeOrder);
            
            Order order01 = new Order(1, "mohamed", 150, order);

            order01.OrderProcessor.ProcessOrder();
            decimal discount = order01.OrderProcessor.CalculateDiscount(order01.OrderAmount);
            Console.WriteLine($"Discount : {discount}");
            


        }
    }
}
