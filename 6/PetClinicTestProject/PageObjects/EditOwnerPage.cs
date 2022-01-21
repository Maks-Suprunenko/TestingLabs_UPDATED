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
    public class EditOwnerPage : BasePage
    {
        public EditOwnerPage(IWebDriver driver) : base(driver) { }
        public IWebElement firstName => driver.FindElement(By.Id("firstName"));
        public IWebElement lastName => driver.FindElement(By.Id("lastName"));
        public IWebElement city => driver.FindElement(By.Id("city"));
        public IWebElement address => driver.FindElement(By.Id("address"));
        public IWebElement telephone => driver.FindElement(By.Id("telephone"));
        public IWebElement updateOwnerButton => driver.FindElement(By.CssSelector(".updateOwner"));
    }
}
