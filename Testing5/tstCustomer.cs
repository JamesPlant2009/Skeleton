using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstCustomer
    {
        string FirstName = "John";
        string LastName = "Doe";
        string Email = "john@example.com";

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "John";
            ACustomer.FirstName = testData;
            Assert.AreEqual(ACustomer.FirstName, testData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "Doe";
            ACustomer.LastName = testData;
            Assert.AreEqual(ACustomer.LastName, testData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "john@example.com";
            ACustomer.Email = testData;
            Assert.AreEqual(ACustomer.Email, testData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string error = "";
            error = ACustomer.Valid(FirstName, LastName, Email);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string error = "";
            string firstName = "J";
            error = ACustomer.Valid(firstName, LastName, Email);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMinMinusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string error = "";
            string firstName = "";
            error = ACustomer.Valid(firstName, LastName, Email);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string error = "";
            string firstName = "Jo";
            error = ACustomer.Valid(firstName, LastName, Email);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string error = "";
            string lastName = "D";
            error = ACustomer.Valid(FirstName, lastName, Email);
            Assert.AreEqual(error, "");
        }

    }
}
