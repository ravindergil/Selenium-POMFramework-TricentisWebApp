using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;
using System;

namespace SeleniumUITest.Test
{
    [TestClass]
    public class RegisterTest : BaseClass
    {

        public HomePage homePage;
        public RegisterPage registerPage;

        [TestMethod]
        public void TestMethod1()
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);

            homePage.ClickRegisterLink();

            registerPage.SelectMaleGender();
            registerPage.EnterFirstName("");
            registerPage.EnterLasttName("");
            registerPage.EnterEmail("");
            registerPage.EnterPassword("password");
            registerPage.EnterConfirmPassword("");
            registerPage.ClickRegister();
            registerPage.GetMessage();



        }
    }
}
