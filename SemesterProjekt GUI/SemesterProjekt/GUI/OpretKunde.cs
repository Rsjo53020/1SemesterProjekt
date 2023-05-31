using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string firstname = TB_FirstName.Text;
            string surname = TB_SurName.Text;
            string phonenumber = TB_PhoneNr.Text;
            string emailadress = TB_EMailAdress.Text;
            string adress = TB_Adress.Text;
            string city = TB_City.Text;
            string postalcode = TB_PostalCode.Text;
            decimal discount = Convert.ToDecimal(Regex.Replace(TB_Discount.Text, @"[^0-9,]", ""));
            DateTime birthday = Convert.ToDateTime(TB_Birthday.Text);
            int age = Convert.ToInt32(Regex.Replace(TB_Age.Text, @"\D", ""));
            string visiontest = TB_VisionTest.Text;
            
            try
            {
                Models.Customer customer = new Models.Customer(
                firstname,
                surname,
                phonenumber,
                emailadress,
                adress,
                city,
                postalcode,
                discount,
                birthday,
                age,
                visiontest                
                );

                Services.Customer.RegisterCustomer(customer);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Der opstod en fejl under filhåndteringen: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Formatfejl: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"En fejl opstod: {ex.Message}");
            }
        }
    }
}
