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
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(800, 62);
            this.PANEL_FindOrder.TabIndex = 91;
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(333, 20);
            this.LB_ShowProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(129, 26);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "Søg Kunde";
            this.LB_ShowProduct.Click += new System.EventHandler(this.LB_ShowProduct_Click);
            // 
            // TB_SearchEMailAdress
            // 
            this.TB_SearchEMailAdress.Location = new System.Drawing.Point(236, 113);
            this.TB_SearchEMailAdress.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SearchEMailAdress.Name = "TB_SearchEMailAdress";
            this.TB_SearchEMailAdress.Size = new System.Drawing.Size(296, 20);
            this.TB_SearchEMailAdress.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(61, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 94;
            this.label4.Text = "E-Mail :";
            // 
            // TB_SearchPhoneNr
            // 
            this.TB_SearchPhoneNr.Location = new System.Drawing.Point(236, 80);
            this.TB_SearchPhoneNr.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SearchPhoneNr.Name = "TB_SearchPhoneNr";
            this.TB_SearchPhoneNr.Size = new System.Drawing.Size(296, 20);
            this.TB_SearchPhoneNr.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
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
            this.DGV_Customers.Location = new System.Drawing.Point(0, 159);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.RowHeadersWidth = 62;
            this.DGV_Customers.Size = new System.Drawing.Size(800, 290);
            this.DGV_Customers.TabIndex = 96;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            // 
            // phoneNrDataGridViewTextBoxColumn
            // 
            this.phoneNrDataGridViewTextBoxColumn.DataPropertyName = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.HeaderText = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.Name = "phoneNrDataGridViewTextBoxColumn";
            // 
            // eMailAdressDataGridViewTextBoxColumn
            // 
            this.eMailAdressDataGridViewTextBoxColumn.DataPropertyName = "EMailAdress";
            this.eMailAdressDataGridViewTextBoxColumn.HeaderText = "EMailAdress";
            this.eMailAdressDataGridViewTextBoxColumn.Name = "eMailAdressDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // visionTestDataGridViewTextBoxColumn
            // 
            this.visionTestDataGridViewTextBoxColumn.DataPropertyName = "VisionTest";
            this.visionTestDataGridViewTextBoxColumn.HeaderText = "VisionTest";
            this.visionTestDataGridViewTextBoxColumn.Name = "visionTestDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.BTN_SearchCustomer.Location = new System.Drawing.Point(548, 86);
            this.BTN_SearchCustomer.Name = "BTN_SearchCustomer";
            this.BTN_SearchCustomer.Size = new System.Drawing.Size(120, 47);
            this.BTN_SearchCustomer.TabIndex = 97;
            this.BTN_SearchCustomer.Text = "Søg ";
            this.BTN_SearchCustomer.UseVisualStyleBackColor = false;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // SøgKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_SearchCustomer);
            this.Controls.Add(this.DGV_Customers);
            this.Controls.Add(this.TB_SearchEMailAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_SearchPhoneNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PANEL_FindOrder);
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