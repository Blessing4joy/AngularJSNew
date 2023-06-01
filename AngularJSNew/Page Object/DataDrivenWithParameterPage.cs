using AngularJSNew.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSNew.Page_Object
{
     class DataDrivenWithParameterPage
    {

        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }





    }
}
