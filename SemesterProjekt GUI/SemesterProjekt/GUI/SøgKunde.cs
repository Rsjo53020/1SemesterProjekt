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

        private void TB_Tlf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SøgKunde_Load(object sender, EventArgs e)
        {

        }

        private void BTN_OpretOrdre_Click(object sender, EventArgs e)
        {
            Form OpdaterKunde = new Form();
            OpdaterKunde.Show();
            this.Close();
        }
    }
}
