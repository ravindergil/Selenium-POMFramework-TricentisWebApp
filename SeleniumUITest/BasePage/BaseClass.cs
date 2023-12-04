using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.BasePage
{
    /*
     * Set up the drivers
     * Re-useable methods
     */

    public class BaseClass
    {
        public static IWebDriver driver;

        [TestInitialize]
        public void Init() 
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("");
            driver.Manage().Window.Maximize();
        }

        //public BaseClass(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}
    }
}
