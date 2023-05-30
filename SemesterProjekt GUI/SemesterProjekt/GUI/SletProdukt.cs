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
    public partial class SletProdukt : Form
    {
        public SletProdukt()
        {
            InitializeComponent();
        }

        private void SletProdukt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productTable.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productTable.Product);

        }
    }
}
