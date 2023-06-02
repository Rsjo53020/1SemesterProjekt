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
    public partial class SøgKunde : Form
    {
        List<Models.Customer> customers = new List<Models.Customer>();
        public SøgKunde()
        {
            InitializeComponent();
        }

        private void BTN_SearchCustomer_Click(object sender, EventArgs e)
        {
            string searchedPhoneNumber = "";
            string searchedEMailAdress = "";
            if (TB_SearchPhoneNr.Text != "")
            {
                searchedPhoneNumber = TB_SearchPhoneNr.Text;

                if (TB_SearchPhoneNr.Text.Contains("+45") & TB_SearchPhoneNr.Text.Length > 9)
                {
                    searchedPhoneNumber = TB_SearchPhoneNr.Text.Substring(3);
                    searchedPhoneNumber.Replace(" ","");
                }
            }
            else if (TB_SearchEMailAdress.Text != "")
            {
                searchedEMailAdress = TB_SearchEMailAdress.Text;

            }

            customers = Services.Customer.FindCostumer(searchedPhoneNumber, searchedEMailAdress);
        }

        private void LL_Forklaring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Path to file
            string filePath = "SøgKunde.pdf";

            // Open file with with standard program
            Process.Start(filePath);
        }
    }
}
