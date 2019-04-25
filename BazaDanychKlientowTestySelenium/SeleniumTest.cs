using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BazaDanychKlientów;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System.Threading;

namespace BazaDanychKlientowTestySelenium
{
    [TestClass]
    public class SeleniumTest
    {
        private readonly WiniumDriver driver;
        public SeleniumTest()
        {
            DesktopOptions options = new DesktopOptions();
            string path = System.IO.Path.GetDirectoryName(typeof(Form1).Assembly.Location);
            options.ApplicationPath = path + @"\BazaDanychKlientów.exe";
            driver = new WiniumDriver(@"C:\Users\Krystian\Documents\GitHub\bazaklientow", options);

        }
        [TestMethod]
        public void AddNewCustomer()
        {
            driver.FindElementByName("customerName").SendKeys("Jan");
            driver.FindElementByName("customerLastName").SendKeys("Nowak");
            driver.FindElementByName("customerAge").SendKeys("14");
            driver.FindElementByName("customerNationality").SendKeys("Niemcy");
            driver.FindElementByName("customerAddress").SendKeys("Berlin");
            driver.FindElementByName("customerPhone").SendKeys("233232323");
            driver.FindElementByName("addCustomer").Click();
            Equals(true, driver.FindElementByName("Jan Nowak"));
            Thread.Sleep(1000);
            driver.FindElementByName("Zamknij").Click();
        }
        [TestMethod]
        public void AddNewCustomerWithEmptyFields()
        {
            driver.FindElementByName("addCustomer").Click();
            Equals(true, driver.FindElementByName("Należy uzuepełnić wszystkie pola"));
            Thread.Sleep(1000);
            driver.FindElementByName("Zamknij").Click();
            driver.FindElementByName("Zamknij").Click();
        }
        [TestMethod]
        public void DisplayCustomer()
        {
            driver.FindElementByName("Bartosz Ruszel").Click();
            driver.FindElementByName("displayBtn").Click();
            Equals(true, driver.FindElementByName("Bartosz Ruszel"));
            Thread.Sleep(1000);
            driver.FindElementByName("Zamknij").Click();
            driver.FindElementByName("Zamknij").Click();
        }
        [TestMethod]
        public void DisplayCustomerWithoutSelect()
        {
            driver.FindElementByName("displayBtn").Click();
            Equals(true, driver.FindElementByName("Aby włączyć podgląd należy wybrać klienta"));
            Thread.Sleep(1000);
            driver.FindElementByName("Zamknij").Click();
            driver.FindElementByName("Zamknij").Click();
        }
        [TestMethod()]
        public void EditCustomer()
        {
            driver.FindElementByName("Dominik Raczkowski").Click();
            driver.FindElementByName("editBtn").Click();
            driver.FindElementByName("customerAge").SendKeys("55");
            driver.FindElementByName("saveBtn").Click();
            driver.FindElementByName("Dominik Raczkowski").Click();
            driver.FindElementByName("displayBtn").Click();
            Equals(true, driver.FindElementByName("55"));
            Thread.Sleep(1000);
            driver.FindElementByName("Zamknij").Click();
            driver.FindElementByName("Zamknij").Click();
        }
        [TestMethod()]
        public void EditCustomerrWithoutSelect()
        {
            driver.FindElementByName("editBtn").Click();
            Equals(true, driver.FindElementByName("Aby dokonać edycji musisz wybrać klienta z listy"));
            Thread.Sleep(1000);
            driver.FindElementByName("Zamknij").Click();
            driver.FindElementByName("Zamknij").Click();
        }
        [TestMethod()]
        public void EditCustomerWithCancel()
        {
            driver.FindElementByName("Dominik Raczkowski").Click();
            driver.FindElementByName("editBtn").Click();
            driver.FindElementByName("customerAge").SendKeys("35");
            driver.FindElementByName("cancelBtn").Click();
            driver.FindElementByName("Dominik Raczkowski").Click();
            driver.FindElementByName("displayBtn").Click();
            Equals(true, driver.FindElementByName("22"));
            Thread.Sleep(1000);
            driver.FindElementByName("Zamknij").Click();
            driver.FindElementByName("Zamknij").Click();
        }
        [TestMethod()]
        public void RemoveCustomer()
        {
            driver.FindElementByName("Krystian Kobus").Click();
            driver.FindElementByName("removeBtn").Click();
            Thread.Sleep(6000);
            driver.FindElementByName("Zamknij").Click();
        }
        [TestMethod()]
        public void RemoveCustomerrWithoutSelect()
        {
            driver.FindElementByName("removeBtn").Click();
            Equals(true, driver.FindElementByName("Aby usunąc klienta należy wybrać go z listy"));
            Thread.Sleep(1000);
            driver.FindElementByName("Zamknij").Click();
            driver.FindElementByName("Zamknij").Click();
        }
    }
}
