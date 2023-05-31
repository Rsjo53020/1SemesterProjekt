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
        public static void CreateProduct(Models.Frame product)
        {
            Database.Database.SqlCreateProduct(product);

        }
        public static void UpdateProduct(Models.Frame product)
        {
            Database.Database.SqlUpdateProduct(product);
        }
        public static void DeleteProduct(Models.Frame product)
        {
            Database.Database.SqlDeleteProduct(product);
        }

        public static void GetAllProductFromDataBase()
        {
            
        }
    }
}
