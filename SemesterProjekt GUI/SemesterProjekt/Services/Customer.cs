using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class Customer
    {

        /// <summary>
        /// Method returns a list of customers from a SQL satement from Database.
        /// </summary>

        public static List<Models.Customer> FindCostumer(string PhoneNr = "", string Mail = "")
        {

            List<Models.Customer> customerList = Database.Database.SqlGetCustomer(PhoneNr, Mail);

            return customerList;
        }

        /// <summary>
        /// Method Creates a Customer, containing a full Customer from Models. 
        /// using SQL Statement from Database
        /// </summary>
        public static void RegisterCustomer(Models.Customer customer)
        {
            Database.Database.SqlCreateCustumer(customer);
        }

        /// <summary>
        /// Method Deletes a Customer, containing a full Customer from Models. 
        /// using SQL Statement from Database
        /// </summary>
        public static void DeleteCustomer(Models.Customer customer)
        {
            Database.Database.SqlDeleteCustomer(customer);
        }

        /// <summary>
        /// Method Updates a Customer, containing a full Customer from Models. 
        /// using SQL Statement from Database
        /// </summary>
        public static void UpdateCustomer(Models.Customer customer)
        {
            Database.Database.SqlUpdateCustomer(customer);
        }

        /// <summary>
        /// Method Finds a customer from CustomerID using a SQL satement from Database and returns the Sustomer
        /// </summary>
        public static Models.Customer FindCustomerFromCustomerID (int CustomerID) 
        {
            Models.Customer customer = Database.Database.SqlFindCustomerFromCustomerID(CustomerID);

                return customer;
        }


    }
}

