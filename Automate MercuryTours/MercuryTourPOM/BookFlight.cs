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
    public class BookFlight
    {
        private IWebDriver driver;

        public BookFlight(IWebDriver driver)
        {
            this.driver = driver;
            //Initialise all the elements on the BookFlight Page Object Model
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Name, Using = "passFirst0")] //To find the input field to enter first name
        private IWebElement firstname;

        [FindsBy(How = How.Name, Using = "passLast0")] //To find the input field to enter last name
        private IWebElement lastname;

        [FindsBy(How = How.Name, Using = "cc_frst_name")] //To find the input field to enter first name for credit card
        private IWebElement ccfirstname;

        [FindsBy(How = How.Name, Using = "cc_last_name")] //To find the input field to enter last name for credit card
        private IWebElement cclastname;

        [FindsBy(How = How.Name, Using = "creditnumber")] // To find the input field to enter credit card number
        private IWebElement cardnumber;

        [FindsBy(How = How.Name, Using = "ticketLess")] // To find the checkbox for Ticketless Travel
        private IWebElement chkboxticket;

        [FindsBy(How = How.Name, Using = "buyFlights")] // To find the continue button to go to next page
        private IWebElement buyflightbtn;

        public void Enterfirstname()
        {
            firstname.SendKeys("ABC"); //To enter ABC as first name in the input field
        }
        public void Enterlastname()
        {
            lastname.SendKeys("XYZ"); //To enter XYZ as last name in the input field

        }
        public void Enterccfirstname()
        {
            ccfirstname.SendKeys("ABC");//To enter ABC as credit card first name in the input field
        }
        public void Entercclastname()
        {
            cclastname.SendKeys("XYZ");//To enter XYZ as credit card last name in the input field
        }
        public void Entercardnumber()
        {
            cardnumber.SendKeys("12345678"); //To enter 12345678 as credit card number in the input field
        }
        public void ticketless()
        {
            chkboxticket.Click(); //To select the Ticketless travel checkbox
        }

        // Call all the functions for booking the ticket
        public void gotobookflight()
        {

            Enterfirstname();
            Enterlastname();
            Entercardnumber();
            Enterccfirstname();
            Entercclastname();
            ticketless();
        }
        public Confirmation buyflight()
        {
            Thread.Sleep(3000);//delay before getting to next page
            buyflightbtn.Click();   //Method to go to next page
            return new Confirmation(driver); // returns an instance of class Confirmation
        }

    }

}



