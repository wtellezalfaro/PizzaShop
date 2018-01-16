using PizzaShop.Models.PizzaEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaShop.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public List<Product> Get()
        {
            Models.PizzaEF.PizzaShopEntities PE = new Models.PizzaEF.PizzaShopEntities();

            return PE.Products.ToList();
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            Models.PizzaEF.PizzaShopEntities PE = new Models.PizzaEF.PizzaShopEntities();
            return PE.Products.Where(n => n.ProductId == id).First();
        }

        // POST: api/Product
        public void Post(Product product)
        {
            Models.PizzaEF.PizzaShopEntities PE = new Models.PizzaEF.PizzaShopEntities();

            PE.Products.Add(product);

            PE.SaveChanges();
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
