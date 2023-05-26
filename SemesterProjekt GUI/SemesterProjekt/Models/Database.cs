using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;


namespace SemesterProjekt.Models
{
    public class Database

    {

        public static string strconn = "Data Source=mssql4.unoeuro.com;Initial Catalog=cskafte_dk_db_skafte;User ID=cskafte_dk;Password=3tfep5Gc4wgAzxDH2rEy";

        /// <summary>
        /// (C)RUD; FirstName (string), SurName(string), PhoneNr(string), EMailAdress(string), Adress(string),
        /// City(string), PostalCode(string),
        /// Discount(Desimal), Birthday(DateTime(YYYY-MM-DD)), Age(int), VisionTest(string)
        /// </summary>
        public static void SqlCreateCustumer(Models.Customer customer)       
        {
            //kalder forbindelsen på simly.com
            SqlConnection conn = new SqlConnection(strconn);

           
            string SQL = $"INSERT INTO Customer Values ({customer.})
        }


        public static Customer SqlGetCustomer(string phoneNr = "", string mail = "")
        {
            if (phoneNr != "")
            {
                string SQLstring = $"SELECT * FROM Customer WHERE PhoneNr = '{phoneNr}';";
            }
            else if (mail != "")
            {
                string SQLstring = $"SELECT * FROM Customer WHERE EmailAdress = '{mail}';";
            }
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
