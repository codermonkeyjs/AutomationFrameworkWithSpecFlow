
namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageElements
    {
        public SignUpPageElements() 
        {
            driver = EventHooks.Driver;
        }
        IWebDriver driver;

        public IWebElement UsernameField => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        public IWebElement PasswordField => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        public IWebElement EmailField => driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        public IWebElement SignUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement PopularTags => driver.FindElement(By.XPath("//p[text()='Popular Tags']"));


    }
    
}
