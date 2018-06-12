using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CAAlphaTest.Utilities
{
    public class Writer
    {
        private Generator gen = new Generator();
        

        /// <summary>
        /// Fills in the input box selected by `attribute` with the text in `text`
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="attribute"></param>
        /// <param name="text"></param>
        public void InputInfoById(IWebDriver driver, string attribute, string text)
        {
            driver.FindElement(By.Id(attribute)).SendKeys(text);
        }


        /// <summary>
        /// Fills in login field with invalid information
        /// </summary>
        /// <param name="driver"></param>
        public void WriteInvalidLogin(IWebDriver driver)
        {
            InputInfoById(driver, "emailCntrl", gen.GenerateRandomEmail());
            InputInfoById(driver, "pwdCntrl", gen.GenerateRandomPassword() + Keys.Enter);
        }

        /// <summary>
        /// Fills in login field with valid information
        /// </summary>
        /// <param name="driver"></param>
        public void WriteValidLogin(IWebDriver driver)
        {
            InputInfoById(driver, "emailCntrl", gen.GenerateMyEmail());
            InputInfoById(driver, "pwdCntrl", gen.GenerateMyPassword() + Keys.Enter);
        }


        /// <summary>
        /// Fills in "Login Credentials" field with arbitary user info
        /// </summary>
        /// <param name="driver"></param>
        public void WriteLoginCredentials(IWebDriver driver)
        {
            InputInfoById(driver, "email_ques_187", gen.GenerateRandomEmail());
            InputInfoById(driver, "email_ques_1879900", gen.GenerateRandomEmail());
            InputInfoById(driver, "password_ques_1", gen.GenerateRandomPassword());
            InputInfoById(driver, "password_ques_19900", gen.GenerateRandomPassword());
        }

        /// <summary>
        /// Fills in "Registration Information" field with arbitary user info
        /// </summary>
        /// <param name="driver"></param>
        public void WriteRegistrationInformation(IWebDriver driver)
        {
            InputInfoById(driver, "text_ques_173", gen.GenerateRandomFirstName());
            InputInfoById(driver, "text_ques_175", gen.GenerateRandomLastName());
        }
    }
}
