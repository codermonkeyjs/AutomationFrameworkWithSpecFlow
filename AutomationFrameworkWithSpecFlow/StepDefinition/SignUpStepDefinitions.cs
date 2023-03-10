
using AutomationFrameworkWithSpecFlow.PageObjects;

namespace AutomationFrameworkWithSpecFlow.StepDefinition
{
    [Binding]
    public class SignUpStepDefinitions
    {
        SignUpPageActions PerformSignUpPageAction;

        public SignUpStepDefinitions() 
        { 
            PerformSignUpPageAction= new SignUpPageActions();

        }
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            PerformSignUpPageAction.NavigateToURL(DefaultValues.Default.DefaultURL);
        }

        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            PerformSignUpPageAction.EnterUsername(DefaultValues.Default.DefaultUserName);
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            PerformSignUpPageAction.EnterPassword(DefaultValues.Default.DefaultPassword);
        }

        [Given(@"I enter email")]
        public void GivenIEnterEmail()
        {
            PerformSignUpPageAction.EnterEmail(DefaultValues.Default.DefaultEmail);
        }

        [When(@"I click the submit button")]
        public void WhenIClickTheSubmitButton()
        {
            PerformSignUpPageAction.ClickSignUpButton();
        }

        [Then(@"I should be able to sign up and sign in")]
        public void ThenIShouldBeAbleToSignUpAndSignIn()
        {
            throw new PendingStepException();
        }
    }
}
