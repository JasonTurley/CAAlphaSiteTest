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
        private Navigator nav = new Navigator();

        /// <summary>
        /// Fills in the input box selected by id `attribute` with the text `text`
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="attribute"></param>
        /// <param name="text"></param>
        public void InputInfoById(IWebDriver driver, string attribute, string text)
        {
            driver.FindElement(By.Id(attribute)).SendKeys(text);
        }

        /// <summary>
        /// Fills in the input box selected by class 'attribute' with the text `text`
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="attribute"></param>
        /// <param name="text"></param>
        public void InputInfoByClass(IWebDriver driver, string attribute, string text)
        {
            driver.FindElement(By.ClassName(attribute)).SendKeys(text);
        }

        /// <summary>
        /// Fills in login field with invalid information
        /// </summary>
        /// <param name="driver"></param>
        public void WriteInvalidLogin(IWebDriver driver)
        {
            InputInfoById(driver, "emailCntrl", gen.GenerateEmail());
            InputInfoById(driver, "pwdCntrl", gen.GeneratePassword() + Keys.Enter);
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
            InputInfoById(driver, "email_ques_187", gen.GenerateEmail());
            InputInfoById(driver, "email_ques_1879900", gen.GenerateEmail());
            InputInfoById(driver, "password_ques_1", gen.GeneratePassword());
            InputInfoById(driver, "password_ques_19900", gen.GeneratePassword());
        }

        /// <summary>
        /// Fills in "Registration Information" field with arbitary user info
        /// </summary>
        /// <param name="driver"></param>
        public void WriteRegistrationInformation(IWebDriver driver)
        {
            // Enter first and last names
            InputInfoById(driver, "text_ques_173", gen.GenerateFirstName());
            InputInfoById(driver, "text_ques_175", gen.GenerateLastName());
            nav.ClickMeId(driver, "add_ques_182");

            // Enter address
            List<string> address = gen.GenerateAddress();
            InputInfoById(driver, "add1_ques_182", address[0]);     // Address line 1
            InputInfoById(driver, "city_ques_182", address[1]);     // City
            //InputInfoById(driver, "", address[2]);                  // FIXME: State
            InputInfoById(driver, "zip_ques_182", address[3]);      // Zip code
            nav.ClickMeId(driver, "verifyAddress_ques_182");

            // Enter phone number and date of birth
            InputInfoById(driver, "phone_ques_189", gen.GeneratePhoneNumber());
            nav.ClickMeClass(driver, "chzn-single");
        }
    }
}
