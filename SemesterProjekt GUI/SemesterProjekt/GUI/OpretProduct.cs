using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            try
            {
                Models.Frame product = new Models.Frame(
                    Convert.ToDecimal(TB_SalesPrice.Text),
                    TB_NameProduct.Text,
                    TB_Discription.Text,
                    TB_Kategory.Text,
                    Convert.ToDecimal(TB_PurchasePrice.Text),
                    Convert.ToInt32(TB_VATSup.Text),
                    TB_Gender.Text,
                    Convert.ToInt32(TB_Age.Text),
                    Convert.ToDecimal(TB_Length.Text),
                    Convert.ToDecimal(TB_Width.Text),
                    TB_Kind.Text,
                    TB_UsedFor.Text,
                    TB_Style.Text,
                    TB_Color.Text
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

        private void LB_FoundOrder_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void OpretProduct_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
