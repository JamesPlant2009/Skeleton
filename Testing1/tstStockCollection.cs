using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.StockId = "AP1A240405002";
            TestItem.SupplierId = 1;
            TestItem.ProductId = 2;
            TestItem.OrderId = 3;
            TestItem.StaffId = 4;
            TestItem.LastOrder = DateTime.Now;
            TestItem.InStock = true;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }



        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.StockId = "AP1A240405002";
            TestStock.SupplierId = 1;
            TestStock.ProductId = 2;
            TestStock.OrderId = 3;
            TestStock.StaffId = 4;
            TestStock.LastOrder = DateTime.Now;
            TestStock.InStock = true;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.StockId = "AP1A240405002";
            TestItem.SupplierId = 1;
            TestItem.ProductId = 2;
            TestItem.OrderId = 3;
            TestItem.StaffId = 4;
            TestItem.LastOrder = DateTime.Now;
            TestItem.InStock = true;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

    }
}
