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

            //vk2 face = new vk2(driver);
            //face.Action();

            ticket user = new ticket(driver);
            user.Action();

            //OK oK = new OK(driver);
            //oK.Action();

            Assert.AreEqual(pruf, actual);
        }
    }
}
