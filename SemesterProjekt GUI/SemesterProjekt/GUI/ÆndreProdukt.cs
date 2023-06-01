using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt.GUI
{
    public partial class ÆndreProdukt : Form
    {
        Models.Frame Product;
        public ÆndreProdukt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method Sets the Textbox text values according to the selected item in Product DatagridView
        /// </summary>
        private void DGV_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DGV_Product.CurrentRow;
            int EAN = Convert.ToInt32(selectedRow.Cells[5].Value);
            Product = Services.Produkt.GetProductFromEAN(EAN);

            TB_UpdatedSalesPrice.Text = Product.SalesPrice.ToString();
            TB_UpdatedNameProduct.Text = Product.NameProduct;
            TB_UpdatedDiscription.Text = Product.Description;
            TB_UpdatedKategory.Text = Product.Kategory;
            TB_PurchasePrice.Text = Product.PurchasePrice.ToString();
            TB_UpdatedVATSup.Text = Product.VATSup.ToString();
            TB_UpdatedAge.Text = Product.Age.ToString();
            TB_UpdatedLength.Text = Product.Length.ToString();
            TB_UpdatedWidth.Text = Product.Width.ToString();
            TB_UpdatedColor.Text = Product.Color;
            TB_UpdatedUsedFor.Text = Product.UsedFor;
            TB_UpdatedGender.Text = Product.Gender;
            TB_UpdatedKind.Text = Product.Gender;
            TB_UpdatedStyle.Text = Product.Style;

        }

        /// <summary>
        /// Method sets DatagridView datasource to SQL method. And searches for NameProduct and Category
        /// </summary>
        private void BTN_SearchProdukt_Click(object sender, EventArgs e)
        {
            try
            {
                var DataSource = Database.Database.SqlGetProduct(TB_SearchNameProduct.Text, TB_SearchKategory.Text);
                DGV_Product.DataSource = DataSource;
            }
            catch (Exception)
            {

                MessageBox.Show("Fejl i indtastning");
            }

        }

        /// <summary>
        /// Method deletes product from database using a refrence to Serives.deleteProduct
        /// </summary>
        private void BTN_SletProdukt_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du gerne vil slette dette produkt?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Services.Produkt.DeleteProduct(Product);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Method update product from textbox values.
        /// </summary>
        private void BTN_UpdateProduct_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Er du sikker på at du gerne vil opdatere dette produkt?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                Product.SalesPrice = TrimStringAfterDot(TB_UpdatedSalesPrice.Text);
                Product.NameProduct = TB_UpdatedNameProduct.Text;
                Product.Description = TB_UpdatedDiscription.Text;
                Product.Kategory = TB_UpdatedKategory.Text;
                Product.PurchasePrice = TrimStringAfterDot(TB_PurchasePrice.Text);
                Product.VATSup = int.Parse(TB_UpdatedVATSup.Text);
                Product.Gender = TB_UpdatedGender.Text;
                Product.Age = int.Parse(TB_UpdatedAge.Text);
                Product.Length = TrimStringAfterDot(TB_UpdatedLength.Text);
                Product.Width = TrimStringAfterDot(TB_UpdatedWidth.Text);
                Product.Kind = TB_UpdatedKind.Text;
                Product.Style = TB_UpdatedStyle.Text;
                Product.Color = TB_UpdatedColor.Text;
                Product.UsedFor = TB_UpdatedUsedFor.Text;
                Services.Produkt.UpdateProduct(Product);

            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void DGV_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static decimal TrimStringAfterDot(string str)
        {
            var ReaplaceComma = str.Replace(',', '.');
            var ConvertStrToDecimal = Convert.ToDecimal(ReaplaceComma);
            var Roundfunction = Math.Round(ConvertStrToDecimal, 2);
            return Roundfunction;
        }
    }
}
