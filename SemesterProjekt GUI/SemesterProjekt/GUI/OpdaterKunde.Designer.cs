namespace SemesterProjekt.GUI
{
    partial class OpdaterKunde
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTable = new SemesterProjekt.CustomerTable();
            this.TB_Discount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_PostNr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Test = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_PostalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new SemesterProjekt.CustomerTableTableAdapters.CustomerTableAdapter();
            this.BTN_SearchCustomer = new System.Windows.Forms.Button();
            this.TB_SearchEMailCustomer = new System.Windows.Forms.TextBox();
            this.TB_SearchTlfCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LL_UpdateProductForklaring = new System.Windows.Forms.LinkLabel();
            this.BTN_UpdateCustomer = new System.Windows.Forms.Button();
            this.TB_CustomerVisionTest = new System.Windows.Forms.TextBox();
            this.TB_CustomerAge = new System.Windows.Forms.TextBox();
            this.TB_CustomerBirthday = new System.Windows.Forms.TextBox();
            this.TB_CustomerDiscount = new System.Windows.Forms.TextBox();
            this.TB_CustomerPostalCode = new System.Windows.Forms.TextBox();
            this.TB_CustomerCity = new System.Windows.Forms.TextBox();
            this.TB_CustomerAdress = new System.Windows.Forms.TextBox();
            this.TB_CustomerEMailAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BTN_DeleteCustomer = new System.Windows.Forms.Button();
            this.productTableAdapter = new SemesterProjekt.ProductTableTableAdapters.ProductTableAdapter();
            this.TB_CustomerPhoneNr = new System.Windows.Forms.TextBox();
            this.TB_CustomerFirstName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATSupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedForDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTable = new SemesterProjekt.ProductTable();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 62);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(275, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "RET OPLYSNINGER";
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.AllowUserToAddRows = false;
            this.DGV_Customer.AllowUserToDeleteRows = false;
            this.DGV_Customer.AllowUserToResizeColumns = false;
            this.DGV_Customer.AllowUserToResizeRows = false;
            this.DGV_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(27, 118);
            this.DGV_Customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.RowHeadersWidth = 51;
            this.DGV_Customer.RowTemplate.Height = 24;
            this.DGV_Customer.Size = new System.Drawing.Size(755, 180);
            this.DGV_Customer.TabIndex = 19;
            this.DGV_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_CellClick);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerTable;
            // 
            // customerTable
            // 
            this.customerTable.DataSetName = "CustomerTable";
            this.customerTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TB_Discount
            // 
            this.TB_Discount.Location = new System.Drawing.Point(613, 886);
            this.TB_Discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Discount.Name = "TB_Discount";
            this.TB_Discount.Size = new System.Drawing.Size(395, 22);
            this.TB_Discount.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(380, 876);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 31);
            this.label11.TabIndex = 75;
            this.label11.Text = "Discount :";
            // 
            // TB_PostNr
            // 
            this.TB_PostNr.Location = new System.Drawing.Point(613, 838);
            this.TB_PostNr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_PostNr.Name = "TB_PostNr";
            this.TB_PostNr.Size = new System.Drawing.Size(395, 22);
            this.TB_PostNr.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(380, 828);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 31);
            this.label8.TabIndex = 73;
            this.label8.Text = "PostNr : ";
            // 
            // TB_Test
            // 
            this.TB_Test.Location = new System.Drawing.Point(613, 791);
            this.TB_Test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Test.Name = "TB_Test";
            this.TB_Test.Size = new System.Drawing.Size(395, 22);
            this.TB_Test.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(380, 782);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 31);
            this.label9.TabIndex = 71;
            this.label9.Text = "Synstest :";
            // 
            // TB_Age
            // 
            this.TB_Age.Location = new System.Drawing.Point(613, 740);
            this.TB_Age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Age.Name = "TB_Age";
            this.TB_Age.Size = new System.Drawing.Size(395, 22);
            this.TB_Age.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(380, 731);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 31);
            this.label10.TabIndex = 69;
            this.label10.Text = "Alder : ";
            // 
            // TB_PostalCode
            // 
            this.TB_PostalCode.Location = new System.Drawing.Point(613, 695);
            this.TB_PostalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_PostalCode.Name = "TB_PostalCode";
            this.TB_PostalCode.Size = new System.Drawing.Size(395, 22);
            this.TB_PostalCode.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(380, 686);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 31);
            this.label7.TabIndex = 67;
            this.label7.Text = "PostNr : ";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // BTN_SearchCustomer
            // 
            this.BTN_SearchCustomer.BackColor = System.Drawing.Color.White;
            this.BTN_SearchCustomer.FlatAppearance.BorderSize = 0;
            this.BTN_SearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SearchCustomer.Location = new System.Drawing.Point(675, 76);
            this.BTN_SearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_SearchCustomer.Name = "BTN_SearchCustomer";
            this.BTN_SearchCustomer.Size = new System.Drawing.Size(108, 34);
            this.BTN_SearchCustomer.TabIndex = 119;
            this.BTN_SearchCustomer.Text = "Søg Kunde";
            this.BTN_SearchCustomer.UseVisualStyleBackColor = false;
            this.BTN_SearchCustomer.Click += new System.EventHandler(this.BTN_SearchCustomer_Click);
            // 
            // TB_SearchEMailCustomer
            // 
            this.TB_SearchEMailCustomer.Location = new System.Drawing.Point(484, 82);
            this.TB_SearchEMailCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_SearchEMailCustomer.Name = "TB_SearchEMailCustomer";
            this.TB_SearchEMailCustomer.Size = new System.Drawing.Size(171, 22);
            this.TB_SearchEMailCustomer.TabIndex = 118;
            // 
            // TB_SearchTlfCustomer
            // 
            this.TB_SearchTlfCustomer.Location = new System.Drawing.Point(171, 82);
            this.TB_SearchTlfCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_SearchTlfCustomer.Name = "TB_SearchTlfCustomer";
            this.TB_SearchTlfCustomer.Size = new System.Drawing.Size(171, 22);
            this.TB_SearchTlfCustomer.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(348, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "Kunde E-Mail :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(23, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(123, 20);
            this.Label2.TabIndex = 115;
            this.Label2.Text = "Kunde Tlf +45 :";
            // 
            // LL_UpdateProductForklaring
            // 
            this.LL_UpdateProductForklaring.AutoSize = true;
            this.LL_UpdateProductForklaring.LinkColor = System.Drawing.Color.White;
            this.LL_UpdateProductForklaring.Location = new System.Drawing.Point(36, 576);
            this.LL_UpdateProductForklaring.Name = "LL_UpdateProductForklaring";
            this.LL_UpdateProductForklaring.Size = new System.Drawing.Size(67, 16);
            this.LL_UpdateProductForklaring.TabIndex = 185;
            this.LL_UpdateProductForklaring.TabStop = true;
            this.LL_UpdateProductForklaring.Text = "Forklaring";
            // 
            // BTN_UpdateCustomer
            // 
            this.BTN_UpdateCustomer.BackColor = System.Drawing.Color.White;
            this.BTN_UpdateCustomer.FlatAppearance.BorderSize = 0;
            this.BTN_UpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_UpdateCustomer.Location = new System.Drawing.Point(653, 556);
            this.BTN_UpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_UpdateCustomer.Name = "BTN_UpdateCustomer";
            this.BTN_UpdateCustomer.Size = new System.Drawing.Size(125, 36);
            this.BTN_UpdateCustomer.TabIndex = 184;
            this.BTN_UpdateCustomer.Text = "Opdater Kunde";
            this.BTN_UpdateCustomer.UseVisualStyleBackColor = false;
            this.BTN_UpdateCustomer.Click += new System.EventHandler(this.BTN_UpdateProduct_Click);
            // 
            // TB_CustomerVisionTest
            // 
            this.TB_CustomerVisionTest.Location = new System.Drawing.Point(216, 521);
            this.TB_CustomerVisionTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerVisionTest.Name = "TB_CustomerVisionTest";
            this.TB_CustomerVisionTest.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerVisionTest.TabIndex = 180;
            // 
            // TB_CustomerAge
            // 
            this.TB_CustomerAge.Location = new System.Drawing.Point(216, 501);
            this.TB_CustomerAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerAge.Name = "TB_CustomerAge";
            this.TB_CustomerAge.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerAge.TabIndex = 179;
            // 
            // TB_CustomerBirthday
            // 
            this.TB_CustomerBirthday.Location = new System.Drawing.Point(216, 480);
            this.TB_CustomerBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerBirthday.Name = "TB_CustomerBirthday";
            this.TB_CustomerBirthday.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerBirthday.TabIndex = 178;
            // 
            // TB_CustomerDiscount
            // 
            this.TB_CustomerDiscount.Location = new System.Drawing.Point(216, 459);
            this.TB_CustomerDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerDiscount.Name = "TB_CustomerDiscount";
            this.TB_CustomerDiscount.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerDiscount.TabIndex = 177;
            // 
            // TB_CustomerPostalCode
            // 
            this.TB_CustomerPostalCode.Location = new System.Drawing.Point(216, 438);
            this.TB_CustomerPostalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerPostalCode.Name = "TB_CustomerPostalCode";
            this.TB_CustomerPostalCode.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerPostalCode.TabIndex = 176;
            // 
            // TB_CustomerCity
            // 
            this.TB_CustomerCity.Location = new System.Drawing.Point(216, 418);
            this.TB_CustomerCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerCity.Name = "TB_CustomerCity";
            this.TB_CustomerCity.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerCity.TabIndex = 175;
            // 
            // TB_CustomerAdress
            // 
            this.TB_CustomerAdress.Location = new System.Drawing.Point(216, 396);
            this.TB_CustomerAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerAdress.Name = "TB_CustomerAdress";
            this.TB_CustomerAdress.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerAdress.TabIndex = 174;
            // 
            // TB_CustomerEMailAdress
            // 
            this.TB_CustomerEMailAdress.Location = new System.Drawing.Point(216, 375);
            this.TB_CustomerEMailAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerEMailAdress.Name = "TB_CustomerEMailAdress";
            this.TB_CustomerEMailAdress.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerEMailAdress.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(32, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 167;
            this.label5.Text = "Syns test :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(29, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 166;
            this.label14.Text = "Alder :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(32, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 165;
            this.label13.Text = "Fødselsdato :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(32, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 164;
            this.label12.Text = "Discount :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(32, 438);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 20);
            this.label17.TabIndex = 163;
            this.label17.Text = "PostNr:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(29, 519);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 20);
            this.label18.TabIndex = 162;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(32, 418);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 20);
            this.label19.TabIndex = 161;
            this.label19.Text = "By :";
            // 
            // BTN_DeleteCustomer
            // 
            this.BTN_DeleteCustomer.BackColor = System.Drawing.Color.White;
            this.BTN_DeleteCustomer.FlatAppearance.BorderSize = 0;
            this.BTN_DeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_DeleteCustomer.Location = new System.Drawing.Point(541, 555);
            this.BTN_DeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_DeleteCustomer.Name = "BTN_DeleteCustomer";
            this.BTN_DeleteCustomer.Size = new System.Drawing.Size(108, 37);
            this.BTN_DeleteCustomer.TabIndex = 160;
            this.BTN_DeleteCustomer.Text = "Slet Kunde";
            this.BTN_DeleteCustomer.UseVisualStyleBackColor = false;
            this.BTN_DeleteCustomer.Click += new System.EventHandler(this.BTN_DeleteCustomer_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // TB_CustomerPhoneNr
            // 
            this.TB_CustomerPhoneNr.Location = new System.Drawing.Point(216, 354);
            this.TB_CustomerPhoneNr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerPhoneNr.Name = "TB_CustomerPhoneNr";
            this.TB_CustomerPhoneNr.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerPhoneNr.TabIndex = 172;
            // 
            // TB_CustomerFirstName
            // 
            this.TB_CustomerFirstName.Location = new System.Drawing.Point(216, 332);
            this.TB_CustomerFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_CustomerFirstName.Name = "TB_CustomerFirstName";
            this.TB_CustomerFirstName.Size = new System.Drawing.Size(564, 22);
            this.TB_CustomerFirstName.TabIndex = 171;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(32, 354);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 20);
            this.label20.TabIndex = 159;
            this.label20.Text = "Tlf + 45:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(32, 375);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 20);
            this.label21.TabIndex = 158;
            this.label21.Text = "E-Mail :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(29, 332);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 20);
            this.label22.TabIndex = 157;
            this.label22.Text = "Kunde Fornavn :";
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "SalesPrice";
            this.salesPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            this.salesPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameProductDataGridViewTextBoxColumn.Width = 150;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.discriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoryDataGridViewTextBoxColumn
            // 
            this.kategoryDataGridViewTextBoxColumn.DataPropertyName = "Kategory";
            this.kategoryDataGridViewTextBoxColumn.HeaderText = "Kategory";
            this.kategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kategoryDataGridViewTextBoxColumn.Name = "kategoryDataGridViewTextBoxColumn";
            this.kategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchasePriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // vATSupDataGridViewTextBoxColumn
            // 
            this.vATSupDataGridViewTextBoxColumn.DataPropertyName = "VATSup";
            this.vATSupDataGridViewTextBoxColumn.HeaderText = "VATSup";
            this.vATSupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vATSupDataGridViewTextBoxColumn.Name = "vATSupDataGridViewTextBoxColumn";
            this.vATSupDataGridViewTextBoxColumn.ReadOnly = true;
            this.vATSupDataGridViewTextBoxColumn.Width = 150;
            // 
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.eANDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            this.eANDataGridViewTextBoxColumn.ReadOnly = true;
            this.eANDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn1.HeaderText = "Age";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // lenghtDataGridViewTextBoxColumn
            // 
            this.lenghtDataGridViewTextBoxColumn.DataPropertyName = "Lenght";
            this.lenghtDataGridViewTextBoxColumn.HeaderText = "Lenght";
            this.lenghtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lenghtDataGridViewTextBoxColumn.Name = "lenghtDataGridViewTextBoxColumn";
            this.lenghtDataGridViewTextBoxColumn.ReadOnly = true;
            this.lenghtDataGridViewTextBoxColumn.Width = 150;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Width = 150;
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn.HeaderText = "Kind";
            this.kindDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            this.kindDataGridViewTextBoxColumn.ReadOnly = true;
            this.kindDataGridViewTextBoxColumn.Width = 150;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.ReadOnly = true;
            this.styleDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // usedForDataGridViewTextBoxColumn
            // 
            this.usedForDataGridViewTextBoxColumn.DataPropertyName = "UsedFor";
            this.usedForDataGridViewTextBoxColumn.HeaderText = "UsedFor";
            this.usedForDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usedForDataGridViewTextBoxColumn.Name = "usedForDataGridViewTextBoxColumn";
            this.usedForDataGridViewTextBoxColumn.ReadOnly = true;
            this.usedForDataGridViewTextBoxColumn.Width = 150;
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
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.ForeColor = System.Drawing.Color.Gainsboro;
            this.label23.Location = new System.Drawing.Point(32, 396);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 20);
            this.label23.TabIndex = 156;
            this.label23.Text = "Adresse :";
            // 
            // OpdaterKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(812, 631);
            this.Controls.Add(this.LL_UpdateProductForklaring);
            this.Controls.Add(this.BTN_UpdateCustomer);
            this.Controls.Add(this.TB_CustomerVisionTest);
            this.Controls.Add(this.TB_CustomerAge);
            this.Controls.Add(this.TB_CustomerBirthday);
            this.Controls.Add(this.TB_CustomerDiscount);
            this.Controls.Add(this.TB_CustomerPostalCode);
            this.Controls.Add(this.TB_CustomerCity);
            this.Controls.Add(this.TB_CustomerAdress);
            this.Controls.Add(this.TB_CustomerEMailAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BTN_DeleteCustomer);
            this.Controls.Add(this.TB_CustomerPhoneNr);
            this.Controls.Add(this.TB_CustomerFirstName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.BTN_SearchCustomer);
            this.Controls.Add(this.TB_SearchEMailCustomer);
            this.Controls.Add(this.TB_SearchTlfCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TB_Discount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_PostNr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Test);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_Age);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_PostalCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGV_Customer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OpdaterKunde";
            this.Text = "OpdaterKunde";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.TextBox TB_Discount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_PostNr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Test;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_PostalCode;
        private System.Windows.Forms.Label label7;
        private CustomerTable customerTable;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerTableTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button BTN_SearchCustomer;
        private System.Windows.Forms.TextBox TB_SearchEMailCustomer;
        private System.Windows.Forms.TextBox TB_SearchTlfCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.LinkLabel LL_UpdateProductForklaring;
        private System.Windows.Forms.Button BTN_UpdateCustomer;
        private System.Windows.Forms.TextBox TB_CustomerVisionTest;
        private System.Windows.Forms.TextBox TB_CustomerAge;
        private System.Windows.Forms.TextBox TB_CustomerBirthday;
        private System.Windows.Forms.TextBox TB_CustomerDiscount;
        private System.Windows.Forms.TextBox TB_CustomerPostalCode;
        private System.Windows.Forms.TextBox TB_CustomerCity;
        private System.Windows.Forms.TextBox TB_CustomerAdress;
        private System.Windows.Forms.TextBox TB_CustomerEMailAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BTN_DeleteCustomer;
        private ProductTableTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox TB_CustomerPhoneNr;
        private System.Windows.Forms.TextBox TB_CustomerFirstName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATSupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedForDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private ProductTable productTable;
        private System.Windows.Forms.Label label23;
    }
}