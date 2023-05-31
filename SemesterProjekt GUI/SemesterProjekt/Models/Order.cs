using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public int CostumerID { get; set; }
        public int LineID { get; set; }
        public Decimal TotalPrice { get; set; }
        public int VAT { get; set; }

        /// <summary>
        /// Constructor Class
        /// </summary>
        public Order(DateTime orderDate, string orderStatus, decimal totalPrice, int VAT, int costumerID)
        {
            this.OrderDate = orderDate;
            this.OrderStatus = orderStatus;
            this.CostumerID = costumerID;
            this.VAT = VAT;
            this.TotalPrice = totalPrice;
        }

        /// <summary>
        /// Constructor Database
        /// </summary>
        public Order(int ordreID, DateTime orderDate, string orderStatus, decimal totalPrice, int VAT, int costumerID, int lineID)
        {
            this.OrderID = ordreID;
            this.LineID = lineID;
            this.OrderDate = orderDate;
            this.OrderStatus = orderStatus;
            this.CostumerID = costumerID;
            this.VAT = VAT;
            this.TotalPrice = totalPrice;
        }
    }
}
