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
    }
}
