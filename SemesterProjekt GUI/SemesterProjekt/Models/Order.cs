using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    internal class Order
    {
        private string CostumerID { get; set; }
        private int ProductLine { get; set; }
        private DateTime OrderDate { get; set; }
        private Decimal TotalPrice { get; set; }

        public void FindOrder(Models.Customer customer)
        {
            return customer;
        }

        public void PlaceOrder()
        {   

        }

        public void DeleteOrder()
        {

        }

    }
}
