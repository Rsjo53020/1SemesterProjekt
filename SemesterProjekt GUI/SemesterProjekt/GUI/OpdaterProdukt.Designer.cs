namespace SemesterProjekt.GUI
{
    partial class OpdaterProdukt
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
            this.BTN_OpdateFindProdukt = new System.Windows.Forms.Button();
            this.TB_OpdateFindKategory = new System.Windows.Forms.TextBox();
            this.TB_OpdateFindProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.BTN_OpdateProduct = new System.Windows.Forms.Button();
            this.DGV_OpdateSelectProduct = new System.Windows.Forms.DataGridView();
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
            this.TB_OpdateSalesPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_OpdateVATSup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_OpdatePurchasePrice = new System.Windows.Forms.TextBox();
            this.TB_OpdateDiscription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.productTableAdapter = new SemesterProjekt.ProductTableTableAdapters.ProductTableAdapter();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OpdateSelectProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(232, 20);
            this.LB_ShowProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(246, 26);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "OPDATER PRODUKT";
            // 
            // BTN_OpdateFindProdukt
            // 
            this.BTN_OpdateFindProdukt.BackColor = System.Drawing.Color.White;
            this.BTN_OpdateFindProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_OpdateFindProdukt.Location = new System.Drawing.Point(32, 192);
            this.BTN_OpdateFindProdukt.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_OpdateFindProdukt.Name = "BTN_OpdateFindProdukt";
            this.BTN_OpdateFindProdukt.Size = new System.Drawing.Size(116, 50);
            this.BTN_OpdateFindProdukt.TabIndex = 95;
            this.BTN_OpdateFindProdukt.Text = "Vis Produkt";
            this.BTN_OpdateFindProdukt.UseVisualStyleBackColor = false;
            // 
            // TB_OpdateFindKategory
            // 
            this.TB_OpdateFindKategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateFindKategory.Location = new System.Drawing.Point(176, 134);
            this.TB_OpdateFindKategory.Margin = new System.Windows.Forms.Padding(2);
            this.TB_OpdateFindKategory.Name = "TB_OpdateFindKategory";
            this.TB_OpdateFindKategory.Size = new System.Drawing.Size(122, 31);
            this.TB_OpdateFindKategory.TabIndex = 94;
            // 
            // TB_OpdateFindProductName
            // 
            this.TB_OpdateFindProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateFindProductName.Location = new System.Drawing.Point(176, 72);
            this.TB_OpdateFindProductName.Margin = new System.Windows.Forms.Padding(2);
            this.TB_OpdateFindProductName.Name = "TB_OpdateFindProductName";
            this.TB_OpdateFindProductName.Size = new System.Drawing.Size(122, 31);
            this.TB_OpdateFindProductName.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "Kategori:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(27, 72);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(145, 25);
            this.Label2.TabIndex = 91;
            this.Label2.Text = "Produkt navn:";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(652, 62);
            this.PANEL_FindOrder.TabIndex = 90;
            // 
            // BTN_OpdateProduct
            // 
            this.BTN_OpdateProduct.BackColor = System.Drawing.Color.White;
            this.BTN_OpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_OpdateProduct.Location = new System.Drawing.Point(436, 426);
            this.BTN_OpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_OpdateProduct.Name = "BTN_OpdateProduct";
            this.BTN_OpdateProduct.Size = new System.Drawing.Size(208, 44);
            this.BTN_OpdateProduct.TabIndex = 96;
            this.BTN_OpdateProduct.Text = "Opdater Produkt";
            this.BTN_OpdateProduct.UseVisualStyleBackColor = false;
            // 
            // DGV_OpdateSelectProduct
            // 
            this.DGV_OpdateSelectProduct.AutoGenerateColumns = false;
            this.DGV_OpdateSelectProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_OpdateSelectProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OpdateSelectProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DGV_OpdateSelectProduct.DataSource = this.productBindingSource;
            this.DGV_OpdateSelectProduct.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_OpdateSelectProduct.Location = new System.Drawing.Point(303, 72);
            this.DGV_OpdateSelectProduct.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_OpdateSelectProduct.Name = "DGV_OpdateSelectProduct";
            this.DGV_OpdateSelectProduct.RowHeadersWidth = 82;
            this.DGV_OpdateSelectProduct.RowTemplate.Height = 33;
            this.DGV_OpdateSelectProduct.Size = new System.Drawing.Size(341, 191);
            this.DGV_OpdateSelectProduct.TabIndex = 97;
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
            // TB_OpdateSalesPrice
            // 
            this.TB_OpdateSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateSalesPrice.Location = new System.Drawing.Point(303, 391);
            this.TB_OpdateSalesPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TB_OpdateSalesPrice.Name = "TB_OpdateSalesPrice";
            this.TB_OpdateSalesPrice.Size = new System.Drawing.Size(122, 31);
            this.TB_OpdateSalesPrice.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(27, 394);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 110;
            this.label8.Text = "Indkøbspris :";
            // 
            // TB_OpdateVATSup
            // 
            this.TB_OpdateVATSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateVATSup.Location = new System.Drawing.Point(303, 440);
            this.TB_OpdateVATSup.Margin = new System.Windows.Forms.Padding(2);
            this.TB_OpdateVATSup.Name = "TB_OpdateVATSup";
            this.TB_OpdateVATSup.Size = new System.Drawing.Size(122, 31);
            this.TB_OpdateVATSup.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(27, 444);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 108;
            this.label7.Text = "CVR leverandør:";
            // 
            // TB_OpdatePurchasePrice
            // 
            this.TB_OpdatePurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdatePurchasePrice.Location = new System.Drawing.Point(303, 340);
            this.TB_OpdatePurchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.TB_OpdatePurchasePrice.Name = "TB_OpdatePurchasePrice";
            this.TB_OpdatePurchasePrice.Size = new System.Drawing.Size(122, 31);
            this.TB_OpdatePurchasePrice.TabIndex = 107;
            // 
            // TB_OpdateDiscription
            // 
            this.TB_OpdateDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateDiscription.Location = new System.Drawing.Point(303, 291);
            this.TB_OpdateDiscription.Margin = new System.Windows.Forms.Padding(2);
            this.TB_OpdateDiscription.Name = "TB_OpdateDiscription";
            this.TB_OpdateDiscription.Size = new System.Drawing.Size(122, 31);
            this.TB_OpdateDiscription.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(27, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Produkt Beskrivelse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(27, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 103;
            this.label9.Text = "Indkøbspris";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // OpdaterProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.TB_OpdateSalesPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_OpdateVATSup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_OpdatePurchasePrice);
            this.Controls.Add(this.TB_OpdateDiscription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DGV_OpdateSelectProduct);
            this.Controls.Add(this.BTN_OpdateProduct);
            this.Controls.Add(this.BTN_OpdateFindProdukt);
            this.Controls.Add(this.TB_OpdateFindKategory);
            this.Controls.Add(this.TB_OpdateFindProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OpdaterProdukt";
            this.Text = "OpdaterProdukt";
            this.Load += new System.EventHandler(this.OpdaterProdukt_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OpdateSelectProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ShowProduct;
        private System.Windows.Forms.Button BTN_OpdateFindProdukt;
        private System.Windows.Forms.TextBox TB_OpdateFindKategory;
        private System.Windows.Forms.TextBox TB_OpdateFindProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Button BTN_OpdateProduct;
        private System.Windows.Forms.DataGridView DGV_OpdateSelectProduct;
        private System.Windows.Forms.TextBox TB_OpdateSalesPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_OpdateVATSup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_OpdatePurchasePrice;
        private System.Windows.Forms.TextBox TB_OpdateDiscription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
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
    }
}