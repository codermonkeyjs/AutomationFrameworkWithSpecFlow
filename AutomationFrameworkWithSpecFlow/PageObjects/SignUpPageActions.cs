
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
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            bool success;
            try
            {
                UsernameField.SendKeys(username + randomInt);
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
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            bool success;
            try
            {
                EmailField.SendKeys(email + randomInt +"@gmail.com");
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

        public bool PopularTagsIsPresent()
        {
            bool success;

            bool isDisplayed = PopularTags.Displayed;
            success = isDisplayed;
            return success;
        }
            
    }
}
