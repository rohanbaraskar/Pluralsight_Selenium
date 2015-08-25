using OpenQA.Selenium;

namespace WebAutomation
{
    public class HomePage
    {
        private static readonly string homePageH1Text = "ASP.NET";

        public static bool IsAt()
        {
            var h1S = Driver.Instance.FindElements(By.TagName("h1"));
            if (h1S.Count > 0)
                return h1S[0].Text == homePageH1Text;
            return false;
        }

        public static bool IsDisplayingUserName(string userName)
        {
            var wellcomeMsg = Driver.Instance.FindElement(By.Id(Data.WellcomeUserNameId));
            return wellcomeMsg.Text.Contains(userName);
        }
    }
}