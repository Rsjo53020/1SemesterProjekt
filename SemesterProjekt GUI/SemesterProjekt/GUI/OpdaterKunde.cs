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

        private void LL_Forklaring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Path to file
            string filePath = @"C:\1semesterProjekt/SemesterProjekt GUI/Søg kunde.pdf";

            // Open file with with standard program
            Process.Start(filePath);
        }

        private void OpdaterKunde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerTable.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerTable.Customer);

        }

        private void BTN_UpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SearchCustomer_Click(object sender, EventArgs e)
        {
            string searchedPhoneNumber = "";
            string searchedEMailAdress = "";
            if (TB_SearchTlfCustomer.Text != "")
            {
                searchedPhoneNumber = TB_SearchTlfCustomer.Text;

                if (TB_SearchTlfCustomer.Text.Contains("+45") & TB_SearchTlfCustomer.Text.Length > 9)
                {
                    searchedPhoneNumber = TB_SearchTlfCustomer.Text.Substring(3);
                    searchedPhoneNumber = searchedPhoneNumber.Replace(" ", "");
                }
            }
            else if (TB_SearchEMailCustomer.Text != "")
            {
                searchedEMailAdress = TB_SearchEMailCustomer.Text;

            }


            customers = Services.Customer.FindCostumer(searchedPhoneNumber, searchedEMailAdress);
        }
    }
}
