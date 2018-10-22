using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrdersApi.Models;

namespace OrdersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        // GET api/orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return new List<Order>(){
                new Order() { Id = 1, Amount = 30.95M },
                new Order() { Id = 2, Amount = 44.99M }
            };
        }
    }
}
