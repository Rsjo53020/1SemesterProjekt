namespace SemesterProjekt.GUI
{
    partial class SletProdukt
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
            this.DGV_DeleteSelectProduct = new System.Windows.Forms.DataGridView();
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
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTable = new SemesterProjekt.ProductTable();
            this.BTN_DeleteProduct = new System.Windows.Forms.Button();
            this.BTN_DeleteFindProdukt = new System.Windows.Forms.Button();
            this.TB_DeleteFindKategory = new System.Windows.Forms.TextBox();
            this.TB_DeleteFindProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.LB_ShowProduct = new System.Windows.Forms.Label();
            this.productTableAdapter = new SemesterProjekt.ProductTableTableAdapters.ProductTableAdapter();
            this.LL_Forklaring = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DeleteSelectProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.PANEL_FindOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_DeleteSelectProduct
            // 
            this.DGV_DeleteSelectProduct.AutoGenerateColumns = false;
            this.DGV_DeleteSelectProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_DeleteSelectProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DeleteSelectProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DGV_DeleteSelectProduct.DataSource = this.productBindingSource;
            this.DGV_DeleteSelectProduct.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_DeleteSelectProduct.Location = new System.Drawing.Point(0, 471);
            this.DGV_DeleteSelectProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_DeleteSelectProduct.Name = "DGV_DeleteSelectProduct";
            this.DGV_DeleteSelectProduct.RowHeadersWidth = 82;
            this.DGV_DeleteSelectProduct.RowTemplate.Height = 33;
            this.DGV_DeleteSelectProduct.Size = new System.Drawing.Size(978, 329);
            this.DGV_DeleteSelectProduct.TabIndex = 119;
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            this.salesPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoryDataGridViewTextBoxColumn
            // 
            this.kategoryDataGridViewTextBoxColumn.DataPropertyName = "Kategory";
            this.kategoryDataGridViewTextBoxColumn.HeaderText = "Kategory";
            this.kategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoryDataGridViewTextBoxColumn.Name = "kategoryDataGridViewTextBoxColumn";
            this.kategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // vATSupDataGridViewTextBoxColumn
            // 
            this.vATSupDataGridViewTextBoxColumn.DataPropertyName = "VATSup";
            this.vATSupDataGridViewTextBoxColumn.HeaderText = "VATSup";
            this.vATSupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vATSupDataGridViewTextBoxColumn.Name = "vATSupDataGridViewTextBoxColumn";
            this.vATSupDataGridViewTextBoxColumn.Width = 125;
            // 
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.eANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            this.eANDataGridViewTextBoxColumn.ReadOnly = true;
            this.eANDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // lenghtDataGridViewTextBoxColumn
            // 
            this.lenghtDataGridViewTextBoxColumn.DataPropertyName = "Lenght";
            this.lenghtDataGridViewTextBoxColumn.HeaderText = "Lenght";
            this.lenghtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lenghtDataGridViewTextBoxColumn.Name = "lenghtDataGridViewTextBoxColumn";
            this.lenghtDataGridViewTextBoxColumn.Width = 125;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.Width = 125;
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn.HeaderText = "Kind";
            this.kindDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            this.kindDataGridViewTextBoxColumn.Width = 125;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // usedForDataGridViewTextBoxColumn
            // 
            this.usedForDataGridViewTextBoxColumn.DataPropertyName = "UsedFor";
            this.usedForDataGridViewTextBoxColumn.HeaderText = "UsedFor";
            this.usedForDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usedForDataGridViewTextBoxColumn.Name = "usedForDataGridViewTextBoxColumn";
            this.usedForDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productTableBindingSource;
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataSource = this.productTable;
            this.productTableBindingSource.Position = 0;
            // 
            // productTable
            // 
            this.productTable.DataSetName = "ProductTable";
            this.productTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTN_DeleteProduct
            // 
            this.BTN_DeleteProduct.BackColor = System.Drawing.Color.White;
            this.BTN_DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_DeleteProduct.Location = new System.Drawing.Point(454, 328);
            this.BTN_DeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_DeleteProduct.Name = "BTN_DeleteProduct";
            this.BTN_DeleteProduct.Size = new System.Drawing.Size(244, 108);
            this.BTN_DeleteProduct.TabIndex = 118;
            this.BTN_DeleteProduct.Text = "Slet Produkt";
            this.BTN_DeleteProduct.UseVisualStyleBackColor = false;
            // 
            // BTN_DeleteFindProdukt
            // 
            this.BTN_DeleteFindProdukt.BackColor = System.Drawing.Color.White;
            this.BTN_DeleteFindProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_DeleteFindProdukt.Location = new System.Drawing.Point(703, 328);
            this.BTN_DeleteFindProdukt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_DeleteFindProdukt.Name = "BTN_DeleteFindProdukt";
            this.BTN_DeleteFindProdukt.Size = new System.Drawing.Size(244, 108);
            this.BTN_DeleteFindProdukt.TabIndex = 117;
            this.BTN_DeleteFindProdukt.Text = "Vis Produkt";
            this.BTN_DeleteFindProdukt.UseVisualStyleBackColor = false;
            // 
            // TB_DeleteFindKategory
            // 
            this.TB_DeleteFindKategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_DeleteFindKategory.Location = new System.Drawing.Point(453, 242);
            this.TB_DeleteFindKategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_DeleteFindKategory.Name = "TB_DeleteFindKategory";
            this.TB_DeleteFindKategory.Size = new System.Drawing.Size(437, 43);
            this.TB_DeleteFindKategory.TabIndex = 116;
            // 
            // TB_DeleteFindProductName
            // 
            this.TB_DeleteFindProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_DeleteFindProductName.Location = new System.Drawing.Point(453, 148);
            this.TB_DeleteFindProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_DeleteFindProductName.Name = "TB_DeleteFindProductName";
            this.TB_DeleteFindProductName.Size = new System.Drawing.Size(437, 43);
            this.TB_DeleteFindProductName.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(39, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 37);
            this.label4.TabIndex = 114;
            this.label4.Text = "Kategori:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(39, 154);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(215, 37);
            this.Label2.TabIndex = 113;
            this.Label2.Text = "Produkt navn:";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(978, 118);
            this.PANEL_FindOrder.TabIndex = 112;
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(447, 49);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(273, 37);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "SLET PRODUKT";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // LL_Forklaring
            // 
            this.LL_Forklaring.AutoSize = true;
            this.LL_Forklaring.LinkColor = System.Drawing.Color.White;
            this.LL_Forklaring.Location = new System.Drawing.Point(46, 415);
            this.LL_Forklaring.Name = "LL_Forklaring";
            this.LL_Forklaring.Size = new System.Drawing.Size(79, 20);
            this.LL_Forklaring.TabIndex = 120;
            this.LL_Forklaring.TabStop = true;
            this.LL_Forklaring.Text = "Forklaring";
            this.LL_Forklaring.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Forklaring_LinkClicked);
            // 
            // SletProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(978, 792);
            this.Controls.Add(this.LL_Forklaring);
            this.Controls.Add(this.DGV_DeleteSelectProduct);
            this.Controls.Add(this.BTN_DeleteProduct);
            this.Controls.Add(this.BTN_DeleteFindProdukt);
            this.Controls.Add(this.TB_DeleteFindKategory);
            this.Controls.Add(this.TB_DeleteFindProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SletProdukt";
            this.Text = "SletProdukt";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DeleteSelectProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_DeleteSelectProduct;
        private System.Windows.Forms.Button BTN_DeleteProduct;
        private System.Windows.Forms.Button BTN_DeleteFindProdukt;
        private System.Windows.Forms.TextBox TB_DeleteFindKategory;
        private System.Windows.Forms.TextBox TB_DeleteFindProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_ShowProduct;
        private System.Windows.Forms.BindingSource productTableBindingSource;
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
        private System.Windows.Forms.LinkLabel LL_Forklaring;
    }
}