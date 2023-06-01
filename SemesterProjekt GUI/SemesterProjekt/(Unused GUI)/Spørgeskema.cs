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
            List<string> Ansvers = new List<string>();
            Ansvers.Add(CB_Age.Text);
            Ansvers.Add(CB_Gender.Text);
            Ansvers.Add(CB_Length.Text);
            Ansvers.Add(CB_Width.Text);
            Ansvers.Add(CB_Kind.Text);
            Ansvers.Add(CB_UsedFor.Text);
            Ansvers.Add(CB_Style.Text);
            Ansvers.Add(CB_Color.Text);

            Services.IntelligentRådgivning intelligentRådgivning = new Services.IntelligentRådgivning();
            intelligentRådgivning.FilterSearchResult(Ansvers);

            
            this.Hide();
        }
    }
}
