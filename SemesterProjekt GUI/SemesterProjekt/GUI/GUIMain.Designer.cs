namespace SemesterProjekt
{
    partial class GUIMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.StockSubMenuPanel = new System.Windows.Forms.Panel();
            this.Btn_ViewStock = new System.Windows.Forms.Button();
            this.Btn_Stock = new System.Windows.Forms.Button();
            this.OrdersSubMenuPanel = new System.Windows.Forms.Panel();
            this.Btn_SearchOrder = new System.Windows.Forms.Button();
            this.Btn_Ordre = new System.Windows.Forms.Button();
            this.CustomerSubMenuPanel = new System.Windows.Forms.Panel();
            this.Btn_UpdateCustomerInfo = new System.Windows.Forms.Button();
            this.Btn_CreateCustomer = new System.Windows.Forms.Button();
            this.Btn_Customer = new System.Windows.Forms.Button();
            this.ProductSubMenuPanel = new System.Windows.Forms.Panel();
            this.Btn_UpdateProduct = new System.Windows.Forms.Button();
            this.Btn_CreateProduct = new System.Windows.Forms.Button();
            this.Btn_Produkt = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.BTN_SynsPunkt = new System.Windows.Forms.Label();
            this.panelFormsLoader = new System.Windows.Forms.Panel();
            this.SideMenuPanel.SuspendLayout();
            this.StockSubMenuPanel.SuspendLayout();
            this.OrdersSubMenuPanel.SuspendLayout();
            this.CustomerSubMenuPanel.SuspendLayout();
            this.ProductSubMenuPanel.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SideMenuPanel.Controls.Add(this.StockSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.Btn_Stock);
            this.SideMenuPanel.Controls.Add(this.OrdersSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.Btn_Ordre);
            this.SideMenuPanel.Controls.Add(this.CustomerSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.Btn_Customer);
            this.SideMenuPanel.Controls.Add(this.ProductSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.Btn_Produkt);
            this.SideMenuPanel.Controls.Add(this.PanelLogo);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(267, 558);
            this.SideMenuPanel.TabIndex = 0;
            this.SideMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SideMenuPanel_Paint);
            // 
            // StockSubMenuPanel
            // 
            this.StockSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.StockSubMenuPanel.Controls.Add(this.Btn_ViewStock);
            this.StockSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockSubMenuPanel.Location = new System.Drawing.Point(0, 473);
            this.StockSubMenuPanel.Name = "StockSubMenuPanel";
            this.StockSubMenuPanel.Size = new System.Drawing.Size(267, 41);
            this.StockSubMenuPanel.TabIndex = 8;
            // 
            // Btn_ViewStock
            // 
            this.Btn_ViewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Btn_ViewStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_ViewStock.FlatAppearance.BorderSize = 0;
            this.Btn_ViewStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ViewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Btn_ViewStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_ViewStock.Location = new System.Drawing.Point(0, 0);
            this.Btn_ViewStock.Name = "Btn_ViewStock";
            this.Btn_ViewStock.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_ViewStock.Size = new System.Drawing.Size(267, 40);
            this.Btn_ViewStock.TabIndex = 0;
            this.Btn_ViewStock.Text = "Lager Beholdning";
            this.Btn_ViewStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ViewStock.UseVisualStyleBackColor = false;
            this.Btn_ViewStock.Click += new System.EventHandler(this.Btn_ViewStock_Click);
            // 
            // Btn_Stock
            // 
            this.Btn_Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Stock.FlatAppearance.BorderSize = 0;
            this.Btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Btn_Stock.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Stock.Location = new System.Drawing.Point(0, 428);
            this.Btn_Stock.Name = "Btn_Stock";
            this.Btn_Stock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Stock.Size = new System.Drawing.Size(267, 45);
            this.Btn_Stock.TabIndex = 7;
            this.Btn_Stock.Text = "Lager";
            this.Btn_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Stock.UseVisualStyleBackColor = true;
            this.Btn_Stock.Click += new System.EventHandler(this.Btn_Stock_Click);
            // 
            // OrdersSubMenuPanel
            // 
            this.OrdersSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.OrdersSubMenuPanel.Controls.Add(this.Btn_SearchOrder);
            this.OrdersSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersSubMenuPanel.Location = new System.Drawing.Point(0, 385);
            this.OrdersSubMenuPanel.Name = "OrdersSubMenuPanel";
            this.OrdersSubMenuPanel.Size = new System.Drawing.Size(267, 43);
            this.OrdersSubMenuPanel.TabIndex = 6;
            // 
            // Btn_SearchOrder
            // 
            this.Btn_SearchOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Btn_SearchOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_SearchOrder.FlatAppearance.BorderSize = 0;
            this.Btn_SearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Btn_SearchOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_SearchOrder.Location = new System.Drawing.Point(0, 0);
            this.Btn_SearchOrder.Name = "Btn_SearchOrder";
            this.Btn_SearchOrder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_SearchOrder.Size = new System.Drawing.Size(267, 40);
            this.Btn_SearchOrder.TabIndex = 1;
            this.Btn_SearchOrder.Text = "Søg Ordre";
            this.Btn_SearchOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_SearchOrder.UseVisualStyleBackColor = false;
            this.Btn_SearchOrder.Click += new System.EventHandler(this.Btn_SearchOrder_Click);
            // 
            // Btn_Ordre
            // 
            this.Btn_Ordre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Ordre.FlatAppearance.BorderSize = 0;
            this.Btn_Ordre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ordre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Btn_Ordre.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Ordre.Location = new System.Drawing.Point(0, 340);
            this.Btn_Ordre.Name = "Btn_Ordre";
            this.Btn_Ordre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Ordre.Size = new System.Drawing.Size(267, 45);
            this.Btn_Ordre.TabIndex = 5;
            this.Btn_Ordre.Text = "Ordre";
            this.Btn_Ordre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ordre.UseVisualStyleBackColor = true;
            this.Btn_Ordre.Click += new System.EventHandler(this.Btn_Ordre_Click);
            // 
            // CustomerSubMenuPanel
            // 
            this.CustomerSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.CustomerSubMenuPanel.Controls.Add(this.Btn_UpdateCustomerInfo);
            this.CustomerSubMenuPanel.Controls.Add(this.Btn_CreateCustomer);
            this.CustomerSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerSubMenuPanel.Location = new System.Drawing.Point(0, 250);
            this.CustomerSubMenuPanel.Name = "CustomerSubMenuPanel";
            this.CustomerSubMenuPanel.Size = new System.Drawing.Size(267, 90);
            this.CustomerSubMenuPanel.TabIndex = 4;
            // 
            // Btn_UpdateCustomerInfo
            // 
            this.Btn_UpdateCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Btn_UpdateCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_UpdateCustomerInfo.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Btn_UpdateCustomerInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_UpdateCustomerInfo.Location = new System.Drawing.Point(0, 40);
            this.Btn_UpdateCustomerInfo.Name = "Btn_UpdateCustomerInfo";
            this.Btn_UpdateCustomerInfo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_UpdateCustomerInfo.Size = new System.Drawing.Size(267, 49);
            this.Btn_UpdateCustomerInfo.TabIndex = 3;
            this.Btn_UpdateCustomerInfo.Text = "Ret Oplysninger";
            this.Btn_UpdateCustomerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UpdateCustomerInfo.UseVisualStyleBackColor = false;
            this.Btn_UpdateCustomerInfo.Click += new System.EventHandler(this.Btn_UpdateCustomerInfo_Click);
            // 
            // Btn_CreateCustomer
            // 
            this.Btn_CreateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Btn_CreateCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_CreateCustomer.FlatAppearance.BorderSize = 0;
            this.Btn_CreateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Btn_CreateCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_CreateCustomer.Location = new System.Drawing.Point(0, 0);
            this.Btn_CreateCustomer.Name = "Btn_CreateCustomer";
            this.Btn_CreateCustomer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_CreateCustomer.Size = new System.Drawing.Size(267, 40);
            this.Btn_CreateCustomer.TabIndex = 0;
            this.Btn_CreateCustomer.Text = "Opret Kunde";
            this.Btn_CreateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CreateCustomer.UseVisualStyleBackColor = false;
            this.Btn_CreateCustomer.Click += new System.EventHandler(this.Btn_CreateCustomer_Click);
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Btn_Customer.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Customer.Location = new System.Drawing.Point(0, 205);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Customer.Size = new System.Drawing.Size(267, 45);
            this.Btn_Customer.TabIndex = 3;
            this.Btn_Customer.Text = "Kunde";
            this.Btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customer.UseVisualStyleBackColor = true;
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // ProductSubMenuPanel
            // 
            this.ProductSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ProductSubMenuPanel.Controls.Add(this.Btn_UpdateProduct);
            this.ProductSubMenuPanel.Controls.Add(this.Btn_CreateProduct);
            this.ProductSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductSubMenuPanel.Location = new System.Drawing.Point(0, 115);
            this.ProductSubMenuPanel.Name = "ProductSubMenuPanel";
            this.ProductSubMenuPanel.Size = new System.Drawing.Size(267, 90);
            this.ProductSubMenuPanel.TabIndex = 2;
            // 
            // Btn_UpdateProduct
            // 
            this.Btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Btn_UpdateProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_UpdateProduct.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Btn_UpdateProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_UpdateProduct.Location = new System.Drawing.Point(0, 40);
            this.Btn_UpdateProduct.Name = "Btn_UpdateProduct";
            this.Btn_UpdateProduct.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_UpdateProduct.Size = new System.Drawing.Size(267, 49);
            this.Btn_UpdateProduct.TabIndex = 3;
            this.Btn_UpdateProduct.Text = "Ændre Produkt";
            this.Btn_UpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UpdateProduct.UseVisualStyleBackColor = false;
            this.Btn_UpdateProduct.Click += new System.EventHandler(this.Btn_UpdateProduct_Click);
            // 
            // Btn_CreateProduct
            // 
            this.Btn_CreateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Btn_CreateProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_CreateProduct.FlatAppearance.BorderSize = 0;
            this.Btn_CreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Btn_CreateProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_CreateProduct.Location = new System.Drawing.Point(0, 0);
            this.Btn_CreateProduct.Name = "Btn_CreateProduct";
            this.Btn_CreateProduct.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Btn_CreateProduct.Size = new System.Drawing.Size(267, 40);
            this.Btn_CreateProduct.TabIndex = 0;
            this.Btn_CreateProduct.Text = "Opret Produkt";
            this.Btn_CreateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CreateProduct.UseVisualStyleBackColor = false;
            this.Btn_CreateProduct.Click += new System.EventHandler(this.Btn_CreateProduct_Click);
            // 
            // Btn_Produkt
            // 
            this.Btn_Produkt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Btn_Produkt.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Produkt.FlatAppearance.BorderSize = 0;
            this.Btn_Produkt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Produkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Btn_Produkt.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Produkt.Location = new System.Drawing.Point(0, 70);
            this.Btn_Produkt.Name = "Btn_Produkt";
            this.Btn_Produkt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Produkt.Size = new System.Drawing.Size(267, 45);
            this.Btn_Produkt.TabIndex = 1;
            this.Btn_Produkt.Text = "Produkt";
            this.Btn_Produkt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Produkt.UseVisualStyleBackColor = false;
            this.Btn_Produkt.Click += new System.EventHandler(this.Btn_Produkt_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PanelLogo.Controls.Add(this.BTN_SynsPunkt);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(267, 70);
            this.PanelLogo.TabIndex = 0;
            // 
            // BTN_SynsPunkt
            // 
            this.BTN_SynsPunkt.AutoSize = true;
            this.BTN_SynsPunkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SynsPunkt.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTN_SynsPunkt.Location = new System.Drawing.Point(27, 26);
            this.BTN_SynsPunkt.Name = "BTN_SynsPunkt";
            this.BTN_SynsPunkt.Size = new System.Drawing.Size(192, 33);
            this.BTN_SynsPunkt.TabIndex = 0;
            this.BTN_SynsPunkt.Text = "SYNSPUNKT";
            this.BTN_SynsPunkt.Click += new System.EventHandler(this.BTN_SynsPunkt_Click);
            // 
            // panelFormsLoader
            // 
            this.panelFormsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormsLoader.Location = new System.Drawing.Point(267, 0);
            this.panelFormsLoader.Name = "panelFormsLoader";
            this.panelFormsLoader.Size = new System.Drawing.Size(667, 558);
            this.panelFormsLoader.TabIndex = 1;
            // 
            // GUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(934, 558);
            this.Controls.Add(this.panelFormsLoader);
            this.Controls.Add(this.SideMenuPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 597);
            this.MinimumSize = new System.Drawing.Size(950, 597);
            this.Name = "GUIMain";
            this.Text = "SYNSPUNKT MENU";
            this.SideMenuPanel.ResumeLayout(false);
            this.StockSubMenuPanel.ResumeLayout(false);
            this.OrdersSubMenuPanel.ResumeLayout(false);
            this.CustomerSubMenuPanel.ResumeLayout(false);
            this.ProductSubMenuPanel.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel ProductSubMenuPanel;
        private System.Windows.Forms.Button Btn_UpdateProduct;
        private System.Windows.Forms.Button Btn_CreateProduct;
        private System.Windows.Forms.Button Btn_Produkt;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel OrdersSubMenuPanel;
        private System.Windows.Forms.Button Btn_SearchOrder;
        private System.Windows.Forms.Button Btn_Ordre;
        private System.Windows.Forms.Panel CustomerSubMenuPanel;
        private System.Windows.Forms.Button Btn_UpdateCustomerInfo;
        private System.Windows.Forms.Button Btn_CreateCustomer;
        private System.Windows.Forms.Button Btn_Customer;
        private System.Windows.Forms.Panel StockSubMenuPanel;
        private System.Windows.Forms.Button Btn_ViewStock;
        private System.Windows.Forms.Button Btn_Stock;
        private System.Windows.Forms.Label BTN_SynsPunkt;
        private System.Windows.Forms.Panel panelFormsLoader;
    }
}