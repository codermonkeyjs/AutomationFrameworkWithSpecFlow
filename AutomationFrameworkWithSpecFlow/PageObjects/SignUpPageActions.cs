
namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageActions : SignUpPageElements
    {
        public bool EnterUsername(string username)
        {
            bool success;
            try
            {
                UsernameField(ElementState.Clickable, 10).SendText(username);
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
                PasswordField(ElementState.Clickable, 10).SendText(password);
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
                EmailField(ElementState.Clickable, 10).SendText(email);
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
                SignUpButton(ElementState.Clickable, 10).Element.Click();
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
