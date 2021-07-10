using AutomationFramework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
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
            int temp = 0;
            element = driver.FindElement(By.XPath(locator));
       //     temp = element.Text;

            IList<IWebElement> ele = driver.FindElements(By.XPath(locator));
            string[] alltext = new string[ele.Count];
            int i = 0;
            foreach(IWebElement element in ele)
            {
                alltext[i++] = element.Text;
                string test = element.Text;
                string test2 = test.Replace(",", "");
                int testNumber = Convert.ToInt32(test2);
                try
                {
                    if (testNumber > 80000 || testNumber < 60000)
                    {
                        Assert.Fail("Price filter is not working");
                    }
                }
                catch(Exception ex)
                {
                    Assert.Fail("Something went wrong");
                }
                
            }
        }

        public void scrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(0,350)");
            js.ExecuteScript("window.scrollBy(0,9500)");

        }
    }
}
