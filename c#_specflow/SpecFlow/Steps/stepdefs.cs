using NUnit.Framework;
using Selenium.Pages;
using Selenium.Support;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps
{
    [Binding]
    public class Stepdefs
    {
        private AutomationTestSite automationTestSite;

        public Stepdefs(AutomationTestSite automationTestSite)
        {
            this.automationTestSite = automationTestSite;
        } 

        [Given(@"I am on ""(.*)""")]
        public void GivenIAmOn(string url)
        {
            automationTestSite.GoTo(url);
        }

        [When(@"I fill in username with ""(.*)""")]
        public void WhenIFillInUsernameWith(string value)
        {
            automationTestSite.EnterTextIntoInputField(PageName.LogIn, Element.UserName, value);
        }

        [When(@"I fill in password with ""(.*)""")]
        public void WhenIFillInPasswordWith(string value)
        {
            automationTestSite.EnterTextIntoInputField(PageName.LogIn, Element.Password, value);
        }

        [When(@"I click on ""(.*)""")]
        public void WhenIClickOn(string element)
        {
            automationTestSite.ClickElementOnPage(PageName.LogIn, Element.SignIn);
        }

        [Then(@"I should see ""(.*)"" in title")]
        public void ThenIShouldSeeInTitle(string text)
        {
            automationTestSite.DoesElementExistOnPage(PageName.LogIn, Element.Header);
        }
    }
}
