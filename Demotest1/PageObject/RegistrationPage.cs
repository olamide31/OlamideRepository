using Demotest1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demotest1.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks2.driver;
        }

        IWebDriver driver;

        IWebElement signup => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));

        IWebElement username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement email => driver.FindElement(By.CssSelector("input.ng-valid-email"));

        IWebElement password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));

        IWebElement signuptoangularjs => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));

        IWebElement confirmloginName => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[4]/a"));









        public void clickonsignup()
        {
            signup.Click();
        }

        public void entreryourusername()
        {
            username.SendKeys("mallam");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/");
        }

        public void enteryouremail()
        {
            email.SendKeys("funkymallam@yahoo.com");
        }

        public void enteryourpassword()
        {
            password.SendKeys("moscow333");
        }

        public void clickonsignuptoregister()
        {
            signuptoangularjs.Click();
        }

        public bool logindisplayed()
        {
            return confirmloginName.Displayed;
        }


    }
}
