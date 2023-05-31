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

        public static void GetAllProductFromDataBase(List<Models.Frame> stockList)
        {
            // Sortér ordrer efter dato
            stockList = stockList.OrderBy(Frame => Frame.EAN).ToList();

            Console.WriteLine("Alle produkter fra databasen i sorteret rækkefølge");
            
            foreach (Frame frames in stockList)
            {

                Console.WriteLine($"{frames.EAN}   {frames.Kind}  ");
            }

            // Skriv til tekstfil
            string filePath = "LagerStatus.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write("Alle produkter fra databasen i sorteret rækkefølge");
                writer.WriteLine();
                writer.WriteLine("Kundenummer           Navn                     Dato        Køb");
                writer.WriteLine();

                foreach (Frame frames in stockList)
                {
                    writer.WriteLine($"{frames.EAN}   {frames.Kind}  ");
                }

                writer.WriteLine("-------------------------------------------------------------------------------");
                writer.WriteLine();
            }

            Console.WriteLine($"Udskriften er gemt i filen: {filePath}");
        }




    }
}
    }
}
