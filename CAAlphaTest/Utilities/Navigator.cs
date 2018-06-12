using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void ClickMeClass(IWebDriver driver, string className)
        {
            driver.FindElement(By.ClassName(className)).Click();
        }

        public void ClickMeLink(IWebDriver driver, string id)
        {
            driver.FindElement(By.LinkText(id)).Click();
        }
    }
}
