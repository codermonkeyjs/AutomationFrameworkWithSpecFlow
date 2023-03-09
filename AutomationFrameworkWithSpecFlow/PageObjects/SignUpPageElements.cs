

namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageElements :PageElementsCommon
    {
        
        public SignUpPageElements() 
        {
           driver = EventHooks.driver;
        }
        IWebDriver driver;
        
        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        IWebElement password => driver.FindElement(By.XPath(""));
    }
    
}
