using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace demo01
{
    
   public class OrderService
    {

        public List<Order> orderList = new List<Order>();
        public bool AddOrder(Order order)
        {
            orderList.ForEach(item => { if (order.Equals(item)) throw new ApplicationException("订单已存在"); });
            orderList.Add(order);
            return true; 
        }
        public bool DeleteOrder(Int32 orderNoNum)
        {
            if (orderList.Remove(orderList.Find(order => order.OrderNo == orderNoNum))) return true;
            else throw new ArgumentException("删除失败");
        }
        public Order QueryOrder(Int32 orderNoNum)
        {
            List<Order> queryList = (from order
                                     in orderList
                                     where orderNoNum == order.OrderNo
                                     select order).ToList();

            return queryList.First();
        }
        public List<Order> QueryOrder(String commodityName)
        {
            List<Order> queryList = (from order
                                     in orderList
                                     where order.list.Find(item => item.CommodityName == commodityName) != null
                                     orderby order.TotalPrice
                                     select order).ToList();

            return queryList;
        }
        public List<Order> QueryOrder(Customer customer)
        {
            List<Order> queryList = (from order
                                     in orderList
                                     where order.customer .Equals(customer)//测试判断出不可以使用== ，必须使用Equals
                                     orderby order.TotalPrice
                                     select order).ToList();

            return queryList;
        }
        public List<Order> QueryOrder(double totalPrice)
        {
            List<Order> queryList = (from order
                                     in orderList
                                     where order.TotalPrice == totalPrice
                                     orderby order.TotalPrice
                                     select order).ToList();

            return queryList;
        }

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));

        public OrderService()
        {
        }

        //添加Export以及Import方法
        public bool Export(String filePath)//所有序列化里面元素都需要为public声明
        {
            if (Path.GetExtension(filePath) != ".xml") throw new ArgumentException("文件类型错误");
            using (FileStream fs = new FileStream(filePath,FileMode.Create))
            {
                Order[] orders = orderList.ToArray();
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
                orderList.Clear();
                Array.ForEach(orders,order => { if (!orderList.Contains(order)) orderList.Add(order); });
                return true;
            }
        }
    }
    
}
