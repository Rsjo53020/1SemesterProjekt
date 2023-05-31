namespace SemesterProjekt.GUI
{
    partial class ÆndreProdukt
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
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.productTableAdapter = new SemesterProjekt.ProductTableTableAdapters.ProductTableAdapter();
            this.TB_SearchNameProduct = new System.Windows.Forms.TextBox();
            this.TB_SearchKategory = new System.Windows.Forms.TextBox();
            this.BTN_SearchProdukt = new System.Windows.Forms.Button();
            this.BTN_SletProdukt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_UpdatedNameProduct = new System.Windows.Forms.TextBox();
            this.TB_UpdatedDiscription = new System.Windows.Forms.TextBox();
            this.TB_UpdatedKategory = new System.Windows.Forms.TextBox();
            this.TB_UpdatedSalesPrice = new System.Windows.Forms.TextBox();
            this.TB_UpdatedVATSup = new System.Windows.Forms.TextBox();
            this.TB_UpdatedGender = new System.Windows.Forms.TextBox();
            this.TB_UpdatedAge = new System.Windows.Forms.TextBox();
            this.TB_UpdatedLenght = new System.Windows.Forms.TextBox();
            this.TB_UpdatedWidth = new System.Windows.Forms.TextBox();
            this.TB_UpdatedKind = new System.Windows.Forms.TextBox();
            this.TB_UpdatedStyle = new System.Windows.Forms.TextBox();
            this.TB_UpdatedColor = new System.Windows.Forms.TextBox();
            this.TB_UpdatedUsedFor = new System.Windows.Forms.TextBox();
            this.BTN_UpdateProduct = new System.Windows.Forms.Button();
            this.LL_UpdateProductForklaring = new System.Windows.Forms.LinkLabel();
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
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(213, 22);
            this.LB_ShowProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(213, 25);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "ÆNDRE PRODUKT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(260, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 92;
            this.label4.Text = "Kategori :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(16, 82);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 17);
            this.Label2.TabIndex = 91;
            this.Label2.Text = "Produkt navn :";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(578, 62);
            this.PANEL_FindOrder.TabIndex = 90;
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
            this.DGV_OpdateSelectProduct.Location = new System.Drawing.Point(19, 118);
            this.DGV_OpdateSelectProduct.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_OpdateSelectProduct.Name = "DGV_OpdateSelectProduct";
            this.DGV_OpdateSelectProduct.ReadOnly = true;
            this.DGV_OpdateSelectProduct.RowHeadersWidth = 82;
            this.DGV_OpdateSelectProduct.RowTemplate.Height = 33;
            this.DGV_OpdateSelectProduct.Size = new System.Drawing.Size(537, 143);
            this.DGV_OpdateSelectProduct.TabIndex = 97;
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            this.salesPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoryDataGridViewTextBoxColumn
            // 
            this.kategoryDataGridViewTextBoxColumn.DataPropertyName = "Kategory";
            this.kategoryDataGridViewTextBoxColumn.HeaderText = "Kategory";
            this.kategoryDataGridViewTextBoxColumn.Name = "kategoryDataGridViewTextBoxColumn";
            this.kategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vATSupDataGridViewTextBoxColumn
            // 
            this.vATSupDataGridViewTextBoxColumn.DataPropertyName = "VATSup";
            this.vATSupDataGridViewTextBoxColumn.HeaderText = "VATSup";
            this.vATSupDataGridViewTextBoxColumn.Name = "vATSupDataGridViewTextBoxColumn";
            this.vATSupDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lenghtDataGridViewTextBoxColumn
            // 
            this.lenghtDataGridViewTextBoxColumn.DataPropertyName = "Lenght";
            this.lenghtDataGridViewTextBoxColumn.HeaderText = "Lenght";
            this.lenghtDataGridViewTextBoxColumn.Name = "lenghtDataGridViewTextBoxColumn";
            this.lenghtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn.HeaderText = "Kind";
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            this.kindDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usedForDataGridViewTextBoxColumn
            // 
            this.usedForDataGridViewTextBoxColumn.DataPropertyName = "UsedFor";
            this.usedForDataGridViewTextBoxColumn.HeaderText = "UsedFor";
            this.usedForDataGridViewTextBoxColumn.Name = "usedForDataGridViewTextBoxColumn";
            this.usedForDataGridViewTextBoxColumn.ReadOnly = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(30, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 110;
            this.label8.Text = "Produkt Beskrivelse :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(30, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 108;
            this.label7.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(30, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "Salgspris :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(29, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 103;
            this.label9.Text = "Produkt Navn :";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // TB_SearchNameProduct
            // 
            this.TB_SearchNameProduct.Location = new System.Drawing.Point(127, 81);
            this.TB_SearchNameProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_SearchNameProduct.Name = "TB_SearchNameProduct";
            this.TB_SearchNameProduct.Size = new System.Drawing.Size(129, 20);
            this.TB_SearchNameProduct.TabIndex = 112;
            // 
            // TB_SearchKategory
            // 
            this.TB_SearchKategory.Location = new System.Drawing.Point(333, 84);
            this.TB_SearchKategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_SearchKategory.Name = "TB_SearchKategory";
            this.TB_SearchKategory.Size = new System.Drawing.Size(129, 20);
            this.TB_SearchKategory.TabIndex = 113;
            this.TB_SearchKategory.TextChanged += new System.EventHandler(this.TB_OpdateFindKategory_TextChanged);
            // 
            // BTN_SearchProdukt
            // 
            this.BTN_SearchProdukt.BackColor = System.Drawing.Color.White;
            this.BTN_SearchProdukt.FlatAppearance.BorderSize = 0;
            this.BTN_SearchProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SearchProdukt.Location = new System.Drawing.Point(475, 79);
            this.BTN_SearchProdukt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_SearchProdukt.Name = "BTN_SearchProdukt";
            this.BTN_SearchProdukt.Size = new System.Drawing.Size(81, 28);
            this.BTN_SearchProdukt.TabIndex = 114;
            this.BTN_SearchProdukt.Text = "Søg Produkt";
            this.BTN_SearchProdukt.UseVisualStyleBackColor = false;
            this.BTN_SearchProdukt.Click += new System.EventHandler(this.BTN_SearchProdukt_Click);
            // 
            // BTN_SletProdukt
            // 
            this.BTN_SletProdukt.BackColor = System.Drawing.Color.White;
            this.BTN_SletProdukt.FlatAppearance.BorderSize = 0;
            this.BTN_SletProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SletProdukt.Location = new System.Drawing.Point(376, 503);
            this.BTN_SletProdukt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_SletProdukt.Name = "BTN_SletProdukt";
            this.BTN_SletProdukt.Size = new System.Drawing.Size(81, 30);
            this.BTN_SletProdukt.TabIndex = 115;
            this.BTN_SletProdukt.Text = "Slet Produkt";
            this.BTN_SletProdukt.UseVisualStyleBackColor = false;
            this.BTN_SletProdukt.Click += new System.EventHandler(this.BTN_SletProdukt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(30, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 117;
            this.label5.Text = "CVR Leverandør :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(29, 450);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(30, 359);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 120;
            this.label11.Text = "Tilegnet køn :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(30, 376);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 121;
            this.label12.Text = "Tilegnet alder :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(30, 393);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 122;
            this.label13.Text = "Længde :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(29, 410);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 123;
            this.label14.Text = "Bredde :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(30, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 124;
            this.label1.Text = "Brilletype :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(33, 443);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 125;
            this.label10.Text = "Stil :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(33, 460);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 126;
            this.label16.Text = "Farve :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(33, 477);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 127;
            this.label15.Text = "Brugt til :";
            // 
            // TB_UpdatedNameProduct
            // 
            this.TB_UpdatedNameProduct.Location = new System.Drawing.Point(168, 273);
            this.TB_UpdatedNameProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedNameProduct.Name = "TB_UpdatedNameProduct";
            this.TB_UpdatedNameProduct.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedNameProduct.TabIndex = 141;
            this.TB_UpdatedNameProduct.TextChanged += new System.EventHandler(this.TB_UpdatedNameProduct_TextChanged);
            // 
            // TB_UpdatedDiscription
            // 
            this.TB_UpdatedDiscription.Location = new System.Drawing.Point(168, 291);
            this.TB_UpdatedDiscription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedDiscription.Name = "TB_UpdatedDiscription";
            this.TB_UpdatedDiscription.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedDiscription.TabIndex = 142;
            this.TB_UpdatedDiscription.TextChanged += new System.EventHandler(this.TB_UpdatedDiscription_TextChanged);
            // 
            // TB_UpdatedKategory
            // 
            this.TB_UpdatedKategory.Location = new System.Drawing.Point(168, 308);
            this.TB_UpdatedKategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedKategory.Name = "TB_UpdatedKategory";
            this.TB_UpdatedKategory.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedKategory.TabIndex = 143;
            this.TB_UpdatedKategory.TextChanged += new System.EventHandler(this.TB_UpdatedKategory_TextChanged);
            // 
            // TB_UpdatedSalesPrice
            // 
            this.TB_UpdatedSalesPrice.Location = new System.Drawing.Point(168, 325);
            this.TB_UpdatedSalesPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedSalesPrice.Name = "TB_UpdatedSalesPrice";
            this.TB_UpdatedSalesPrice.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedSalesPrice.TabIndex = 144;
            this.TB_UpdatedSalesPrice.TextChanged += new System.EventHandler(this.TB_UpdatedSalesPrice_TextChanged);
            // 
            // TB_UpdatedVATSup
            // 
            this.TB_UpdatedVATSup.Location = new System.Drawing.Point(168, 342);
            this.TB_UpdatedVATSup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedVATSup.Name = "TB_UpdatedVATSup";
            this.TB_UpdatedVATSup.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedVATSup.TabIndex = 145;
            this.TB_UpdatedVATSup.TextChanged += new System.EventHandler(this.TB_UpdatedVATSup_TextChanged);
            // 
            // TB_UpdatedGender
            // 
            this.TB_UpdatedGender.Location = new System.Drawing.Point(168, 359);
            this.TB_UpdatedGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedGender.Name = "TB_UpdatedGender";
            this.TB_UpdatedGender.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedGender.TabIndex = 146;
            this.TB_UpdatedGender.TextChanged += new System.EventHandler(this.TB_UpdatedGender_TextChanged);
            // 
            // TB_UpdatedAge
            // 
            this.TB_UpdatedAge.Location = new System.Drawing.Point(168, 376);
            this.TB_UpdatedAge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedAge.Name = "TB_UpdatedAge";
            this.TB_UpdatedAge.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedAge.TabIndex = 147;
            this.TB_UpdatedAge.TextChanged += new System.EventHandler(this.TB_UpdatedAge_TextChanged);
            // 
            // TB_UpdatedLenght
            // 
            this.TB_UpdatedLenght.Location = new System.Drawing.Point(168, 393);
            this.TB_UpdatedLenght.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedLenght.Name = "TB_UpdatedLenght";
            this.TB_UpdatedLenght.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedLenght.TabIndex = 148;
            this.TB_UpdatedLenght.TextChanged += new System.EventHandler(this.TB_UpdatedLenght_TextChanged);
            // 
            // TB_UpdatedWidth
            // 
            this.TB_UpdatedWidth.Location = new System.Drawing.Point(168, 410);
            this.TB_UpdatedWidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedWidth.Name = "TB_UpdatedWidth";
            this.TB_UpdatedWidth.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedWidth.TabIndex = 149;
            this.TB_UpdatedWidth.TextChanged += new System.EventHandler(this.TB_UpdatedWidth_TextChanged);
            // 
            // TB_UpdatedKind
            // 
            this.TB_UpdatedKind.Location = new System.Drawing.Point(168, 426);
            this.TB_UpdatedKind.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedKind.Name = "TB_UpdatedKind";
            this.TB_UpdatedKind.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedKind.TabIndex = 150;
            this.TB_UpdatedKind.TextChanged += new System.EventHandler(this.TB_UpdatedKind_TextChanged);
            // 
            // TB_UpdatedStyle
            // 
            this.TB_UpdatedStyle.Location = new System.Drawing.Point(168, 443);
            this.TB_UpdatedStyle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedStyle.Name = "TB_UpdatedStyle";
            this.TB_UpdatedStyle.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedStyle.TabIndex = 151;
            this.TB_UpdatedStyle.TextChanged += new System.EventHandler(this.TB_UpdatedStyle_TextChanged);
            // 
            // TB_UpdatedColor
            // 
            this.TB_UpdatedColor.Location = new System.Drawing.Point(168, 460);
            this.TB_UpdatedColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedColor.Name = "TB_UpdatedColor";
            this.TB_UpdatedColor.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedColor.TabIndex = 152;
            this.TB_UpdatedColor.TextChanged += new System.EventHandler(this.TB_UpdatedColor_TextChanged);
            // 
            // TB_UpdatedUsedFor
            // 
            this.TB_UpdatedUsedFor.Location = new System.Drawing.Point(168, 477);
            this.TB_UpdatedUsedFor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_UpdatedUsedFor.Name = "TB_UpdatedUsedFor";
            this.TB_UpdatedUsedFor.Size = new System.Drawing.Size(388, 20);
            this.TB_UpdatedUsedFor.TabIndex = 153;
            this.TB_UpdatedUsedFor.TextChanged += new System.EventHandler(this.TB_UpdatedUsedFor_TextChanged);
            // 
            // BTN_UpdateProduct
            // 
            this.BTN_UpdateProduct.BackColor = System.Drawing.Color.White;
            this.BTN_UpdateProduct.FlatAppearance.BorderSize = 0;
            this.BTN_UpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_UpdateProduct.Location = new System.Drawing.Point(461, 503);
            this.BTN_UpdateProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_UpdateProduct.Name = "BTN_UpdateProduct";
            this.BTN_UpdateProduct.Size = new System.Drawing.Size(95, 29);
            this.BTN_UpdateProduct.TabIndex = 154;
            this.BTN_UpdateProduct.Text = "Opdater Produkt";
            this.BTN_UpdateProduct.UseVisualStyleBackColor = false;
            this.BTN_UpdateProduct.Click += new System.EventHandler(this.BTN_UpdateProduct_Click);
            // 
            // LL_UpdateProductForklaring
            // 
            this.LL_UpdateProductForklaring.AutoSize = true;
            this.LL_UpdateProductForklaring.LinkColor = System.Drawing.Color.White;
            this.LL_UpdateProductForklaring.Location = new System.Drawing.Point(33, 511);
            this.LL_UpdateProductForklaring.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LL_UpdateProductForklaring.Name = "LL_UpdateProductForklaring";
            this.LL_UpdateProductForklaring.Size = new System.Drawing.Size(53, 13);
            this.LL_UpdateProductForklaring.TabIndex = 155;
            this.LL_UpdateProductForklaring.TabStop = true;
            this.LL_UpdateProductForklaring.Text = "Forklaring";
            // 
            // ÆndreProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(578, 541);
            this.Controls.Add(this.LL_UpdateProductForklaring);
            this.Controls.Add(this.BTN_UpdateProduct);
            this.Controls.Add(this.TB_UpdatedUsedFor);
            this.Controls.Add(this.TB_UpdatedColor);
            this.Controls.Add(this.TB_UpdatedStyle);
            this.Controls.Add(this.TB_UpdatedKind);
            this.Controls.Add(this.TB_UpdatedWidth);
            this.Controls.Add(this.TB_UpdatedLenght);
            this.Controls.Add(this.TB_UpdatedAge);
            this.Controls.Add(this.TB_UpdatedGender);
            this.Controls.Add(this.TB_UpdatedVATSup);
            this.Controls.Add(this.TB_UpdatedSalesPrice);
            this.Controls.Add(this.TB_UpdatedKategory);
            this.Controls.Add(this.TB_UpdatedDiscription);
            this.Controls.Add(this.TB_UpdatedNameProduct);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_SletProdukt);
            this.Controls.Add(this.BTN_SearchProdukt);
            this.Controls.Add(this.TB_SearchKategory);
            this.Controls.Add(this.TB_SearchNameProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DGV_OpdateSelectProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ÆndreProdukt";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.DataGridView DGV_OpdateSelectProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TextBox TB_SearchNameProduct;
        private System.Windows.Forms.TextBox TB_SearchKategory;
        private System.Windows.Forms.Button BTN_SearchProdukt;
        private System.Windows.Forms.Button BTN_SletProdukt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_UpdatedNameProduct;
        private System.Windows.Forms.TextBox TB_UpdatedDiscription;
        private System.Windows.Forms.TextBox TB_UpdatedKategory;
        private System.Windows.Forms.TextBox TB_UpdatedSalesPrice;
        private System.Windows.Forms.TextBox TB_UpdatedVATSup;
        private System.Windows.Forms.TextBox TB_UpdatedGender;
        private System.Windows.Forms.TextBox TB_UpdatedAge;
        private System.Windows.Forms.TextBox TB_UpdatedLenght;
        private System.Windows.Forms.TextBox TB_UpdatedWidth;
        private System.Windows.Forms.TextBox TB_UpdatedKind;
        private System.Windows.Forms.TextBox TB_UpdatedStyle;
        private System.Windows.Forms.TextBox TB_UpdatedColor;
        private System.Windows.Forms.TextBox TB_UpdatedUsedFor;
        private System.Windows.Forms.Button BTN_UpdateProduct;
        private System.Windows.Forms.LinkLabel LL_UpdateProductForklaring;
    }
}