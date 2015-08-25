namespace WebAutomation
{
    public class Data
    {
        public static string HomeUrl
        {
            get { return "http://seleniumwebappps.azurewebsites.net/"; }
        }

        public static string LoginUrl
        {
            get { return "http://seleniumwebappps.azurewebsites.net/Account/Login"; }
        }

        public static string LoginEmailId
        {
            get { return "Email"; }
        }

        public static string LoginPasswordId
        {
            get { return "Password"; }
        }

        public static string LoginButtonId
        {
            get { return "LoginBtn"; }
        }

        public static string WellcomeUserNameId
        {
            get { return "WellcomeUserName"; }
        }

        public static string CommentTextAreaId
        {
            get { return "updateSLACommentArea"; }
        }
    }
}