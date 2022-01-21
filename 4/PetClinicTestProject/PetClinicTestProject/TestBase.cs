using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace PetClinicTestProject
{
    public class TestBase
    {
        public static IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        protected string BaseUrl;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            BaseUrl = "http://20.50.171.10:8080/";
            driver.Navigate().GoToUrl(BaseUrl);
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
    }
}
