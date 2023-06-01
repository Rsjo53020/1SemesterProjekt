using SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class Orders
    {
        /// <summary>
        /// Method returns a List of customers from a Start date and End date, using SQL satement from Database
        /// </summary>
        public static List<Models.Order> FindOrder(DateTime StartDate, DateTime EndDate)
        {
            List<Models.Order> orderList = Database.Database.SqlGetOrder(StartDate, EndDate);
            return orderList;
        }

        public static void DeleteOrder(Models.Order order)
        {
        }

        /// <summary>
        /// Method print all orders from a customer, 
        /// using a list of customers and two Dates.
        /// </summary>
        public static void GetCustomerPurchaseOrdersBetweenDates(List<Models.Order> orders, DateTime startDate, DateTime endDate)
        {
            // Sort orders by date
            orders = orders.OrderBy(order => order.OrderDate).ToList();

            Console.WriteLine("SALGSSTATISTIK 2023");
            Console.WriteLine($"Fra dato: {startDate.ToShortDateString()} Til dato: {endDate.ToShortDateString()}");
            Console.WriteLine("Kundenummer   OrderStatus                               Dato            Køb");
            Console.WriteLine("----------------------------------------------");

            foreach (Models.Order order in orders)
            {
                Models.Customer customer = Services.Customer.FindCustomerFromCustomerID(order.CostumerID);

                Console.WriteLine($"{order.CostumerID,-12}   {customer.FirstName,-10}  {customer.SurName,-10} {order.OrderDate.ToShortDateString()}    {order.TotalPrice}");
            }

            decimal totalSales = orders.Sum(order => order.TotalPrice);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Summen af alle salg i perioden: {totalSales}");

            // Write to text file
            string filePath = "salgsstatistik.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("SALGSSTATISTIK 2023");
                writer.WriteLine($"Fra dato: {startDate.ToShortDateString()} Til dato: {endDate.ToShortDateString()}");
                writer.WriteLine();
                writer.WriteLine("Kundenummer           Navn                               Dato          Køb");
                writer.WriteLine();

                foreach (Models.Order order in orders)
                {
                    Models.Customer customer = Services.Customer.FindCustomerFromCustomerID(order.CostumerID);
                    writer.WriteLine($"{order.CostumerID,-21} {customer.FirstName,-10}  {customer.SurName,-10}             {order.OrderDate.ToShortDateString()}    {order.TotalPrice}");
                }

                writer.WriteLine("-------------------------------------------------------------------------------");
                writer.WriteLine();
                writer.WriteLine($"Summen af alle salg i perioden: {totalSales}");
            }

            Console.WriteLine($"Udskriften er gemt i filen: {filePath}");
        }




    }
}
