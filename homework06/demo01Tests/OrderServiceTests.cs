using Microsoft.VisualStudio.TestTools.UnitTesting;
using demo01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace demo01.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            OrderService service = new OrderService();
            Assert.AreEqual(service.AddOrder(new Order(new Customer("w", 18, '男'),123, new OrderDetails("wuhan"))), true);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService service = new OrderService();
            service.AddOrder(new Order(new Customer("w", 18, '男'), 123, new OrderDetails("wuhan")));
            Assert.AreEqual(service.DeleteOrder(123), true);
        }

        [TestMethod()]
        public void QueryOrderTest()//按照订单号查询
        {
            OrderService service = new OrderService();
            service.AddOrder(new Order(new Customer("w", 18, '男'), 123, new OrderDetails("wuhan")));
            Assert.AreEqual(service.QueryOrder(123), 
                            new Order(new Customer("w", 18, '男'), 123, new OrderDetails("wuhan")));
        }

        [TestMethod()]
        public void QueryOrderTest1()//按照商品名查询
        {
            OrderService service = new OrderService();
            Order order = new Order(new Customer("w", 18, '男'), 123, new OrderDetails("wuhan"));
            order.AddInfo(1, "西瓜", 30);//订单中添加商品西瓜20元
            service.AddOrder(order);

            
            //配送时间会有细微差别
            Assert.AreEqual(service.QueryOrder("西瓜").First().OrderNo,//按照西瓜名称查询
                          123  );
                         
        }

        [TestMethod()]
        public void QueryOrderTest2()//按照顾客查询
        {
            OrderService service = new OrderService();
            Order order = new Order(new Customer("w", 18, '男'), 123, new OrderDetails("wuhan"));
            order.AddInfo(1, "西瓜", 30);//订单中添加商品西瓜20元
            service.AddOrder(order);

            Assert.AreEqual(service.QueryOrder(new Customer("w", 18, '男')).First().OrderNo, 123);
        }

        [TestMethod()]
        public void QueryOrderTest3()//按照商品总价查询
        {
            OrderService service = new OrderService();
            Order order = new Order(new Customer("w", 18, '男'), 123, new OrderDetails("wuhan"));
            order.AddInfo(1, "西瓜", 30);//订单中添加商品西瓜20元
            service.AddOrder(order);

            Assert.AreEqual(service.QueryOrder(30.0).First().details.Address, "wuhan");
        }

        [TestMethod()]
        public void ExportTest()
        {
            bool isChanged = false;
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\86188\Documents\mycode\C#\DotNetHomeWork\homework06\demo01Tests\bin\Debug");
            watcher.Changed += new FileSystemEventHandler(
                   delegate(object source, FileSystemEventArgs e){ isChanged = true; });
            watcher.EnableRaisingEvents = true;

            OrderService service = new OrderService();
            service.Export("s.xml");
            Assert.AreEqual(File.ReadAllText("s.xml"),
                "<?xml version=\"1.0\"?>\r\n<ArrayOfOrder xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />");
            Assert.AreEqual(isChanged, true);//判断文件是否被更改

            //".html"触发异常。".xml"
            //windows默认换行\r\n
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService service = new OrderService();
            Order order = new Order(new Customer("w", 18, '男'), 123, new OrderDetails("wuhan"));
            order.AddInfo(1, "西瓜", 30);//订单中添加商品西瓜20元
            service.AddOrder(order);
            service.Export("s.xml");

            service.orderList.Clear();
            service.Import("s.xml");
            Assert.AreEqual(service.orderList.First().OrderNo, 123);
        }

        [TestCleanup()]
        public void ClearXMl()
        {
            File.Delete("s.xml");
            File.Create("s.xml");
        }
    }
}