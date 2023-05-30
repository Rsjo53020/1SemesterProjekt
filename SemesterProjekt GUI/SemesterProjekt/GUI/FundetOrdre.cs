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
    public partial class FundetOrdre : Form
    {
        public FundetOrdre()
        {
            InitializeComponent();
        }

        private void FundetOrdre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersTable.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.ordersTable.Orders);

        }
    }
}
