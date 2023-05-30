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
            this.ordersTable = new SemesterProjekt.OrdersTable();
            this.ordersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new SemesterProjekt.OrdersTableTableAdapters.OrdersTableAdapter();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FoundOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_FoundOrder);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(800, 65);
            this.PANEL_FindOrder.TabIndex = 30;
            // 
            // LB_FoundOrder
            // 
            this.LB_FoundOrder.AutoSize = true;
            this.LB_FoundOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_FoundOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_FoundOrder.Location = new System.Drawing.Point(361, 23);
            this.LB_FoundOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_FoundOrder.Name = "LB_FoundOrder";
            this.LB_FoundOrder.Size = new System.Drawing.Size(151, 25);
            this.LB_FoundOrder.TabIndex = 16;
            this.LB_FoundOrder.Text = "Fundet Ordre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 141);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 31);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // LB_LineID
            // 
            this.LB_LineID.AutoSize = true;
            this.LB_LineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_LineID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_LineID.Location = new System.Drawing.Point(328, 90);
            this.LB_LineID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LineID.Name = "LB_LineID";
            this.LB_LineID.Size = new System.Drawing.Size(111, 25);
            this.LB_LineID.TabIndex = 27;
            this.LB_LineID.Text = "Produkter:";
            // 
            // TB_CustomerID
            // 
            this.TB_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_CustomerID.Location = new System.Drawing.Point(182, 189);
            this.TB_CustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.TB_CustomerID.Name = "TB_CustomerID";
            this.TB_CustomerID.Size = new System.Drawing.Size(259, 31);
            this.TB_CustomerID.TabIndex = 26;
            // 
            // LB_CustomerID
            // 
            this.LB_CustomerID.AutoSize = true;
            this.LB_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_CustomerID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_CustomerID.Location = new System.Drawing.Point(38, 193);
            this.LB_CustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_CustomerID.Name = "LB_CustomerID";
            this.LB_CustomerID.Size = new System.Drawing.Size(80, 25);
            this.LB_CustomerID.TabIndex = 25;
            this.LB_CustomerID.Text = "Kunde:";
            // 
            // TB_VAT
            // 
            this.TB_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_VAT.Location = new System.Drawing.Point(182, 242);
            this.TB_VAT.Margin = new System.Windows.Forms.Padding(2);
            this.TB_VAT.Name = "TB_VAT";
            this.TB_VAT.Size = new System.Drawing.Size(175, 31);
            this.TB_VAT.TabIndex = 24;
            // 
            // LB_VAT
            // 
            this.LB_VAT.AutoSize = true;
            this.LB_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_VAT.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_VAT.Location = new System.Drawing.Point(38, 245);
            this.LB_VAT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_VAT.Name = "LB_VAT";
            this.LB_VAT.Size = new System.Drawing.Size(66, 25);
            this.LB_VAT.TabIndex = 23;
            this.LB_VAT.Text = "Butik:";
            // 
            // TB_TotalPrice
            // 
            this.TB_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_TotalPrice.Location = new System.Drawing.Point(617, 396);
            this.TB_TotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TB_TotalPrice.Name = "TB_TotalPrice";
            this.TB_TotalPrice.Size = new System.Drawing.Size(175, 31);
            this.TB_TotalPrice.TabIndex = 22;
            // 
            // LB_TotalPrice
            // 
            this.LB_TotalPrice.AutoSize = true;
            this.LB_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_TotalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_TotalPrice.Location = new System.Drawing.Point(474, 401);
            this.LB_TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_TotalPrice.Name = "LB_TotalPrice";
            this.LB_TotalPrice.Size = new System.Drawing.Size(109, 25);
            this.LB_TotalPrice.TabIndex = 21;
            this.LB_TotalPrice.Text = "Pris Total:";
            // 
            // TB_OrderStatus
            // 
            this.TB_OrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OrderStatus.Location = new System.Drawing.Point(182, 292);
            this.TB_OrderStatus.Margin = new System.Windows.Forms.Padding(2);
            this.TB_OrderStatus.Name = "TB_OrderStatus";
            this.TB_OrderStatus.Size = new System.Drawing.Size(103, 31);
            this.TB_OrderStatus.TabIndex = 20;
            // 
            // LB_OrderStatus
            // 
            this.LB_OrderStatus.AutoSize = true;
            this.LB_OrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderStatus.Location = new System.Drawing.Point(38, 296);
            this.LB_OrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_OrderStatus.Name = "LB_OrderStatus";
            this.LB_OrderStatus.Size = new System.Drawing.Size(139, 25);
            this.LB_OrderStatus.TabIndex = 19;
            this.LB_OrderStatus.Text = "Ordre Status:";
            // 
            // LB_OrderDate
            // 
            this.LB_OrderDate.AutoSize = true;
            this.LB_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderDate.Location = new System.Drawing.Point(38, 145);
            this.LB_OrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_OrderDate.Name = "LB_OrderDate";
            this.LB_OrderDate.Size = new System.Drawing.Size(123, 25);
            this.LB_OrderDate.TabIndex = 18;
            this.LB_OrderDate.Text = "Ordre Dato:";
            // 
            // TB_OrderID
            // 
            this.TB_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OrderID.Location = new System.Drawing.Point(182, 90);
            this.TB_OrderID.Margin = new System.Windows.Forms.Padding(2);
            this.TB_OrderID.Name = "TB_OrderID";
            this.TB_OrderID.Size = new System.Drawing.Size(103, 31);
            this.TB_OrderID.TabIndex = 17;
            // 
            // LB_OrderID
            // 
            this.LB_OrderID.AutoSize = true;
            this.LB_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderID.Location = new System.Drawing.Point(38, 94);
            this.LB_OrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_OrderID.Name = "LB_OrderID";
            this.LB_OrderID.Size = new System.Drawing.Size(98, 25);
            this.LB_OrderID.TabIndex = 16;
            this.LB_OrderID.Text = "Ordre ID:";
            // 
            // BTN_PrintToTxt
            // 
            this.BTN_PrintToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTN_PrintToTxt.Location = new System.Drawing.Point(248, 366);
            this.BTN_PrintToTxt.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_PrintToTxt.Name = "BTN_PrintToTxt";
            this.BTN_PrintToTxt.Size = new System.Drawing.Size(216, 59);
            this.BTN_PrintToTxt.TabIndex = 31;
            this.BTN_PrintToTxt.Text = "Udskriv til .txt fil";
            this.BTN_PrintToTxt.UseVisualStyleBackColor = true;
            // 
            // BTN_UpdateOrder
            // 
            this.BTN_UpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTN_UpdateOrder.Location = new System.Drawing.Point(16, 366);
            this.BTN_UpdateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_UpdateOrder.Name = "BTN_UpdateOrder";
            this.BTN_UpdateOrder.Size = new System.Drawing.Size(216, 59);
            this.BTN_UpdateOrder.TabIndex = 32;
            this.BTN_UpdateOrder.Text = "Opdater Ordre";
            this.BTN_UpdateOrder.UseVisualStyleBackColor = true;
            // 
            // DGV_FoundOrders
            // 
            this.DGV_FoundOrders.AutoGenerateColumns = false;
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
            this.DGV_FoundOrders.Location = new System.Drawing.Point(461, 90);
            this.DGV_FoundOrders.Name = "DGV_FoundOrders";
            this.DGV_FoundOrders.Size = new System.Drawing.Size(327, 242);
            this.DGV_FoundOrders.TabIndex = 33;
            // 
            // ordersTable
            // 
            this.ordersTable.DataSetName = "OrdersTable";
            this.ordersTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableBindingSource
            // 
            this.ordersTableBindingSource.DataSource = this.ordersTable;
            this.ordersTableBindingSource.Position = 0;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.ordersTableBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "Totalprice";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "Totalprice";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // lineIDDataGridViewTextBoxColumn
            // 
            this.lineIDDataGridViewTextBoxColumn.DataPropertyName = "LineID";
            this.lineIDDataGridViewTextBoxColumn.HeaderText = "LineID";
            this.lineIDDataGridViewTextBoxColumn.Name = "lineIDDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FundetOrdre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FundetOrdre";
            this.Text = "FundetOrdre";
            this.Load += new System.EventHandler(this.FundetOrdre_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FoundOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
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
    }
}