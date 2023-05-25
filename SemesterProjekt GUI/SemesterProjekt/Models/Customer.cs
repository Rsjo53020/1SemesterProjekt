using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public class Customer
    {
        private int CustomerID { get; set; }
        private string FirstName { get; set; }
        private string SurName { get; set; }
        private string PhoneNr { get; set; }
        private string Mail { get; set; }
        private string Address { get; set; }
        private string City { get; set; }
        private string PostalCode { get; set; }
        private decimal Discount { get; set; }
        private DateTime Birthday { get; set; }
        private int Age { get; set; }
        private string VisionTest { get; set; }
    }


    public static Customer FindCostumer(int PhoneNr, string Mail)
    {
        return Customer;
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
