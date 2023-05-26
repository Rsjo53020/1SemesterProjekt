using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public class Database
    {
        public static string ConnectSQL()
        {
            string strconn = "Data Source=mssql4.unoeuro.com;Initial Catalog=cskafte_dk_db_skafte;User ID=cskafte_dk;Password=3tfep5Gc4wgAzxDH2rEy";

            return strconn;
        }
        /// <summary>
        /// (C)RUD; FirstName (string), SurName(string), PhoneNr(string), EMailAdress(string), Adress(string),
        /// City(string), PostalCode(string),
        /// Discount(Desimal), Birthday(DateTime(YYYY-MM-DD)), Age(int), VisionTest(string)
        /// </summary>
        public static void SqlCreateCustumer(Customer customer)
        {
            string SQLstring = "insert into Customer(FirstName, SurName, PhoneNr, EMailAdress, Adress," +
                " City, PostalCode, Discount, Birthday, Age, VisionTest) " +
                "Values('jens', 'jensen', '87654321', 'test.jensen@test.test', 'jensenvej 22', 'københavn'," +
                " '1526', 0.10, '1986-05-12', 37, '+2.5');";

        }

        public static Customer SqlGetCustomer(string phoneNr, string mail)
        {
            return Customer;
        }

        public static void SqlDeleteCustomer(string phoneNr, string mail)
        {

        }

        public static Customer SqlUpdateCustomer(Customer customer)
        {
            return Customer;
        }
        public static void SqlCreateOrder(Order order)
        {

        }

        public static Order SqlGetOrder(Customer.PhoneNr, Customer.Mail)
        {
            return Order;
        }

        public static void SqlDeleteOrder(Customer.PhoneNr, Customer.Mail)
        {

        }

        public static Order SqlUpdateOrder(Order order)
        {
            return Order;
        }

        public static void SqlCreateProduct(Product product)
        {
        }

        public static Product SqlGetProduct(Product name = "", Product Category = "")
        {
            return Product;
        }

        public static void SqlDeleteProduct(Product name = "", Product Category = "")
        {

        }

        public static Product SqlUpdateProduct(Product product)
        {
            return Product;
        }
    }
    

}
