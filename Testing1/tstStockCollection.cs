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
            TestItem.IdentityId = 1;
            TestItem.StockId = "AP1A240405002";
            TestItem.SupplierId = 2;
            TestItem.ProductId = 3;
            TestItem.OrderId = 4;
            TestItem.StaffId = 5;
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
            TestStock.IdentityId = 1;
            TestStock.StockId = "AP1A240405002";
            TestStock.SupplierId = 2;
            TestStock.ProductId = 3;
            TestStock.OrderId = 4;
            TestStock.StaffId = 5;
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
            TestItem.IdentityId = 1;
            TestItem.StockId = "AP1A240405002";
            TestItem.SupplierId = 2;
            TestItem.ProductId = 3;
            TestItem.OrderId = 4;
            TestItem.StaffId = 5;
            TestItem.LastOrder = DateTime.Now;
            TestItem.InStock = true;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            int PrimaryKey = 0;
            TestItem.IdentityId = 30;
            TestItem.StockId = "AP10";
            TestItem.SupplierId = 2;
            TestItem.ProductId = 3;
            TestItem.OrderId = 4;
            TestItem.StaffId = 5;
            TestItem.LastOrder = DateTime.Now;
            TestItem.InStock = true;

            AllStocks.ThisStock = TestItem;

            
            PrimaryKey = AllStocks.Add();

            TestItem.IdentityId = PrimaryKey;

            AllStocks.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStocks.ThisStock, TestItem);


        }


        [TestMethod]
        public void UpdateMethodOK()//If data type changes this needs to change
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            int PrimaryKey = 0;
            
            TestItem.StockId = "AP10";
            TestItem.SupplierId = 1;
            TestItem.ProductId = 2;
            TestItem.OrderId = 3;
            TestItem.StaffId = 4;
            TestItem.LastOrder = DateTime.Now;
            TestItem.InStock = true;

            AllStock.ThisStock = TestItem;

            
            PrimaryKey = AllStock.Add();

            TestItem.IdentityId = PrimaryKey;

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
