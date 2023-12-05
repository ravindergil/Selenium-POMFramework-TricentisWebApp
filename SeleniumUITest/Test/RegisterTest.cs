using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;


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
            Assert.AreEqual(homePage.GetTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.GetTitle(), "Demo Web Shop. Register");

            registerPage.SelectMaleGender();
            registerPage.EnterFirstName("John");
            registerPage.EnterLasttName("Doe");
            registerPage.EnterEmail("john4doe@abcd.com");
            registerPage.EnterPassword("passWord");
            registerPage.EnterConfirmPassword("passWord");
            registerPage.ClickRegister();
            Assert.AreEqual(registerPage.GetMessage(), "Your registration completed");
            registerPage.ClickLogOut();



        }
    }
}
