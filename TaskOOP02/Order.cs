using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP02
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public IOrderProcessor OrderProcessor { get; set; }


        public Order(int orderId, string customerName, decimal orderAmount, IOrderProcessor orderProcessor)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderAmount = orderAmount;
            OrderProcessor = orderProcessor;
        }

        
    }
}
