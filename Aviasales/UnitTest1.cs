using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;

namespace Aviasales
{
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            //driver = new ChromeDriver();
        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            //driver.Quit();
        }

        [Test]
        public void Reg()
        {
            var actual = "Выйти";
            var pruf = "Выйти";

            //facebook face = new facebook(driver);
            //face.Action();

            ticket user = new ticket(driver);
            user.Action();

            Assert.AreEqual(pruf, actual);
        }
    }
}
