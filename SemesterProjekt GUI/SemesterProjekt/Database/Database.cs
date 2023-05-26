using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net.NetworkInformation;


namespace SemesterProjekt.Models
{
    public class Database

    {
        /// <summary>
        /// Connection to datebase + open and close the connection
        /// </summary>
        /// <param name="sSQL"></param>
        public static void ConnectionToDatabase(string sSQL)
        {
            string strconn = "Data Source=mssql4.unoeuro.com;Initial Catalog=cskafte_dk_db_skafte;User ID=cskafte_dk;Password=3tfep5Gc4wgAzxDH2rEy";

            //call connection to database
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand command = new SqlCommand(sSQL, conn);

            OpenAndCloseTheConnectionToDatabase(conn, command);

        }

        public static void OpenAndCloseTheConnectionToDatabase(SqlConnection conn, SqlCommand command)
        {
            conn.Open(); //Open connection to Database
            command.ExecuteNonQuery();
            conn.Close(); //Close connection to Database
        }


        /// <summary>
        /// (C)RUD on Customer: FirstName (string), SurName(string), PhoneNr(string), EMailAdress(string), Adress(string),
        /// City(string), PostalCode(string),
        /// Discount(Desimal), Birthday(DateTime(YYYY-MM-DD)), Age(int), VisionTest(string)
        /// </summary>
        public static void SqlCreateCustumer(Models.Customer customer)
        {
            string sSQL = $"INSERT INTO Customer Values ({customer.FirstName}, {customer.SurName}, " +
                $"{customer.PhoneNr}, {customer.Mail}, {customer.Address}, {customer.City}, " +
                $"{customer.PostalCode}, {customer.Discount}, {customer.Birthday}, {customer.Age}, {customer.VisionTest});";

            ConnectionToDatabase(sSQL);





        }

        /// <summary>
        /// C(R)UD on Customer: takes two parameters to find a customer
        /// </summary>
        public static string SqlGetCustomer(string phoneNr = "", string mail = "")
        {

            string sSQL = "";
            if (phoneNr != "")
            {
                sSQL = $"SELECT * FROM Customer WHERE PhoneNr = '{phoneNr}';";
            }
            else if (mail != "")
            {
                sSQL = $"SELECT * FROM Customer WHERE EmailAdress = '{mail}';";

            }

            ConnectionToDatabase(sSQL);

            return sSQL;
        }

        public static void SqlDeleteCustomer(Customer customer)
        {

            string sSQL = $"DELETE * FROM Customer WHERE CustomerID = '{customer.CustomerID}';";

            ConnectionToDatabase(sSQL);


        }

        public static void SqlUpdateCustomer(Customer customer)
        {
            string sSQL = sSQL = $"UPDATE Customer SET FirstName = ({customer.FirstName}, SurName = {customer.SurName}, " +
                $"PhoneNr = {customer.PhoneNr},EMailAdress = {customer.Mail}, Adress = {customer.Address}, City = {customer.City}, " +
                $"PostalCode = {customer.PostalCode}, Discount = {customer.Discount}, Birthday = {customer.Birthday}, Age = {customer.Age}, VisionTest {customer.VisionTest}) WHERE PhoneNr = {customer.CustomerID}"

            ConnectionToDatabase(sSQL);


           
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
