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
    public partial class OpdaterKunde : Form
    {
        public OpdaterKunde()
        {
            InitializeComponent();
        }

        List<Models.Customer> customers = new List<Models.Customer>();
        Models.Customer Customer;

        /// <summary>
        /// Method Opens .pdf explanation of UI
        /// </summary>
        private void LL_Forklaring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath = @"C:\1semesterProjekt/SemesterProjekt GUI/Søg kunde.pdf";
            Process.Start(filePath);
        }

        /// <summary>
        /// Method sets the Customers DataGridView datasource to SQL method 
        /// And searches for Customer PhoneNr and EMailAdress
        /// </summary>
        private void BTN_SearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                customers = Services.Customer.FindCostumer(TB_SearchTlfCustomer.Text, TB_SearchEMailCustomer.Text);
                DGV_Customer.DataSource = customers;
            }
            catch (Exception)
            {

                MessageBox.Show("Fejl i indtastning");
            }

        }

        /// <summary>
        /// Method sets Textbox values according to selected items in Customer DataGridView
        /// </summary>
        private void DGV_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DGV_Customer.CurrentRow;

            // Få værdien af en bestemt celle i rækken baseret på kolonnens index
            int customerid = Convert.ToInt32(selectedRow.Cells[0].Value);
            //Services.Customer.FindCustomerFromCustomerID(int.Parse(DGV_Customer.Rows[e.RowIndex].Cells["CustomerID"].Value));

            //DGV_Customer.CurrentRow.Selected = true;
            //DGV_Customer.ReadOnly = true;
            //Customer.FirstName = DGV_Customer.Rows[e.RowIndex].Cells["FirstName"].Value?.ToString();
            //Customer.SurName = DGV_Customer.Rows[e.RowIndex].Cells["PhoneNr"].Value.ToString();
            //Customer.EMailAdress = DGV_Customer.Rows[e.RowIndex].Cells["EMailAdress"].Value.ToString();
            //Customer.Adress = DGV_Customer.Rows[e.RowIndex].Cells["Adress"].Value.ToString();
            //Customer.City = DGV_Customer.Rows[e.RowIndex].Cells["City"].Value.ToString();
            //Customer.PostalCode = DGV_Customer.Rows[e.RowIndex].Cells["PostalCode"].Value.ToString();
            //Customer.Discount = Convert.ToDecimal(DGV_Customer.Rows[e.RowIndex].Cells["Discount"].Value);
            //Customer.Birthday = Convert.ToDateTime(DGV_Customer.Rows[e.RowIndex].Cells["Birthday"].Value);
            //Customer.Age = Convert.ToInt32(DGV_Customer.Rows[e.RowIndex].Cells["Age"].Value);
            //Customer.VisionTest = DGV_Customer.Rows[e.RowIndex].Cells["VisionTest"].Value.ToString();
            //Customer.CustomerID = Convert.ToInt32(DGV_Customer.Rows[e.RowIndex].Cells["CustomerID"].Value);
            //Customer.PhoneNr = DGV_Customer.Rows[e.RowIndex].Cells["Age"].Value.ToString();
        }

        private void BTN_UpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void BTN_DeleteCustomer_Click(object sender, EventArgs e)
        {
           
        }
    }
}
