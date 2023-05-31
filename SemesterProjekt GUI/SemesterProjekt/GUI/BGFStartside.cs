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
    public partial class BGFStartside : Form
    {
        public BGFStartside()
        {
            InitializeComponent();
        }

        private void BTN_Butik_Click(object sender, EventArgs e)
        {
            GUIMain gUIMain = new GUIMain();
            gUIMain.Show();
            this.Hide();

        }

        private void BTN_Kunde_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Alexa\\Desktop\\1semesterProjekt\\SemesterProjekt GUI\\AICustomer\\bin\\Debug\\AICustomer.exe");
            this.Hide();
        }


        
    }
}
