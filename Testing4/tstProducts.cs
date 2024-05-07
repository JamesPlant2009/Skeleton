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
    }
}
