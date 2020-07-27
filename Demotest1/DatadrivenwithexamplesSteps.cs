using Demotest1.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Demotest1
{
    [Binding]
    public class DatadrivenwithexamplesSteps
    {
        DatadrivenwithExamplePage datadrivenwithExamplePage;

        public DatadrivenwithexamplesSteps()
        {
            datadrivenwithExamplePage = new DatadrivenwithExamplePage();
        }

        [When(@"the user enter username text ""(.*)""")]
        public void WhenTheUserEnterUsernameText(string Nasty)
        {
            datadrivenwithExamplePage.EnterUserName(Nasty);
        }
                
        
        [When(@"the user enter email text ""(.*)""")]
        public void WhenTheUserEnterEmailText(string Elephant)
        {
            datadrivenwithExamplePage.EnterEmail(Elephant);
        }
        
        [When(@"the user enter password text ""(.*)""")]
        public void WhenTheUserEnterPasswordText(string Pigeon)
        {
            datadrivenwithExamplePage.Enterpassword(Pigeon);
        }
    }
}
