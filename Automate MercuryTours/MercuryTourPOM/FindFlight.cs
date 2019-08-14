using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace Automate_MercuryTours.MercuryTourPOM
{
    public class FindFlight
    {
        private IWebDriver driver;

        public FindFlight(IWebDriver driver)
        {
            this.driver = driver;
            //Initialise all the elements on the FindFlight Page Object Model
            PageFactory.InitElements(driver, this);
        }



        [FindsBy(How = How.Name, Using = "fromPort")]// To find the dropdown control for departure
        private IWebElement fromport;

        [FindsBy(How = How.Name, Using = "toPort")] // To find the dropdown control for arrival
        private IWebElement toport;

        [FindsBy(How = How.Name, Using = "findFlights")]// To find the continue button to go to next page
        private IWebElement findflightbtn;


        public void SelectTriptype()
        {
            IList<IWebElement> radio = driver.FindElements(By.Name("tripType"));
            radio[1].Click();                   // To select the radio button Oneway
        }

        public void Departingfrom() // Method to select Sydney from dropdown
        {
            SelectElement selectElement = new SelectElement(fromport);
            selectElement.SelectByText("Sydney");
        }

        public void ArrivingIn() // Method to select London from dropdown
        {
            SelectElement selectElement = new SelectElement(toport);
            selectElement.SelectByText("London");
        }

        public void SelectClass() // Method to select First Class among the radiobuttons
        {
            IList<IWebElement> rdoTrip = driver.FindElements(By.Name("servClass"));
            rdoTrip[2].Click();
        }

        public void gotofindflight()
        {
            SelectTriptype();
            Departingfrom();
            ArrivingIn();
            SelectClass();
        }
        public reserveFlights clickonfindflightbtn() //Method to go to next page
        {
            Thread.Sleep(3000);//delay before getting to next page
            findflightbtn.Click();
            return new reserveFlights(driver); //Returns an instance of the class reserveFlights
        }

    }
}
