﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CAAlphaTest.Utilities
{
    public class Writer
    {
        private Generator _gen = new Generator();
        private Navigator _nav = new Navigator();

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
            InputInfoById(driver, "emailCntrl", _gen.GenerateEmail());
            InputInfoById(driver, "pwdCntrl", _gen.GeneratePassword() + Keys.Enter);
        }

        /// <summary>
        /// Fills in login field with valid information
        /// </summary>
        /// <param name="driver"></param>
        public void WriteValidLogin(IWebDriver driver)
        {
            InputInfoById(driver, "emailCntrl", _gen.GenerateMyEmail());
            InputInfoById(driver, "pwdCntrl", _gen.GenerateMyPassword() + Keys.Enter);
        }

        /// <summary>
        /// Fills in "Login Credentials" field with arbitary user info
        /// </summary>
        /// <param name="driver"></param>
        public void WriteLoginCredentials(IWebDriver driver)
        {
            InputInfoById(driver, "email_ques_187", _gen.GenerateEmail());
            InputInfoById(driver, "email_ques_1879900", _gen.GenerateEmail());
            InputInfoById(driver, "password_ques_1", _gen.GeneratePassword());
            InputInfoById(driver, "password_ques_19900", _gen.GeneratePassword());
        }

        /// <summary>
        /// Fills in "Registration Information" field with arbitary user info
        /// </summary>
        /// <param name="driver"></param>
        public void WriteRegistrationInformation(IWebDriver driver)
        {
            // Enter first and last names
            InputInfoById(driver, "text_ques_173", _gen.GenerateFirstName());
            InputInfoById(driver, "text_ques_175", _gen.GenerateLastName());
            _nav.ClickMeId(driver, "add_ques_182");

            Thread.Sleep(2000);
            // Enter address
            List<string> address = _gen.GenerateAddress();
            InputInfoById(driver, "add1_ques_182", address[0]);     // Address line 1
            InputInfoById(driver, "city_ques_182", address[1]);     // City
            //InputInfoById(driver, "", address[2]);                  // FIXME: State
            InputInfoById(driver, "zip_ques_182", address[3]);      // Zip code
            _nav.ClickMeId(driver, "verifyAddress_ques_182");

            Thread.Sleep(2000);
            // Enter phone number and date of birth
            InputInfoById(driver, "phone_ques_189", _gen.GeneratePhoneNumber());
            _nav.ClickMeXPath(driver, "/html/body/div[2]/div[1]/div/div/div/div[3]/div/div[1]/ul/li[5]/div/div[7]/a");
        }
    }
}