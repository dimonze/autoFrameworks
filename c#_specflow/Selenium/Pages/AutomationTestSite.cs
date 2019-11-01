using System;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.Support;

namespace Selenium.Pages
{
    public class AutomationTestSite
    {
        public PageName PageName;
        public string BaseUrl;
        private ChromeDriver WebDriver;
        private Collection<TestPage> Pages;

        public AutomationTestSite()
        {
            WebDriver = new ChromeDriver();
            Pages = InitializePages();
        }

        private Collection<TestPage> InitializePages()
        {
            return new Collection<TestPage>
            {
				new LogInPage(WebDriver)
            };
        }

        public void GoTo(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }
        
        public TestPage GetPage(PageName pageName)
        {
            return Pages.FirstOrDefault(page => page.Name.Equals(pageName));
        }

        public bool DoesElementExistOnPage(PageName pageName, Element element)
        {
            var locator = GetPage(pageName).GetLocator(element);
            try
            {
                WebDriver.FindElement(locator.FindBy);
            }
            catch (NoSuchElementException noSuchElementException)
            {
                return false;
            }
            return true;
        }

        public void ClickElementOnPage(PageName pageName, Element element)
        {
            var locator = GetPage(pageName).GetLocator(element);
            WebDriver.FindElement(locator.FindBy).Click();
            System.Threading.Thread.Sleep(5000);
        }

        public void EnterTextIntoInputField(PageName pageName, Element element, string text)
        {
            var locator = GetPage(pageName).GetLocator(element);
            WebDriver.FindElement(locator.FindBy).SendKeys(text);
        }

        public void Dispose()
        {
            WebDriver.Dispose();
        }
    }
}
