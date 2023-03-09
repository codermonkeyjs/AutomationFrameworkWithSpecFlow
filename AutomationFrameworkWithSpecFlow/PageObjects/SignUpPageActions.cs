
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
    }
}
