using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.IO;
using OpenQA.Selenium;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using OpenQA.Selenium.Support.UI;

namespace TT
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                using (var driver = new ChromeDriver())
                {
                    TimeSpan timeout = new TimeSpan(00, 00, 20);

                    driver.Navigate().GoToUrl("https://i.avs.io/jgkvl");
                    driver.Manage().Window.Maximize();

               
                    var name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("button__content")));
                    name.Click();
                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("form__random")));
                    name.Click();
                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("button__content")));
                    name.Click();
                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class=\"shares__buttons\"]/button")));
                    name.Click();
                    driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("email")));
                    name.SendKeys("merikanov94@mail.ru");
                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("pass")));
                    name.SendKeys("ruslan0000");
                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Id("install_allow")));
                    name.Click();
                    driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Id("share_mail")));
                    name.Click();
                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Id("share_friend_inp")));
                    name.Click();
                    //name.SendKeys("Руcлан Мериканов");
                    Task.Delay(500).Wait();
                    name.SendKeys(Keys.Enter);

                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Id("post_button")));
                    name.Click();
                    
                    Task.Delay(4000).Wait();
                    driver.Quit();
                }
            }
        }
    }
}
