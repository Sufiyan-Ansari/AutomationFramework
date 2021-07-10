﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Implementation
{
    class DriverFactory
    {
        public static IWebDriver driver;
        public static IWebDriver getDriver()
        {
            if(driver == null)
            {
                try
                {
                    string url = "";
                    
                }
                catch(Exception ex)
                {

                }
                return driver;
            }
            return driver;
        }

        public static void Initialize(string url)
        {
            ChromeOptions chromeOption = new ChromeOptions();
            chromeOption.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(chromeOption);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
    }
}
