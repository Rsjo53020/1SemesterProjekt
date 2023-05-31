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
            // Sortér ordrer efter dato
            orders = orders.OrderBy(Order => Order.OrderDate).ToList();
            

            Console.WriteLine("SALGSSTATISTIK 2023");
            Console.WriteLine($"Fra dato: {startDate.ToShortDateString()} Til dato: {endDate.ToShortDateString()}");
            Console.WriteLine("Kundenummer   OrderStatus                     Dato        Køb");
            Console.WriteLine("----------------------------------------------");
            
            foreach (Order order in orders)
            {
                Models.Customer customer = Services.Customer.FindCustomerFromCustomerID(order.CostumerID);
          
                Console.WriteLine($"{order.CostumerID}   {customer.FirstName}  {customer.SurName} {order.OrderDate.ToShortDateString()}    {order.TotalPrice}");
            }

            decimal totalSales = orders.Sum(order => order.TotalPrice);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Summen af alle salg i perioden: {totalSales}");

            // Skriv til tekstfil
            string filePath = "salgsstatistik.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write("SALGSSTATISTIK 2023");
                writer.Write($"                  Fra dato: {startDate.ToShortDateString()} Til dato: {endDate.ToShortDateString()}");
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("Kundenummer           Navn                     Dato        Køb");
                writer.WriteLine();

                foreach (Order order in orders)
                {
                    Models.Customer customer = Services.Customer.FindCustomerFromCustomerID(order.CostumerID);
                    writer.WriteLine($"{order.CostumerID}                     {customer.FirstName}  {customer.SurName}             {order.OrderDate.ToShortDateString()}    {order.TotalPrice}");
                }

                writer.WriteLine("-------------------------------------------------------------------------------");
                writer.WriteLine();
                writer.WriteLine($"                             Summen af alle salg i perioden: {totalSales}");
            }

            Console.WriteLine($"Udskriften er gemt i filen: {filePath}");
        }




    }
}
