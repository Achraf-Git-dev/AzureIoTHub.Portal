// Copyright (c) CGI France. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

//namespace AzureIoTHub.Portal.Tests.E2E
//{
//    using AzureIoTHub.Portal.Tests.E2E.Pages;
//    using NUnit.Framework;
//    using OpenQA.Selenium.Chrome;
//    using OpenQA.Selenium;
//    using OpenQA.Selenium.Support.UI;

//    public class AddDevice
//    {
//        private IWebDriver driver;

//        [SetUp]
//        public void SetUp()
//        {
//            driver = new ChromeDriver();
//        }

//        [Test]
//        public void AddDeviceTest()
//        {
//            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
//            var loginpage = new LoginPage(driver, wait);

//            loginpage.Login("achraf.boujida@etu.uca.fr", "dDpDDhSFL7VvrQA");


//            _ = wait.Until(d => d.FindElement(By.CssSelector(".mud-paper:nth-child(1) .mud-nav-link-text")).Displayed);

//            // list
//            driver.FindElement(By.CssSelector(".mud-paper:nth-child(1) .mud-nav-link-text")).Click();
//            _ = wait.Until(d => d.FindElement(By.Id("addDeviceButton")).Displayed);
//            driver.FindElement(By.Id("addDeviceButton")).Click();

//            _ = wait.Until(d => d.FindElement(By.CssSelector(".mud-input-adornment path:nth-child(2)")).Displayed);

//            //giving DeviceId and DeviceName
//            driver.FindElement(By.CssSelector(".mud-input-adornment path:nth-child(2)")).Click();
//            driver.FindElement(By.CssSelector(".mud-typography-body2")).Click();
//            driver.FindElement(By.Id("DeviceID")).Click();
//            driver.FindElement(By.Id("DeviceID")).SendKeys("6bc7dc880f60ba3b");
//            driver.FindElement(By.Id("DeviceName")).Click();
//            driver.FindElement(By.Id("DeviceName")).SendKeys("6bc7dc880f60ba3b");
//            driver.FindElement(By.CssSelector("#SaveButton > .mud-button-label")).Click();

//            //logout
//            loginpage.Logout();

//            System.Threading.Thread.Sleep(4000);
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            driver.Quit();
//        }
//    }
//}