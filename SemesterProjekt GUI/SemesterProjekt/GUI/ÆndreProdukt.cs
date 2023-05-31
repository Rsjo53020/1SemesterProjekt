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
    public partial class ÆndreProdukt : Form
    {
        public ÆndreProdukt()
        {
            InitializeComponent();
        }

        private void DGV_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_Product.CurrentRow.Selected = true;
            DGV_Product.ReadOnly = true;
            TB_UpdatedSalesPrice.Text = DGV_Product.Rows[e.RowIndex].Cells["SalesPrice"].Value.ToString();
            TB_UpdatedNameProduct.Text = DGV_Product.Rows[e.RowIndex].Cells["NameProduct"].Value.ToString();
            TB_UpdatedDiscription.Text = DGV_Product.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            TB_UpdatedKategory.Text = DGV_Product.Rows[e.RowIndex].Cells["Kategory"].Value.ToString();
            TB_PurchasePrice.Text = DGV_Product.Rows[e.RowIndex].Cells["PurchasePrice"].Value.ToString();
            TB_UpdatedVATSup.Text = DGV_Product.Rows[e.RowIndex].Cells["VATSup"].Value.ToString();
            TB_UpdatedGender.Text = DGV_Product.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            TB_UpdatedAge.Text = DGV_Product.Rows[e.RowIndex].Cells["Age"].Value.ToString();
            TB_UpdatedLenght.Text = DGV_Product.Rows[e.RowIndex].Cells["Length"].Value.ToString();
            TB_UpdatedWidth.Text = DGV_Product.Rows[e.RowIndex].Cells["Width"].Value.ToString();
            TB_UpdatedKind.Text = DGV_Product.Rows[e.RowIndex].Cells["Kind"].Value.ToString();
            TB_UpdatedStyle.Text = DGV_Product.Rows[e.RowIndex].Cells["Style"].Value.ToString();
            TB_UpdatedColor.Text = DGV_Product.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            TB_UpdatedUsedFor.Text = DGV_Product.Rows[e.RowIndex].Cells["UsedFor"].Value.ToString();
        }

        private void BTN_SearchProdukt_Click(object sender, EventArgs e)
        {
            var DataSource = Database.Database.SqlGetProduct(TB_SearchNameProduct.Text, TB_SearchKategory.Text);
            DGV_Product.DataSource = DataSource;
        }

        private void DGV_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void OpdaterProdukt_Load(object sender, EventArgs e)
        {

        }

        private void BTN_SletProdukt_Click(object sender, EventArgs e)
        {

        }

        private void BTN_UpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedUsedFor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedStyle_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedKind_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedLenght_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedVATSup_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedSalesPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedKategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedDiscription_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_UpdatedNameProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_OpdateFindKategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
