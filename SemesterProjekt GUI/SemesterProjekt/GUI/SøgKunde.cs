using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt.GUI
{
    public partial class SøgKunde : Form
    {
        public SøgKunde()
        {
            InitializeComponent();
        }

        private void LB_ShowProduct_Click(object sender, EventArgs e)
        {

        }

        private void SøgKunde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerTable.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerTable.Customer);

        }
    }
}
