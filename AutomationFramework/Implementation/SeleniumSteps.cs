using AutomationFramework.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationFramework.Implementation
{
    class SeleniumSteps
    {
        IWebElement element;
        IWebDriver driver = ContextPage.driver;


        public void LaunchApplication()
        {
            try
            {
                ContextPage.driver = DriverFactory.getDriver();

            }

            catch(Exception ex)
            {
            }
        }
        public void HoverToElement(string locator)
        {
            element = driver.FindElement(By.XPath(locator));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void wait(int time)
        {
            Thread.Sleep(time);
        }
        public void Click(string locator)
        {
            element = driver.FindElement(By.XPath(locator));
            element.Click();
        }

        public void SendKeys(string keys, string locator)
        {
            element = driver.FindElement(By.XPath(locator));
            element.SendKeys(keys);
        }

        public void PriceVerification(string locator)
        {
            string temp = "";
            element = driver.FindElement(By.XPath(locator));
            temp = element.Text;

            IList<IWebElement> ele = driver.FindElements(By.XPath(locator));
            String[] alltext = new String[ele.Count];
            int i = 0;
            foreach(IWebElement element in ele)
            {
                alltext[i++] = element.Text;
            }

        }
    }
}
