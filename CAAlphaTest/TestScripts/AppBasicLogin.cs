using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using CAAlphaTest;
using CAAlphaTest.Utilities;

namespace CAAlphaTest.TestScripts
{
    public class AppBasicLogin
    {
 
        private IWebDriver _driver;
        private string baseUrl = "https://fresh.alpha.devca.net/";
        private const string continueId = "registerContinue";
        private Navigator nav = new Navigator();
        private Generator gen = new Generator();
        private Writer writer = new Writer();
       
        /// <summary>
        /// Open Firefox browser and navigate to Common App Alpha website
        /// </summary>
        public void LoadLoginPage()
        {
            _driver = new FirefoxDriver();
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
            writer.WriteInvalidLogin(_driver);
        }

        /// <summary>
        /// Login to site with valid email and password
        /// </summary>
        public void ValidUserLogin()
        {
            LoadLoginPage();
            writer.WriteValidLogin(_driver);
        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadNewUserPage()
        {
            LoadLoginPage();
            nav.ClickMeLink(_driver, "create an account");
        }


        /// <summary>
        /// Create new account for first year
        /// </summary>
        public void CreateFirstYearStudent()
        {
            LoadNewUserPage();

            // Select first year student option
            nav.ClickMeId(_driver, "radio_1");
            nav.ClickMeId(_driver, continueId);

            // Fill in user login information
            writer.WriteLoginCredentials(_driver);
            nav.ClickMeId(_driver, continueId);

            // Fill in user registration information
            writer.WriteRegistrationInformation(_driver);
        }

    }
}
