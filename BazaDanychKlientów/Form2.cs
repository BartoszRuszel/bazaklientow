using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanychKlientów
{
    public partial class Form2 : Form
    {
        private Customer selectedCustomer;
        public Form2(Customer customer)
        {
            selectedCustomer = customer;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameLabel.Text = selectedCustomer.Name;
            LastName.Text = selectedCustomer.LastName;
            Nationality.Text = selectedCustomer.Nationality;
            Age.Text = selectedCustomer.Age;
            PhoneNumber.Text = selectedCustomer.Phone;
            Address.Text = selectedCustomer.Address;
        }

        private void customerName_Click(object sender, EventArgs e)
        {

        }

        private void customerAge_Click(object sender, EventArgs e)
        {

        }
    }
}
