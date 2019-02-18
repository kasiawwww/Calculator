using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWsei.Selenium.Test
{
    class LoginPage
    {
        [FindsBy(How = How.Id, Using = "page-header")]
        public IWebElement Login { get; set; }
    }
}
