using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWsei.Selenium.Test
{
    public abstract class MainTests
    {
        public IWebDriver driver;
        [SetUp]
        public void RunBrowser()
        {
            driver = new ChromeDriver("D:/Users/k.widlak/Downloads/");
            //driver = new FirefoxDriver();
            driver.Url = "https://e.wsei.edu.pl/";
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
