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
    public class VetSection
    {
        public List<VetConfiguration> VetList { get; }

        public VetSection(IConfiguration configuration)
        {
            configuration.GetSection("vets").Bind(VetList = new List<VetConfiguration>());
        }
    }
}
