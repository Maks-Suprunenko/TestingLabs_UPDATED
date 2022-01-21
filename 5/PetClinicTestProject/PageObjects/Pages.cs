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
    public class Pages : BasePage
    {
        public Pages(IWebDriver driver) : base(driver) { }
        public EditOwnerPage EditOwner => new EditOwnerPage(driver);
        public AddVeterinarianPage AddVeterinarian => new AddVeterinarianPage(driver);
        public NavigationComponent Navigation => new NavigationComponent(driver);
    }
}
