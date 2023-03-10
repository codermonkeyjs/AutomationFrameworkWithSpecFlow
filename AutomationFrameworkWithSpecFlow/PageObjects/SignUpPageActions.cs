
namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageActions : SignUpPageElements
    {
        public SignUpPageActions()
        {
            driver = EventHooks.Driver;
        }
        IWebDriver driver;

        public void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool EnterUsername(string username)
        {
            bool success;
            try
            {
                UsernameField.SendKeys(username);
                success = true;

            }
            catch(ElementNotInteractableException ex)
            {   
                success = false;
            }
            return success;
        }

        public bool EnterPassword(string password)
        {
            bool success;
            try
            {
                PasswordField.SendKeys(password);
                success = true;

            }
            catch (ElementNotInteractableException ex)
            {
                success = false;
            }
            return success;
        }

        public bool EnterEmail(string email)
        {
            bool success;
            try
            {
                EmailField.SendKeys(email);
                success = true;

            }
            catch (ElementNotInteractableException ex)
            {
                success = false;
            }
            return success;
        }

        public bool ClickSignUpButton()
        {
            bool success;
            try
            {
                SignUpButton.Click();
                success = true;

            }
            catch (ElementNotInteractableException ex)
            {
                success = false;
            }
            return success;
        }
    }
}
