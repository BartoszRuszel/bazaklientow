using System;
using BazaDanychKlientów;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BazaDanychKlientówTesty
{
    [TestClass()]
    public class Form1Tests
    {
        string customerName;
        string customerLastName;
        string customerNationality;
        string customerAge;
        string customerPhone;
        string customerAddress;
        Form1 form;

        [TestInitialize()]
        public void SomeVars()
        {
            form = new Form1();
        }

        [TestMethod()]
        public void CustomerEmptyField()
        {
            customerName = "Grzegorz";
            customerLastName = "Kowalski";
            customerNationality = "";
            customerAge = "15";
            customerPhone = "543";
            customerAddress = "Nieznana";

            bool validation = form.AddCustomer(customerName, customerLastName, customerNationality, customerAge, customerPhone, customerAddress);
            Assert.AreEqual(false, validation);
        }

        [TestMethod()]
        public void CustomerEmptyAllFields()
        {
            customerName = "Grzegorz";
            customerLastName = "Kowalski";
            customerNationality = "Poland";
            customerAge = "15";
            customerPhone = "543";
            customerAddress = "Nieznana";

            Assert.ThrowsException<NotImplementedException>(() => form.AddItem(customerName, customerLastName,
                customerNationality, customerAge, customerPhone, customerAddress));
        }
        [TestMethod()]
        public void CustomerWrongAge()
        {
            customerName = "Grzegorz";
            customerLastName = "Kowalski";
            customerNationality = "Poland";
            customerAge = "";
            customerPhone = "543";
            customerAddress = "Nieznana";

            bool  validation = form.AddCustomer(customerName, customerLastName, customerNationality, customerAge, customerPhone, customerAddress);
            Assert.AreEqual(false, validation);
        }

        [TestMethod()]
        public void CustomerEdit()
        {
            string windowEditing = "Window to edit";
            string validation = form.EditCustomer(windowEditing);

            Assert.AreEqual("Edytujesz klienta", validation);
        }
    }
}
