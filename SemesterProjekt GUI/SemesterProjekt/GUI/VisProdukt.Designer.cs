namespace SemesterProjekt.GUI
{
    partial class VisProdukt
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
            this.LB_ShowProduct = new System.Windows.Forms.Label();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.TB_FindKategory = new System.Windows.Forms.TextBox();
            this.TB_FindProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BTN_FindProduct = new System.Windows.Forms.Button();
            this.DGV_ShowFindProduct = new System.Windows.Forms.DataGridView();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATSupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedForDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTable = new SemesterProjekt.ProductTable();
            this.productTableAdapter = new SemesterProjekt.ProductTableTableAdapters.ProductTableAdapter();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowFindProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(292, 32);
            this.LB_ShowProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(135, 26);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "Vis Produkt";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(652, 76);
            this.PANEL_FindOrder.TabIndex = 33;
            this.PANEL_FindOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_FindOrder_Paint);
            // 
            // TB_FindKategory
            // 
            this.TB_FindKategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_FindKategory.Location = new System.Drawing.Point(296, 157);
            this.TB_FindKategory.Margin = new System.Windows.Forms.Padding(2);
            this.TB_FindKategory.Name = "TB_FindKategory";
            this.TB_FindKategory.Size = new System.Drawing.Size(296, 31);
            this.TB_FindKategory.TabIndex = 88;
            // 
            // TB_FindProductName
            // 
            this.TB_FindProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_FindProductName.Location = new System.Drawing.Point(296, 95);
            this.TB_FindProductName.Margin = new System.Windows.Forms.Padding(2);
            this.TB_FindProductName.Name = "TB_FindProductName";
            this.TB_FindProductName.Size = new System.Drawing.Size(296, 31);
            this.TB_FindProductName.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Kategori:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(20, 99);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(145, 25);
            this.Label2.TabIndex = 83;
            this.Label2.Text = "Produkt navn:";
            // 
            // BTN_FindProduct
            // 
            this.BTN_FindProduct.BackColor = System.Drawing.Color.White;
            this.BTN_FindProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_FindProduct.Location = new System.Drawing.Point(418, 205);
            this.BTN_FindProduct.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_FindProduct.Name = "BTN_FindProduct";
            this.BTN_FindProduct.Size = new System.Drawing.Size(174, 63);
            this.BTN_FindProduct.TabIndex = 89;
            this.BTN_FindProduct.Text = "Søg Produkt";
            this.BTN_FindProduct.UseVisualStyleBackColor = false;
            // 
            // DGV_ShowFindProduct
            // 
            this.DGV_ShowFindProduct.AutoGenerateColumns = false;
            this.DGV_ShowFindProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_ShowFindProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowFindProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesPriceDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn,
            this.kategoryDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.vATSupDataGridViewTextBoxColumn,
            this.eANDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.lenghtDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.kindDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.usedForDataGridViewTextBoxColumn});
            this.DGV_ShowFindProduct.DataSource = this.productBindingSource;
            this.DGV_ShowFindProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_ShowFindProduct.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_ShowFindProduct.Location = new System.Drawing.Point(0, 287);
            this.DGV_ShowFindProduct.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_ShowFindProduct.Name = "DGV_ShowFindProduct";
            this.DGV_ShowFindProduct.RowHeadersWidth = 82;
            this.DGV_ShowFindProduct.RowTemplate.Height = 33;
            this.DGV_ShowFindProduct.Size = new System.Drawing.Size(652, 228);
            this.DGV_ShowFindProduct.TabIndex = 90;
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            // 
            // kategoryDataGridViewTextBoxColumn
            // 
            this.kategoryDataGridViewTextBoxColumn.DataPropertyName = "Kategory";
            this.kategoryDataGridViewTextBoxColumn.HeaderText = "Kategory";
            this.kategoryDataGridViewTextBoxColumn.Name = "kategoryDataGridViewTextBoxColumn";
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            // 
            // vATSupDataGridViewTextBoxColumn
            // 
            this.vATSupDataGridViewTextBoxColumn.DataPropertyName = "VATSup";
            this.vATSupDataGridViewTextBoxColumn.HeaderText = "VATSup";
            this.vATSupDataGridViewTextBoxColumn.Name = "vATSupDataGridViewTextBoxColumn";
            // 
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            this.eANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // lenghtDataGridViewTextBoxColumn
            // 
            this.lenghtDataGridViewTextBoxColumn.DataPropertyName = "Lenght";
            this.lenghtDataGridViewTextBoxColumn.HeaderText = "Lenght";
            this.lenghtDataGridViewTextBoxColumn.Name = "lenghtDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn.HeaderText = "Kind";
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // usedForDataGridViewTextBoxColumn
            // 
            this.usedForDataGridViewTextBoxColumn.DataPropertyName = "UsedFor";
            this.usedForDataGridViewTextBoxColumn.HeaderText = "UsedFor";
            this.usedForDataGridViewTextBoxColumn.Name = "usedForDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productTable;
            // 
            // productTable
            // 
            this.productTable.DataSetName = "ProductTable";
            this.productTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // VisProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.DGV_ShowFindProduct);
            this.Controls.Add(this.BTN_FindProduct);
            this.Controls.Add(this.TB_FindKategory);
            this.Controls.Add(this.TB_FindProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisProdukt";
            this.Text = "VisProdukt";
            this.Load += new System.EventHandler(this.VisProdukt_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowFindProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ShowProduct;
        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.TextBox TB_FindKategory;
        private System.Windows.Forms.TextBox TB_FindProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button BTN_FindProduct;
        private System.Windows.Forms.DataGridView DGV_ShowFindProduct;
        private ProductTable productTable;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductTableTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATSupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedForDataGridViewTextBoxColumn;
    }
}