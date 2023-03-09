

namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageSetUp
    {
        public static IWebDriver Driver
        {
            get; private set;
        }

        public static SignUpPageActions PerformSignUpPageAction;

        [SetUp]
        public void SignUpSetUp()
        {
            PerformSignUpPageAction = new SignUpPageActions();
            var driverFactory = new DriverFactory();
            driverFactory.GetDriver(DriverFactory.DriverType.chrome, false);
        }
    }
}
