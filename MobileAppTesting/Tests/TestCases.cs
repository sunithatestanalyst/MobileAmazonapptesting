using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileAppTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace MobileAppTesting
{
    [TestFixture]
    public class TestCases
    {
        DesiredCapabilities caps;
       public static AndroidDriver<AppiumWebElement> driver;

        [SetUp]
        public void Startapp()
        {

            caps = new DesiredCapabilities();
            caps.SetCapability("platformName", "Android");
            caps.SetCapability("deviceName", "ASUS_T00J");
            caps.SetCapability("appPackage", "com.amazon.mShop.android.shopping");
            // caps.SetCapability("appWaitActivity", "com.amazon.mShop.android.home.HomeActivity");
            caps.SetCapability("appActivity", "com.amazon.mShop.android.home.HomeActivity");
            //  caps.SetCapability("appActivity", "com.amazon.mShop.startup.StartupLocalizationSelectionActivity");
            // caps.SetCapability("noReset", "True");

             driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), caps);
        }

        [Test]
        public void Currencyselection()
        {
            
            AmazonIntro obj = new AmazonIntro();
            obj.Currencyselection();
        }
    }
}
