using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class Orders
    {
        public static List<Models.Order> FindOrder(DateTime StartDate, DateTime EndDate)
        {
            List<Models.Order> orderList = Database.Database.SqlGetOrder(StartDate, EndDate); 

            return orderList;
        }

        public static void DeleteOrder(Models.Order order)
        {
         
        }
    }
}
