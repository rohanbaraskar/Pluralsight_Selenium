using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Data.LoginUrl);
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string _username;
        private string _password;

        public LoginCommand(string userName)
        {
            _username = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            _password = password;
            return this;
        }

        public void Login()
        {
            if(string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
                throw new ArgumentException();

            var emailInput = Driver.Instance.FindElement(By.Id(Data.LoginEmailId));
            emailInput.SendKeys(_username);

            var passwordInput = Driver.Instance.FindElement(By.Id(Data.LoginPasswordId));
            passwordInput.SendKeys(_password);

            var loginButton = Driver.Instance.FindElement(By.Id(Data.LoginButtonId));
            loginButton.Click();
        }
    }
}
