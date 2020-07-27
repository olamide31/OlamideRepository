using Demotest1.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Demotest1.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }






        [Given(@"I navigate to angularjs website")]
        public void GivenINavigateToAngularjsWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
                
        
        [When(@"I clicked on sign up")]
        public void WhenIClickedOnSignUp()
        {
            registrationPage.clickonsignup();
        }
        
        [When(@"i enter my username")]
        public void WhenIEnterMyUsername()
        {
            registrationPage.entreryourusername();
        }
        
        [When(@"i enter my email")]
        public void WhenIEnterMyEmail()
        {
            registrationPage.enteryouremail();
        }
        
        [When(@"i enter my password")]
        public void WhenIEnterMyPassword()
        {
            registrationPage.enteryourpassword();
        }
        
        [When(@"i click on sign up to angularjs")]
        public void WhenIClickOnSignUpToAngularjs()
        {
            registrationPage.clickonsignuptoregister();
        }
        
        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            // different type of Assertion
            // 1.NUnit Assertion
            // 2.JUnit Assertion
            // 3.MStest
            Assert.That(registrationPage.logindisplayed);
        }
    }
}
