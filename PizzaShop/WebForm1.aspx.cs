using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaShop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Models.PizzaEF.PizzaShopEntities PE = new Models.PizzaEF.PizzaShopEntities();

            Models.PizzaEF.Product prod = new Models.PizzaEF.Product()
            {
                ProductName = "nomobre",
                ProductType = "PIZZA",
                ProductSubType = "Hawaiian",
                ProductBakingTime = 1,
                ProductCookingTime = 1,
                ProductHeatingTime = 1,
                ProductSalePrice = 4,
            };

            PE.Products.Add(prod);

            PE.SaveChanges();

            prod.OrderProducts.Sum(n => n.ProductPrice);

            //prod.OrderProducts.First().Order.OrderNum;


            List <Models.PizzaEF.Product> prods = PE.Products.Where(n => n.ProductId == 1).ToList();


        }
    }
}