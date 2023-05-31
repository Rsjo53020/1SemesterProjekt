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

            List<Models.Customer> customerList = Database.Database.SqlGetCustomer(PhoneNr, Mail);

            return customerList;
        }

        public static void RegisterCustomer(Models.Customer customer)
        {
            Database.Database.SqlCreateCustumer(customer);
        }

        public void DeleteCustomer(Models.Customer customer)
        {
            Database.Database.SqlDeleteCustomer(customer);
        }

        public void UpdateCustomer(Models.Customer customer)
        {
            Database.Database.SqlUpdateCustomer(customer);
        }
        public Models.Customer FindCustomerFromCustomerID (int CustomerID) 
        {
            Models.Customer customer = Database.Database.SqlFindCustomerFromCustomerID(CustomerID);

                return customer;
        }
    }
}

