using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using CAAlphaTest;
using CAAlphaTest.TestScripts;

namespace SmokeTest
{
    
    [TestClass]
    public class SmokeTestExecution
    {

        AppBasicLogin testAppBasicLogin = new AppBasicLogin();
        AppCreate testAppCreate = new AppCreate();

        //[OneTimeSetUpAttribute]
        [Test]
        public void TestLoadLoginPage()
        {
            testAppBasicLogin.LoadLoginPage();
        }

        //[OneTimeTearDown]
        [Test]
        public void TestTearDownBrowser()
        {
            testAppBasicLogin.TearDownBrowser();
        }
        [Test]
        public void TestInvalidUserLogIn()
        {
            testAppBasicLogin.InvalidUserLogin();
        }

        [Test]
        public void TestUserLogin()
        {
            testAppBasicLogin.ValidUserLogin();
        }
       
        [Test]
        public void TestSignOutUser()
        {
            testAppBasicLogin.SignOutUser();
        }
        [Test]
        public void TestCreateFirstYearStudent()
        {
            testAppBasicLogin.CreateFirstYearStudent();
        }
    }
}