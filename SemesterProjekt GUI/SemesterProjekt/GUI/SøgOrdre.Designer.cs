namespace SemesterProjekt.GUI
{
    partial class SøgOrdre
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
            this.LB_FindOrder = new System.Windows.Forms.Label();
            this.DTP_EndDate = new System.Windows.Forms.DateTimePicker();
            this.DTP_StartDate = new System.Windows.Forms.DateTimePicker();
            this.DGV_ShowOrder = new System.Windows.Forms.DataGridView();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTable = new SemesterProjekt.OrdersTable();
            this.BTN_SearchOrder = new System.Windows.Forms.Button();
            this.BTN_DeleteOrder = new System.Windows.Forms.Button();
            this.BTN_UpdateOrder = new System.Windows.Forms.Button();
            this.LL_Forklaring = new System.Windows.Forms.LinkLabel();
            this.ordersTableAdapter = new SemesterProjekt.OrdersTableTableAdapters.OrdersTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_FindOrder);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(652, 65);
            this.PANEL_FindOrder.TabIndex = 31;
            // 
            // LB_FindOrder
            // 
            this.LB_FindOrder.AutoSize = true;
            this.LB_FindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_FindOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_FindOrder.Location = new System.Drawing.Point(263, 23);
            this.LB_FindOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_FindOrder.Name = "LB_FindOrder";
            this.LB_FindOrder.Size = new System.Drawing.Size(148, 25);
            this.LB_FindOrder.TabIndex = 16;
            this.LB_FindOrder.Text = "SØG ORDRE";
            // 
            // DTP_EndDate
            // 
            this.DTP_EndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DTP_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DTP_EndDate.Location = new System.Drawing.Point(169, 124);
            this.DTP_EndDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DTP_EndDate.Name = "DTP_EndDate";
            this.DTP_EndDate.Size = new System.Drawing.Size(213, 23);
            this.DTP_EndDate.TabIndex = 33;
            // 
            // DTP_StartDate
            // 
            this.DTP_StartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DTP_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DTP_StartDate.Location = new System.Drawing.Point(169, 92);
            this.DTP_StartDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DTP_StartDate.Name = "DTP_StartDate";
            this.DTP_StartDate.Size = new System.Drawing.Size(213, 23);
            this.DTP_StartDate.TabIndex = 35;
            // 
            // DGV_ShowOrder
            // 
            this.DGV_ShowOrder.AutoGenerateColumns = false;
            this.DGV_ShowOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_ShowOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDateDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.lineIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn});
            this.DGV_ShowOrder.DataSource = this.ordersBindingSource;
            this.DGV_ShowOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_ShowOrder.Location = new System.Drawing.Point(0, 168);
            this.DGV_ShowOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DGV_ShowOrder.Name = "DGV_ShowOrder";
            this.DGV_ShowOrder.RowHeadersWidth = 62;
            this.DGV_ShowOrder.RowTemplate.Height = 28;
            this.DGV_ShowOrder.Size = new System.Drawing.Size(652, 347);
            this.DGV_ShowOrder.TabIndex = 37;
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
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.ordersTable;
            // 
            // ordersTable
            // 
            this.ordersTable.DataSetName = "OrdersTable";
            this.ordersTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTN_SearchOrder
            // 
            this.BTN_SearchOrder.BackColor = System.Drawing.Color.White;
            this.BTN_SearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_SearchOrder.Location = new System.Drawing.Point(395, 117);
            this.BTN_SearchOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BTN_SearchOrder.Name = "BTN_SearchOrder";
            this.BTN_SearchOrder.Size = new System.Drawing.Size(81, 30);
            this.BTN_SearchOrder.TabIndex = 38;
            this.BTN_SearchOrder.Text = "Søg ";
            this.BTN_SearchOrder.UseVisualStyleBackColor = false;
            // 
            // BTN_DeleteOrder
            // 
            this.BTN_DeleteOrder.BackColor = System.Drawing.Color.White;
            this.BTN_DeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_DeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_DeleteOrder.Location = new System.Drawing.Point(565, 117);
            this.BTN_DeleteOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BTN_DeleteOrder.Name = "BTN_DeleteOrder";
            this.BTN_DeleteOrder.Size = new System.Drawing.Size(82, 30);
            this.BTN_DeleteOrder.TabIndex = 39;
            this.BTN_DeleteOrder.Text = "Slet ";
            this.BTN_DeleteOrder.UseVisualStyleBackColor = false;
            // 
            // BTN_UpdateOrder
            // 
            this.BTN_UpdateOrder.BackColor = System.Drawing.Color.White;
            this.BTN_UpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_UpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_UpdateOrder.Location = new System.Drawing.Point(480, 117);
            this.BTN_UpdateOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BTN_UpdateOrder.Name = "BTN_UpdateOrder";
            this.BTN_UpdateOrder.Size = new System.Drawing.Size(81, 30);
            this.BTN_UpdateOrder.TabIndex = 40;
            this.BTN_UpdateOrder.Text = "Opdater ";
            this.BTN_UpdateOrder.UseVisualStyleBackColor = false;
            // 
            // LL_Forklaring
            // 
            this.LL_Forklaring.AutoSize = true;
            this.LL_Forklaring.LinkColor = System.Drawing.Color.White;
            this.LL_Forklaring.Location = new System.Drawing.Point(24, 458);
            this.LL_Forklaring.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LL_Forklaring.Name = "LL_Forklaring";
            this.LL_Forklaring.Size = new System.Drawing.Size(53, 13);
            this.LL_Forklaring.TabIndex = 87;
            this.LL_Forklaring.TabStop = true;
            this.LL_Forklaring.Text = "Forklaring";
            this.LL_Forklaring.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Forklaring_LinkClicked);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(10, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 104;
            this.label9.Text = "Ordre Dato Start :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(10, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Ordre Dato Slut :";
            // 
            // SøgOrdre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LL_Forklaring);
            this.Controls.Add(this.BTN_UpdateOrder);
            this.Controls.Add(this.BTN_DeleteOrder);
            this.Controls.Add(this.BTN_SearchOrder);
            this.Controls.Add(this.DGV_ShowOrder);
            this.Controls.Add(this.DTP_StartDate);
            this.Controls.Add(this.DTP_EndDate);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "SøgOrdre";
            this.Text = "SøgOrdre";
            this.Load += new System.EventHandler(this.SøgOrdre_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_FindOrder;
        private System.Windows.Forms.DateTimePicker DTP_EndDate;
        private System.Windows.Forms.DateTimePicker DTP_StartDate;
        private System.Windows.Forms.DataGridView DGV_ShowOrder;
        private System.Windows.Forms.Button BTN_SearchOrder;
        private System.Windows.Forms.Button BTN_DeleteOrder;
        private System.Windows.Forms.Button BTN_UpdateOrder;
        private System.Windows.Forms.LinkLabel LL_Forklaring;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}