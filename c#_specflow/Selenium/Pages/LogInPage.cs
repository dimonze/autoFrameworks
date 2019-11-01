using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Support;

namespace Selenium.Pages
{
    public class LogInPage : TestPage
    {
     
        public LogInPage(ChromeDriver webDriver)
        {
            Setup(webDriver);
            Name = PageName.LogIn;
        }

        protected sealed override Collection<Locator> InitializeLocators()
        {
            return new Collection<Locator>
            {
                new Locator(Element.SignIn, By.Name("submit")),
                new Locator(Element.UserName, By.Id("identity")),
                new Locator(Element.Header, By.XPath("//li[@class='vd-tab active-tab ' and contains(.,'CONTENT HEALTH')]")),
                new Locator(Element.Password, By.Id("password"))
            };
        }    
    }
}
