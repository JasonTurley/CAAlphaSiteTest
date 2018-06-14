using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CAAlphaTest.Utilities
{
    public class Navigator
    {

        public void ClickMeId(IWebDriver driver, string idName)
        {
            driver.FindElement(By.Id(idName)).Click();
        }

        public void ClickMeXPath(IWebDriver driver, string path)
        {
            driver.FindElement(By.ClassName(path)).Click();
        }

        public void ClickMeLink(IWebDriver driver, string id)
        {
            driver.FindElement(By.LinkText(id)).Click();
        }
    }
}
