

namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageSetUp
    {
        public static IWebDriver Driver
        {
            get; private set;
        }

        public static SignUpPageActions PerformSignUpPageAction;
        public static WaitManager PerformWaitManagerAction;

        [SetUp]
        public void SignUpSetUp()
        {
            PerformSignUpPageAction = new SignUpPageActions();
            PerformWaitManagerAction = new WaitManager();
            var driverFactory = new DriverFactory();
            driverFactory.GetDriver(DriverFactory.DriverType.chrome, false);
        }
    }
}
