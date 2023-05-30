using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt.Models
{
    public abstract class Product
    {
        public decimal PurchasePrice { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal SalesPrice { get; set; }
        public string Category { get; set; }
        public int EAN { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public string Type { get; set; }
        public string UsedFor { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
        public string Material { get; set; }
        public string FrameColor { get; set; }
    }

    public class Frame : Product
    {
        public string FrameMaterial { get; set; }
        public double FrameLength { get; set; }
        public double FrameWidth { get; set; }

        /// <summary>
        /// Constructor Frame Class
        /// </summary>

        public Frame(decimal purchasePrice, string description, string name, decimal salesPrice, string category, int EAN,
            decimal length, decimal width, string type, string usedFor, string color, string style, string material, string frameColor,
            double frameLength, double frameWidth)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.Name = name;
            this.SalesPrice = salesPrice;
            this.Category = category;
            this.EAN = EAN;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.Material = material;
            this.FrameColor = frameColor;
            this.FrameLength = frameLength;
            this.FrameWidth = frameWidth;
        }


        /// <summary>
        /// Constructor Frame Databse
        /// </summary>
        public Frame(decimal purchasePrice, string description, string name, decimal salesPrice, string category,
            decimal length, decimal width, string type, string usedFor, string color, string style, string material, string frameColor,
            double frameLength, double frameWidth)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.Name = name;
            this.SalesPrice = salesPrice;
            this.Category = category;
            this.EAN = EAN;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.Material = material;
            this.FrameColor = frameColor;
            this.FrameLength = frameLength;
            this.FrameWidth = frameWidth;
        }

    }

    public class Binocular : Product
    {
        public string BinocularMaterial { get; set; }
        public string BinocularColor { get; set; }
        public int BinocularIntensity { get; set; }

        /// <summary>
        /// Constructor  Binocular Class
        /// </summary>
        public Binocular(decimal purchasePrice, string description, string name, decimal salesPrice, string category, int EAN,
            decimal length, decimal width, string type, string usedFor, string color, string style, string material, string frameColor,
            string binocularMaterial, string binocularColor, int binocularIntensity)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.Name = name;
            this.SalesPrice = salesPrice;
            this.Category = category;
            this.EAN = EAN;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.Material = material;
            this.FrameColor = frameColor;
            this.BinocularMaterial = binocularMaterial;
            this.BinocularColor = binocularColor;
            this.BinocularIntensity = binocularIntensity;
        }
        /// <summary>
        /// Constructor Binocular Database
        /// </summary>

        public Binocular(decimal purchasePrice, string description, string name, decimal salesPrice, string category,
            decimal length, decimal width, string type, string usedFor, string color, string style, string material, string frameColor,
            string binocularMaterial, string binocularColor, int binocularIntensity)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.Name = name;
            this.SalesPrice = salesPrice;
            this.Category = category;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.Material = material;
            this.FrameColor = frameColor;
            this.BinocularMaterial = binocularMaterial;
            this.BinocularColor = binocularColor;
            this.BinocularIntensity = binocularIntensity;
        }
    }



    public class SpectacleLens : Product
    {
        public string LensIntensity { get; set; }
        public string LensSize { get; set; }

        /// <summary>
        /// Constructor SpectacleLens Class
        /// </summary>

        public SpectacleLens(decimal purchasePrice, string description, string name, decimal salesPrice, string category, int EAN,
                decimal length, decimal width, string type, string usedFor, string color, string style, string material, string frameColor, string LensIntensity, string LensSize)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.Name = name;
            this.SalesPrice = salesPrice;
            this.Category = category;
            this.EAN = EAN;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.Material = material;
            this.FrameColor = frameColor;
            this.LensIntensity = LensIntensity;
            this.LensSize = LensSize;
        }

        /// <summary>
        /// Constructor SpectacleLens Database
        /// </summary>
        public SpectacleLens(decimal purchasePrice, string description, string name, decimal salesPrice, string category,
               decimal length, decimal width, string type, string usedFor, string color, string style, string material, string frameColor, string LensIntensity, string LensSize)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.Name = name;
            this.SalesPrice = salesPrice;
            this.Category = category;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.Material = material;
            this.FrameColor = frameColor;
            this.LensIntensity = LensIntensity;
            this.LensSize = LensSize;
        }



        public class ContactLens : Product
        {
            public string LensSize { get; set; }
            public string Lifetime { get; set; }
            public string LensIntensity { get; set; }

            /// <summary>
            /// Constructor ContactLens Class   
            /// </summary>

            public ContactLens(decimal purchasePrice, string description, string name, decimal salesPrice, string category, int EAN,
                decimal length, decimal width, string type, string usedFor, string color, string style, string material, string frameColor, string lensIntensity, string lensSize)
            {
                this.PurchasePrice = purchasePrice;
                this.Description = description;
                this.Name = name;
                this.SalesPrice = salesPrice;
                this.Category = category;
                this.EAN = EAN;
                this.Length = length;
                this.Width = width;
                this.Type = type;
                this.UsedFor = usedFor;
                this.Color = color;
                this.Style = style;
                this.Material = material;
                this.FrameColor = frameColor;
                this.LensIntensity = lensIntensity;
                this.LensSize = lensSize;
            }

            /// <summary>
            /// Constructor ContactLens Database    
            /// </summary>
            public ContactLens(decimal purchasePrice, string description, string name, decimal salesPrice, string category,
                decimal length, decimal width, string type, string usedFor, string color, string style, string material, string frameColor, string lensIntensity, string lensSize)
            {
                this.PurchasePrice = purchasePrice;
                this.Description = description;
                this.Name = name;
                this.SalesPrice = salesPrice;
                this.Category = category;
                this.Length = length;
                this.Width = width;
                this.Type = type;
                this.UsedFor = usedFor;
                this.Color = color;
                this.Style = style;
                this.Material = material;
                this.FrameColor = frameColor;
                this.LensIntensity = lensIntensity;
                this.LensSize = lensSize;
            }
        }
    }
}






