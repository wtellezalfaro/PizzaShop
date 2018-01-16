using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaShop.Models.PizzaEF
{
    public partial class Product
    {
        public decimal suma
        {
            get
            {
                return OrderProducts.Where(n => n.ProductPrice > 5).Sum(n => n.ProductPrice);
            }
        }

    }
}