using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public class ProductLine
    {
        //Properties
        private int LineID {get; set;}
        private int ProductAmount { get; set; }
        private decimal TotalPrice { get; set; }
        private decimal SalesPrice { get; set; }
        private decimal PricePrItem { get; set; }
        private decimal DiscountItem { get; set; }


        /// <summary>
        /// Constructor Class
        /// </summary>
        public ProductLine(int lineID, int productAmount, decimal totalPrice, decimal salesPrice, decimal pricePrItem, decimal discountItem)
        {
            this.LineID = lineID;
            this.ProductAmount = productAmount;
            this.TotalPrice = totalPrice;
            this.SalesPrice = salesPrice;
            this.PricePrItem = pricePrItem;
            this.DiscountItem = discountItem;
        }


        /// <summary>
        /// Constructor Database
        /// </summary>
        public ProductLine(int productAmount, decimal salesPrice, decimal pricePrItem, decimal discountItem)
        {
            this.SalesPrice = salesPrice;
            this.PricePrItem = pricePrItem;
            this.ProductAmount = productAmount;
            this.DiscountItem = discountItem;
        }
    }
}


