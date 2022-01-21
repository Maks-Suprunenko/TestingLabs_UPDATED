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
using Microsoft.Extensions.Configuration;

namespace PetClinicTestProject
{
    public class OwnerSection
    {
        public List<OwnerConfiguration> OwnerList { get; }

        public OwnerSection(IConfiguration configuration)
        {
            configuration.GetSection("owners").Bind(OwnerList = new List<OwnerConfiguration>());
        }
    }
}
