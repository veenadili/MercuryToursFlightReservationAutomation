using Automate_MercuryTours.MercuryTourPOM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Automate_MercuryTours.MercuryTourTest
{
    public class MercuryTourTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void BookaTrip()
        {
            Login login = new Login(driver); // Creating an instance of class login
            login.goToPage();  // Invoking gotoPage Method defined in class Login
            login.logindetails(); // Invoking method logindetails defined in class Login

            FindFlight fndflight = login.clickonLoginBtn();
            fndflight.gotofindflight();

            reserveFlights reserve = fndflight.clickonfindflightbtn();// Invoking method clickonfindflightbtn defined in class reserveFlights 

            BookFlight Book = reserve.clickonreserveflightbtn();
            Book.gotobookflight();// Invoking method gotobookflight defined in class BookFlight
            Confirmation confirm = Book.buyflight();
            confirm.Asserts();// Invoking method assert defined in class Confirmation

        }

        [TearDown]
        public void CloseBrowser()
        {
            Thread.Sleep(3000); //delaying before quiting
            driver.Quit(); // Quits the browser
        }





    }
}
