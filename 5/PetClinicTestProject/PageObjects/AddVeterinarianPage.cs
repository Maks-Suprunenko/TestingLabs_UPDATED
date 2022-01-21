﻿using System;
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
    public class AddVeterinarianPage : BasePage
    {
        public AddVeterinarianPage(IWebDriver driver) : base(driver) { }
        public IWebElement firstName => driver.FindElement(By.Id("firstName"));
        public IWebElement lastName => driver.FindElement(By.Id("lastName"));
        public IWebElement addVetherinarianButton => driver.FindElement(By.CssSelector(".saveVet"));
    }
}