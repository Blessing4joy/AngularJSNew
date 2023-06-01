using AngularJSNew.Page_Object;
using System;
using TechTalk.SpecFlow;

namespace AngularJSNew.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {

        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterStepDefinitions()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }







        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }

        [Given(@"I enter my Username text ""([^""]*)""")]
        public void GivenIEnterMyUsernameText(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }

        [Given(@"I enter my Email text ""([^""]*)""")]
        public void GivenIEnterMyEmailText(string email)
        {
            dataDrivenWithParameterPage.EnterEmail(email);
        }

        [Given(@"I enter my Password text ""([^""]*)""")]
        public void GivenIEnterMyPasswordText(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }
    }
}
