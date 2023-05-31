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
                var DataSource = Database.Database.SqlGetCustomer(TB_SearchTlfCustomer.Text, TB_SearchEMailCustomer.Text);
                DGV_Customer.DataSource = DataSource;
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
            DGV_Customer.CurrentRow.Selected = true;
            DGV_Customer.ReadOnly = true;
            TB_CustomerFirstName.Text = DGV_Customer.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            TB_CustomerPhoneNr.Text = DGV_Customer.Rows[e.RowIndex].Cells["PhoneNr"].Value.ToString();
            TB_CustomerEMailAdress.Text = DGV_Customer.Rows[e.RowIndex].Cells["EMailAdress"].Value.ToString();
            TB_CustomerAdress.Text = DGV_Customer.Rows[e.RowIndex].Cells["Adress"].Value.ToString();
            TB_CustomerCity.Text = DGV_Customer.Rows[e.RowIndex].Cells["City"].Value.ToString();
            TB_CustomerPostalCode.Text = DGV_Customer.Rows[e.RowIndex].Cells["PostalCode"].Value.ToString();
            TB_CustomerDiscount.Text = DGV_Customer.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
            TB_CustomerBirthday.Text = DGV_Customer.Rows[e.RowIndex].Cells["Birthday"].Value.ToString();
            TB_CustomerAge.Text = DGV_Customer.Rows[e.RowIndex].Cells["Age"].Value.ToString();
            TB_CustomerVisionTest.Text = DGV_Customer.Rows[e.RowIndex].Cells["VisionTest"].Value.ToString();
        }

        private void BTN_UpdateProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
