using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanychKlientów
{
    public class Customer
    {
        public Customer( string CustomerName, string CustomerLastName, string CustomerAge ,string CustomerNationality, string CustomerPhone, string CustomerAddress)
        {
            
            this.Name = CustomerName;
            this.LastName = CustomerLastName;
            this.Age = CustomerAge;
            this.Nationality = CustomerNationality;
            this.Phone = CustomerPhone;
            this.Address = CustomerAddress;
        }

        
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}

