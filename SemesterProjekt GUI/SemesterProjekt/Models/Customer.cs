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


        public Customer(int customerID, string firstName, string lastName, string phoneNr, string mail,
            string adress, string city, string postalCode, decimal discount, DateTime birthday,
            int age, string visiontest)
        {
            this.CustomerID = customerID;
            this.FirstName = firstName;
            this.Address = lastName;

        }


        public static string ConnectSQL()
        {
            string strconn = "Data Source=mssql4.unoeuro.com;Initial Catalog=cskafte_dk_db_skafte;User ID=cskafte_dk;Password=3tfep5Gc4wgAzxDH2rEy";

            return strconn;
        }



        public static Customer FindCostumer(int PhoneNr, string Mail)
        {
            return Customer;
        }
        /// <summary>
        /// (C)RUD; FirstName (string), SurName(string), PhoneNr(string), EMailAdress(string), Adress(string),
        /// City(string), PostalCode(string),
        /// Discount(Desimal), Birthday(DateTime(YYYY-MM-DD)), Age(int), VisionTest(string)
        /// </summary>
        public static void RegisterCustomer()
        {

            string SQLstring = "insert into Customer(FirstName, SurName, PhoneNr, EMailAdress, Adress," +
                " City, PostalCode, Discount, Birthday, Age, VisionTest) " +
                "Values('jens', 'jensen', '87654321', 'test.jensen@test.test', 'jensenvej 22', 'københavn'," +
                " '1526', 0.10, '1986-05-12', 37, '+2.5');";
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
