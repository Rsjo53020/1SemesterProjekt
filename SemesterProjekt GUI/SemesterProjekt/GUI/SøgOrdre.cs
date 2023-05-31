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
        List<Models.Order> orders = new List<Models.Order>();
        DateTime DateStart;
        DateTime DateEnd;
        public SøgOrdre()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method Shows .Pdf explanation of UI
        /// </summary>
        private void LL_Forklaring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath = @"C:\SemesterProjekt GUI/Søg ordre.pdf";
            Process.Start(filePath);
        }

        private void BTN_SearchOrder_Click(object sender, EventArgs e)
        {
            orders = Services.Orders.FindOrder(DTP_StartDate.Value, DTP_EndDate.Value);
            DGV_ShowOrder.DataSource = orders;
            DateStart = DTP_StartDate.Value;
            DateEnd = DTP_EndDate.Value;
        }

        /// <summary>
        /// Method Calls Service.Orders and Creates a Textfile from a list and two Dates
        /// </summary>
        private void BTN_CreateTXTFile_Click(object sender, EventArgs e)
        {
            Services.Orders.GetCustomerPurchaseOrdersBetweenDates(orders, DateStart, DateEnd);
        }


        /// <summary>
        /// Method shows GUI "FundetOrdre" and hides GUI "SøgOrdre
        /// </summary>
        private void BTN_UpdateOrder_Click(object sender, EventArgs e)
        {
            FundetOrdre FundetOrdre = new FundetOrdre();
            FundetOrdre.Show();
            this.Hide();
        }
    }
}
