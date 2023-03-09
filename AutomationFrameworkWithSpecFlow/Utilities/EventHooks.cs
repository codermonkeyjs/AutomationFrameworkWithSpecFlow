using AutomationFrameworkWithSpecFlow.PageObjects;

namespace AutomationFrameworkWithSpecFlow.Utilities
{
    [Binding]
    public class EventHooks
    {
        public static IWebDriver Driver
        {
            get; private set;
        }

        public static SignUpPageActions PerformSignUpPageAction;
        public static WaitManager PerformWaitManagerAction;
        public static BrowserManager PerformBrowserManagerAction;

        [BeforeScenario]
        public void BeforeScenario()
        {
            PerformSignUpPageAction = new SignUpPageActions();
            PerformWaitManagerAction = new WaitManager(Driver);
            PerformBrowserManagerAction = new BrowserManager(Driver);
            var driverFactory = new DriverFactory();
            driverFactory.GetDriver(DriverFactory.DriverType.chrome, false);
        }

        [AfterScenario]
        public void AfterScenario()
        {
                Driver.Quit();
        }
    }
}