

using AutomationFrameworkWithSpecFlow.PageObjects.ElementTypes;

namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageElements : PageElementsCommon
    {
        
        public SignUpPageElements() 
        {
           driver = EventHooks.driver;
        }
        IWebDriver driver;

        protected InputField UsernameField(ElementState elementState, int maxWaitInSeconds) =>
            new InputField(FindElement(By.XPath("//input[@placeholder='Username']"),
                                       elementState,
                                       maxWaitInSeconds));

    }
    
}
