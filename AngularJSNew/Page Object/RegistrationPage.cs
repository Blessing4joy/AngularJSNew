using AngularJSNew.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSNew.Page_Object
{
     class RegistrationPage
    {
        public RegistrationPage() 
        {
            driver = Hooks1.driver;
        }


        IWebDriver driver;

        IWebElement Signup => driver.FindElement(By.XPath("(//a[@class='nav-link'])[2]"));
        IWebElement Username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement SignupButton => driver.FindElement(By.XPath("//button[@type='submit']"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }


        public void ClickonSignup()
        {
            Signup.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("MamaJoY");
        }

        public void EnterEmail()
        {
            Email.SendKeys("blessing218@gmail.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("Password123");
        }

        public void ClickonSignupButton()
        {
            SignupButton.Click();
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }
    }
}
