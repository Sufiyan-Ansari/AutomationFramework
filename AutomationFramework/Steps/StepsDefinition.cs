using AutomationFramework.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationFramework.Steps
{
    [Binding]
    class StepsDefinition
    {
        
        [Given(@"User Launches the Application")]
        public void GivenUserLaunchesTheApplication()
        {
            SeleniumSteps step = new SeleniumSteps();
            step.LaunchApplication();
        }
        [Given(@"user is navigation on ""(.*)""")]
        public void GivenUserIsNavigationOn(string locator)
        {
            SeleniumSteps step = new SeleniumSteps();
            step.HoverToElement(locator);
        }
        [When(@"I wait for ""(.*)""")]

        [Given(@"I wait for ""(.*)""")]
        public void GivenIWaitFor(int time)
        {
            SeleniumSteps step = new SeleniumSteps();
            step.wait(time);
        }
        [Given(@"I am clicking on ""(.*)""")]
        [When(@"I am clicking on ""(.*)""")]
        public void GivenIAmClickingOn(string locator)
        {
            SeleniumSteps step = new SeleniumSteps();
            step.Click(locator);
        }
        [Given(@"I have given ""(.*)"" on ""(.*)""")]
        public void GivenIHaveGivenOn(string keys, string locator)
        {
            SeleniumSteps step = new SeleniumSteps();
            step.SendKeys(keys,locator);
        }

        [Then(@"I want to validate filters of price range on ""(.*)""")]
        public void ThenIWantToValidateFiltersOfPriceRangeOn(string locator)
        {
            SeleniumSteps step = new SeleniumSteps();
            step.PriceVerification(locator);
        }






    }
}
