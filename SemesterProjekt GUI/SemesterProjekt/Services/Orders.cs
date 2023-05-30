using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    internal class Orders
    {
        public static List<Models.Order> FindOrder(DateTime StartDate, DateTime EndDate)
        {
            List<Models.Order> orderslist = Database.Database.SqlGetCustomer(StartDate, EndDate);

            return orderslist;
        }

        public void DeleteOrder(int Order)
        {
            Database.Database.SqlDeleteOrder(Order);
        }
    }
}
