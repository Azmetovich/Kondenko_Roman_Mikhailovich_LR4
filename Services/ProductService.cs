using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librari.Interfaces;
using Librari.Exceptions;

namespace Librari.Services
{
    public class ProductService : IProductService
    {
        public decimal CalculateTotal(decimal price, int quantity)
        {
            if (price < 0 || quantity <= 0)
            {
                throw new InvalidProductException("Неверная цена или количество");
            }

            return price * quantity;
        }

        public decimal ApplyDiscount(decimal price, decimal discount)
        {
            if (price < 0 || discount < 0 || discount > 100)
            {
                throw new InvalidProductException("Неверная цена или скидка");
            }

            return price - price * discount / 100;
        }
    }
}
