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
using NUnit.Framework;
using Microsoft.Extensions.Configuration;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Steps;
using NUnit.Framework.Interfaces;

namespace PetClinicTestProject
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }
    public class Hooks : TestBase
    {
        private BrowserType browserType;
        public Hooks(BrowserType browser)
        {
            browserType = browser;
        }
        [SetUp]
        public void InitializeBrowser()
        {
            ChooseBrowser(browserType);
            driver.Manage().Window.Size = new System.Drawing.Size(1152, 620);
            driver.Navigate().GoToUrl(BaseUrl);
            BaseUrl = "http://20.50.171.10:8080/";
            pages = new Pages(driver);
        }
        public void ChooseBrowser(BrowserType browser)
        {
            driver = new FirefoxDriver(@"C:\Users\makss\Desktop\Тестування\7\PetClinicTestProject");
            Dictionary<string, object> additionalSelenoidCapabilities = new Dictionary<string, object>();
            additionalSelenoidCapabilities["name"] = "PI-59-2 LR7";
            additionalSelenoidCapabilities["enableVNC"] = false;

            switch (browser)
            {
                case BrowserType.Chrome:
                    var chrome_options = new ChromeOptions();
                    chrome_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chrome_options.ToCapabilities());
                    break;
                case BrowserType.Firefox:
                    var firefox_options = new FirefoxOptions();
                    firefox_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), firefox_options.ToCapabilities());
                    break;
                default:
                    driver = new FirefoxDriver(@"C:\Users\makss\Desktop\Тестування\7\PetClinicTestProject");
                    break;
            }
        }
    }
}
