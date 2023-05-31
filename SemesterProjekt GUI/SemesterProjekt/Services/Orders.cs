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
        public static List<Models.Order> FindOrder(DateTime StartDate, DateTime EndDate)
        {
            List<Models.Order> orderList = Database.Database.SqlGetOrder(StartDate, EndDate);
            
            return orderList;

        }

        public static void DeleteOrder(Models.Order order)
        {

        }

        public static void GetCustomerPurchaseOrdersBetweenDates(List<Models.Order> orders, DateTime startDate, DateTime endDate)
        {
            
            List<Models.Customer> customers = Services.Customer.FindCostumer();

            // Sortér ordrer efter dato
            orders = orders.OrderBy(Order => Order.OrderDate).ToList();
            

            Console.WriteLine("SALGSSTATISTIK 2023");
            Console.WriteLine($"Fra dato: {startDate.ToShortDateString()} Til dato: {endDate.ToShortDateString()}");
            Console.WriteLine("Kundenummer   OrderStatus                     Dato        Køb");
            Console.WriteLine("----------------------------------------------");

            foreach (Order order in orders)
            {
                Console.WriteLine($"{order.CostumerID}   {order.OrderStatus.PadRight(25)} {order.OrderDate.ToShortDateString()}    {order.TotalPrice}");
            }

            decimal totalSales = orders.Sum(order => order.TotalPrice);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Summen af alle salg i perioden: {totalSales}");

            // Skriv til tekstfil
            string filePath = "salgsstatistik.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("SALGSSTATISTIK 2023");
                writer.WriteLine($"Fra dato: {startDate.ToShortDateString()} Til dato: {endDate.ToShortDateString()}");
                writer.WriteLine("Kundenummer   OrderStatus                     Dato        Køb");
                writer.WriteLine("----------------------------------------------");

                foreach (Order order in orders)
                {
                    writer.WriteLine($"{order.CostumerID}   {order.OrderStatus.PadRight(25)} {order.OrderDate.ToShortDateString()}    {order.TotalPrice}");
                }

                writer.WriteLine("----------------------------------------------");
                writer.WriteLine($"Summen af alle salg i perioden: {totalSales}");
            }

            Console.WriteLine($"Udskriften er gemt i filen: {filePath}");
        }
    }
}
