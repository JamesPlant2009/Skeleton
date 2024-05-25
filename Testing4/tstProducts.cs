using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstProducts
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProducts AnProduct = new clsProducts();
            Assert.IsNotNull(AnProduct);
        }
        [TestMethod]
        public void productInStockPropertyOK()
        {
            clsProucts AnProduct = new clsProucts();
            Boolean testData = true;
            AnProduct.inStock = testData;
            Assert.AreEqual(AnProduct.inStock, testData);
        }
        [TestMethod]
        public void productDateAddedPropertyOk()
        {
            clsProducts AnProduct = new clsProducts();
            DateTime testData = DateTime.Now.Date;
            AnProduct.dateadded = testData;
            Assert.AreEqual(AnProduct.dateadded, testData);
        }
        [TestMethod]
        public void productLastOrderedPropertyOk()
        {
            clsProducts AnProduct = new clsProducts();
            DateTime testData = DateTime.Now.Date;
            AnProduct.lastordered = testData;
            Assert.AreEqual(AnProduct.lastordered, testData);
        }
        [TestMethod]
        public void productPricePropertyOK()
        {
            clsproducts AnProduct = new clsProducts();
            Int32 testData = 1;
            AnProduct.price = testData;
            Assert.AreEqual(AnProduct.price, testData);
            
        }
        [TestMethod]
        public void productNamePropertyOk()
        {
            clsproducts Anproduct = new clsproducts();
            string testData = "123a";
            Anproduct.ProductName = testData; 
            Assert.AreEqual(Anproduct.ProductName, testData);
        }
}
    }
}
    