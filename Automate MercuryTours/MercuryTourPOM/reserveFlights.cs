using Automate_MercuryTours.MercuryTourPOM;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automate_MercuryTours.MercuryTourPOM
{
    public class reserveFlights
    {

        private IWebDriver driver;

        public reserveFlights(IWebDriver driver)
        {
            this.driver = driver;
            //Initialise all the elements on the reserveFlights Page Object Model
            PageFactory.InitElements(driver, this);
        }



        [FindsBy(How = How.Name, Using = "reserveFlights")]
        private IWebElement reserveflightbtn; //To find the continue button to go to next page

        public BookFlight clickonreserveflightbtn() //Method to go to next Page 
        {
            Thread.Sleep(3000);//delay before getting to next page
            reserveflightbtn.Click();
            return new BookFlight(driver); // Returns an instance of the class BookFlight 
        }


    }
}
