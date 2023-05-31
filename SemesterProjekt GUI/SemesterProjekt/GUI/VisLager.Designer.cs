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
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cskafte_dk_db_skafteDataSet2 = new SemesterProjekt.cskafte_dk_db_skafteDataSet2();
            this.storeStockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cskafte_dk_db_skafteDataSet = new SemesterProjekt.cskafte_dk_db_skafteDataSet();
            this.storeStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeStockTable = new SemesterProjekt.StoreStockTable();
            this.storeStockTableAdapter = new SemesterProjekt.StoreStockTableTableAdapters.StoreStockTableAdapter();
            this.BTN_CreateTXTFile = new System.Windows.Forms.Button();
            this.storeStockTableAdapter1 = new SemesterProjekt.cskafte_dk_db_skafteDataSetTableAdapters.StoreStockTableAdapter();
            this.cskafte_dk_db_skafteDataSet1 = new SemesterProjekt.cskafte_dk_db_skafteDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new SemesterProjekt.cskafte_dk_db_skafteDataSet1TableAdapters.ProductTableAdapter();
            this.productTableAdapter1 = new SemesterProjekt.cskafte_dk_db_skafteDataSet2TableAdapters.ProductTableAdapter();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cskafte_dk_db_skafteDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cskafte_dk_db_skafteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cskafte_dk_db_skafteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowStock);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(540, 65);
            this.PANEL_FindOrder.TabIndex = 31;
            // 
            // LB_ShowStock
            // 
            this.LB_ShowStock.AutoSize = true;
            this.LB_ShowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowStock.Location = new System.Drawing.Point(168, 19);
            this.LB_ShowStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowStock.Name = "LB_ShowStock";
            this.LB_ShowStock.Size = new System.Drawing.Size(242, 25);
            this.LB_ShowStock.TabIndex = 16;
            this.LB_ShowStock.Text = "LAGER BEHOLDNING";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eANDataGridViewTextBoxColumn,
            this.SalesPrice,
            this.NameProduct,
            this.Discription,
            this.Kategory,
            this.PurchasePrice,
            this.VATSup,
            this.Gender,
            this.Age,
            this.Lenght,
            this.Width,
            this.Kind,
            this.Style,
            this.Color,
            this.UsedFor});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(540, 460);
            this.dataGridView1.TabIndex = 32;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.cskafte_dk_db_skafteDataSet2;
            // 
            // cskafte_dk_db_skafteDataSet2
            // 
            this.cskafte_dk_db_skafteDataSet2.DataSetName = "cskafte_dk_db_skafteDataSet2";
            this.cskafte_dk_db_skafteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeStockBindingSource1
            // 
            this.storeStockBindingSource1.DataMember = "StoreStock";
            this.storeStockBindingSource1.DataSource = this.cskafte_dk_db_skafteDataSet;
            // 
            // cskafte_dk_db_skafteDataSet
            // 
            this.cskafte_dk_db_skafteDataSet.DataSetName = "cskafte_dk_db_skafteDataSet";
            this.cskafte_dk_db_skafteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeStockBindingSource
            // 
            this.storeStockBindingSource.DataMember = "StoreStock";
            this.storeStockBindingSource.DataSource = this.storeStockTable;
            // 
            // storeStockTable
            // 
            this.storeStockTable.DataSetName = "StoreStockTable";
            this.storeStockTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeStockTableAdapter
            // 
            this.storeStockTableAdapter.ClearBeforeFill = true;
            // 
            // BTN_CreateTXTFile
            // 
            this.BTN_CreateTXTFile.BackColor = System.Drawing.Color.White;
            this.BTN_CreateTXTFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CreateTXTFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_CreateTXTFile.Location = new System.Drawing.Point(432, 461);
            this.BTN_CreateTXTFile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BTN_CreateTXTFile.Name = "BTN_CreateTXTFile";
            this.BTN_CreateTXTFile.Size = new System.Drawing.Size(81, 30);
            this.BTN_CreateTXTFile.TabIndex = 107;
            this.BTN_CreateTXTFile.Text = "Udskriv";
            this.BTN_CreateTXTFile.UseVisualStyleBackColor = false;
            this.BTN_CreateTXTFile.Click += new System.EventHandler(this.BTN_CreateTXTFile_Click);
            // 
            // storeStockTableAdapter1
            // 
            this.storeStockTableAdapter1.ClearBeforeFill = true;
            // 
            // cskafte_dk_db_skafteDataSet1
            // 
            this.cskafte_dk_db_skafteDataSet1.DataSetName = "cskafte_dk_db_skafteDataSet1";
            this.cskafte_dk_db_skafteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.cskafte_dk_db_skafteDataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
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
            // SalesPrice
            // 
            this.SalesPrice.DataPropertyName = "SalesPrice";
            this.SalesPrice.HeaderText = "SalesPrice";
            this.SalesPrice.Name = "SalesPrice";
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "NameProduct";
            this.NameProduct.HeaderText = "NameProduct";
            this.NameProduct.Name = "NameProduct";
            // 
            // Discription
            // 
            this.Discription.DataPropertyName = "Discription";
            this.Discription.HeaderText = "Discription";
            this.Discription.Name = "Discription";
            // 
            // Kategory
            // 
            this.Kategory.DataPropertyName = "Kategory";
            this.Kategory.HeaderText = "Kategory";
            this.Kategory.Name = "Kategory";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // VATSup
            // 
            this.VATSup.DataPropertyName = "VATSup";
            this.VATSup.HeaderText = "VATSup";
            this.VATSup.Name = "VATSup";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Lenght
            // 
            this.Lenght.DataPropertyName = "Lenght";
            this.Lenght.HeaderText = "Lenght";
            this.Lenght.Name = "Lenght";
            // 
            // Width
            // 
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Kind
            // 
            this.Kind.DataPropertyName = "Kind";
            this.Kind.HeaderText = "Kind";
            this.Kind.Name = "Kind";
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // UsedFor
            // 
            this.UsedFor.DataPropertyName = "UsedFor";
            this.UsedFor.HeaderText = "UsedFor";
            this.UsedFor.Name = "UsedFor";
            // 
            // VisLager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(540, 525);
            this.Controls.Add(this.BTN_CreateTXTFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisLager";
            this.Text = "VisLager";
            this.Load += new System.EventHandler(this.VisLager_Load);
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cskafte_dk_db_skafteDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cskafte_dk_db_skafteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeStockTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cskafte_dk_db_skafteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_ShowStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StoreStockTable storeStockTable;
        private System.Windows.Forms.BindingSource storeStockBindingSource;
        private StoreStockTableTableAdapters.StoreStockTableAdapter storeStockTableAdapter;
        private System.Windows.Forms.Button BTN_CreateTXTFile;
        private cskafte_dk_db_skafteDataSet cskafte_dk_db_skafteDataSet;
        private System.Windows.Forms.BindingSource storeStockBindingSource1;
        private cskafte_dk_db_skafteDataSetTableAdapters.StoreStockTableAdapter storeStockTableAdapter1;
        private cskafte_dk_db_skafteDataSet1 cskafte_dk_db_skafteDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private cskafte_dk_db_skafteDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private cskafte_dk_db_skafteDataSet2 cskafte_dk_db_skafteDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private cskafte_dk_db_skafteDataSet2TableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedFor;
    }
}