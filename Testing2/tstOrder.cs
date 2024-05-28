using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        string stockId = "4A";
        string customerId = "7";
        string price = "1000";
        string orderDate = DateTime.Now.ToShortDateString();

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
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 6) 
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
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.CustomerId != 2)
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
            Int32 OrderId = 6;
            Found= AnOrder.Find(OrderId);
            if(AnOrder.DateOrdered != Convert.ToDateTime("24/05/2024"))
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
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.Price != 150)
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
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.StockId != "3B")
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
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if( AnOrder.OrderShipped != true )
            {
                OK=false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            string error = " ";
            error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void StockIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string stockId = "1";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIdMinPlusOne() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string stockId = "1A";
            Error  = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIdMinMinusOne() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string stockId = "";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, " The Stock Id must not be left blank");
        }
        [TestMethod]
        public void StockIdMaxMinusOne() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string stockId = "1AAAAAA";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIdMax() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string stockId = "1AAAAAAA";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIdMaxPlusOne() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string stockId = "1AAAAAAAA";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, " The lenght of Stock Id must not be more than 8 chars");
        }
        [TestMethod]
        public void StockIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string stockId = "1AAA";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIdExMax() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string stockId = "";
            stockId = stockId.PadRight(500, 'A');
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, " The lenght of Stock Id must not be more than 8 chars");
        }
    }
}
