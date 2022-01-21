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
    public class NavigationComponent : BasePage
    {
        public NavigationComponent(IWebDriver driver) : base(driver) { }
        public IWebElement ownerTab => driver.FindElement(By.CssSelector(".ownerTab"));
        public IWebElement ownerListLink => driver.FindElement(By.CssSelector(".open li:nth-child(1) span:nth-child(2)"));
        public IWebElement vetsTab => driver.FindElement(By.CssSelector(".vetsTab"));
        public IWebElement vetsListLink => driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)"));
    }
}
