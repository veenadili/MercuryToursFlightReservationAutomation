using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Automate_MercuryTours.MercuryTourPOM
{
    public class Login
    {
        private IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            //Initialise all the elements on the Login Page Object Model
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "userName")] // To find the input field to enter Username
        private IWebElement username;

        [FindsBy(How = How.Name, Using = "password")] // To find the input field to enter Password
        private IWebElement password;

        [FindsBy(How = How.Name, Using = "login")] // To find the login button
        private IWebElement login;


        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://newtours.demoaut.com/mercurywelcome.php");// To navigate to mercury Tours website
        }

        public void EnterUsername()
        {
            username.SendKeys("mercury"); //To enter mercury as username in input field
        }
        public void Enterpassword()
        {
            password.SendKeys("mercury"); //To enter mercury as password in input field
        }

        public void logindetails()
        {

            EnterUsername();
            Enterpassword();

        }
        public FindFlight clickonLoginBtn()
        {
            login.Click(); //Method to continue to next page 
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromMinutes(4));
            return new FindFlight(driver);// Returns an instance of class FindFlight
        }


    }
}
