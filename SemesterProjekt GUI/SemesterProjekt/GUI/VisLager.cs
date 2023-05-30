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
    public partial class VisLager : Form
    {
        public VisLager()
        {
            InitializeComponent();
        }

        private void VisLager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeStockTable.StoreStock' table. You can move, or remove it, as needed.
            this.storeStockTableAdapter.Fill(this.storeStockTable.StoreStock);

        }
    }
}
