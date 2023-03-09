
namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class SignUpPageActions : SignUpPageElements
    {
        public void EnterUsername(string username)
        {
            try
            {
                username.SendKeys("");

            }
            catch(ElementNotInteractableException ex)
            {

            }

        }
    }
}
