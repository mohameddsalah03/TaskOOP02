using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP02
{
    internal class OnlineOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * .10m;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processes orders placed online");
        }
    }
}
