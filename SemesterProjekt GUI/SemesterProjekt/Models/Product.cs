using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public abstract class Product
    {
        public decimal PurchasePrice { get; set; }
        public string Desciption { get; set; }
        public string Name { get; set; }
        public Decimal SalesPrice { get; set; }
        public string Kategory { get; set; }
        public int EAN { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Lenght { get; set; }
        public decimal Widh { get; set; }
        public string Type { get; set; }
        public string usedFor { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
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

