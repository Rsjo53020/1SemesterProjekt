using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public abstract class Product
    {
        private decimal PurchasePrice { get; set; }
        private string Desciption { get; set; }
        private string Name { get; set; }
        private Decimal SalesPrice { get; set; }
        private string Kategory { get; set; }
        private int EAN { get; set; }
    }

    /// <summary>
    /// Constructor Class
    /// </summary>
    public Product(decimal purchasePrice, string desciption, string name, decimal salesPrice, string kategory, int ean)
    {
        this.PurchasePrice = purchasePrice;
        this.Desciption = desciption;
        this.Name = name;
        this.SalesPrice = salesPrice;
        this.Kategory = kategory;
        this.EAN = ean;
    }


    /// <summary>
    /// Constructor Database
    /// </summary>
    public Product(decimal purchasePrice, string desciption, string name, decimal salesPrice, string kategory)
    {
        this.PurchasePrice = purchasePrice;
        this.Desciption = desciption;
        this.Name = name;
        this.SalesPrice = salesPrice;
        this.Kategory = kategory;
    }
    


    public class Frame : Product
    {
        public string FrameMaterial { get; set; }
        public string FrameColor { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
    }

    public class Binocular : Product
    {
        public string BinocularMaterial { get; set; }
        public string BinocularColor { get; set; }
        public int BinocularIntensity { get; set; }
    }

    public class ContactLens : Product
    {
        public string LensSize { get; set; }
        public string Lifetime { get; set; }
        public string LensIntensity { get; set; }
    }
    public class SpectacleLens : Product
    {
        public string LensIntensity { get; set; }
        public string LensSize { get; set; }
    }
}

