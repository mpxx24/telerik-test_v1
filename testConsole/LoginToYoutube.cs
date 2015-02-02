using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;

namespace testConsole
{
    class LoginToYoutube
    {
        public LoginToYoutube(Manager myMgr, string login, string password)
        {
            var log_in = myMgr.ActiveBrowser.Find.ById<HtmlInputText>("Email");
            log_in.Text = login;
            var pass = myMgr.ActiveBrowser.Find.ById<HtmlInputText>("Passwd");
            pass.Text = password;
            var loginButton = myMgr.ActiveBrowser.Find.ById<HtmlAnchor>("singIn");
            loginButton.Click();
        }
    }
}
