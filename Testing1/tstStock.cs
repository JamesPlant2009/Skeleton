using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void InStockPropertyOK()
        {
            clsStock AnStock = new clsStock();
            Boolean TestData = true;
            AnStock.InStock = TestData;
            Assert.AreEqual(AnStock.InStock, TestData);
        }

        [TestMethod]
        public void LastOrderPropertyOK()
        {
            clsStock AnStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AnStock.LastOrder = TestData;
            Assert.AreEqual(AnStock.LastOrder, TestData);
        }

        [TestMethod]
        public void StockIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "AP1A240";
            //assign the data to the property
            AnStock.StockId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockId, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.SupplierId, TestData);
        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnStock.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductId, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "1";
            //assign the data to the property
            AnStock.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.OrderId, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnStock.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StaffId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            string StockID = "AP21";
            Found = AnStock.Find(StockID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP21";
            Found = AnStock.Find(StockID);
            if (AnStock.StockId != "AP21")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP21";
            Found = AnStock.Find(StockID);
            if (AnStock.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastOrderFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP21";
            Found = AnStock.Find(StockID);
            if (AnStock.LastOrder != Convert.ToDateTime("10/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP21";
            Found = AnStock.Find(StockID);
            if (AnStock.SupplierId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP21";
            Found = AnStock.Find(StockID);
            if (AnStock.ProductId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP21";
            Found = AnStock.Find(StockID);
            if (AnStock.OrderId != "21")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP21";
            Found = AnStock.Find(StockID);
            if (AnStock.StaffId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
