using SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

        public static void GetStockStatus()
        {
            List<Models.Product> stockList = new List<Models.Product>();

            stockList = Database.Database.SqlGetAllProductFromDatabase();
            // Sort orders by date
            stockList = stockList.OrderBy(Frame => Frame.EAN).ToList();

            Console.WriteLine("Lager status i sorteret rækkefølge");
            
           
            foreach (Frame frames in stockList)
            {
                Console.WriteLine($"{frames.EAN} {frames.NameProduct} {frames.PurchasePrice} {frames.SalesPrice} ");
            }

            // Write to text file
            string filePath = "LagerStatus.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write("Lager status i sorteret rækkefølge");
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("EAN            Navn                     Indkøbspris          Salgspris");
                writer.WriteLine();

                foreach (Frame frames in stockList)
                {
                    writer.WriteLine($"{frames.EAN}              {frames.NameProduct}                     {frames.PurchasePrice}          {frames.SalesPrice}");
                }

                writer.WriteLine("-------------------------------------------------------------------------------");
                writer.WriteLine();
            }

            Console.WriteLine($"Udskriften er gemt i filen: {filePath}");
        }
        public static Models.Frame GetProductFromEAN (int ean)
        {
            Models.Frame product = Database.Database.SqlGetProductFromEAN(ean);
            return product;
        }




    }
}