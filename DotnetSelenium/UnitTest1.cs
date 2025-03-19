using DotnetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            webElement.SendKeys(Keys.Return);
            
        }
        //[Test]
        //public void EaWebsiteTest()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        //  SeleniumCustomeMethods.Click(driver, By.LinkText("Login"));
        //    driver.FindElement(By.Name("UserName")).SendKeys("Admin");
        //    driver.FindElement(By.Name("Password")).SendKeys("password");
        //    driver.FindElement(By.ClassName("btn")).Submit();            
        
        //}
        //[Test]
        //public void TestwithPageObjectModel()
        //{
          
        //    //Pom
        //    LoginPage login = new LoginPage(driver); 
        //   login.ClickLogin();
        //    login.Login("Admin","password");
        //}

        //[Test]
        //public void AdvancedControls()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("http://localhost:63342/Webtest/index.html?_ijt=iru3d8bbcn376v50cq1esj5k5l");
        //   SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("cars")));
        //    selectElement.SelectByText("Audi");
        //}
    }
}