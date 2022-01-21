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
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Steps;



namespace PetClinicTestProject
{
    public static class Helpers
    {
        [AllureStep("Click on the input and type a new value")]
        public static void ClickNType(IWebElement element, string text)
        {
            element.Click();
            element.SendKeys(text);
        }
        [AllureStep("Clear the input and type a new value")]
        public static void ClearNType(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
        [AllureStep("Scroll to the bottom of the page")]
        public static void Scroll2Bottom(IWebDriver driver)
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
    }
}
