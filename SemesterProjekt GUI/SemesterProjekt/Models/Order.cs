using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public class Order
    {
        private int OrderID { get; set; }
        private DateTime OrderDate { get; set; }
        private string OrderStatus { get; set; }
        private int CostumerID { get; set; }
        private int LineID { get; set; }
        private Decimal TotalPrice { get; set; }
        private int VAT { get; set; }

        /// <summary>
        /// Constructor Class
        /// </summary>
        public Order(DateTime orderDate, string orderStatus, decimal totalPrice, int VAT, int costumerID)
        {
            this.OrderDate = orderDate;
            this.OrderStatus = orderStatus;
            this.CostumerID = costumerID;
            this.LineID = LineID;
            this.VAT = VAT;
            this.TotalPrice = totalPrice;
        }

        /// <summary>
        /// Constructor Database
        /// </summary>
        public Order(int OrdreID, DateTime orderDate, string orderStatus, decimal totalPrice, int VAT, int costumerID, int LineID)
        {
            this.OrderID = OrdreID;
            this.LineID = LineID;
            this.OrderDate = orderDate;
            this.OrderStatus = orderStatus;
            this.CostumerID = costumerID;
            this.VAT = VAT;
            this.TotalPrice = totalPrice;
        }
    }
}
