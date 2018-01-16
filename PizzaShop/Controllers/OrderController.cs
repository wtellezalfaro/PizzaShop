using PizzaShop.Models.PizzaEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaShop.Controllers
{
    public class OrderController : ApiController
    {
        // GET: api/Order
        public List<Order> Get()
        {
            Models.PizzaEF.PizzaShopEntities PE = new Models.PizzaEF.PizzaShopEntities();

            return PE.Orders.ToList();
        }

        // GET: api/Order/5
        public Order Get(Int64 id)
        {
            Models.PizzaEF.PizzaShopEntities PE = new Models.PizzaEF.PizzaShopEntities();
            return PE.Orders.Where(n => n.OrderId == id).First();
        }

        // POST: api/Order
        public void Post(Order order)
        {
            Models.PizzaEF.PizzaShopEntities PE = new Models.PizzaEF.PizzaShopEntities();

            PE.Orders.Add(order);

            PE.SaveChanges();
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
        }
    }
}
