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
    public static class EditOwnerPage
    {
        public static IWebElement firstName => TestBase.driver.FindElement(By.Id("firstName"));
        public static IWebElement lastName => TestBase.driver.FindElement(By.Id("lastName"));
        public static IWebElement city => TestBase.driver.FindElement(By.Id("city"));
        public static IWebElement address => TestBase.driver.FindElement(By.Id("address"));
        public static IWebElement telephone => TestBase.driver.FindElement(By.Id("telephone"));
        public static void ClearNType(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
        public static IWebElement updateOwnerButton => TestBase.driver.FindElement(By.CssSelector(".updateOwner"));
    }
}
