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
    public partial class VisProdukt : Form
    {
        public VisProdukt()
        {
            InitializeComponent();
        }


        private void PANEL_FindOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VisProdukt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productTable.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productTable.Product);

        }
    }
}
