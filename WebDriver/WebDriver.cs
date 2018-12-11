using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace WebDriverTask
{
    class WebDriver
    {
        public void WebDrive()
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://vk.com/login");
            var elementEmail = driver.FindElement(By.Id("email"));
            var elementPassword = driver.FindElement(By.Id("pass"));
            var loginButton = driver.FindElement(By.Id("login_button"));


            elementEmail.SendKeys("375296655456");
            elementPassword.SendKeys("SaveMYSoul1998");
            loginButton.Click();

           driver.Navigate().GoToUrl("https://vk.com/im");

            var unreadMessage = driver.FindElement(By.Id("ui_rmenu_unread"));
            unreadMessage.Click();
            var messagesList = driver.FindElementsByClassName("nim-dialog--text-preview");
            var myUnreadMessage = new System.Text.StringBuilder();

        
            foreach (var i in messagesList)
            {
              
                Console.WriteLine(myUnreadMessage.Append(i.Text+'\n'));
            }
        }
    }
}
