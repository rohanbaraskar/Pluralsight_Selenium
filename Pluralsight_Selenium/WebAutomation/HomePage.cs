using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebAutomation
{
    public class HomePage
    {
        private const string HomePageH1Text = "ASP.NET";

        public static bool IsAt()
        {
            var h1S = Driver.Instance.FindElements(By.TagName("h1"));
            if (h1S.Count > 0)
                return h1S[0].Text == HomePageH1Text;
            return false;
        }

        public static bool IsDisplayingUserName(string userName)
        {
            var wellcomeMsg = Driver.Instance.FindElement(By.Id(Data.WellcomeUserNameId));
            return wellcomeMsg.Text.Contains(userName);
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Data.HomeUrl);
        }

        public static void EnterComment(string comment)
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromMinutes(1));
            var element= wait.Until(driver =>
            {
                var commentTextArea = Driver.Instance.FindElement(By.Id(Data.CommentTextAreaId));
                return (commentTextArea != null && commentTextArea.Displayed && commentTextArea.Enabled) ? commentTextArea : null;
            });
            element.SendKeys(comment);
        }
    }
}