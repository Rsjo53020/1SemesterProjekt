using SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class Produkt
    {
        /// <summary>
        /// Method returns a List of products using a NameProduct and Kategory 
        /// Using SQL satement from Database
        /// </summary>
        public static List<Models.Product> GetProduct(string getNameProduct = "", string getKategory = "")
        {
            List<Models.Product> ProductList = Database.Database.SqlGetProduct(getNameProduct, getKategory);
            return ProductList;
        }

        /// <summary>
        /// Method creates a product using Models.Frame
        /// using SQL statements from Database
        /// </summary>
        public static void CreateProduct(Models.Frame product)
        {
            Database.Database.SqlCreateProduct(product);

        }

        /// <summary>
        /// Method updates a product using a complete product 
        /// using SQL statements from Databse
        /// </summary>
        public static void UpdateProduct(Models.Frame product)
        {
            Database.Database.SqlUpdateProduct(product);
        }

        /// <summary>
        /// Method deletes products using SQL satements from Database
        /// </summary>
        public static void DeleteProduct(Models.Frame product)
        {
            Database.Database.SqlDeleteProduct(product);
        }
    }
}
