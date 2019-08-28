using fitlibrary;
using fit.Runner;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using SeleniumFixtures.Pages;

namespace SeleniumFixtures
{
    public class WebFixture
    {
        public WebFixture()
        {
        }

        public void OpenUrl(string url)
        {
            Browser.Init();
            Browser.Driver.Navigate().GoToUrl(url);
        }

        public void Search(string text)
        {
            SearchPage googlePage = new SearchPage();
            googlePage.SearchText("Fitnesse");
        }

        public void CloseBrowser()
        {
            if (Browser.Driver!= null)
            {
                Browser.Driver.Dispose();
            }
        }
    }
}
