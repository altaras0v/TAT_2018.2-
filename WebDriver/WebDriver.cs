using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverTask
{
    class WebDriver
    {
        public void WebDrive()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            var elementEmail = driver.FindElement(By.Id("email"));
            var elementPassword = driver.FindElement(By.Id("pass"));
            var loginButton = driver.FindElement(By.Id("loginbutton"));


            elementEmail.SendKeys("altaras0b@gmail.com");
            elementPassword.SendKeys("idNM7x01");
            loginButton.Click();

            driver.Navigate().GoToUrl("https://www.facebook.com/messages/");

            var unreadMessages = driver.FindElementsByClassName("_1ht5 _2il3 _5l-3 _3itx");

        }
    }
}
