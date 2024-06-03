using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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
            Assert.AreNotEqual(Error, "");
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
            Assert.AreNotEqual(Error, "");
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
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateTimeExMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate =testDate.AddYears(-100);
            string orderDate = testDate.ToString();
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateTimeExMax() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(100);
            string orderDate = testDate.ToString();
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateTimeMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(-1);
            string orderDate = testDate.ToString();
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateTimeMin() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            string orderDate = testDate.ToString();
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateTimeMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(1);
            string orderDate = testDate.ToString();
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateTimeError() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string orderDate = "This is the wrong data type";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "0";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "10000";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void priceError()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "This is the wrong data type";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceExMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "-999999";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceExMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "999999";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceMinMinusOne() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "-1";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "9999";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void priceMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "1";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void priceMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "10001";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceMid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "5000";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "0";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustIdMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "10000";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustIdError()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "This is the wrong data type";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustIdExMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "-999999";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustIdExMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "999999";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustIdMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string price = "-1";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustIdMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "9999";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "1";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "10001";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string customerId = "5000";
            Error = AnOrder.Valid(stockId, customerId, price, orderDate);
            Assert.AreEqual(Error, "");
        }
    }
}
