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
        public static List<Models.Product> GetProduct(string getNameProduct = "", string getKategory = "")
        {
            List<Models.Product> ProductList = Database.Database.SqlGetProduct(getNameProduct, getKategory);
            return ProductList;
        }
        public static void CreateProduct()
        {

        }
        public static void UpdateProduct()
        {

        }
        public static void DeleteProduct()
        {

        }
    }
}
