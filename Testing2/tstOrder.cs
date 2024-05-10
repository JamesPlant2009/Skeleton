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
            AnOrder.DateAdded = testData;
            Assert.AreEqual(AnOrder.DateAdded, testData);
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
            string testData = "";
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
    }
}
