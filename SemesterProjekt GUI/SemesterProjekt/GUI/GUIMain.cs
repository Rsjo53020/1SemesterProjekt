using SemesterProjekt.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt
{
    public partial class GUIMain : Form
    {
        public GUIMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method Shows SubMenu in sidepanel
        /// </summary>
        private void ShowSubMenu()
        {
            if (ProductSubMenuPanel.Visible == true)
                ProductSubMenuPanel.Visible = true;
            if (CustomerSubMenuPanel.Visible == true)
                CustomerSubMenuPanel.Visible = true;
            if (OrdersSubMenuPanel.Visible == true)
                OrdersSubMenuPanel.Visible = true;
            if (StockSubMenuPanel.Visible == true)
                StockSubMenuPanel.Visible = true;
        }

        /// <summary>
        /// Method Closes other open Submenus
        /// </summary>
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ShowSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void SideMenuPanel_Paint(object sender, PaintEventArgs e)
        {
            //Reset Click event, slet Metode.
        }

        private void Btn_Produkt_Click(object sender, EventArgs e)
        {
            showSubMenu(ProductSubMenuPanel);
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            showSubMenu(CustomerSubMenuPanel);
        }

        private void Btn_Ordre_Click(object sender, EventArgs e)
        {
            showSubMenu(OrdersSubMenuPanel);
        }

        private void Btn_Stock_Click(object sender, EventArgs e)
        {
            showSubMenu(StockSubMenuPanel);
        }

        /// <summary>
        /// Method Loads GUI into Subpanel in GUIMain
        /// </summary>
        public Form activeForm = null;
        public void openFormsLoader(Form loadedForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = loadedForm;
            loadedForm.TopLevel = false;
            loadedForm.FormBorderStyle = FormBorderStyle.None;
            loadedForm.Dock = DockStyle.Fill;
            panelFormsLoader.Controls.Add(loadedForm);
            panelFormsLoader.Tag = loadedForm;
            loadedForm.BringToFront();
            loadedForm.Show();
        }

        /// <summary>
        /// Method Opens GUI "OpretProduct" And shows "panelFormLoader"
        /// </summary>
        private void Btn_CreateProduct_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new OpretProduct());
        }

        /// <summary>
        /// Method Opens GUI "VisProdukt" And shows "panelFormLoader"
        /// </summary>
        private void Btn_ViewProduct_Click(object sender, EventArgs e)
        {
            //panelFormsLoader.Visible = true;
            //openFormsLoader(new VisProdukt());
        }

        /// <summary>
        /// Method Opens GUI "SletProdukt" And shows "panelFormLoader"
        /// </summary>
        private void Btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            //    panelFormsLoader.Visible = true;
            //    openFormsLoader(new SletProdukt());
        }

        /// <summary>
        /// Method Opens GUI "ÆndreProdukt" And shows "panelFormLoader"
        /// </summary>
        private void Btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new ÆndreProdukt());
        }

        /// <summary>
        /// Method Opens GUI "OpretKunde" And shows "panelFormLoader"
        /// </summary>
        private void Btn_CreateCustomer_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new OpretKunde());
        }

        /// <summary>
        /// Method Opens GUI "SøgKunde" And shows "panelFormLoader"
        /// </summary>
        private void Btn_ViewCustomer_Click(object sender, EventArgs e)
        {
            //panelFormsLoader.Visible = true;
            //openFormsLoader(new SøgKunde());
        }

        /// <summary>
        /// Method Opens GUI "OpdaterKunde" And shows "panelFormLoader"
        /// </summary>
        private void Btn_UpdateCustomerInfo_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new OpdaterKunde());
        }

        /// <summary>
        /// Method Opens GUI "SøgOrdre" And shows "panelFormLoader"
        /// </summary>
        private void Btn_SearchOrder_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new SøgOrdre());
        }

        /// <summary>
        /// Method Opens GUI "VisLager" And shows "panelFormLoader"
        /// </summary>
        private void Btn_ViewStock_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new VisLager());
        }

        /// <summary>
        /// Method Hides Active panelFormsLoader. Returns To GUIMAIN
        /// </summary>
        private void BTN_SynsPunkt_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = false;
        }
    }
}
