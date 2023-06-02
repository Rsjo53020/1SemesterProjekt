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
            this.DGV_Product = new System.Windows.Forms.DataGridView();
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
            this.TB_UpdatedLength = new System.Windows.Forms.TextBox();
            this.TB_UpdatedWidth = new System.Windows.Forms.TextBox();
            this.TB_UpdatedKind = new System.Windows.Forms.TextBox();
            this.TB_UpdatedStyle = new System.Windows.Forms.TextBox();
            this.TB_UpdatedColor = new System.Windows.Forms.TextBox();
            this.TB_UpdatedUsedFor = new System.Windows.Forms.TextBox();
            this.BTN_UpdateProduct = new System.Windows.Forms.Button();
            this.LL_UpdateProductForklaring = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_PurchasePrice = new System.Windows.Forms.TextBox();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.frameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.frameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LL_TilKurv = new System.Windows.Forms.LinkLabel();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(320, 34);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(316, 37);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "ÆNDRE PRODUKT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(390, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "Kategori :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(24, 126);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(138, 25);
            this.Label2.TabIndex = 91;
            this.Label2.Text = "Produkt navn :";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LL_TilKurv);
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(867, 95);
            this.PANEL_FindOrder.TabIndex = 90;
            // 
            // DGV_Product
            // 
            this.DGV_Product.AllowUserToAddRows = false;
            this.DGV_Product.AllowUserToDeleteRows = false;
            this.DGV_Product.AllowUserToResizeColumns = false;
            this.DGV_Product.AllowUserToResizeRows = false;
            this.DGV_Product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Product.Location = new System.Drawing.Point(28, 181);
            this.DGV_Product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.ReadOnly = true;
            this.DGV_Product.RowHeadersWidth = 82;
            this.DGV_Product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Product.RowTemplate.Height = 33;
            this.DGV_Product.Size = new System.Drawing.Size(806, 220);
            this.DGV_Product.TabIndex = 97;
            this.DGV_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Product_CellClick);
            this.DGV_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Product_CellContentClick);
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
            this.label8.Location = new System.Drawing.Point(46, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 25);
            this.label8.TabIndex = 110;
            this.label8.Text = "Produkt Beskrivelse :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(46, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 108;
            this.label7.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(46, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Købs Pris :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(45, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 103;
            this.label9.Text = "Produkt Navn :";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // TB_SearchNameProduct
            // 
            this.TB_SearchNameProduct.Location = new System.Drawing.Point(190, 125);
            this.TB_SearchNameProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_SearchNameProduct.Name = "TB_SearchNameProduct";
            this.TB_SearchNameProduct.Size = new System.Drawing.Size(192, 26);
            this.TB_SearchNameProduct.TabIndex = 112;
            // 
            // TB_SearchKategory
            // 
            this.TB_SearchKategory.Location = new System.Drawing.Point(500, 129);
            this.TB_SearchKategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_SearchKategory.Name = "TB_SearchKategory";
            this.TB_SearchKategory.Size = new System.Drawing.Size(192, 26);
            this.TB_SearchKategory.TabIndex = 113;
            // 
            // BTN_SearchProdukt
            // 
            this.BTN_SearchProdukt.BackColor = System.Drawing.Color.White;
            this.BTN_SearchProdukt.FlatAppearance.BorderSize = 0;
            this.BTN_SearchProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SearchProdukt.Location = new System.Drawing.Point(712, 121);
            this.BTN_SearchProdukt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_SearchProdukt.Name = "BTN_SearchProdukt";
            this.BTN_SearchProdukt.Size = new System.Drawing.Size(122, 42);
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
            this.BTN_SletProdukt.Location = new System.Drawing.Point(564, 798);
            this.BTN_SletProdukt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_SletProdukt.Name = "BTN_SletProdukt";
            this.BTN_SletProdukt.Size = new System.Drawing.Size(122, 46);
            this.BTN_SletProdukt.TabIndex = 115;
            this.BTN_SletProdukt.Text = "Slet Produkt";
            this.BTN_SletProdukt.UseVisualStyleBackColor = false;
            this.BTN_SletProdukt.Click += new System.EventHandler(this.BTN_SletProdukt_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(46, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 117;
            this.label5.Text = "CVR Leverandør :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(45, 719);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(46, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 25);
            this.label11.TabIndex = 120;
            this.label11.Text = "Tilegnet køn :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(46, 605);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 25);
            this.label12.TabIndex = 121;
            this.label12.Text = "Tilegnet alder :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(46, 631);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 25);
            this.label13.TabIndex = 122;
            this.label13.Text = "Længde :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(45, 658);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 25);
            this.label14.TabIndex = 123;
            this.label14.Text = "Bredde :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(46, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 124;
            this.label1.Text = "Brilletype :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(51, 708);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 125;
            this.label10.Text = "Stil :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(51, 734);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 25);
            this.label16.TabIndex = 126;
            this.label16.Text = "Farve :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(51, 760);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 25);
            this.label15.TabIndex = 127;
            this.label15.Text = "Brugt til :";
            // 
            // TB_UpdatedNameProduct
            // 
            this.TB_UpdatedNameProduct.Location = new System.Drawing.Point(253, 446);
            this.TB_UpdatedNameProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedNameProduct.Name = "TB_UpdatedNameProduct";
            this.TB_UpdatedNameProduct.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedNameProduct.TabIndex = 141;
            // 
            // TB_UpdatedDiscription
            // 
            this.TB_UpdatedDiscription.Location = new System.Drawing.Point(253, 474);
            this.TB_UpdatedDiscription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedDiscription.Name = "TB_UpdatedDiscription";
            this.TB_UpdatedDiscription.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedDiscription.TabIndex = 142;
            // 
            // TB_UpdatedKategory
            // 
            this.TB_UpdatedKategory.Location = new System.Drawing.Point(253, 500);
            this.TB_UpdatedKategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedKategory.Name = "TB_UpdatedKategory";
            this.TB_UpdatedKategory.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedKategory.TabIndex = 143;
            // 
            // TB_UpdatedSalesPrice
            // 
            this.TB_UpdatedSalesPrice.Location = new System.Drawing.Point(253, 421);
            this.TB_UpdatedSalesPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedSalesPrice.Name = "TB_UpdatedSalesPrice";
            this.TB_UpdatedSalesPrice.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedSalesPrice.TabIndex = 144;
            // 
            // TB_UpdatedVATSup
            // 
            this.TB_UpdatedVATSup.Location = new System.Drawing.Point(253, 552);
            this.TB_UpdatedVATSup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedVATSup.Name = "TB_UpdatedVATSup";
            this.TB_UpdatedVATSup.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedVATSup.TabIndex = 145;
            // 
            // TB_UpdatedGender
            // 
            this.TB_UpdatedGender.Location = new System.Drawing.Point(253, 579);
            this.TB_UpdatedGender.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedGender.Name = "TB_UpdatedGender";
            this.TB_UpdatedGender.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedGender.TabIndex = 146;
            // 
            // TB_UpdatedAge
            // 
            this.TB_UpdatedAge.Location = new System.Drawing.Point(253, 605);
            this.TB_UpdatedAge.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedAge.Name = "TB_UpdatedAge";
            this.TB_UpdatedAge.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedAge.TabIndex = 147;
            // 
            // TB_UpdatedLength
            // 
            this.TB_UpdatedLength.Location = new System.Drawing.Point(253, 631);
            this.TB_UpdatedLength.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedLength.Name = "TB_UpdatedLength";
            this.TB_UpdatedLength.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedLength.TabIndex = 148;
            // 
            // TB_UpdatedWidth
            // 
            this.TB_UpdatedWidth.Location = new System.Drawing.Point(253, 658);
            this.TB_UpdatedWidth.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedWidth.Name = "TB_UpdatedWidth";
            this.TB_UpdatedWidth.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedWidth.TabIndex = 149;
            // 
            // TB_UpdatedKind
            // 
            this.TB_UpdatedKind.Location = new System.Drawing.Point(253, 681);
            this.TB_UpdatedKind.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedKind.Name = "TB_UpdatedKind";
            this.TB_UpdatedKind.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedKind.TabIndex = 150;
            // 
            // TB_UpdatedStyle
            // 
            this.TB_UpdatedStyle.Location = new System.Drawing.Point(253, 708);
            this.TB_UpdatedStyle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedStyle.Name = "TB_UpdatedStyle";
            this.TB_UpdatedStyle.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedStyle.TabIndex = 151;
            // 
            // TB_UpdatedColor
            // 
            this.TB_UpdatedColor.Location = new System.Drawing.Point(253, 734);
            this.TB_UpdatedColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedColor.Name = "TB_UpdatedColor";
            this.TB_UpdatedColor.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedColor.TabIndex = 152;
            // 
            // TB_UpdatedUsedFor
            // 
            this.TB_UpdatedUsedFor.Location = new System.Drawing.Point(253, 760);
            this.TB_UpdatedUsedFor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_UpdatedUsedFor.Name = "TB_UpdatedUsedFor";
            this.TB_UpdatedUsedFor.Size = new System.Drawing.Size(580, 26);
            this.TB_UpdatedUsedFor.TabIndex = 153;
            // 
            // BTN_UpdateProduct
            // 
            this.BTN_UpdateProduct.BackColor = System.Drawing.Color.White;
            this.BTN_UpdateProduct.FlatAppearance.BorderSize = 0;
            this.BTN_UpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_UpdateProduct.Location = new System.Drawing.Point(692, 798);
            this.BTN_UpdateProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_UpdateProduct.Name = "BTN_UpdateProduct";
            this.BTN_UpdateProduct.Size = new System.Drawing.Size(143, 45);
            this.BTN_UpdateProduct.TabIndex = 154;
            this.BTN_UpdateProduct.Text = "Opdater Produkt";
            this.BTN_UpdateProduct.UseVisualStyleBackColor = false;
            this.BTN_UpdateProduct.Click += new System.EventHandler(this.BTN_UpdateProduct_Click_1);
            // 
            // LL_UpdateProductForklaring
            // 
            this.LL_UpdateProductForklaring.AutoSize = true;
            this.LL_UpdateProductForklaring.LinkColor = System.Drawing.Color.White;
            this.LL_UpdateProductForklaring.Location = new System.Drawing.Point(50, 809);
            this.LL_UpdateProductForklaring.Name = "LL_UpdateProductForklaring";
            this.LL_UpdateProductForklaring.Size = new System.Drawing.Size(79, 20);
            this.LL_UpdateProductForklaring.TabIndex = 155;
            this.LL_UpdateProductForklaring.TabStop = true;
            this.LL_UpdateProductForklaring.Text = "Forklaring";
            this.LL_UpdateProductForklaring.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_UpdateProductForklaring_LinkClicked);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(45, 421);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 25);
            this.label17.TabIndex = 156;
            this.label17.Text = "Salgs Pris :";
            // 
            // TB_PurchasePrice
            // 
            this.TB_PurchasePrice.Location = new System.Drawing.Point(253, 526);
            this.TB_PurchasePrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_PurchasePrice.Name = "TB_PurchasePrice";
            this.TB_PurchasePrice.Size = new System.Drawing.Size(580, 26);
            this.TB_PurchasePrice.TabIndex = 157;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(SemesterProjekt.Models.Product);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(SemesterProjekt.Models.Product);
            // 
            // frameBindingSource1
            // 
            this.frameBindingSource1.DataSource = typeof(SemesterProjekt.Models.Frame);
            // 
            // frameBindingSource
            // 
            this.frameBindingSource.DataSource = typeof(SemesterProjekt.Models.Frame);
            // 
            // LL_TilKurv
            // 
            this.LL_TilKurv.AutoSize = true;
            this.LL_TilKurv.LinkColor = System.Drawing.Color.White;
            this.LL_TilKurv.Location = new System.Drawing.Point(754, 34);
            this.LL_TilKurv.Name = "LL_TilKurv";
            this.LL_TilKurv.Size = new System.Drawing.Size(59, 20);
            this.LL_TilKurv.TabIndex = 158;
            this.LL_TilKurv.TabStop = true;
            this.LL_TilKurv.Text = "Til Kurv";
            this.LL_TilKurv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_TilKurv_LinkClicked);
            // 
            // ÆndreProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(867, 858);
            this.Controls.Add(this.TB_PurchasePrice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LL_UpdateProductForklaring);
            this.Controls.Add(this.BTN_UpdateProduct);
            this.Controls.Add(this.TB_UpdatedUsedFor);
            this.Controls.Add(this.TB_UpdatedColor);
            this.Controls.Add(this.TB_UpdatedStyle);
            this.Controls.Add(this.TB_UpdatedKind);
            this.Controls.Add(this.TB_UpdatedWidth);
            this.Controls.Add(this.TB_UpdatedLength);
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
            this.Controls.Add(this.DGV_Product);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ÆndreProdukt";
            this.Text = "OpdaterProdukt";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ShowProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.DataGridView DGV_Product;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private ProductTable productTable;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductTableTableAdapters.ProductTableAdapter productTableAdapter;
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
        private System.Windows.Forms.TextBox TB_UpdatedLength;
        private System.Windows.Forms.TextBox TB_UpdatedWidth;
        private System.Windows.Forms.TextBox TB_UpdatedKind;
        private System.Windows.Forms.TextBox TB_UpdatedStyle;
        private System.Windows.Forms.TextBox TB_UpdatedColor;
        private System.Windows.Forms.TextBox TB_UpdatedUsedFor;
        private System.Windows.Forms.Button BTN_UpdateProduct;
        private System.Windows.Forms.LinkLabel LL_UpdateProductForklaring;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_PurchasePrice;
        private System.Windows.Forms.BindingSource frameBindingSource;
        private System.Windows.Forms.BindingSource frameBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.LinkLabel LL_TilKurv;
    }
}