using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SemesterProjekt.GUI
{
    public partial class BGFStartside : Form
    {
        public BGFStartside()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method opens "GUIMain" and hides "BGFStartside"
        /// </summary>
        private void BTN_Butik_Click(object sender, EventArgs e)
        {
            GUIMain GUIMain = new GUIMain();
            GUIMain.Show();
            this.Hide();
        }

        /// <summary>
        /// Method Opens "Spørgeskema" Form
        /// </summary>
        private void BTN_Kunde_Click(object sender, EventArgs e)
        {
            Spørgeskema spørgeskema = new Spørgeskema();
            spørgeskema.Show();
            this.Hide();
        }
    }
}
