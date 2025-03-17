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
        [Test]
        public void EaWebsiteTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
           driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Name("UserName")).SendKeys("Admin");
            driver.FindElement(By.Name("Password")).SendKeys("password");
            driver.FindElement(By.ClassName("btn")).Submit();
          
        
        }
    }
}