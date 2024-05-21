using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderShippedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean testData = true;
            AnOrder.OrderShipped = testData;
            Assert.AreEqual(AnOrder.OrderShipped, testData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime testData = DateTime.Now.Date;
            AnOrder.DateOrdered = testData;
            Assert.AreEqual(AnOrder.DateOrdered, testData);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.OrderId = testData;
            Assert.AreEqual(AnOrder.OrderId, testData);
        }
        [TestMethod]
        public void OrderPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.Price = testData;
            Assert.AreEqual(AnOrder.Price, testData);
        }
        [TestMethod]
        public void StockIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string testData = "123A";
            AnOrder.StockId = testData;
            Assert.AreEqual(AnOrder.StockId, testData);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.CustomerId = testData;
            Assert.AreEqual(AnOrder.CustomerId, testData);
        }
        [TestMethod]
        public void FindMethodOK() 
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 1) 
            {
            OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.CustomerId != 1)
            {
                OK= false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOrderedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found= AnOrder.Find(OrderId);
            if(AnOrder.DateOrdered != Convert.ToDateTime("14/05/2025"))
            {
            OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false
                , OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.Price != 1)
            {
                OK=false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.StockId != "123A")
            {
                OK=false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderShipped()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if( AnOrder.OrderShipped != true )
            {
                OK=false;
            }
            Assert.IsTrue(OK);
        }
    }
}
