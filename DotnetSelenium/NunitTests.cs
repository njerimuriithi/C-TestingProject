using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetSelenium.Pages;

namespace DotnetSelenium
{
    [TestFixture("Admin","password")]
    public class NunitTests
    {
        private readonly string userName;
        private readonly string password;
        private IWebDriver _driver; 
        public NunitTests(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }



        [SetUp] 
        public void SetUp() {

            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            _driver.Manage().Window.Maximize();  
        }

        [Test]
        [Category("smoke")]
        //to run this on terminal -> dotnet test --filter "category=smoke"
        public void TestwithPageObjectModel()
        {

            //Pom
            //Arrange
            LoginPage login = new LoginPage(_driver);
            //Act
            login.ClickLogin();
            login.Login(userName, password);
        }

        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }



    }
}
