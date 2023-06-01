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
        /// <summary>
        /// Creates txt file from all products in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CreateTXTFile_Click(object sender, EventArgs e)
        {
            Services.Produkt.GetStockStatus();
        }
        /// <summary>
        /// adds all products from database into datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisLager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cskafte_dk_db_skafteDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.cskafte_dk_db_skafteDataSet2.Product);
            // TODO: This line of code loads data into the 'cskafte_dk_db_skafteDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cskafte_dk_db_skafteDataSet1.Product);
            // TODO: This line of code loads data into the 'cskafte_dk_db_skafteDataSet.StoreStock' table. You can move, or remove it, as needed.
            this.storeStockTableAdapter1.Fill(this.cskafte_dk_db_skafteDataSet.StoreStock);

        }
    }
}
