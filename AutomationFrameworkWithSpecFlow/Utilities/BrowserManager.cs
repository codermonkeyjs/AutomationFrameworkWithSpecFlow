
namespace AutomationFrameworkWithSpecFlow.Utilities
{
    public class BrowserManager
    {
        private readonly IWebDriver _driver;
        public BrowserManager(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
        public string GetCurrentTitle()
        {
            return _driver.Title;
        }

        public void NavigateToURL(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
        public void OpenLinkInNewTab(string url)
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript($"window.open('{url}')");
        }
        public void SwitchToTabUsingIndex(int index)
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[index]);
        }

        public string GetCurrentUrl()
        {
            return _driver.Url;
        }

        public void RefreshPage()
        {
            _driver.Navigate().Refresh();
        }

        public void AcceptAlert()
        {
            _driver.SwitchTo().Alert().Accept();
        }

        public void ScrollToElement(IWebElement element)
        {
            try
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript(
                    "window.scrollTo(" + element.Location.X + "," + element.Location.Y + ")");
            }
            catch
            {
                throw new ElementNotVisibleException();
            }
        }
        public void ScrollByNumberOfPixels(int pixelsX, int pixelsY)
        {
            try
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript(
                    "window.scrollBy(" + pixelsX + "," + pixelsY + ")");
            }
            catch
            {
                throw new ElementNotVisibleException();
            }
        }

        public void DoubleClickOnElement(IWebElement element)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(element).Perform();
            action.DoubleClick(element).Perform();
        }

        public void ScrollToBottomOfPage()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }

        public void ScrollToTopOfPage()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 0)");
        }
    }
}
