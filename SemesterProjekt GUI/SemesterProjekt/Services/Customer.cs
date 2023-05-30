using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class Customer
    {
        
        public static Customer FindCostumer(string PhoneNr = "", string Mail = "")
        {
            Database.Database.SqlGetCustomer(PhoneNr, Mail);
            Customer customer = new Customer();
            customer = Database.Database.SqlGetCustomer(PhoneNr, Mail);
            return customer;
        }

        public static void RegisterCustomer()
        {

        }

        public static void DeleteCustomer()
        {

        }
        public static void UpdateCustomer()
        {

        }
    }
}
