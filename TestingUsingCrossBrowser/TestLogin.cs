/*
 * Project:Using the crossbrowser testing for facebook 
 * Author:Sahithi p
 * Date :19/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace TestingUsingCrossBrowser
{
    [TestFixture]
    [Parallelizable]
    public class TestLogin : BaseClass
    {
        //giving the chrome and firefox browsers
        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "chrome", "firefox", };
            foreach (string b in browsers)
            {
                yield return b;
            }
        }



        [Test]
        [TestCaseSource("BrowserToRunWith")]
        //login into myntra using findelements
        public void LoginIntoFacebook(string browsername)
        {
            BrowserTestMethod(browsername);
            driver.Url = "https://www.myntra.com/";
            driver.FindElement(By.XPath("//span[@class = 'desktop-userTitle']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class = 'desktop-getUserInLinks desktop-getInLinks']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@class='form-control mobileNumberInput']")).SendKeys("6302921479");
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("//div[@class='submitBottomOption']")).Click();
            System.Threading.Thread.Sleep(10000);
        }



    }
}




