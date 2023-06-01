using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class IntelligentRådgivning
    {
        List<Models.Product> products; 

        public static List<Models.Product> FilterSearchResult(string Gender, string Age, string Length, string Width, string Kind,
        string UsedFor, string Style, string Color)
        {
             
            List<Models.Product> returnProduct = new List<Models.Product>( Database.Database.SqlGetAllProductAI(Gender, Age, Length, Width, Kind, UsedFor, Style, Color));

            return returnProduct;
        }
        public List<Models.Product> ReturnProducts()
        {

            return products;
        }
    }


}
