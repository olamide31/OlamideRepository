using Demotest1.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Demotest1.StepDefinition
{
    [Binding]
    public class DatadrivenwithparametersSteps
    {
        Datadrivenwithparameterpage datadrivenwithparameterpage;

        public DatadrivenwithparametersSteps()
        {
            datadrivenwithparameterpage = new Datadrivenwithparameterpage();
        }



        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            datadrivenwithparameterpage.navigatetowebsite(url);
        }
                   

        
        [When(@"I enter my username text ""(.*)""")]
        public void WhenIEnterMyUsernameText(string joko)
        {
            datadrivenwithparameterpage.EnterUserName(joko);
        }
        
        [When(@"i enter my email text ""(.*)""")]
        public void WhenIEnterMyEmailText(string mafo)
        {
            datadrivenwithparameterpage.EnterEmail(mafo);
        }
        
        [When(@"i enter password text ""(.*)""")]
        public void WhenIEnterPasswordText(string gbedu)
        {
            datadrivenwithparameterpage.Enterpassword(gbedu);
        }
        
        [When(@"i click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            datadrivenwithparameterpage.clickonsignupbutton();
        }
        
        [Then(@"i am logged in with my username displayed")]
        public void ThenIAmLoggedInWithMyUsernameDisplayed()
        {
            Assert.That(datadrivenwithparameterpage.isuserloginDisplayed);
        }
    }
}
