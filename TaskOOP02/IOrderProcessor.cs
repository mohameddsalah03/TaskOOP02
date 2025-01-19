using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOOP02
{
    public interface IOrderProcessor
    {
        decimal CalculateDiscount(decimal orderAmount);
        void ProcessOrder();
    }
}
