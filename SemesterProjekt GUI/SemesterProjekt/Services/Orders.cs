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
            List<Models.Order> orders = new List<Models.Order>();
            List<Models.Order> customers = Database.Database.SqlGetCustomer(DateTime StartDate, DateTime EndDate);

            return orders;
        }

        public void DeleteOrder(int OrderID)
        {
            Database.Database.SqlDeleteOrder(OrderID);
        }
    }
}
