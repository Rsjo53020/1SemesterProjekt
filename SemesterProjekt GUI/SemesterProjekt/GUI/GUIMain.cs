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
        /// Denne Metode loader de forskellige forms ind i panelFormsLoader, som er placeret i GUIMain.
        /// </summary>
        private Form activeForm = null;
        private void openFormsLoader(Form loadedForm)
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

        private void Btn_CreateProduct_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new OpretProduct());
        }

        private void Btn_ViewProduct_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new VisProdukt());
        }

        private void Btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new SletProdukt());
        }

        private void Btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new OpdaterProdukt());
        }

        private void Btn_CreateCustomer_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new OpretKunde());
        }

        private void Btn_ViewCustomer_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new SøgKunde());
        }

        private void Btn_UpdateCustomerInfo_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new OpdaterKunde());
        }

        private void Btn_SearchOrder_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new SøgOrdre());
        }

        private void Btn_ViewStock_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = true;
            openFormsLoader(new VisLager());
        }

        private void BTN_SynsPunkt_Click(object sender, EventArgs e)
        {
            panelFormsLoader.Visible = false;
        }
    }
}
