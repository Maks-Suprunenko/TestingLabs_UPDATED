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
using NUnit.Framework.Interfaces;
using Microsoft.Extensions.Configuration;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Steps;

namespace PetClinicTestProject
{
    [AllureNUnit]
    public class TestBase
    {
        public static IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        public Pages pages
        {
            get; set;
        }
        public IConfiguration Configuration { get; set; }
        public OwnerSection Owner { get; set; }
        public VetSection Vet { get; set; }
        private IJavaScriptExecutor js;
        protected string BaseUrl;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            BaseUrl = "http://20.50.171.10:8080/";
            driver.Navigate().GoToUrl(BaseUrl);
            pages = new Pages(driver);
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var filename = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
                var path = $"C:\\Users\\makss\\Desktop\\Тестування\\6\\PetClinicTestProject\\TestResults{filename}";
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
                AllureLifecycle.Instance.AddAttachment(filename, "image/png", path);
            }
        }
        [AllureStep("Retreive test data")]
        protected void GetTestData()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(@"C:\Users\makss\Desktop\Тестування\5\PetClinicTestProject\TestDataConfiguration")
                .AddJsonFile("TestData.json", optional: false, reloadOnChange: true)
                .Build();
            Owner = new OwnerSection(Configuration);
            Configuration.GetSection("owners").Bind(Owner);
            Vet = new VetSection(Configuration);
            Configuration.GetSection("vets").Bind(Vet);
        }
    }
}
