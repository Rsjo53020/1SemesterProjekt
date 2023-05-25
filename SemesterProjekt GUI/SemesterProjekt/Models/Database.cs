using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public class Database
    {
    }

    public static void SqlCreateCustumer(Customer customer)
    {

    }

    public static Customer SqlGetCustomer(string phoneNr, string mail)
    {
        return Customer;
    }

    public static void SqlDeleteCustomer(string phoneNr, string mail)
    {

    }

    public static Customer SqlUpdateCustomer(Customer customer)
    {
        return Customer;
    }
    public static void SqlCreateOrder(Order order)
    {

    }

    public static Order SqlGetOrder(Customer.PhoneNr, Customer.Mail)
    {
        return Order;
    }

    public static void SqlDeleteOrder(Customer.PhoneNr, Customer.Mail)
    {

    }

    public static Order SqlUpdateOrder(Order order)
    {
        return Order;
    }

    public static void SqlCreateProduct(Product product)
    {
    }

    public static Product SqlGetProduct(Product name = "", Product Category = "")
    {
        return Product;
    }

    public static void SqlDeleteProduct(Product name = "", Product Category = "")
    {

    }

    public static Product SqlUpdateProduct(Product product)
    {
        return Product;
    }

}
