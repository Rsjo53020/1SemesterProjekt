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
