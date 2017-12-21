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
            for (int i = 0; i < 1500; i++)
            {
                Class1 class1 = new Class1();
                class1.Action();

                Class2 class2 = new Class2();
                class2.Action();

                Class3 class3 = new Class3();
                class3.Action();
            }
        }
    }
}
