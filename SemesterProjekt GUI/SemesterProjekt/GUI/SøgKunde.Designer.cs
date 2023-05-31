namespace SemesterProjekt.GUI
{
    partial class SøgKunde
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
            this.components = new System.ComponentModel.Container();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.LB_ShowProduct = new System.Windows.Forms.Label();
            this.TB_SearchEMailAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_SearchPhoneNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visionTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTable = new SemesterProjekt.CustomerTable();
            this.BTN_SearchCustomer = new System.Windows.Forms.Button();
            this.customerTableAdapter = new SemesterProjekt.CustomerTableTableAdapters.CustomerTableAdapter();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(1200, 95);
            this.PANEL_FindOrder.TabIndex = 91;
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(500, 31);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(184, 37);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "Søg Kunde";
            this.LB_ShowProduct.Click += new System.EventHandler(this.LB_ShowProduct_Click);
            // 
            // TB_SearchEMailAdress
            // 
            this.TB_SearchEMailAdress.Location = new System.Drawing.Point(354, 174);
            this.TB_SearchEMailAdress.Name = "TB_SearchEMailAdress";
            this.TB_SearchEMailAdress.Size = new System.Drawing.Size(442, 26);
            this.TB_SearchEMailAdress.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(92, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 37);
            this.label4.TabIndex = 94;
            this.label4.Text = "E-Mail :";
            // 
            // TB_SearchPhoneNr
            // 
            this.TB_SearchPhoneNr.Location = new System.Drawing.Point(354, 123);
            this.TB_SearchPhoneNr.Name = "TB_SearchPhoneNr";
            this.TB_SearchPhoneNr.Size = new System.Drawing.Size(442, 26);
            this.TB_SearchPhoneNr.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(92, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tlf +45 :";
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.AutoGenerateColumns = false;
            this.DGV_Customers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.phoneNrDataGridViewTextBoxColumn,
            this.eMailAdressDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.visionTestDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn});
            this.DGV_Customers.DataSource = this.customerBindingSource;
            this.DGV_Customers.Location = new System.Drawing.Point(0, 245);
            this.DGV_Customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.RowHeadersWidth = 62;
            this.DGV_Customers.Size = new System.Drawing.Size(1200, 446);
            this.DGV_Customers.TabIndex = 96;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            this.surNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNrDataGridViewTextBoxColumn
            // 
            this.phoneNrDataGridViewTextBoxColumn.DataPropertyName = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.HeaderText = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNrDataGridViewTextBoxColumn.Name = "phoneNrDataGridViewTextBoxColumn";
            this.phoneNrDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMailAdressDataGridViewTextBoxColumn
            // 
            this.eMailAdressDataGridViewTextBoxColumn.DataPropertyName = "EMailAdress";
            this.eMailAdressDataGridViewTextBoxColumn.HeaderText = "EMailAdress";
            this.eMailAdressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMailAdressDataGridViewTextBoxColumn.Name = "eMailAdressDataGridViewTextBoxColumn";
            this.eMailAdressDataGridViewTextBoxColumn.Width = 150;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 150;
            // 
            // visionTestDataGridViewTextBoxColumn
            // 
            this.visionTestDataGridViewTextBoxColumn.DataPropertyName = "VisionTest";
            this.visionTestDataGridViewTextBoxColumn.HeaderText = "VisionTest";
            this.visionTestDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.visionTestDataGridViewTextBoxColumn.Name = "visionTestDataGridViewTextBoxColumn";
            this.visionTestDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerTable;
            // 
            // customerTable
            // 
            this.customerTable.DataSetName = "CustomerTable";
            this.customerTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTN_SearchCustomer
            // 
            this.BTN_SearchCustomer.BackColor = System.Drawing.Color.White;
            this.BTN_SearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SearchCustomer.Location = new System.Drawing.Point(822, 132);
            this.BTN_SearchCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_SearchCustomer.Name = "BTN_SearchCustomer";
            this.BTN_SearchCustomer.Size = new System.Drawing.Size(180, 72);
            this.BTN_SearchCustomer.TabIndex = 97;
            this.BTN_SearchCustomer.Text = "Søg ";
            this.BTN_SearchCustomer.UseVisualStyleBackColor = false;
            this.BTN_SearchCustomer.Click += new System.EventHandler(this.BTN_SearchCustomer_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // SøgKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BTN_SearchCustomer);
            this.Controls.Add(this.DGV_Customers);
            this.Controls.Add(this.TB_SearchEMailAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_SearchPhoneNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SøgKunde";
            this.Text = "SøgKunde";
            this.Load += new System.EventHandler(this.SøgKunde_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_ShowProduct;
        private System.Windows.Forms.TextBox TB_SearchEMailAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_SearchPhoneNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private System.Windows.Forms.Button BTN_SearchCustomer;
        private CustomerTable customerTable;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerTableTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visionTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
    }
}