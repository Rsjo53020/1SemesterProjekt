using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt.GUI
{
    public partial class OpretKunde : Form
    {
        public OpretKunde()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Convert textboxes to Models.Customer(constructor) and parse to service layer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CreateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Customer customer = new Models.Customer(
                TB_FirstName.Text,
                TB_SurName.Text,
                TB_PhoneNr.Text,
                TB_EMailAdress.Text,
                TB_Adress.Text,
                TB_City.Text,
                TB_PostalCode.Text,
                Convert.ToDecimal(TB_Discount.Text),
                Convert.ToDateTime(TB_Birthday.Text),
                Convert.ToInt32(TB_Age.Text),
                TB_VisionTest.Text
                );

                Services.Customer.RegisterCustomer(customer);
            }
            catch  
            {
                MessageBox.Show("Fejl i indtastning!");
            }
        }
    }
}
