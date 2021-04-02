using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class OrderService
    {
       public List<Order> orderList = new List<Order>();
        public void AddOrder(Order order) { orderList.Add(order); }
        public void DeleteOrder(Int32 orderNoNum)
        {
            if (orderList.Remove(orderList.Find(order => order.OrderNo==orderNoNum))) Console.WriteLine("删除成功");
            else throw new ArgumentException("删除失败");
        }
        public List<Order> QueryOrder(Int32 orderNoNum) {
            List<Order> queryList = (from order 
                                     in orderList 
                                     where orderNoNum == order.OrderNo 
                                     select order).ToList();
            
            return queryList;
        }
        public List<Order> QueryOrder(String commodityName)
        {
            List<Order> queryList = (from order 
                                     in orderList 
                                     where order.list.Find(item=>item.CommodityName==commodityName)!=null 
                                     orderby order.totalPrice  
                                     select order  ).ToList();
            
            return queryList;
        }
        public List<Order> QueryOrder(Customer customer)
        {
            List<Order> queryList = (from order 
                                     in orderList 
                                     where order.customer== customer 
                                     orderby order.totalPrice 
                                     select order).ToList();
            
            return queryList;
        }
        public List<Order> QueryOrder(double totalPrice)
        {
            List<Order> queryList = (from order 
                                     in orderList 
                                     where order.totalPrice == totalPrice 
                                     orderby order.totalPrice 
                                     select order).ToList();
           
            return queryList;
        }



    }
    
}
