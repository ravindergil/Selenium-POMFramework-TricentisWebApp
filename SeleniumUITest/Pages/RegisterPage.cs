using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.Pages
{
    public class RegisterPage
    {
        public static IWebDriver driver;
        public RegisterPage(IWebDriver driver)
        {
            RegisterPage.driver=driver;
        }

        /* Page Objects
         */
        public static readonly By genderMale = By.Id("gender-male");
        public static readonly By genderFemale = By.Id("gender-female");
        public static readonly By firstName = By.Id("FirstName");
        public static readonly By lastName = By.Id("LastName");
        public static readonly By emailID = By.XPath("//input[@id='Email']");
        public static readonly By passWord = By.CssSelector("input[name='Password']");
        public static readonly By confirmPass = By.CssSelector("input#ConfirmPassword");
        public static readonly By registerBtn = By.CssSelector("input#ConfirmPassword");
        public static readonly By message = By.CssSelector("div.result");
        public static readonly By confirmEmail = By.XPath("//div[@class='header-links']/ul/li[1]/a");
        public static readonly By logOut = By.CssSelector("a.ico-logout");

        /* Page Methods
         */
        public void SelectMaleGender()
        {
            driver.FindElement(genderMale).Click();
        }

        public void EnterFirstName(String Fname)
        {
            driver.FindElement(firstName).SendKeys(Fname);
        }

        public void EnterLasttName(String Lname)
        {
            driver.FindElement(lastName).SendKeys(Lname);
        }

        public void EnterEmail(string Email)
        {
            driver.FindElement(emailID).SendKeys(Email);
        }

        public void EnterPassword(String Password)
        {
            driver.FindElement(passWord).SendKeys(Password);
        }

        public void EnterConfirmPassword(String Password)
        {
            driver.FindElement(confirmPass).SendKeys(Password);
        }

        public void ClickRegister()
        {
            driver.FindElement(registerBtn).Click();
        }

        public String GetMessage()
        {
            return driver.FindElement(message).Text;
        }

        public String GetConfirmEmail()
        {
            return driver.FindElement(confirmEmail).Text;
        }

        public void ClickLogOut()
        {
            driver.FindElement(logOut).Click();
        }

        public String GetTitle()
        {
            return driver.Title;
        }


    }

}
