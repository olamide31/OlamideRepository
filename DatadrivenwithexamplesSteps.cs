using System;
using TechTalk.SpecFlow;

namespace Demotest1...
{
    [Binding]
    public class DatadrivenwithexamplesSteps
    {
        [When(@"the user enter username text ""(.*)""")]
        public void WhenTheUserEnterUsernameText(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user enter email text ""(.*)""")]
        public void WhenTheUserEnterEmailText(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user enter password text ""(.*)""")]
        public void WhenTheUserEnterPasswordText(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
