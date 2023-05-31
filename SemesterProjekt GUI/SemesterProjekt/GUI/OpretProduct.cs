using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt.GUI
{
    public partial class OpretProduct : Form
    {
        public OpretProduct()
        {
            InitializeComponent();
        }

        private void BTN_CreateProduct_Click(object sender, EventArgs e)
        {
            decimal salesprice = Convert.ToDecimal(Regex.Replace(TB_SalesPrice.Text, @"[^0-9,]", "")); 
            string nameproduct = TB_NameProduct.Text;
            string discription = TB_Discription.Text;
            string kategory = TB_Kategory.Text;
            decimal purchaseprice = Convert.ToDecimal(Regex.Replace(TB_PurchasePrice.Text, @"[^0-9,]", ""));
            int vatsup = Convert.ToInt32(Regex.Replace(TB_VATSup.Text, @"\D", ""));
            string genter = TB_Gender.Text;
            int age = Convert.ToInt32(Regex.Replace(TB_Age.Text, @"\D", ""));
            decimal length = Convert.ToDecimal(Regex.Replace(TB_Length.Text, @"[^0-9,]", ""));
            decimal width = Convert.ToDecimal(Regex.Replace(TB_Width.Text, @"[^0-9,]", ""));
            string kind = TB_Kind.Text;
            string usedfor = TB_UsedFor.Text;
            string style = TB_Style.Text;
            string color = TB_Color.Text;


            try
            {
                Models.Frame product = new Models.Frame(
                    salesprice,
                    nameproduct,
                    discription,
                    kategory,
                    purchaseprice,
                    vatsup,
                    genter,
                    age,
                    length,
                    width,
                    kind,
                    usedfor,
                    style,
                    color
                    );

                Services.Produkt.CreateProduct(product);
            }
               catch (IOException ex)
            {
                MessageBox.Show($"Der opstod en fejl under filhåndteringen: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Formatfejl: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"En fejl opstod: {ex.Message}");
            }
        }
    }
}
