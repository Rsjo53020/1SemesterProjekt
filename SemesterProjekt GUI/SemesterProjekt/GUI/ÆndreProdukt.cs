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
        List<Models.Product> FramesList = new List<Models.Product>();
        public ÆndreProdukt()
        {
            InitializeComponent();
        }

        private void OpdaterProdukt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productTable.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productTable.Product);

        }

        private void BTN_SearchProdukt_Click(object sender, EventArgs e)
        {

            FramesList = Database.Database.SqlGetProduct(TB_SearchNameProduct.Text, TB_SearchKategory.Text);
            DGV_OpdateSelectProduct.DataSource = FramesList;
            TB_UpdatedSalesPrice.Text = DGV_OpdateSelectProduct.SelectedRows[0].DataBoundItem.ToString();

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
