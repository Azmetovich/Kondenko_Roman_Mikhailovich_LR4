using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librari.Interfaces
{
    public interface IProductService
    {
        decimal CalculateTotal(decimal price, int quantity);
        decimal ApplyDiscount(decimal price, decimal discount);
    }
}
