namespace SemesterProjekt.GUI
{
    partial class FundetOrdre
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
            this.LB_FoundOrder = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LB_LineID = new System.Windows.Forms.Label();
            this.TB_CustomerID = new System.Windows.Forms.TextBox();
            this.LB_CustomerID = new System.Windows.Forms.Label();
            this.TB_VAT = new System.Windows.Forms.TextBox();
            this.LB_VAT = new System.Windows.Forms.Label();
            this.TB_TotalPrice = new System.Windows.Forms.TextBox();
            this.LB_TotalPrice = new System.Windows.Forms.Label();
            this.TB_OrderStatus = new System.Windows.Forms.TextBox();
            this.LB_OrderStatus = new System.Windows.Forms.Label();
            this.LB_OrderDate = new System.Windows.Forms.Label();
            this.TB_OrderID = new System.Windows.Forms.TextBox();
            this.LB_OrderID = new System.Windows.Forms.Label();
            this.BTN_PrintToTxt = new System.Windows.Forms.Button();
            this.BTN_UpdateOrder = new System.Windows.Forms.Button();
            this.DGV_FoundOrders = new System.Windows.Forms.DataGridView();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTable = new SemesterProjekt.OrdersTable();
            this.ordersTableAdapter = new SemesterProjekt.OrdersTableTableAdapters.OrdersTableAdapter();
            this.LL_Forklaring = new System.Windows.Forms.LinkLabel();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FoundOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_FoundOrder);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(1200, 100);
            this.PANEL_FindOrder.TabIndex = 30;
            // 
            // LB_FoundOrder
            // 
            this.LB_FoundOrder.AutoSize = true;
            this.LB_FoundOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_FoundOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_FoundOrder.Location = new System.Drawing.Point(542, 35);
            this.LB_FoundOrder.Name = "LB_FoundOrder";
            this.LB_FoundOrder.Size = new System.Drawing.Size(220, 37);
            this.LB_FoundOrder.TabIndex = 16;
            this.LB_FoundOrder.Text = "Fundet Ordre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 43);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // LB_LineID
            // 
            this.LB_LineID.AutoSize = true;
            this.LB_LineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_LineID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_LineID.Location = new System.Drawing.Point(492, 138);
            this.LB_LineID.Name = "LB_LineID";
            this.LB_LineID.Size = new System.Drawing.Size(165, 37);
            this.LB_LineID.TabIndex = 27;
            this.LB_LineID.Text = "Produkter:";
            // 
            // TB_CustomerID
            // 
            this.TB_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_CustomerID.Location = new System.Drawing.Point(273, 291);
            this.TB_CustomerID.Name = "TB_CustomerID";
            this.TB_CustomerID.Size = new System.Drawing.Size(386, 43);
            this.TB_CustomerID.TabIndex = 26;
            // 
            // LB_CustomerID
            // 
            this.LB_CustomerID.AutoSize = true;
            this.LB_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_CustomerID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_CustomerID.Location = new System.Drawing.Point(57, 297);
            this.LB_CustomerID.Name = "LB_CustomerID";
            this.LB_CustomerID.Size = new System.Drawing.Size(118, 37);
            this.LB_CustomerID.TabIndex = 25;
            this.LB_CustomerID.Text = "Kunde:";
            // 
            // TB_VAT
            // 
            this.TB_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_VAT.Location = new System.Drawing.Point(273, 372);
            this.TB_VAT.Name = "TB_VAT";
            this.TB_VAT.Size = new System.Drawing.Size(260, 43);
            this.TB_VAT.TabIndex = 24;
            // 
            // LB_VAT
            // 
            this.LB_VAT.AutoSize = true;
            this.LB_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_VAT.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_VAT.Location = new System.Drawing.Point(57, 377);
            this.LB_VAT.Name = "LB_VAT";
            this.LB_VAT.Size = new System.Drawing.Size(97, 37);
            this.LB_VAT.TabIndex = 23;
            this.LB_VAT.Text = "Butik:";
            // 
            // TB_TotalPrice
            // 
            this.TB_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_TotalPrice.Location = new System.Drawing.Point(926, 609);
            this.TB_TotalPrice.Name = "TB_TotalPrice";
            this.TB_TotalPrice.Size = new System.Drawing.Size(260, 43);
            this.TB_TotalPrice.TabIndex = 22;
            // 
            // LB_TotalPrice
            // 
            this.LB_TotalPrice.AutoSize = true;
            this.LB_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_TotalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_TotalPrice.Location = new System.Drawing.Point(711, 617);
            this.LB_TotalPrice.Name = "LB_TotalPrice";
            this.LB_TotalPrice.Size = new System.Drawing.Size(162, 37);
            this.LB_TotalPrice.TabIndex = 21;
            this.LB_TotalPrice.Text = "Pris Total:";
            // 
            // TB_OrderStatus
            // 
            this.TB_OrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OrderStatus.Location = new System.Drawing.Point(273, 449);
            this.TB_OrderStatus.Name = "TB_OrderStatus";
            this.TB_OrderStatus.Size = new System.Drawing.Size(152, 43);
            this.TB_OrderStatus.TabIndex = 20;
            // 
            // LB_OrderStatus
            // 
            this.LB_OrderStatus.AutoSize = true;
            this.LB_OrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderStatus.Location = new System.Drawing.Point(57, 455);
            this.LB_OrderStatus.Name = "LB_OrderStatus";
            this.LB_OrderStatus.Size = new System.Drawing.Size(208, 37);
            this.LB_OrderStatus.TabIndex = 19;
            this.LB_OrderStatus.Text = "Ordre Status:";
            // 
            // LB_OrderDate
            // 
            this.LB_OrderDate.AutoSize = true;
            this.LB_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderDate.Location = new System.Drawing.Point(57, 223);
            this.LB_OrderDate.Name = "LB_OrderDate";
            this.LB_OrderDate.Size = new System.Drawing.Size(185, 37);
            this.LB_OrderDate.TabIndex = 18;
            this.LB_OrderDate.Text = "Ordre Dato:";
            // 
            // TB_OrderID
            // 
            this.TB_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OrderID.Location = new System.Drawing.Point(273, 138);
            this.TB_OrderID.Name = "TB_OrderID";
            this.TB_OrderID.Size = new System.Drawing.Size(152, 43);
            this.TB_OrderID.TabIndex = 17;
            // 
            // LB_OrderID
            // 
            this.LB_OrderID.AutoSize = true;
            this.LB_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderID.Location = new System.Drawing.Point(57, 145);
            this.LB_OrderID.Name = "LB_OrderID";
            this.LB_OrderID.Size = new System.Drawing.Size(148, 37);
            this.LB_OrderID.TabIndex = 16;
            this.LB_OrderID.Text = "Ordre ID:";
            // 
            // BTN_PrintToTxt
            // 
            this.BTN_PrintToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTN_PrintToTxt.Location = new System.Drawing.Point(372, 563);
            this.BTN_PrintToTxt.Name = "BTN_PrintToTxt";
            this.BTN_PrintToTxt.Size = new System.Drawing.Size(324, 91);
            this.BTN_PrintToTxt.TabIndex = 31;
            this.BTN_PrintToTxt.Text = "Udskriv til .txt fil";
            this.BTN_PrintToTxt.UseVisualStyleBackColor = true;
            // 
            // BTN_UpdateOrder
            // 
            this.BTN_UpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTN_UpdateOrder.Location = new System.Drawing.Point(24, 563);
            this.BTN_UpdateOrder.Name = "BTN_UpdateOrder";
            this.BTN_UpdateOrder.Size = new System.Drawing.Size(324, 91);
            this.BTN_UpdateOrder.TabIndex = 32;
            this.BTN_UpdateOrder.Text = "Opdater Ordre";
            this.BTN_UpdateOrder.UseVisualStyleBackColor = true;
            // 
            // DGV_FoundOrders
            // 
            this.DGV_FoundOrders.AutoGenerateColumns = false;
            this.DGV_FoundOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_FoundOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_FoundOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDateDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.lineIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn});
            this.DGV_FoundOrders.DataSource = this.ordersBindingSource;
            this.DGV_FoundOrders.Location = new System.Drawing.Point(692, 138);
            this.DGV_FoundOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_FoundOrders.Name = "DGV_FoundOrders";
            this.DGV_FoundOrders.RowHeadersWidth = 62;
            this.DGV_FoundOrders.Size = new System.Drawing.Size(490, 372);
            this.DGV_FoundOrders.TabIndex = 33;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "Totalprice";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "Totalprice";
            this.totalpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            this.vATDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // lineIDDataGridViewTextBoxColumn
            // 
            this.lineIDDataGridViewTextBoxColumn.DataPropertyName = "LineID";
            this.lineIDDataGridViewTextBoxColumn.HeaderText = "LineID";
            this.lineIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lineIDDataGridViewTextBoxColumn.Name = "lineIDDataGridViewTextBoxColumn";
            this.lineIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.ordersTableBindingSource;
            // 
            // ordersTableBindingSource
            // 
            this.ordersTableBindingSource.DataSource = this.ordersTable;
            this.ordersTableBindingSource.Position = 0;
            // 
            // ordersTable
            // 
            this.ordersTable.DataSetName = "OrdersTable";
            this.ordersTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // LL_Forklaring
            // 
            this.LL_Forklaring.AutoSize = true;
            this.LL_Forklaring.LinkColor = System.Drawing.Color.White;
            this.LL_Forklaring.Location = new System.Drawing.Point(1056, 563);
            this.LL_Forklaring.Name = "LL_Forklaring";
            this.LL_Forklaring.Size = new System.Drawing.Size(79, 20);
            this.LL_Forklaring.TabIndex = 34;
            this.LL_Forklaring.TabStop = true;
            this.LL_Forklaring.Text = "Forklaring";
            this.LL_Forklaring.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Forklaring_LinkClicked);
            // 
            // FundetOrdre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.LL_Forklaring);
            this.Controls.Add(this.DGV_FoundOrders);
            this.Controls.Add(this.BTN_UpdateOrder);
            this.Controls.Add(this.BTN_PrintToTxt);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LB_LineID);
            this.Controls.Add(this.TB_CustomerID);
            this.Controls.Add(this.LB_CustomerID);
            this.Controls.Add(this.TB_VAT);
            this.Controls.Add(this.LB_VAT);
            this.Controls.Add(this.TB_TotalPrice);
            this.Controls.Add(this.LB_TotalPrice);
            this.Controls.Add(this.TB_OrderStatus);
            this.Controls.Add(this.LB_OrderStatus);
            this.Controls.Add(this.LB_OrderDate);
            this.Controls.Add(this.TB_OrderID);
            this.Controls.Add(this.LB_OrderID);
            this.Name = "FundetOrdre";
            this.Text = "FundetOrdre";
            this.Load += new System.EventHandler(this.FundetOrdre_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FoundOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_FoundOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LB_LineID;
        private System.Windows.Forms.TextBox TB_CustomerID;
        private System.Windows.Forms.Label LB_CustomerID;
        private System.Windows.Forms.TextBox TB_VAT;
        private System.Windows.Forms.Label LB_VAT;
        private System.Windows.Forms.TextBox TB_TotalPrice;
        private System.Windows.Forms.Label LB_TotalPrice;
        private System.Windows.Forms.TextBox TB_OrderStatus;
        private System.Windows.Forms.Label LB_OrderStatus;
        private System.Windows.Forms.Label LB_OrderDate;
        private System.Windows.Forms.TextBox TB_OrderID;
        private System.Windows.Forms.Label LB_OrderID;
        private System.Windows.Forms.Button BTN_PrintToTxt;
        private System.Windows.Forms.Button BTN_UpdateOrder;
        private System.Windows.Forms.DataGridView DGV_FoundOrders;
        private System.Windows.Forms.BindingSource ordersTableBindingSource;
        private OrdersTable ordersTable;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrdersTableTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel LL_Forklaring;
    }
}