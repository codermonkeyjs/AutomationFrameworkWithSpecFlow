using AutomationFrameworkWithSpecFlow.PageObjects;
using TechTalk.SpecFlow;

namespace AutomationFrameworkWithSpecFlow.Utilities
{
    [Binding]
    public class EventHooks
    {
        public static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}