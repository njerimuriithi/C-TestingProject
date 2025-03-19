using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSelenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver) {
            this.driver = driver;
        }
        IWebElement loginlink => driver.FindElement(By.Id("loginLink"));
        IWebElement txtUsername => driver.FindElement(By.Id("UserName"));
        IWebElement txtPassord => driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driver.FindElement(By.ClassName("btn"));

        public void ClickLogin()
        {
            loginlink.Click();  
        }
        public void Login(string username, string password)
        {
            txtUsername.SendKeys(username);
            txtPassord.SendKeys(password);  
            btnLogin.Click();
        }
    }
}
