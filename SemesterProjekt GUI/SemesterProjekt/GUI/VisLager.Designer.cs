namespace SemesterProjekt.GUI
{
    partial class VisLager
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
            this.LB_ShowStock = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storeStockTable = new SemesterProjekt.StoreStockTable();
            this.storeStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeStockTableAdapter = new SemesterProjekt.StoreStockTableTableAdapters.StoreStockTableAdapter();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeStockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowStock);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(652, 65);
            this.PANEL_FindOrder.TabIndex = 31;
            // 
            // LB_ShowStock
            // 
            this.LB_ShowStock.AutoSize = true;
            this.LB_ShowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowStock.Location = new System.Drawing.Point(290, 23);
            this.LB_ShowStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowStock.Name = "LB_ShowStock";
            this.LB_ShowStock.Size = new System.Drawing.Size(112, 25);
            this.LB_ShowStock.TabIndex = 16;
            this.LB_ShowStock.Text = "Vis Lager";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vATDataGridViewTextBoxColumn,
            this.amountOfProductDataGridViewTextBoxColumn,
            this.eANDataGridViewTextBoxColumn,
            this.storeStockIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storeStockBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(652, 450);
            this.dataGridView1.TabIndex = 32;
            // 
            // storeStockTable
            // 
            this.storeStockTable.DataSetName = "StoreStockTable";
            this.storeStockTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeStockBindingSource
            // 
            this.storeStockBindingSource.DataMember = "StoreStock";
            this.storeStockBindingSource.DataSource = this.storeStockTable;
            // 
            // storeStockTableAdapter
            // 
            this.storeStockTableAdapter.ClearBeforeFill = true;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            // 
            // amountOfProductDataGridViewTextBoxColumn
            // 
            this.amountOfProductDataGridViewTextBoxColumn.DataPropertyName = "AmountOfProduct";
            this.amountOfProductDataGridViewTextBoxColumn.HeaderText = "AmountOfProduct";
            this.amountOfProductDataGridViewTextBoxColumn.Name = "amountOfProductDataGridViewTextBoxColumn";
            // 
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            // 
            // storeStockIDDataGridViewTextBoxColumn
            // 
            this.storeStockIDDataGridViewTextBoxColumn.DataPropertyName = "StoreStockID";
            this.storeStockIDDataGridViewTextBoxColumn.HeaderText = "StoreStockID";
            this.storeStockIDDataGridViewTextBoxColumn.Name = "storeStockIDDataGridViewTextBoxColumn";
            this.storeStockIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VisLager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VisLager";
            this.Text = "VisLager";
            this.Load += new System.EventHandler(this.VisLager_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_ShowStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StoreStockTable storeStockTable;
        private System.Windows.Forms.BindingSource storeStockBindingSource;
        private StoreStockTableTableAdapters.StoreStockTableAdapter storeStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeStockIDDataGridViewTextBoxColumn;
    }
}