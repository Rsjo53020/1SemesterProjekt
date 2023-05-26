using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SemesterProjekt.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string PhoneNr { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public decimal Discount { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public string VisionTest { get; set; }


        public Customer(int customerID, string firstName, string surName, string phoneNr, string mail,
            string adress, string city, string postalCode, decimal discount, DateTime birthday,
            int age, string visiontest)
        {
            this.CustomerID = customerID;
            this.FirstName = firstName;
            this.SurName = surName;
            this.PhoneNr = phoneNr;
            this.Mail = mail;
            this.Address = adress;
            this.City = city;
            this.PostalCode = postalCode;
            this.Discount = discount;
            this.Birthday = birthday;
            this.Age = age;
            this.VisionTest = visiontest;

        }

        public Customer(string firstName, string surName, string phoneNr, string mail,
            string adress, string city, string postalCode, decimal discount, DateTime birthday,
            int age, string visiontest)
        {
            this.FirstName = firstName;
            this.SurName = surName;
            this.PhoneNr = phoneNr;
            this.Mail = mail;
            this.Address = adress;
            this.City = city;
            this.PostalCode = postalCode;
            this.Discount = discount;
            this.Birthday = birthday;
            this.Age = age;
            this.VisionTest = visiontest;
        }




        public static Customer FindCostumer(int PhoneNr, string Mail)
        {
            return Customer;
        }
        /// <summary>
        /// 
        /// </summary>
        public static void RegisterCustomer()
        {


        }
        /// <summary>
        /// 
        /// </summary>
        public static void DeleteCustomer()
        {

        }
        public static void UpdateCustomer()
        {

        }

    }


}
