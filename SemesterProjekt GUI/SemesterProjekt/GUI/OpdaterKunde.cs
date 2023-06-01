using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Customer = Services.Customer.FindCustomerFromCustomerID(customerid);
            //Services.Customer.FindCustomerFromCustomerID(int.Parse(DGV_Customer.Rows[e.RowIndex].Cells["CustomerID"].Value));

            TB_CustomerFirstName.Text = Customer.FirstName;
            TB_CustomerPhoneNr.Text = Customer.PhoneNr.ToString();
            TB_CustomerEMailAdress.Text = Customer.EMailAdress;
            TB_CustomerAdress.Text = Customer.Adress;
            TB_CustomerCity.Text = Customer.City;
            TB_CustomerPostalCode.Text = Customer.PostalCode;
            TB_CustomerDiscount.Text = Customer.Discount.ToString();
            TB_CustomerBirthday.Text = Customer.Birthday.ToString("yyyy-MM-dd");
            TB_CustomerAge.Text = Customer.Age.ToString();
            TB_CustomerVisionTest.Text = Customer.VisionTest.ToString();

        }

        private void BTN_UpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void BTN_DeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du gerne vil slette denne kunde?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) 
            {
                Services.Customer.DeleteCustomer(Customer);
            }
            else if (result == DialogResult.No) 
            {
                this.Close();
            }
            
        }

        private void BTN_UpdateCustomer_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Er du sikker på at du gerne vil opdatere denne kunde?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Customer.FirstName = TB_CustomerFirstName.Text;
                Customer.PhoneNr = TB_CustomerPhoneNr.Text;
                Customer.EMailAdress = TB_CustomerEMailAdress.Text;
                Customer.Adress = TB_CustomerAdress.Text;
                Customer.City = TB_CustomerCity.Text;
                Customer.PostalCode = TB_CustomerPostalCode.Text;
                Customer.Discount = Convert.ToDecimal(Regex.Replace(TB_CustomerDiscount.Text, @"[^0-9.]", ""));
                Customer.Birthday = Convert.ToDateTime(TB_CustomerBirthday.Text);
                Customer.Age = Convert.ToInt32(Regex.Replace(TB_CustomerAge.Text, @"\D", ""));
                Customer.VisionTest = TB_CustomerVisionTest.Text;
                Services.Customer.UpdateCustomer(Customer);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
                
        }

        private void LL_UpdateProductForklaring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
