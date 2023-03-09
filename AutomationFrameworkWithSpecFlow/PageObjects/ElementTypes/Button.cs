

namespace AutomationFrameworkWithSpecFlow.PageObjects.ElementTypes
{
    public class Button :PageElementsCommon
    {
        public Button(ReadOnlyCollection<IWebElement> webElements) : base(webElements)
        {
        }
        public bool LeftClickMouseButtonById()
        {
            bool buttonClicked = false;

            try
            {

                Element.Click();
                buttonClicked = true;
            }
            catch (Exception ex)
            {
            }
            return buttonClicked;
        }

    }
}
