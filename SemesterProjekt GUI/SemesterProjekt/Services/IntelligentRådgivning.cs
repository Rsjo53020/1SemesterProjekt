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
        /// <summary>
        /// returns a list of products vith values equal to input
        /// </summary>
        /// <param name="Gender"></param>
        /// <param name="Age"></param>
        /// <param name="Length"></param>
        /// <param name="Width"></param>
        /// <param name="Kind"></param>
        /// <param name="UsedFor"></param>
        /// <param name="Style"></param>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static List<Models.Product> FilterSearchResult(string Gender, string Age, string Length, string Width, string Kind,
        string UsedFor, string Style, string Color)
        {
             
            List<Models.Product> returnProduct = new List<Models.Product>( Database.Database.SqlGetAllProductAI(Gender, Age, Length, Width, Kind, UsedFor, Style, Color));

            return returnProduct;
        }
      
    }


}
