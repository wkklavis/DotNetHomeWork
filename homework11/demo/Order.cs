using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    [Serializable]
    public class Order : IComparable
    {
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        [Key]
        public Int32 OrderNo { get; set; }

        public Double totalPrice;
        
        public Double TotalPrice
        {
            get
            {
                double sum = 0;
                Commodities.ForEach(item => sum += item.CommodityPrice);
                return sum;
            }
            set 
            {
                double sum = 0;
                Commodities.ForEach(item => sum += item.CommodityPrice);
                totalPrice = sum;
            }
        }
        
        
        public OrderDetails Details { get; set; }
        public int DetailsId { get; set; }
        public List<CommodityInfo> Commodities { get; set; } = new List<CommodityInfo>();

        public Order(Customer customer, Int32 orderNo, OrderDetails details)
        {
            this.Customer = customer;
            OrderNo = orderNo;
            this.Details = details;
        }

        public Order(Customer customer, int orderNo, double totalPrice, OrderDetails details)
        {
            this.Customer = customer;
            OrderNo = orderNo;
            TotalPrice = totalPrice;
            Details = details;
        }

        public Order()
        {
        }

        //对Order里面具体商品数据进行修改
        public void AddInfo(int no, String name, double price)
        {
            /*CommodityInfo commodity = new CommodityInfo(no, name, price);
            commodity.Order = this;
            using (var db = new OrderContext())
            {
                db.Commodities.Add(commodity);               
                db.SaveChanges();
            }*/
            this.Commodities.Add(new CommodityInfo(no, name, price));
        }
        
        public void DeleteInfo(int no)
        {
            using (var db = new OrderContext())
            {
                var query = db.Commodities.FirstOrDefault(com => com.CommodityNo == no);
                if (query != null)
                {
                    db.Commodities.Remove(query);
                    db.SaveChanges();
                }               
            }
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

            return $" {Customer} 订单{OrderNo} 配送{Details} 总计{TotalPrice}元";
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Customer>.Default.Equals(Customer, order.Customer) &&
                   OrderNo == order.OrderNo;
        }

        public override int GetHashCode()
        {
            int hashCode = 305862269;
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + OrderNo.GetHashCode();
            return hashCode;
        }
    }



}
