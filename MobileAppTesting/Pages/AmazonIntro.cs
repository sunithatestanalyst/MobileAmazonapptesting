using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace MobileAppTesting.Pages
{
   internal class AmazonIntro
    {
       
        internal void Currencyselection()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Explicit Wait 

           IWebElement currencyElement= Waitforelement(By.XPath("(//android.widget.Button[@content-desc='Submit'])[3]"),30);

            currencyElement.Click();

            IWebElement Nzdollarselection = Waitforelement(By.Id("NZ$ - NZD - New Zealand Dollar"), 20);
            Nzdollarselection.Click();

            IWebElement Doneincountryselection = Waitforelement(By.XPath("(//android.widget.Button[@content-desc='Submit'])[4]"),8);
            Doneincountryselection.Click();

           TestCases.driver.FindElement(By.Id("com.amazon.mShop.android.shopping:id/skip_sign_in_button")).Click();
            
        }

        internal IWebElement Waitforelement(By by ,int timeinseconds)
        {
                WebDriverWait wait = new WebDriverWait(TestCases.driver, TimeSpan.FromSeconds(timeinseconds));
               return(wait.Until(d => d.FindElement(by)));
                         
           

        }
    }
}
