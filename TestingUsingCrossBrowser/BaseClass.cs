/*
 * Project:Using the crossbrowser testing for facebook 
 * Author:Sahithi p
 * Date :19/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;


namespace TestingUsingCrossBrowser
{
    public class BaseClass
    {
        public static IWebDriver driver;

      //Launches Browser
        public void BrowserTestMethod(string browsername)
        {
            if (browsername.Equals("chrome"))
                driver = new ChromeDriver();
            else
                driver = new FirefoxDriver(); 


            //Maximize Browser
            driver.Manage().Window.Maximize();  
            
        }

      [TearDown]
        // This method will fire at the end of the Test
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
