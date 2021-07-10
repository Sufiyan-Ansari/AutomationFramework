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
            ScenarioContext.Current.Pending();
        }



    }
}
