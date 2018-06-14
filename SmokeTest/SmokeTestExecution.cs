using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using CAAlphaTest.TestScripts;

namespace SmokeTest
{
    
    [TestClass]
    public class SmokeTestExecution
    {

        //[OneTimeSetUpAttribute]
        [Test]
        public void TestLoadLoginPage()
        {
            IWebDriver driver = new FirefoxDriver();
            AppBasicLogin testAppBasicLogin = new AppBasicLogin(driver);
            testAppBasicLogin.LoadLoginPage();
        }

        //[OneTimeTearDown]
        [Test]
        public void TestTearDownBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            AppBasicLogin testAppBasicLogin = new AppBasicLogin(driver);
            testAppBasicLogin.TearDownBrowser();
        }
        [Test]
        public void TestInvalidUserLogIn()
        {
            IWebDriver driver = new FirefoxDriver();
            AppBasicLogin testAppBasicLogin = new AppBasicLogin(driver);
            testAppBasicLogin.InvalidUserLogin();
        }

        [Test]
        public void TestUserLogin()
        {
            IWebDriver driver = new FirefoxDriver();
            AppBasicLogin testAppBasicLogin = new AppBasicLogin(driver);
            testAppBasicLogin.ValidUserLogin();
        }
       
        [Test]
        public void TestSignOutUser()
        {
            IWebDriver driver = new FirefoxDriver();
            AppBasicLogin testAppBasicLogin = new AppBasicLogin(driver);
            testAppBasicLogin.SignOutUser();
        }
        [Test]
        public void TestCreateFirstYearStudent()
        {
            IWebDriver driver = new FirefoxDriver();
            AppBasicLogin testAppBasicLogin = new AppBasicLogin(driver);
            testAppBasicLogin.CreateFirstYearStudent();
        }
    }
}