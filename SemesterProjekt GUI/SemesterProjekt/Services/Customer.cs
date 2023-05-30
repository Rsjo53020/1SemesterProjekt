using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class Customer
    {

        public static List<Models.Customer> FindCostumer(string PhoneNr = "", string Mail = "")
        {

            List<Models.Customer> customers = Database.Database.SqlGetCustomer(PhoneNr, Mail);

            return customers;
        }

        public void RegisterCustomer(string FirstName, string SurName, string PhoneNr, string Mail, string Address, string City, string PostalCode, decimal Discount, DateTime Birthday, int Age, string VisionTest)
        {
            Models.Customer customer = new Models.Customer(FirstName, SurName, PhoneNr, Mail, Address, City, PostalCode, Discount, Birthday, Age, VisionTest);
            Database.Database.SqlCreateCustumer(customer);
        }

        public void DeleteCustomer(int CustomerID)
        {
            Database.Database.SqlDeleteCustomer(CustomerID);
        }

        public void UpdateCustomer(int CustomerID, string FirstName, string SurName, string PhoneNr, string Mail, string Address, string City, string PostalCode, decimal Discount, DateTime Birthday, int Age, string VisionTest)
        {
            Models.Customer customer = new Models.Customer(CustomerID, FirstName, SurName, PhoneNr, Mail, Address, City, PostalCode, Discount, Birthday, Age, VisionTest);
            List<Models.Customer> UpdatedCustomer = Database.Database.SqlUpdateCustomer(customer);
        }
    }
}

