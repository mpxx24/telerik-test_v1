using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;

namespace testConsole
{
    class ClickUploadButton
    {
        public ClickUploadButton(Manager myMgr)
        {
            var sendButton = myMgr.ActiveBrowser.Find.ById<HtmlAnchor>("upload-btn");
            sendButton.Click();
        }
    }
}
