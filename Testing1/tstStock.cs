using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{


    [TestClass]
    public class tstStock
    {

        //good test data
        string SupplierId = "15";
        string StaffId = "30";//If data type changes this needs to change
        string ProductId = "500";
        string OrderId = "675";
        string LastOrder = DateTime.Now.ToShortDateString();

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
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.OrderId, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()//If data type changes this needs to change
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
        public void FindMethodOK()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            string StockID = "AP1A240405002";
            Found = AnStock.Find(StockID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIdFound()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP1A240405002";
            Found = AnStock.Find(StockID);
            if (AnStock.StockId != "AP1A240405002")
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
            string StockID = "AP1A240405002";
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
            string StockID = "AP1A240405002";
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
            string StockID = "AP1A240405002";
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
            string StockID = "AP1A240405002";
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
            string StockID = "AP1A240405002";
            Found = AnStock.Find(StockID);
            if (AnStock.OrderId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            string StockID = "AP1A240405002";
            Found = AnStock.Find(StockID);
            if (AnStock.StaffId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
           clsStock AnStock = new clsStock();
            string Error = "";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }


        //OrderID Tests

        [TestMethod]
        public void OrderIdExtMin()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "-100000000000";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMinLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "0";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMin()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "1";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderIdExtMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "2";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "2147483646";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMax()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "2147483647";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "2147483648";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIdMid()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "1073741824";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIdExtMax()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "100000000000";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdExtInvalidDataType()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string OrderId = "Fred";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        //Supplier ID Tests

        [TestMethod]
        public void SupplierIdExtMin()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "-100000000000";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMinLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "0";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMin()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "1";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierIdExtMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "2";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "2147483646";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMax()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "2147483647";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "2147483648";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIdMid()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "1073741824";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIdExtMax()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "100000000000";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIdExtInvalidDataType()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string SupplierId = "Fred";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        // Start of ProductID Testing
        [TestMethod]
        public void ProductIdExtMin()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "-100000000000";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMinLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "0";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMin()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "1";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductIdExtMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "2";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "2147483646";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMax()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "2147483647";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "2147483648";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMid()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "1073741824";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdExtMax()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "100000000000";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIdExtInvalidDataType()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string ProductId = "Fred";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        //Start of StaffID tests

        [TestMethod]
        public void StaffIdExtMin()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "-100000000000";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinLessOne()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "0";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMin()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "1";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffIdExtMinPlusOne()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "2";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMaxLessOne()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "2147483646";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SatffIdMax()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "2147483647";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMaxPlusOne()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "2147483648";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIdMid()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "1073741824";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIdExtMax()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "100000000000";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdExtInvalidDataType()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StaffId = "Fred";
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }


        //Start of LastOrder tests
        [TestMethod]
        public void LastOrderExtMin()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string LastOrder = TestDate.ToString();
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastOrderMinLessOne()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string LastOrder = TestDate.ToString();
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastOrderMin()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string LastOrder = TestDate.ToString();
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreEqual(Error, "");
        }

        
        [TestMethod]
        public void LastOrderMinPlusOne()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string LastOrder = TestDate.ToString();
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastOrderExtMax()//If data type changes this needs to change
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string LastOrder = TestDate.ToString();
            Error = AnStock.Valid(SupplierId, ProductId, OrderId, StaffId, LastOrder);
            Assert.AreNotEqual(Error, "");
        }








    }
}
