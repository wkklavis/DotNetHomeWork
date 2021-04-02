using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Order:IComparable
    {
        public Customer customer { get; set; }

        public Int32 OrderNo { get; set; }
        public Double totalPrice
        {
            get
            {
                double sum = 0;
                list.ForEach(item => sum += item.CommodityPrice);
                return sum;
            }
        }

        OrderDetails details;
        public List<CommodityInfo> list = new List<CommodityInfo>();

        public Order(Customer customer, Int32 orderNo, OrderDetails details)
        {
            this.customer = customer;
            OrderNo = orderNo;
            this.details = details;
        }


        //对Order里面具体商品数据进行修改
        public void AddInfo(int no, String name, double price)
        {
            CommodityInfo info = new CommodityInfo(no, name, price);
            list.ForEach(item => { if (item.Equals(info)) throw new ApplicationException("商品已存在"); });
            list.Add(info);

        }
        public void ChangeInfo(String oldName, String newName)
        {
            CommodityInfo comm = list.Find(info => info.CommodityName == oldName);
            if (comm == null) throw new ArgumentException("修改失败");
            else { comm.CommodityName = newName; Console.WriteLine("修改成功"); }
        }
        public void ChangeInfo(double oldPrice, double newPrice)
        {
            CommodityInfo comm = list.Find(info => info.CommodityPrice == oldPrice);
            if (comm == null) throw new ArgumentException("修改失败");
            else { comm.CommodityPrice = newPrice; Console.WriteLine("修改成功"); }
        }
        public void DeleteInfo(int no)
        {
            if (list.Remove(list.Find(info => info.CommodityNo == no))) Console.WriteLine("删除成功");
            else throw new ArgumentException("删除失败");
        }
        

        //Order比较
        public int CompareTo(object obj)
        {
            Order order = obj as Order;
            if (order == null) throw new System.ArgumentException();
            else return OrderNo.CompareTo(order.OrderNo);
        }
        public override string ToString()
        {
            
            return $" {customer} 订单{OrderNo} 配送{details} 总计{totalPrice}元";
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Customer>.Default.Equals(customer, order.customer) &&
                   OrderNo == order.OrderNo;
        }

        public override int GetHashCode()
        {
            int hashCode = 305862269;
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(customer);
            hashCode = hashCode * -1521134295 + OrderNo.GetHashCode();
            return hashCode;
        }
    }


    
}
