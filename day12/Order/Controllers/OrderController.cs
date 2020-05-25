using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Order.Models;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly OrderContext OrderDb;

        //构造函数把OrderContext 作为参数，Asp.net core 框架可以自动注入OrderContext对象
        public OrderController(OrderContext context)
        {
            this.OrderDb = context;
        }

        // GET: api/order/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<OrderItem> GetOrderItem(long id)
        {
            var OrderItem = OrderDb.OrderItems.FirstOrDefault(t => t.Id == id);
            if (OrderItem == null)
            {
                return NotFound();
            }
            return OrderItem;
        }

        // GET: api/order
        // GET: api/order/pageQuery?name=课程&&isComplete=true
        [HttpGet]
        public ActionResult<List<OrderItem>> GetOrderItems(string name, string itemName, double unitPrice,int quantity)
        {
            var query = buildQuery(name, itemName,unitPrice ,quantity);
            return query.ToList();
        }

        // GET: api/order/pageQuery?skip=5&&take=10  
        // GET: api/order/pageQuery?name=课程&&isComplete=true&&skip=5&&take=10
        [HttpGet("pageQuery")]
        public ActionResult<List<OrderItem>> queryOrderItem(string name, string itemName, double unitPrice,int quantity, int skip, int take)
        {
            var query = buildQuery(name, itemName,unitPrice ,quantity).Skip(skip).Take(take);
            return query.ToList();
        }

        private IQueryable<OrderItem> buildQuery(string name, string itemName, double unitPrice,int quantity)
        {
            IQueryable<OrderItem> query = OrderDb.TodoItems;
            if (name != null)
            {
                query = query.Where(t => t.Name.Contains(name));
            }
            if (itemName != null)
            {
                query = query.Where(t => t.Name.Contains(name));  
            }
            if(unitPrice !=null)
            {
                query = query.Where(t => t.UnitPrice == unitPrice);
            }
            if(quantity!=null)
            {
                query=query.Where(t=>t.Quantity=quantity);
            }
            return query;
        }


        // POST: api/order
        [HttpPost]
        public ActionResult<OrderItem> PostOrderItem(OrderItem order)
        {
            try
            {
                OrderDb.OrderItems.Add(order);
                OrderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // PUT: api/todo/{id}
        [HttpPut("{id}")]
        public ActionResult<OrderItem> PutOrderItem(long id, OrderItem order)
        {
            if (id != order.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                OrderDb.Entry(order).State = EntityState.Modified;
                OrderDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrderItem(long id)
        {
            try
            {
                var order = OrderDb.OrderItems.FirstOrDefault(t => t.Id == id);
                if (order != null)
                {
                    OrderDb.Remove(order);
                    OrderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}