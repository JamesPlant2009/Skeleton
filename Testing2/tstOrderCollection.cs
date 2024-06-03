using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstacnceOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> testList = new List<clsOrder>();
            clsOrder testItem  = new clsOrder();
            testItem.OrderShipped = true;
            testItem.OrderId = 1;
            testItem.StockId = "1A";
            testItem.CustomerId = 1;
            testItem.Price = 1;
            testItem.DateOrdered = DateTime.Now;
            testList.Add(testItem);
            AllOrders.OrderList = testList;
            Assert.AreEqual(AllOrders.OrderList, testList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder testOrder = new clsOrder();
            testOrder.OrderShipped = true;
            testOrder.OrderId = 1;
            testOrder.StockId = "1A";
            testOrder.CustomerId = 1;
            testOrder.Price = 1;
            testOrder.DateOrdered = DateTime.Now;
            AllOrder.ThisOrder = testOrder;
            Assert.AreEqual(AllOrder.ThisOrder, testOrder);

        }
        [TestMethod]
        public void ListandCount()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> testList = new List<clsOrder>();
            clsOrder testItem = new clsOrder();
            testItem.OrderShipped = true;
            testItem.OrderId = 1;
            testItem.StockId = "1A";
            testItem.CustomerId = 1;
            testItem.Price = 1;
            testItem.DateOrdered = DateTime.Now;
            testList.Add(testItem);
            AllOrder.OrderList = testList;
            Assert.AreEqual(AllOrder.Count, testList.Count);
        }

    }
}
