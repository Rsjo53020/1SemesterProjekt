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


        /// <summary>
        /// Constructor Class
        /// </summary>
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

        /// <summary>
        /// Constructor Database
        /// </summary>
        public Customer(string firstName, string surName, string phoneNr, string mail,
            string adress, string city, string postalCode, decimal discount, DateTime birthday,
            int age, string visiontest)
        {
            this.FirstName = FirstName;
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
    }
}
