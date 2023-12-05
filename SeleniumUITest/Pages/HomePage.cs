using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.DOM;
using SeleniumUITest.BasePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.Pages
{
    public class HomePage
    {
        public static IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            HomePage.driver = driver;
        }

        /* Page Objects
         */

        public readonly By registerLink = By.ClassName("ico-register");
        public readonly By logInLink = By.ClassName("ico-login");
        public readonly By shoppingCartLink = By.Id("li#topcartlink>a :nth-child(1)");
        public readonly By Cartqty = By.Id("li#topcartlink>a :nth-child(2)");
        public readonly By wishList = By.XPath("//span[@class='cart-label' and text()='Wishlist']");
        public readonly By wishListQty = By.XPath("//span[@class='wishlist-qty']");
        public readonly By searchStoreLink = By.Id("small-searchterms");
        public readonly By searchBtn = By.CssSelector("div[class='search-box']>form :nth-child(3)");

        /* Page Methods
         */
        public void ClickRegisterLink()
        {
            driver.FindElement(registerLink).Click();
        }

        public void ClickLogInLink()
        {
            driver.FindElement(logInLink).Click();
        }

    }

}
