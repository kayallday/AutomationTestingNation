using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BeforeBasePage
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver Driver;
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Close();
            Driver.Dispose();
            Driver.Quit();
        }
    }
}
