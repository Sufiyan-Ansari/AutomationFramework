using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.POM
{
    class ControlProperties
    {
        public static By PriceRange = By.XPath("//div[@data-testid='price']//button[@data-testid='filter-toggle']//span");
        public static By MinRange = By.XPath("//div//label[@data-testid='min_price']");
        public static By MaxRange = By.XPath("//div//label[@data-testid='max_price']");
        public static By SearchButton = By.XPath("//div//button[@data-testid='search']");
        public static By AmountField = By.XPath("//div[@data-testid='listing-price']//span[2]");
        public static By Page2 = By.XPath("//div//a[@data-test='pagination-page-2']");



    }
}
