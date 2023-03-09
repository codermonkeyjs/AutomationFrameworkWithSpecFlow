
namespace AutomationFrameworkWithSpecFlow.Utilities
{
    public class WaitManager
    { 
        private readonly IWebDriver _driver;

        internal WaitManager(IWebDriver webDriver) 
        { 
            _driver = webDriver;
        }
        public DefaultWait<IWebDriver> InSecondsCheckingEveryXMilliSeconds(int seconds, int milliseconds)
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(_driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(milliseconds)
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            return wait;
        }
        public IWebElement InSecondsCheckingEveryXMilliSecondsUntilElementVisible(int seconds, int milliseconds, By by)
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(_driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(milliseconds)
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = wait.Until(x => x.FindElement(by));
            return searchResult;

        }
        public void ForSeconds(int seconds) //Use this if you are waiting for a set amount of time
        {
            Thread.Sleep(seconds * 1000);
        }

        public void ForMilliSeconds(int milliseconds) //Use this if you are waiting for a set amount of time
        {
            Thread.Sleep(milliseconds);
        }
        public WebDriverWait InSeconds(int seconds) //DO NOT USE FOR WAITING FOR A SPECIFIC AMOUNT TIME
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds))
            {
                Timeout = TimeSpan.FromSeconds(seconds)
            };
            return wait;
        }

        public WebDriverWait InMilliSeconds(int milliSeconds) //DO NOT USE FOR WAITING FOR A SPECIFIC AMOUNT TIME
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(milliSeconds))
            {
                Timeout = TimeSpan.FromMilliseconds(milliSeconds)
            };
            return wait;
        }

        public bool UntilUrlContains(string url, int maximumWaitInSeconds)
        {
            return InSeconds(maximumWaitInSeconds)
                    .Until(SeleniumExtras
                    .WaitHelpers.ExpectedConditions
                    .UrlContains(url));
        }

        public bool UntilUrlMatches(string url, int maximumWaitInSeconds)
        {
            return InSeconds(maximumWaitInSeconds)
                    .Until(SeleniumExtras
                    .WaitHelpers
                    .ExpectedConditions
                    .UrlMatches(url));
        }

        public bool UntilElementToBeClickable(By by, int maximumWaitInSeconds)
        {
            var myElement = InSeconds(maximumWaitInSeconds)
                            .Until(SeleniumExtras.WaitHelpers
                            .ExpectedConditions
                            .ElementToBeClickable(by));
            return myElement.Enabled;
        }

        public bool UntilElementToContainText(By by, int maximumWaitInSeconds, string text)
        {
            var myElement = InSeconds(maximumWaitInSeconds)
                            .Until(SeleniumExtras.WaitHelpers
                            .ExpectedConditions
                            .TextToBePresentInElement((IWebElement)by, text));
            return myElement;
        }

        public bool UntilElementIsVisible(By by, int maximumWaitInSeconds)
        {
            var element = InSeconds(maximumWaitInSeconds)
                          .Until(SeleniumExtras.WaitHelpers
                          .ExpectedConditions
                          .ElementIsVisible(by));
            return element.Displayed;
        }

        public bool UntilInvisibilityOfElementLocated(By by, int maximumWaitInSeconds)
        {
            var check = InSeconds(maximumWaitInSeconds)
                        .Until(SeleniumExtras
                        .WaitHelpers
                        .ExpectedConditions
                        .InvisibilityOfElementLocated(by));
            return check;
        }
    }
}

