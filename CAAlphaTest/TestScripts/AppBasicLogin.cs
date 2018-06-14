
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using CAAlphaTest.Utilities;

namespace CAAlphaTest.TestScripts
{
    public class AppBasicLogin
    {
 
        private IWebDriver _driver;
        private string baseUrl = "https://fresh.alpha.devca.net/";
        private const string continueId = "registerContinue";
        private Navigator _nav = new Navigator();
        private Generator _gen = new Generator();
        private Writer _writer = new Writer();
       

        public AppBasicLogin(IWebDriver driver)
        {
            this._driver = driver;
        }

        /// <summary>
        /// Open Firefox browser and navigate to Common App Alpha website
        /// </summary>
        public void LoadLoginPage()
        {
            _driver.Navigate().GoToUrl(baseUrl);
            _driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Close and cleanup browser 
        /// </summary>
        public void TearDownBrowser()
        {
            _driver.Close();
            _driver.Dispose();
        }

        /// <summary>
        /// Login to site with an invalid email and password
        /// </summary>
        public void InvalidUserLogin()
        {
            LoadLoginPage();
            _writer.WriteInvalidLogin(_driver);
        }

        /// <summary>
        /// Login to site with valid email and password
        /// </summary>
        public void ValidUserLogin()
        {
            LoadLoginPage();
            _writer.WriteValidLogin(_driver);
        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadNewUserPage()
        {
            LoadLoginPage();
            _nav.ClickMeLink(_driver, "create an account");
        }

        /// <summary>
        /// Signs user out of account
        /// </summary>
        public void SignOutUser()
        {
            ValidUserLogin();

            // Wait for page to load before seaching for sign out button
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _nav.ClickMeId(_driver, "appLogOff");
        }

        public void CreateFirstYearStudent()
        {
            LoadNewUserPage();

            // Select first year student option
            _nav.ClickMeId(_driver, "radio_1");
            _nav.ClickMeId(_driver, continueId);

            // Fill in user login information
            _writer.WriteLoginCredentials(_driver);
            _nav.ClickMeId(_driver, continueId);

            // Fill in user registration information
            _writer.WriteRegistrationInformation(_driver);
        }
    }
}