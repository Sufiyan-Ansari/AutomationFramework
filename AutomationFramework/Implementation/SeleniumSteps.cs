using AutomationFramework.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
