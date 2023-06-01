using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt._Unused_GUI_
{
    public partial class AIResult : Form
    {
        public AIResult()
        {
            InitializeComponent();
        }

        private void AIResult_Load(object sender, EventArgs e)
        {
            Services.IntelligentRådgivning intelligentRådgivning = new Services.IntelligentRådgivning();
            List<Models.Product> products = intelligentRådgivning.ReturnProducts();
            dataGridView1.DataSource = products;
        }
        public void SetData (List<Models.Product> products) 
        {
            dataGridView1.DataSource = products;
        }
    }
}
