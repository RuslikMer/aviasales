﻿using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;

namespace TT
{
    public class Class1
    {
        TimeSpan timeout = new TimeSpan(00, 00, 20);

        public void Action()
        {
            
                using (var driver = new ChromeDriver())
                {
                    driver.Navigate().GoToUrl("https://i.avs.io/jgkvl");
                    driver.Manage().Window.Maximize();

                    var name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("button__content")));
                    name.Click();
                    Task.Delay(1500).Wait();
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
                    Task.Delay(500).Wait();
                    name.SendKeys("Александр Шувалов");
                    Task.Delay(500).Wait();
                    name.SendKeys(Keys.Enter);

                    name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Id("post_button")));
                    name.Click();

                    Task.Delay(3000).Wait();
                    driver.Quit();
                }
        }
    }
}
