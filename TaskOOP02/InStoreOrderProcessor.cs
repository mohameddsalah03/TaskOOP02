using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP02
{
    internal class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * .05m;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("placed in physical stores");
        }
    }
}
