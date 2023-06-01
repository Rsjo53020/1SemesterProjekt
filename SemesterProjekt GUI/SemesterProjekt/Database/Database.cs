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
using SemesterProjekt.Models;
using System.Drawing;
using System.Xml.Linq;
using System.Windows.Forms;

namespace SemesterProjekt.Database
{
    public class Database

    {
        public static string strconn = "Data Source=mssql4.unoeuro.com;Initial Catalog=cskafte_dk_db_skafte;User ID=cskafte_dk;Password=3tfep5Gc4wgAzxDH2rEy";

        /// <summary>
        /// Connection to datebase + open and close the connection
        /// </summary>
        /// <param name="sSQL"></param>
        public static void ConnectionToDatabase(string sSQL)
        {
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
            string sSQL = $"INSERT INTO Customer Values ('{customer.FirstName}', '{customer.SurName}', " +
                $"'{customer.PhoneNr}', '{customer.EMailAdress}', '{customer.Adress}', '{customer.City}', " +
                $"'{customer.PostalCode}', {customer.Discount}, '{customer.Birthday.ToString("yyyy-MM-dd")}', {customer.Age}, " +
                $"'{customer.VisionTest}', null);";

            ConnectionToDatabase(sSQL);

        }

        /// <summary>
        /// C(R)UD on Customer: takes two parameters to find a customer
        /// </summary>
        public static List<Models.Customer> SqlGetCustomer(string phoneNr = "", string mail = "")
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

            //call connection to database
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand command = new SqlCommand(sSQL, conn);

            conn.Open(); //Open connection to Database
            SqlDataReader reader = command.ExecuteReader();
            List<Models.Customer> customerlist = new List<Models.Customer>();

            while (reader.Read())
            {
                Customer customer = new Customer(
                    (int)reader["CustomerID"],
                    reader["FirstName"].ToString(),
                    reader["SurName"].ToString(),
                    reader["PhoneNr"].ToString(),
                    reader["EMailAdress"].ToString(),
                    reader["Adress"].ToString(),
                    reader["City"].ToString(),
                    reader["PostalCode"].ToString(),
                    (Decimal)reader["Discount"],
                    (DateTime)reader["Birthday"],
                    (int)reader["Age"],
                    reader["VisionTest"].ToString()
                    );

                customerlist.Add(customer);
            }
            reader.Close();
            conn.Close(); //Close connection to Database

            return customerlist;
        }

        public static Models.Customer SqlFindCustomerFromCustomerID(int customerID)
        {
            string sSQL = $"SELECT * FROM Customer WHERE CustomerID = {customerID};";

            //call connection to database
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand command = new SqlCommand(sSQL, conn);

            conn.Open(); //Open connection to Database
            SqlDataReader reader = command.ExecuteReader();

            Models.Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer(
                   (int)reader["CustomerID"],
                   reader["FirstName"].ToString(),
                   reader["SurName"].ToString(),
                   reader["PhoneNr"].ToString(),
                   reader["EMailAdress"].ToString(),
                   reader["Adress"].ToString(),
                   reader["City"].ToString(),
                   reader["PostalCode"].ToString(),
                   (Decimal)reader["Discount"],
                   (DateTime)reader["Birthday"],
                   (int)reader["Age"],
                   reader["VisionTest"].ToString()
                   );



            }
            reader.Close();
            conn.Close(); //Close connection to Database

            return customer;
        }
        /// <summary>
        /// CRU(D) on Customer: Delete a customer
        /// </summary>
        /// <param name="customer"></param>
        public static void SqlDeleteCustomer(Models.Customer customer)
        {

            string sSQL = $"DELETE FROM Customer WHERE CustomerID = {customer.CustomerID};";

            ConnectionToDatabase(sSQL);


        }
        /// <summary>
        ///  CR(U)D on Customer: uppdate a customer  
        /// </summary>
        /// <param name="customer"></param>
        public static void SqlUpdateCustomer(Models.Customer customer)
        {
            string sSQL = $"UPDATE Customer SET FirstName = '{customer.FirstName}', SurName = '{customer.SurName}', " +
                $" PhoneNr = '{customer.PhoneNr}', EMailAdress = '{customer.EMailAdress}', Adress = '{customer.Adress}', City = '{customer.City}', " +
                $"PostalCode = '{customer.PostalCode}', Discount = {customer.Discount}, Birthday = '{customer.Birthday.ToString("yyyy-MM-dd")}', Age = {customer.Age}, " +
                $" VisionTest = '{customer.VisionTest}' WHERE CustomerID = {customer.CustomerID};";

            ConnectionToDatabase(sSQL);



        }
        /// <summary>
        ///(C)RUD on Order - not important in version 1
        /// </summary>
        /// <param name="order"></param>
        public static void SqlCreateOrder()
        {

        }
        /// <summary>
        /// C(R)UD on Order: Find a order by date
        /// </summary>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns></returns>
        public static List<Models.Order> SqlGetOrder(DateTime dateStart, DateTime dateEnd)
        {
            string sSQL = $"SELECT * FROM Orders WHERE OrderDate between '{dateStart.ToString("yyyy-MM-dd")}' AND" +
                $" '{dateEnd.ToString("yyyy-MM-dd")}';";


            List<Models.Order> OrderList = new List<Models.Order>();

            //call connection to database
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand command = new SqlCommand(sSQL, conn);

            conn.Open(); //Open connection to Database
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Order order = new Order(
                    (int)reader["OrderID"],
                    (DateTime)reader["OrderDate"],
                    reader["OrderStatus"].ToString(),
                    (Decimal)reader["TotalPrice"],
                    (int)reader["VAT"],
                    (int)reader["CustomerID"],
                    (int)reader["LineID"]
                    );

                OrderList.Add(order);


            }
            reader.Close();
            conn.Close(); //Close connection to Database

            return OrderList;

        }
        /// <summary>
        /// CRU(D) on Order - Delete a product is not important in version 1
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        public static void SqlDeleteOrder()
        {

        }
        /// <summary>
        /// CR(U)D on Order - not important in version 1
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static void SqlUpdateOrder()
        {

        }
        /// <summary>
        /// (C)RUD on Product: Create a produckt 
        /// </summary>
        /// <param name="product"></param>
        public static void SqlCreateProduct(Models.Frame product)
        {
            string sSQL = $"INSERT INTO Product Values ({product.SalesPrice}," +
                $" '{product.NameProduct}', '{product.Description}', '{product.Kategory}'," +
                $" {product.PurchasePrice}, {product.VATSup}, '{product.Gender}', {product.Age}," +
                $" {product.Length}, {product.Width}, '{product.Kind}', '{product.Style}'," +
                $" '{product.Color}', '{product.UsedFor}');";



            ConnectionToDatabase(sSQL);
        }
        /// <summary>
        /// C(R)UD on Product: takes two parameters to find a product
        /// </summary>
        public static List<Models.Product> SqlGetProduct(string getNameProdukt = "", string getKategory = "")
        {

            string sSQL = "";
            if (getNameProdukt != "")
            {
                sSQL = $"SELECT * FROM Product WHERE NameProduct = '{getNameProdukt}';";
            }
            else if (getKategory != "")
            {
                sSQL = $"SELECT * FROM Product WHERE Kategory = '{getKategory}';";

            }

            //call connection to database
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand command = new SqlCommand(sSQL, conn);

            conn.Open(); //Open connection to Database
            SqlDataReader reader = command.ExecuteReader();
            List<Models.Product> ProductList = new List<Models.Product>();

            while (reader.Read())
            {
                Frame frame = new Frame(
                    (Decimal)reader["SalesPrice"],
                    reader["NameProduct"].ToString(),
                    reader["Discription"].ToString(),
                    reader["Kategory"].ToString(),
                    (Decimal)reader["PurchasePrice"],
                    (int)reader["VATSup"],
                    (int)reader["EAN"],
                    reader["Gender"].ToString(),
                    (int)reader["Age"],
                    (Decimal)reader["Lenght"],
                    (Decimal)reader["Width"],
                    reader["Kind"].ToString(),
                    reader["UsedFor"].ToString(),
                    reader["Style"].ToString(),
                    reader["Color"].ToString()
                    );

                ProductList.Add(frame);


            }
            reader.Close();
            conn.Close(); //Close connection to Database

            return ProductList;

        }
        public static Models.Frame SqlGetProductFromEAN(int EAN)
        {

            string sSQL = $"SELECT * FROM Product WHERE EAN = {EAN};";

            //call connection to database
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand command = new SqlCommand(sSQL, conn);

            conn.Open(); //Open connection to Database
            SqlDataReader reader = command.ExecuteReader();

            Models.Frame product = null;
            while (reader.Read())
            {
                product = new Frame(
                    (Decimal)reader["SalesPrice"],
                    reader["NameProduct"].ToString(),
                    reader["Discription"].ToString(),
                    reader["Kategory"].ToString(),
                    (Decimal)reader["PurchasePrice"],
                    (int)reader["VATSup"],
                    (int)reader["EAN"],
                    reader["Gender"].ToString(),
                    (int)reader["Age"],
                    (Decimal)reader["Lenght"],
                    (Decimal)reader["Width"],
                    reader["Kind"].ToString(),
                    reader["UsedFor"].ToString(),
                    reader["Style"].ToString(),
                    reader["Color"].ToString()
                    );



            }
            reader.Close();
            conn.Close(); //Close connection to Database

            return product;




        }
        public static List<Models.Product> SqlGetAllProductFromDatabase()
        {
            string sSQL = $"SELECT * FROM Product";

            //call connection to database
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand command = new SqlCommand(sSQL, conn);

            conn.Open(); //Open connection to Database
            SqlDataReader reader = command.ExecuteReader();
            List<Models.Product> ProductList = new List<Models.Product>();

            while (reader.Read())
            {
                Frame frame = new Frame(
                    (Decimal)reader["SalesPrice"],
                    reader["NameProduct"].ToString(),
                    reader["Discription"].ToString(),
                    reader["Kategory"].ToString(),
                    (Decimal)reader["PurchasePrice"],
                    (int)reader["VATSup"],
                    (int)reader["EAN"],
                    reader["Gender"].ToString(),
                    (int)reader["Age"],
                    (Decimal)reader["Lenght"],
                    (Decimal)reader["Width"],
                    reader["Kind"].ToString(),
                    reader["UsedFor"].ToString(),
                    reader["Style"].ToString(),
                    reader["Color"].ToString()
                    );

                ProductList.Add(frame);


            }
            reader.Close();
            conn.Close(); //Close connection to Database

            return ProductList;

        }
        /// <summary>
        /// CRU(D) on Product: Delete a Product
        /// </summary>
        /// <param name="product"></param>
        public static void SqlDeleteProduct(Models.Frame product)
        {

            string sSQL = $"DELETE * FROM Product WHERE EAN = {product.EAN};";

            ConnectionToDatabase(sSQL);

        }

        /// <summary>
        /// CR(U)D on Product: Update a Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static void SqlUpdateProduct(Models.Frame product)
        {
            string sSQL = sSQL = $"UPDATE Product SET SalesPrice = ({product.SalesPrice}," +
                $" NameProduct = {product.NameProduct}, Discription = {product.Description}," +
                $" Kategory = {product.Kategory}, PurchasePrice = {product.PurchasePrice}," +
                $" VATSup = {product.VATSup}, EAN = {product.EAN}, Gender = {product.Gender}," +
                $" Gender = {product.Age}, Length = {product.Length}, Width = {product.Width}," +
                $" Kind = {product.Kind}, UstedFor = {product.UsedFor}, Style = {product.Style}," +
                $" Color = {product.Color}, WHERE EAN = {product.EAN}";

            ConnectionToDatabase(sSQL);

        }
    }


}
