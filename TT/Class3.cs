using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;

namespace TT
{
    public class Class3
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
                Task.Delay(900).Wait();
                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("form__random")));
                name.Click();
                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("button__content")));
                name.Click();
                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class=\"shares__buttons\"]/button[4]")));
                name.Click();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                Task.Delay(900).Wait();

                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("fr.email")));
                name.SendKeys("merikanov94@mail.ru");
                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("fr.password")));
                name.SendKeys("rorshach1994");
                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class=\"form-actions\"]/input")));
                name.Click();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

                Task.Delay(300).Wait();

                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("button-pro")));
                name.Click();

                Task.Delay(3000).Wait();
                driver.Quit();

            }

        }
    }
}
