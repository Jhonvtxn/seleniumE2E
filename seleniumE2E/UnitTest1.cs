using NUnit.Framework;

namespace seleniumE2E
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;

    namespace SeleniumTests
    {
        [TestFixture]
        public class UntitledTestCase
        {
            private IWebDriver driver;
            private StringBuilder verificationErrors;
            private string baseURL;
            private bool acceptNextAlert = true;

            [SetUp]
            public void SetupTest()
            {
                driver = new ChromeDriver("C:\\Users\\Jon\\Desktop\\chrome");
                baseURL = "https://www.google.com/";
                verificationErrors = new StringBuilder();
            }

            [TearDown]
            public void TeardownTest()
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
                Assert.AreEqual("", verificationErrors.ToString());
            }

            [Test]
            public void TheUntitledTestCaseTest()
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Navigate().GoToUrl("http://localhost:4200/#/login");
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//input[@type='email']")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//input[@type='email']")).Clear();
                driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("jhon@gmail.com");
                driver.FindElement(By.XPath("//input[@type='password']")).Clear();
                driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("123456@Ab");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Matenha-me conectado'])[1]/following::button[1]")).Click();
                driver.FindElement(By.LinkText("Registra Ponto")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//div/i")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//div/i")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//div/i")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.LinkText("Perfil Usuario")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.LinkText("Happy Friday")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Registrar HappyFriday'])[1]/following::select[1]")).Click();
                new SelectElement(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Registrar HappyFriday'])[1]/following::select[1]"))).SelectByText("29/11/21");
                driver.FindElement(By.XPath("//div/i")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.LinkText("Dashboard")).Click();
                Thread.Sleep(5000);
            }
            private bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            private bool IsAlertPresent()
            {
                try
                {
                    driver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            private string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }

}