using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace demo
{
    
   public class OrderService
    {

        public List<Order> OrderList { get; set; }
        public bool AddOrder(Order order)
        {
            using (var db = new OrderContext())
            {
                db.Orders.Add(order);                
                
                db.SaveChanges();
            }
            return true; 
        }
        public bool DeleteOrder(Int32 orderNoNum)
        {
            using (var db = new OrderContext()) 
            {
                var query = db.Orders.Include("Customer").Include("Commodities").FirstOrDefault(o => o.OrderNo == orderNoNum);
                if (query != null) 
                {       
                    db.Orders.Remove(query); 
                    db.SaveChanges(); 
                    return true; 
                }
                else return false;
            }
            
        }
        public Order QueryOrder(Int32 orderNoNum)
        {
            using (var db = new OrderContext())
            {
               return db.Orders.Include("Customer").Include("Commodities").SingleOrDefault(o=>o.OrderNo==orderNoNum);
                
            }
        }
        public List<Order> QueryOrder(String commodityName)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include("Customer").Include("Commodities").Where(o => o.Commodities.Where(com => com.CommodityName == commodityName)!=null);
                return query.ToList<Order>();
            }
        }
       
        public List<Order> QueryOrder(double totalPrice)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include("Customer").Include("Commodities").Where(o => o.TotalPrice==totalPrice);
                return query.ToList<Order>();
            }
        }

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));

        public OrderService()
        {
            using (var db = new OrderContext())
            {
                OrderList = db.Orders.Include("Customer").Include("Commodities").ToList<Order>();
            }
        }

        //添加Export以及Import方法
        public bool Export(String filePath)//所有序列化里面元素都需要为public声明
        {
            if (Path.GetExtension(filePath) != ".xml") throw new ArgumentException("文件类型错误");
            using (FileStream fs = new FileStream(filePath,FileMode.Create))
            {
                Order[] orders = OrderList.ToArray();
                xmlSerializer.Serialize(fs, orders);
                return true;
            }
        }

        public bool Import(String filePath)
        {
            if (Path.GetExtension(filePath) != ".xml") throw new ArgumentException("文件类型错误");
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                Order[] orders = (Order[])xmlSerializer.Deserialize(fs);
                OrderList.Clear();
                Array.ForEach(orders,order => { if (!OrderList.Contains(order)) OrderList.Add(order); });
                return true;
            }
        }
    }
    
}
