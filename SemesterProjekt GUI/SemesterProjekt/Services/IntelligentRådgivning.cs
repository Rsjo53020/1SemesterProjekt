using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class IntelligentRådgivning
    {
        List<Models.Product> products = new List<Models.Product>();

        public void FilterSearchResult(string Gender, string Age, string Length, string Width, string Kind,
        string UsedFor, string Style, string Color)
        {
             
            products = Database.Database.SqlGetAllProductAI(Gender, Age, Length, Width, Kind, UsedFor, Style, Color);

        }
    }


}
