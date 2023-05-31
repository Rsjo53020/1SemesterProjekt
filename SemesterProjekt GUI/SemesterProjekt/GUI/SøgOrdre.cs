using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt.GUI
{
    public partial class SøgOrdre : Form
    {
        public SøgOrdre()
        {
            InitializeComponent();
        }

        private void LL_Forklaring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Path to file
            string filePath = @"C:\SemesterProjekt GUI/Søg ordre.pdf";

            // Open file with with standard program
            Process.Start(filePath);
        }

        private void SøgOrdre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersTable.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.ordersTable.Orders);

        }

        private void BTN_SearchOrder_Click(object sender, EventArgs e)
        {
            List<Models.Order> orders = Services.Orders.FindOrder(DTP_StartDate.Value, DTP_EndDate.Value);
            DGV_ShowOrder.DataSource = orders;



        }
    }
}
