using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Int32 testData = 1;
            AnUser.UserId = testData;
            Assert.AreEqual(AnUser.UserId, testData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string testData = "Aidan";
            AnUser.UserName = testData;
            Assert.AreEqual(AnUser.UserName, testData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string testData = "Password321";
            AnUser.UserPassword = testData;
            Assert.AreEqual(AnUser.UserPassword, testData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string testData = "Order";
            AnUser.UserDepartment = testData;
            Assert.AreEqual(AnUser.UserDepartment, testData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            string UserName = "Aidan";
            string UserPassword = "Password321";
            Found = AnUser.FindUser(UserName, UserPassword);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNameandPassword()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Aidan";
            string UserPassword = "Password321";
            Found = AnUser.FindUser(UserName, UserPassword);
            if (AnUser.UserName != UserName && AnUser.UserPassword != UserPassword)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
