
namespace AutomationFrameworkWithSpecFlow.Utilities
{
    public class DriverFactory
    {
        private IWebDriver _driver;

        public enum DriverType
        {
            chrome,
            edge,
            firefox
        }

        public IWebDriver GetDriver(DriverType typeOfDriver, bool runHeadless)
        {
            try
            {
                if (typeOfDriver == DriverType.edge) _driver = null;
                else if (typeOfDriver == DriverType.firefox) _driver = null;
                else _driver = CreateChromeDriver(runHeadless);
            }
            catch (DriverServiceNotFoundException)
            {
                _driver = null;
            }
            return _driver;
        }

        private IWebDriver CreateChromeDriver(bool runHeadless)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            if (runHeadless)
            {
                chromeOptions.AddArgument("headless");
            }

            chromeOptions.AddArguments("incognito",
                                       "disable-infobars",
                                       "disable-popup-blocking",
                                       "start-maximized",
                                       "use-fake-device-for-media-stream");

            new DriverManager().SetUpDriver(new ChromeConfig());

            return new ChromeDriver(chromeOptions);
        }
    }
}
