using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Common
{
    class ContextPage
    {
        public static IWebDriver driver;
        public static IWebDriver Driver
        {
            set { driver = value; }
            get { return driver; }
        }

    }
}
