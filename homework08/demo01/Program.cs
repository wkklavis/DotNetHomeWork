using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();

            /*Customer customer1 = new Customer("w", 18, '男');
            OrderDetails details1 = new OrderDetails("wuhan");
            Order order1 = new Order(customer1, 123 ,details1);
            order1.AddInfo(1,"西瓜",20);
  
            Customer customer2 = new Customer("z", 19, '女');
            OrderDetails details2 = new OrderDetails("wuhan");
            Order order2 = new Order(customer2, 124, details2);
            order2.AddInfo(1, "西瓜", 15);
        

            service.AddOrder(order1);
            service.AddOrder(order2);*/

            //service.Export("s.xml");
            //Console.WriteLine(File.ReadAllText("s.xml"));

            Console.WriteLine("----------");
            service.Import("s.xml");
            service.orderList.ForEach(item => Console.WriteLine(item));
        }
    }
}
