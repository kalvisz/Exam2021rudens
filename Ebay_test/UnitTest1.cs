using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WindowsFormsApp1;

namespace Ebay_test
{
    [TestClass]
    public class UnitTest1 
    {
 
        [TestMethod]
        public void Test1_field()
        {
            IWebDriver driver;
            string path;
            bool idIr;
            // ==================================== ceļš uz selenium
            path = @"C:\Users\Kalvis\Desktop\Studijas\kursi\7.semestris\Programmaturas izstrades tehnologijas\BrowserDrivers";
            var options = new ChromeOptions();
            // palaižam chrome bez vizuālās daļas
            options.AddArguments("headless");
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(path, options);
            driver.Url = "https://www.ebay.com/";
            // meklē nepieciešamo ID
            idIr = driver.FindElement(By.Id("gh-ac")).Displayed;

            driver.Quit();

            Assert.AreEqual(true, idIr, "ID neeksistē");

        }
        [TestMethod]
        public void Test2_search()
        {
            //pēdējā mirklī izdomāju modificēt testu, kas varbūt būtu labāks, nekā pirmais
            try
            {
                IWebDriver driver;
                string path;
                bool idIr;
                // ==================================== ceļš uz selenium
                path = @"C:\Users\Kalvis\Desktop\Studijas\kursi\7.semestris\Programmaturas izstrades tehnologijas\BrowserDrivers";
                var options = new ChromeOptions();
                // palaižam chrome bez vizuālās daļas
                options.AddArguments("headless");
                options.AddExcludedArgument("enable-logging");
                driver = new ChromeDriver(path, options);
                driver.Url = "https://www.ebay.com/";
                // meklē nepieciešamo ID

                idIr = driver.FindElement(By.Id("gh-btn")).Displayed;

                driver.Quit();
            }catch(OpenQA.Selenium.NoSuchElementException e)
            {
                StringAssert.Contains(e.Message, "Id neeksistē");
                return;
            }
            
        }
    }
}
