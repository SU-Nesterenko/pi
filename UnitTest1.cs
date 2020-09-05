using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumItself
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver browser;
        IWebElement tb, btn,lb;

        [TestInitialize]
        public void TestInit()
        {
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Navigate().GoToUrl("http://localhost:8646/WebForm1.aspx");
            tb = browser.FindElement(By.Id("TextBox1"));
            btn = browser.FindElement(By.Id("Button1"));
           
        }

        [TestMethod]
        public void TooSmall()
        {
            tb.SendKeys("5");
            btn.Click();
            //Thread.Sleep(1000);
            lb = browser.FindElement(By.Id("Label1"));
            Assert.AreEqual(lb.Text,"Ты ещё мал");
        }

        [TestMethod]
        public void Good()
        {
            tb.SendKeys("25");
            btn.Click();
            //Thread.Sleep(1000);
            lb = browser.FindElement(By.Id("Label1"));
            Assert.AreEqual(lb.Text, "Хорошо");
        }
    }
}
