using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAutomation;

namespace WebTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Login_Always_ShowUserName()
        {
            LoginPage.GoTo();

            LoginPage.LoginAs(AccountData.UserName)
                .WithPassword(AccountData.Password)
                .Login();

            Assert.IsTrue(HomePage.IsAt(), "Home page was not redirected after logging in.");
            Assert.IsTrue(HomePage.IsDisplayingUserName(AccountData.UserName),
                "User name is not displayed on banner.");
        }
    }

}
