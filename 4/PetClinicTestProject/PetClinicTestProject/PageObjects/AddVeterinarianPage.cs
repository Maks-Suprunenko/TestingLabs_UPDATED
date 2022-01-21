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
    public static class AddVeterinarianPage
    {
        public static IWebElement firstName => TestBase.driver.FindElement(By.Id("firstName"));
        public static IWebElement lastName => TestBase.driver.FindElement(By.Id("lastName"));
        public static void ClickNType(IWebElement element, string text)
        {
            element.Click ();
            element.SendKeys(text);
        }
        public static IWebElement addVetherinarianButton => TestBase.driver.FindElement(By.CssSelector(".saveVet"));
    }
}
