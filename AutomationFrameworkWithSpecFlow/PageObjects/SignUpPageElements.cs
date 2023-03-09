

using AutomationFrameworkWithSpecFlow.PageObjects.ElementTypes;

namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageElements : PageElementsCommon
    {
        
        public SignUpPageElements() 
        {
        }

        protected InputField UsernameField(ElementState elementState, int maxWaitInSeconds) =>
            new InputField(FindElement(By.XPath("//input[@placeholder='Username']"),
                                       elementState,
                                       maxWaitInSeconds));
        protected InputField PasswordField(ElementState elementState, int maxWaitInSeconds) =>
            new InputField(FindElement(By.XPath("//input[@placeholder='Email']"),
                                        elementState,
                                        maxWaitInSeconds));
        protected InputField EmailField(ElementState elementState, int maxWaitInSeconds) =>
            new InputField(FindElement(By.XPath("//input[@placeholder='Password']"),
                                        elementState,
                                        maxWaitInSeconds));
        protected Button SignUpButton(ElementState elementState, int maxWaitInSeconds) =>
            new Button(FindElement(By.XPath("//button[@type='submit']"),
                                    elementState,
                                    maxWaitInSeconds));

    }
    
}
