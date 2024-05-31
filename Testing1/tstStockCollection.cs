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
        public void StockListOK()//If data type changes this needs to change
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
        public void ThisStockPropertyOK()//If data type changes this needs to change
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
        public void ListAndCountOK()//If data type changes this needs to change
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


        [TestMethod]
        public void AddMethodOK()//If data type changes this needs to change
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            string PrimaryKey = "AP15";
            TestItem.StockId = "AP10";
            TestItem.SupplierId = 1;
            TestItem.ProductId = 2;
            TestItem.OrderId = 3;
            TestItem.StaffId = 4;
            TestItem.LastOrder = DateTime.Now;
            TestItem.InStock = true;

            AllStocks.ThisStock = TestItem;

            
            PrimaryKey = AllStocks.Add();

            TestItem.StockId = PrimaryKey;

            AllStocks.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStocks.ThisStock, TestItem);


        }


        [TestMethod]
        public void UpdateMethodOK()//If data type changes this needs to change
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            string PrimaryKey = "AP10";
            TestItem.StockId = "AP10";
            TestItem.SupplierId = 1;
            TestItem.ProductId = 2;
            TestItem.OrderId = 3;
            TestItem.StaffId = 4;
            TestItem.LastOrder = DateTime.Now;
            TestItem.InStock = true;

            AllStock.ThisStock = TestItem;

            
            PrimaryKey = AllStock.Add();

            TestItem.StockId = PrimaryKey;

            TestItem.SupplierId = 10;
            TestItem.ProductId = 20;
            TestItem.OrderId = 30;
            TestItem.StaffId = 40;
            TestItem.LastOrder = DateTime.Now;
            TestItem.InStock = false;

            AllStock.ThisStock = TestItem;
            AllStock.Update();

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);


        }






    }
}
