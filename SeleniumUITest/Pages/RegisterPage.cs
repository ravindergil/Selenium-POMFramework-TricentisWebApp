using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public static readonly By registerByn = By.CssSelector("input#ConfirmPassword");
        public static readonly By message = By.CssSelector("div.result");

        /* Page Methods
         */




    }

}
