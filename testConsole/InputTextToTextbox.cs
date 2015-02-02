using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;

namespace testConsole
{
    class InputTextToTextbox
    {
        public InputTextToTextbox(Manager myMgr, string searchingTerm)
        {
            var searchYT = myMgr.ActiveBrowser.Find.ById<HtmlInputText>("masthead-search-term");
            searchYT.Text = searchingTerm;
        }
    }
}
