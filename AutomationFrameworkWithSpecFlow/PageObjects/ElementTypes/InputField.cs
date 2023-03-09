using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkWithSpecFlow.PageObjects.ElementTypes
{
    public class InputField : PageElementsCommon
    {
        public InputField(ReadOnlyCollection<IWebElement> webElements) : base(webElements)
        {
        }

        public bool SendText(string text, bool pressEnterAfter = false)
        {
            bool success = false;

            try
            {
                Element.Click();
                ClearText();
                Element.SendKeys(text);
                if (pressEnterAfter)
                {
                    Element.SendKeys(Keys.Enter);
                }
                success = true;
            }
            catch (Exception ex)
            {
             
            }
            return success;
        }

        public void ClearText()
        {
            try
            {
                Element.Clear();
            }
            catch (StaleElementReferenceException ex)
            {
                Element.Clear();
            }
        }
    }
}
