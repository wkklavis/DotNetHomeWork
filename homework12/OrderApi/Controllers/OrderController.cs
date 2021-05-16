using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        OrderContext db;

        public OrderController(OrderContext db)
        {
            this.db = db;
        }

        [HttpGet("getCount")]
        public int GetCount()
        {
            return db.Orders.Count();
        }

        // GET: Order/getAll
        // 查询所有订单
        [HttpGet("getAll")]
        public ActionResult<List<Order>> Get()
        {
            return db.Orders.Include(o=>o.Customer)
                .Include(o => o.Details)
                .Include(o => o.Commodities)
                .ToList();
        }




        [HttpGet("{orderNo}")]
        public ActionResult<Order> GetOrder(int orderNo)
        {
            var item = db.Orders.Include(o => o.Customer)
                .Include(o => o.Details)
                .Include(o => o.Commodities)
                .FirstOrDefault(o => o.OrderNo == orderNo);
            if (item == null) { return NotFound(); }
            else return item;
        }
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }
        [HttpPut("{no}")]
        public ActionResult<Order> PutOrder(int no,Order order)
        {
            if (no != order.OrderNo) { return BadRequest("Can't be modified;"); }
            try
            {
                db.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(int id)
        {
            try
            {
                var item = db.Orders.FirstOrDefault(o => o.OrderNo == id);
                if (item != null)
                {
                    db.Remove(item);
                    db.SaveChanges();
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
