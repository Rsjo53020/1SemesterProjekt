using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Models.Frame product = new Models.Frame(
                Convert.ToDecimal(TB_SalesPrice.Text),
                TB_NameProduct.Text,
                TB_Discription.Text,
                TB_Kategory.Text,
                Convert.ToDecimal(TB_PurchasePrice),
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

            Services.Produkt.CreateProduct( product );




        }
    }
}
