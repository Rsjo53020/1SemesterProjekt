using SemesterProjekt._Unused_GUI_;
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
    public partial class Spørgeskema : Form
    {
        public Spørgeskema()
        {
            InitializeComponent();
        }

        private void BTN_SearchProdukt_Click(object sender, EventArgs e)
        {
            string Gender = CB_Gender.Text;
            string Age = CB_Age.Text;
            string Length = CB_Length.Text;
            string Width = CB_Width.Text;
            string Kind = CB_Kind.Text;
            string UsedFor = CB_UsedFor.Text;
            string Style = CB_Style.Text;
            string Color = CB_Color.Text;

            AIResult aIResult = new AIResult();
            aIResult.Show();
            this.Hide();
        }
    }
}
