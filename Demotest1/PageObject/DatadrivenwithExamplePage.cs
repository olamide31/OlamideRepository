using Demotest1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demotest1.PageObject
{
    class DatadrivenwithExamplePage
    {
        public DatadrivenwithExamplePage()
        {
            driver = Hooks2.driver;
        }


        IWebDriver driver;


        IWebElement usernameinput => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement emailinput => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));

        IWebElement passwordinput => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));

        IWebElement signUpButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));

        IWebElement userlogin => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[4]/a"));










        public void EnterUserName(string joko)
        {
            Random randomGenerator = new Random();
            int randomint = randomGenerator.Next(1000);
            usernameinput.SendKeys(joko + randomint);
            //usernameinput.SendKeys(joko);
        }

        public void navigatetowebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string Elephant)
        {
            Random randomGenerator = new Random();
            int randomint = randomGenerator.Next(1000);
            emailinput.SendKeys(Elephant + randomint + "@yahoo.com");
            //emailinput.SendKeys(mafo);
        }

        public void Enterpassword(string Pigeon)
        {
            passwordinput.SendKeys(Pigeon);
        }

        public void clickonsignupbutton()
        {
            signUpButton.Click();
        }

        public bool isuserloginDisplayed()
        {
            return userlogin.Displayed;
        }










    }
}
