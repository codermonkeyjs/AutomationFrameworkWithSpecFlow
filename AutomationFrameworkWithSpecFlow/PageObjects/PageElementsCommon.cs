
namespace AutomationFrameworkWithSpecFlow.PageObjects
{
    public class PageElementsCommon
    {
        public IWebElement Element
        {
            get; private set;
        }

        public ReadOnlyCollection<IWebElement> ElementCollection
        {
            get; private set;
        }

        public PageElementsCommon()
        {

        }

        public PageElementsCommon(IWebElement webElement)
        {
            Element = webElement;
        }

        public PageElementsCommon(ReadOnlyCollection<IWebElement> webElements)
        {
            if (webElements.Count > 0)
            {
                Element = webElements[0];
                ElementCollection = webElements;

            }
            else
            {
                ElementCollection = webElements;
            }

        }
        public enum ElementState
        {
            Visible, NotVisible, Clickable, UrlContains, UntilUrlMatches
        }

        public static ReadOnlyCollection<IWebElement> FindElement(By by,
                                                                  ElementState elementState,
                                                                  int timeoutInSeconds,
                                                                  string url = "")
        {
            try
            {
                _ = elementState switch
                {
                    ElementState.Clickable => SignUpPageSetUp
                                              .PerformWaitManagerAction
                                              .UntilElementToBeClickable(by, timeoutInSeconds),
                    ElementState.NotVisible => SignUpPageSetUp
                                              .PerformWaitManagerAction
                                              .UntilInvisibilityOfElementLocated(by, timeoutInSeconds),
                    ElementState.UntilUrlMatches => SignUpPageSetUp
                                                    .PerformWaitManagerAction
                                                    .UntilUrlMatches(url, timeoutInSeconds),
                    ElementState.UrlContains => SignUpPageSetUp
                                                .PerformWaitManagerAction
                                                .UntilUrlContains(url, timeoutInSeconds),
                    ElementState.Visible => SignUpPageSetUp
                                            .PerformWaitManagerAction
                                            .UntilElementIsVisible(by, timeoutInSeconds),
                    _ => throw new ArgumentOutOfRangeException(nameof(elementState),
                                                               $"The wait type of : {elementState} is not supported at this time"),
                };
            }
            catch(Exception ex)
            {
                return null;
            }
            return SignUpPageSetUp.Driver.FindElements(by);
                
        }
    }
}

