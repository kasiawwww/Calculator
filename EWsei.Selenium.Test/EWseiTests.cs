using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;

namespace EWsei.Selenium.Test
{
    [TestFixture]
    public class EwseiTests : MainTests
    {

        [Test]
        public void LoginWrongPassword()
        {
            //LoginPage loginpage = new LoginPage();
            //var x = loginpage.Login;
            var login = driver.FindElement(By.XPath(".//a[text()='Logowanie']"));
            login.Click();

            var username = driver.FindElement(By.ClassName("username"));
            username.SendKeys("username");
            var password = driver.FindElement(By.ClassName("password"));
            username.SendKeys("password");
            var loginbtn = driver.FindElement(By.ClassName("loginbtn"));
            username.SendKeys("loginbtn");
            loginbtn.Submit();

            var error = driver.FindElement(By.CssSelector("error"));
            StringAssert.StartsWith("Niewłaściwa", error.Text);
            //StringAssert.StartsWith("Zaloguj", header.Text);
           // Assert.IsTrue(loginpanel.Displayed);

        }
    }
}
