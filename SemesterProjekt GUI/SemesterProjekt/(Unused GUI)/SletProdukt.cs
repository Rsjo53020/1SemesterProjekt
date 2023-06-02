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
    public partial class SletProdukt : Form
    {
        public SletProdukt()
        {
            InitializeComponent();
        }

        private void LL_Forklaring_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Path to file
            string filePath = "SletProdukt.pdf";

            // Open file with with standard program
            Process.Start(filePath);
        }
    }
}
