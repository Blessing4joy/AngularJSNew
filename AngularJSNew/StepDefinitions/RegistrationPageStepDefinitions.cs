using AngularJSNew.Page_Object;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AngularJSNew.StepDefinitions
{
    [Binding]
    public class RegistrationPageStepDefinitions
    {
        RegistrationPage registrationPage;


        public RegistrationPageStepDefinitions()
        {
            registrationPage = new RegistrationPage();
        }
    
   
    
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickonSignup();
        }

        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"I click on Sign up Button")]
        public void WhenIClickOnSignUpButton()
        {
            registrationPage.ClickonSignupButton();
        }

        [Then(@"I should be able to Sign up sucessfully")]
        public void ThenIShouldBeAbleToSignUpSucessfully()
        {
           Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }
    }
}
