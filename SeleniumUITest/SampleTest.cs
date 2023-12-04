using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace SeleniumUITest
{
    [TestClass]
    public class SampleTest
    {
        public IWebDriver driver;
        public String Email => "john4doe@abcd.com";

        [TestInitialize]
        public void Init() 
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void TestMethod1()
        {
            String title = driver.Title;
            Assert.AreEqual(title, "Demo Web Shop");
            driver.FindElement(By.ClassName("ico-register")).Click();
            String titleReg = driver.Title;
            Assert.AreEqual(titleReg, "Demo Web Shop. Register");
            driver.FindElement(By.Id("gender-male")).Click();
            driver.FindElement(By.Id("FirstName")).SendKeys("John");
            driver.FindElement(By.Id("LastName")).SendKeys("Doe");
            driver.FindElement(By.XPath("//input[@id='Email']")).SendKeys(Email);
            driver.FindElement(By.CssSelector("input[name='Password']")).SendKeys("passWord");
            driver.FindElement(By.CssSelector("input#ConfirmPassword")).SendKeys("passWord");
            driver.FindElement(By.Id("register-button")).Click();

            String message = driver.FindElement(By.CssSelector("div.result")).Text;
            Assert.AreEqual(message, "Your registration completed");

            String account = driver.FindElement(By.XPath("//div[@class='header-links']/ul/li[1]/a")).Text;
            Assert.AreEqual(account, Email);

            IWebElement logOut = driver.FindElement(By.CssSelector("a.ico-logout"));
            Assert.IsTrue(logOut.Displayed);
            driver.FindElement(By.CssSelector("a.ico-logout")).Click();

        }

        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();
        }


    }
}
