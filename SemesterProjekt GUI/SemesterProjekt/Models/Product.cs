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
        public string NameProduct { get; set; }
        public decimal SalesPrice { get; set; }
        public string Kategory { get; set; }
        public int EAN { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public string Kind { get; set; }
        public string UsedFor { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
        public int VATSup { get; set; }

    }

    public class Frame : Product
    {
        public string FrameMaterial { get; set; }

        /// <summary>
        /// Constructor Frame Class
        /// </summary>

        public Frame(decimal purchasePrice, string description, string NameProduct, decimal salesPrice, string Kategory,
            decimal length, decimal width, string kind, string usedFor, string color, string style, int VATSup)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.NameProduct = NameProduct;
            this.SalesPrice = SalesPrice;
            this.Kategory = Kategory;
            this.EAN = EAN;
            this.Length = length;
            this.Width = width;
            this.Kind = kind;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.VATSup = VATSup;
        }


        /// <summary>
        /// Constructor Frame Database
        /// </summary>
        public Frame(decimal SalesPrice, string NameProduct, decimal purchasePrice, string description, string Kategory,
            decimal length, decimal width, string kind, string usedFor, string color, string style, int VATSup, int EAN)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.NameProduct = NameProduct;
            this.SalesPrice = SalesPrice;
            this.Kategory = Kategory;
            this.Length = length;
            this.Width = width;
            this.Kind = kind;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.VATSup = VATSup;
            this.EAN = EAN;
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
        public Binocular(decimal purchasePrice, string description, string NameProduct, decimal salesPrice, string Kategory, int EAN,
            decimal length, decimal width, string type, string usedFor, string color, string style, int VATSup,
            string binocularMaterial, string binocularColor, int binocularIntensity)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.Name = NameProduct;
            this.SalesPrice = salesPrice;
            this.Kategory = Kategory;
            this.EAN = EAN;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.VATSup = VATSup;
            this.BinocularMaterial = binocularMaterial;
            this.BinocularColor = binocularColor;
            this.BinocularIntensity = binocularIntensity;
        }
        /// <summary>
        /// Constructor Binocular Database
        /// </summary>

        public Binocular(decimal purchasePrice, string description, string name, decimal salesPrice, string Kategory,
            decimal length, decimal width, string type, string usedFor, string color, string style, int VATSup,
            string binocularMaterial, string binocularColor, int binocularIntensity)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.NameProduct = NameProduct;
            this.SalesPrice = salesPrice;
            this.Kategory = Kategory;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.VATSup = VATSup;
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

        public SpectacleLens(decimal purchasePrice, string description, string NameProduct, decimal salesPrice, string Kategory, int EAN,
                decimal length, decimal width, string type, string usedFor, string color, string style, int VATSup, string LensIntensity, string LensSize)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.NameProduct = NameProduct;
            this.SalesPrice = salesPrice;
            this.Kategory = Kategory;
            this.EAN = EAN;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.VATSup = VATSup;
            this.LensIntensity = LensIntensity;
            this.LensSize = LensSize;
        }

        /// <summary>
        /// Constructor SpectacleLens Database
        /// </summary>
        public SpectacleLens(decimal purchasePrice, string description, string NameProduct, decimal salesPrice, string Kategory,
               decimal length, decimal width, string type, string usedFor, string color, string style, int VATSup, string LensIntensity, string LensSize)
        {
            this.PurchasePrice = purchasePrice;
            this.Description = description;
            this.NameProduct = NameProduct;
            this.SalesPrice = salesPrice;
            this.Kategory = Kategory;
            this.Length = length;
            this.Width = width;
            this.Type = type;
            this.UsedFor = usedFor;
            this.Color = color;
            this.Style = style;
            this.VATSup = VATSup;
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

            public ContactLens(decimal purchasePrice, string description, string NameProduct, decimal salesPrice, string Kategory, int EAN,
                decimal length, decimal width, string type, string usedFor, string color, string style, int VATSup, string lensIntensity, string lensSize)
            {
                this.PurchasePrice = purchasePrice;
                this.Description = description;
                this.NameProduct = NameProduct;
                this.SalesPrice = salesPrice;
                this.Kategory = Kategory;
                this.EAN = EAN;
                this.Length = length;
                this.Width = width;
                this.Type = type;
                this.UsedFor = usedFor;
                this.Color = color;
                this.Style = style;
                this.VATSup = VATSup;
                this.LensIntensity = lensIntensity;
                this.LensSize = lensSize;
            }

            /// <summary>
            /// Constructor ContactLens Database    
            /// </summary>
            public ContactLens(decimal purchasePrice, string description, string NameProduct, decimal salesPrice, string Kategory,
                decimal length, decimal width, string type, string usedFor, string color, string style, int VATSup, string lensIntensity, string lensSize)
            {
                this.PurchasePrice = purchasePrice;
                this.Description = description;
                this.NameProduct = NameProduct;
                this.SalesPrice = salesPrice;
                this.Kategory = Kategory;
                this.Length = length;
                this.Width = width;
                this.Type = type;
                this.UsedFor = usedFor;
                this.Color = color;
                this.Style = style;
                this.VATSup = VATSup;
                this.LensIntensity = lensIntensity;
                this.LensSize = lensSize;
            }
        }
    }
}






