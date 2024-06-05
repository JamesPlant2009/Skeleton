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
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder testItem = new clsOrder();
            int primaryKey = 0;
            testItem.OrderId = 30;
            testItem.StockId = "7A";
            testItem.CustomerId = 8;
            testItem.Price = 5000;
            testItem.DateOrdered = DateTime.Now;
            testItem.OrderShipped = true;

            AllOrder.ThisOrder = testItem;

            primaryKey = AllOrder.Add();

            testItem.OrderId = primaryKey;

            AllOrder.ThisOrder.Find(primaryKey);

            Assert.AreEqual(AllOrder.ThisOrder, testItem);
        }
        [TestMethod]
        public void UpdateMethodOK() 
        {
            clsOrderCollection allOrder = new clsOrderCollection();
            clsOrder testItem = new clsOrder();
            Int32 primaryKey = 0;
            testItem.StockId = "7A";
            testItem.CustomerId = 8;
            testItem.Price = 5000;
            testItem.DateOrdered = DateTime.Now;
            testItem.OrderShipped = true;

            allOrder.ThisOrder = testItem;
            primaryKey = allOrder.Add();

            testItem.OrderId = primaryKey;

            testItem.StockId = "7B";
            testItem.CustomerId = 9;
            testItem.Price = 4000;
            testItem.DateOrdered = DateTime.Now;
            testItem.OrderShipped = false;

            allOrder.ThisOrder = testItem;
            allOrder.Update();
            allOrder.ThisOrder.Find(primaryKey);
            Assert.AreEqual (allOrder.ThisOrder, testItem);

        }
        [TestMethod]
        public void DeleteMethodOK() 
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder testItem = new clsOrder();
            Int32 primaryKey = 0;
            testItem.StockId = "10A";
            testItem.CustomerId = 8;
            testItem.Price = 5000;
            testItem.DateOrdered = DateTime.Now;
            testItem.OrderShipped = true;
            AllOrder.ThisOrder = testItem;
            primaryKey = AllOrder.Add();
            testItem.OrderId = primaryKey;
            AllOrder.ThisOrder.Find(primaryKey);
            AllOrder.Delete();
            Boolean Found = AllOrder.ThisOrder.Find(primaryKey);
            Assert.IsFalse (Found);
        }
        [TestMethod]
        public void ReportByStockIdMethodOK() 
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredStockId = new clsOrderCollection();
            FilteredStockId.ReportByStockId("");
            Assert.AreEqual(AllOrders.Count, FilteredStockId.Count);
        }
        [TestMethod]
        public void ReportByStockIdNoneFound() 
        {
            clsOrderCollection FilteredStockId = new clsOrderCollection();
            FilteredStockId.ReportByStockId("xxxx");
            Assert.AreEqual(0, FilteredStockId.Count);
            
        }
    }
}
