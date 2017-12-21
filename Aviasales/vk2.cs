using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;

namespace Aviasales
{
    public class vk2
    {
        public IWebDriver driver { set; get; }
        TimeSpan timeout = new TimeSpan(00, 00, 20);

        public vk2(IWebDriver driver)
        {
            this.driver = driver;
        }

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
                name.SendKeys("79023557033");
                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("pass")));
                name.SendKeys("qwertyqwe");
                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Id("install_allow")));
                name.Click();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Id("share_mail")));
                name.Click();
                name = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Id("share_friend_inp")));
                name.Click();
                Task.Delay(500).Wait();
                name.SendKeys("Елена Малькова");
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
