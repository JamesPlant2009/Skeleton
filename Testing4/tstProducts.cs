using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstProducts
    {
        string ProductName = "Phone1";
        string Price = "1000";
        string LastOrder = DateTime.Now.ToShortDateString();
        string DateAdded = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            clsProducts AnProduct = new clsProducts();
            Assert.IsNotNull(AnProduct);
        }
        [TestMethod]
        public void productInStockPropertyOK()
        {
            clsProducts AnProduct = new clsProducts();
            Boolean testData = true;
            AnProduct.inStock = testData;
            Assert.AreEqual(AnProduct.inStock, testData);
        }
        [TestMethod]
        public void productDateAddedPropertyOk()
        {
            clsProducts AnProduct = new clsProducts();
            DateTime testData = DateTime.Now.Date;
            AnProduct.dateAdded = testData;
            Assert.AreEqual(AnProduct.dateAdded, testData);
        }
        [TestMethod]
        public void productLastOrderedPropertyOk()
        {
            clsProducts AnProduct = new clsProducts();
            DateTime testData = DateTime.Now.Date;
            AnProduct.lastOrder = testData;
            Assert.AreEqual(AnProduct.lastOrder, testData);
        }
        [TestMethod]
        public void productPricePropertyOK()
        {
            clsProducts AnProduct = new clsProducts();
            Int32 testData = 1;
            AnProduct.price = testData;
            Assert.AreEqual(AnProduct.price, testData);
            
        }
        [TestMethod]
        public void productNamePropertyOk()
        {
            clsProducts Anproduct = new clsProducts();
            string testData = "123a";
            Anproduct.productName = testData; 
            Assert.AreEqual(Anproduct.productName, testData);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            clsProducts AnProduct = new clsProducts();
            string Error = "";
            Error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreEqual(Error,"");  

        }
        [TestMethod]
        public void MinProdName()
        {
            clsProducts AnProduct =new clsProducts();
            string error = "";
            string productName = "a";
            error = AnProduct.Valid(productName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void ProdMinMinusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string productName = "";
            error = AnProduct.Valid(productName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void ProdMinPlusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string productName = "aa";
            error = AnProduct.Valid(productName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void MaxProdName()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string productName = "aaaaaaaaaa";
            error = AnProduct.Valid(productName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void ProdMaxMinusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string productName = "aaaaaaaaa";
            error = AnProduct.Valid(productName, Price, LastOrder,DateAdded);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void ProdMaxPlusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string productName = "aaaaaaaaaaa";
            error = AnProduct.Valid(productName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void MidProdName()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string productName = "aaaaa";
            error = AnProduct.Valid(productName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string Price = "0";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void PriceMinMinusOne()
        {
            clsProducts AnPorduct = new clsProducts();
            string error = "";
            string Price = "-1";
            error = AnPorduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string Price = "1";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string Price = "10000";
            error = AnProduct.Valid(ProductName,Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PriceMaxMinusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string Price = "9999";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string Price = "10001";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void PriceExMin()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string Price = "-999999";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void PriceExMax()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string Price = "999999";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string Price = "5000";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void LastOrderExMin()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(-100);
            string LastOrder = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void LastOrderExMax()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(100);
            string LastOrder = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void LastOrderMinMinusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(-1);
            string LastOrder = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void LastOrderMinPlusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(1);
            string LastOrder = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void LastOrderMin()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            string LastOrder = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void LastOrderWrongData()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string LastOrder = "giving wrong data types";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void DateAddedExMin()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(-100);
            string DateAdded = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void DateAddedExMax()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(100);
            string DateAdded = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void DateAddedMinMinusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(-1);
            string DateAdded = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(1);
            string DateAdded = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");

        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            string DateAdded = testDate.ToString();
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreEqual(error, "");

        }
        [TestMethod]
        public void DateAddedWrongData()
        {
            clsProducts AnProduct = new clsProducts();
            string error = "";
            string DateAdded = "giving wrong data types";
            error = AnProduct.Valid(ProductName, Price, LastOrder, DateAdded);
            Assert.AreNotEqual(error, "");
        }
    }
}
    