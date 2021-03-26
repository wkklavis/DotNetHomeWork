using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("w", 18, '男');
            OrderDetails details1 = new OrderDetails("wuhan");
            Order order1 = new Order(customer1, 123 ,details1);
            order1.AddInfo(1,"西瓜",20);
            order1.cal();
            

            Customer customer2 = new Customer("z", 19, '女');
            OrderDetails details2 = new OrderDetails("wuhan");
            Order order2 = new Order(customer2, 124, details2);
            order2.AddInfo(1, "西瓜", 15);
            order2.cal();

            

            OrderService service = new OrderService();

            service.AddOrder(order1);
            service.AddOrder(order2);

            service.QueryOrder(123).ForEach(item=> Console.WriteLine(item));
            Console.WriteLine("----------");
            service.QueryOrder("西瓜").ForEach(item=> Console.WriteLine(item));

            Console.WriteLine("----------");
            service.orderList.Sort();//按照订单号排序
            service.orderList.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("----------");
            service.orderList.Sort((Order o1,Order o2)=>(int)(o1.totalPrice-o2.totalPrice));//按照订单总价格排序
            service.orderList.ForEach(item => Console.WriteLine(item));
        }
    }
}
