using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BibliotecaTest
{
    [TestFixture]
    public class SeleniumTests
    {
        [Test]
        public void VerificarLogin()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://localhost:58972/Auth/Login?ReturnUrl=%2f";
            Thread.Sleep(3000);
            var user = chrome.FindElement(By.Name("Username"));
            var password = chrome.FindElement(By.Name("Password"));

            user.SendKeys("admin");
            password.SendKeys("admin");

            var boton = chrome.FindElement(By.Id("btnLogin"));
            boton.Click();
            Thread.Sleep(3000);
            Assert.AreEqual(chrome.Url, "http://localhost:58972/");
        }


    }
}
