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
            //Anproduct.ProductName = testData; 
            //Assert.AreEqual(Anproduct.ProductName, testData);
        }
        [TestMethod]
        public void ValideMethodOk()
        {
            clsProducts AnProduct = new clsProducts();
            string Error = "";
            //Error = AnProduct.Valid(productName, price, LastOrder, DateAdded);
            Assert.AreEqual(Error,"");  

        }

    }
}
    