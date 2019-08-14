using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate_MercuryTours.MercuryTourPOM
{
    public class Confirmation
    {
        private IWebDriver driver;

        public Confirmation(IWebDriver driver)
        {
            this.driver = driver;            
        }

        public void Asserts()
        {
            //Asserting the values that are passed on confirmation page.
            var chkName = driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr[1]/td[2]/table/tbody/tr[5]/td/table/tbody/tr[9]/td/p/font[1]"));
            var chkCountry = driver.FindElement(By.XPath("//table//tr[3]/td/font"));
            Assert.IsTrue(chkName.Text.Contains("ABC"));
            Assert.IsTrue(chkCountry.Text.Contains("Sydney"));
            Assert.IsTrue(chkCountry.Text.Contains("London"));
            Assert.IsFalse(chkCountry.Text.Contains("abc"));
        }
    }
}