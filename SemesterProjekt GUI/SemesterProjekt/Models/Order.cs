using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    internal class Order
    {
        private int OrderID { get; set; }
        private DateTime OrderDate { get; set; }
        private string OrderStatus { get; set; }
        private string CostumerID { get; set; }
        private int ProductLine { get; set; }
        private Decimal TotalPrice { get; set; }


        /// <summary>
        /// Constructor Class
        /// </summary>
        public Order(int orderID, DateTime orderDate, string orderStatus, string costumerID, int productLine, decimal totalPrice)
        {
            this.OrderID = orderID;
            this.OrderDate = orderDate;
            this.OrderStatus = orderStatus;
            this.CostumerID = costumerID;
            this.ProductLine = productLine;
            this.TotalPrice = totalPrice;
        }

        /// <summary>
        /// Constructor Database
        /// </summary>
        public Order(DateTime orderDate, string orderStatus, decimal totalPrice)
        {
            this.OrderDate = orderDate;
            this.OrderStatus = orderStatus;
            this.TotalPrice = totalPrice;
        }
    }
}
