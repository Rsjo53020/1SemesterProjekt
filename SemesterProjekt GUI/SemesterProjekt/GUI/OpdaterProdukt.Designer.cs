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
            this.LB_ShowProduct = new System.Windows.Forms.Label();
            this.BTN_OpdateFindProdukt = new System.Windows.Forms.Button();
            this.TB_OpdateFindKategory = new System.Windows.Forms.TextBox();
            this.TB_OpdateFindProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.BTN_OpdateProduct = new System.Windows.Forms.Button();
            this.DGV_OpdateSelectProduct = new System.Windows.Forms.DataGridView();
            this.TB_OpdateSalesPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_OpdateVATSup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_OpdatePurchasePrice = new System.Windows.Forms.TextBox();
            this.TB_OpdateDiscription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OpdateSelectProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(743, 50);
            this.LB_ShowProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(451, 51);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "OPDATER PRODUKT";
            // 
            // BTN_OpdateFindProdukt
            // 
            this.BTN_OpdateFindProdukt.Location = new System.Drawing.Point(61, 415);
            this.BTN_OpdateFindProdukt.Name = "BTN_OpdateFindProdukt";
            this.BTN_OpdateFindProdukt.Size = new System.Drawing.Size(348, 122);
            this.BTN_OpdateFindProdukt.TabIndex = 95;
            this.BTN_OpdateFindProdukt.Text = "Vis Produkt";
            this.BTN_OpdateFindProdukt.UseVisualStyleBackColor = true;
            // 
            // TB_OpdateFindKategory
            // 
            this.TB_OpdateFindKategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateFindKategory.Location = new System.Drawing.Point(605, 304);
            this.TB_OpdateFindKategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_OpdateFindKategory.Name = "TB_OpdateFindKategory";
            this.TB_OpdateFindKategory.Size = new System.Drawing.Size(356, 55);
            this.TB_OpdateFindKategory.TabIndex = 94;
            // 
            // TB_OpdateFindProductName
            // 
            this.TB_OpdateFindProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateFindProductName.Location = new System.Drawing.Point(605, 186);
            this.TB_OpdateFindProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_OpdateFindProductName.Name = "TB_OpdateFindProductName";
            this.TB_OpdateFindProductName.Size = new System.Drawing.Size(356, 55);
            this.TB_OpdateFindProductName.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(53, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 48);
            this.label4.TabIndex = 92;
            this.label4.Text = "Kategori:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(53, 193);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(277, 48);
            this.Label2.TabIndex = 91;
            this.Label2.Text = "Produkt navn:";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(4);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(2012, 145);
            this.PANEL_FindOrder.TabIndex = 90;
            // 
            // BTN_OpdateProduct
            // 
            this.BTN_OpdateProduct.Location = new System.Drawing.Point(1144, 760);
            this.BTN_OpdateProduct.Name = "BTN_OpdateProduct";
            this.BTN_OpdateProduct.Size = new System.Drawing.Size(699, 122);
            this.BTN_OpdateProduct.TabIndex = 96;
            this.BTN_OpdateProduct.Text = "OPDATER PRODUKT";
            this.BTN_OpdateProduct.UseVisualStyleBackColor = true;
            // 
            // DGV_OpdateSelectProduct
            // 
            this.DGV_OpdateSelectProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_OpdateSelectProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OpdateSelectProduct.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_OpdateSelectProduct.Location = new System.Drawing.Point(1144, 186);
            this.DGV_OpdateSelectProduct.Name = "DGV_OpdateSelectProduct";
            this.DGV_OpdateSelectProduct.RowHeadersWidth = 82;
            this.DGV_OpdateSelectProduct.RowTemplate.Height = 33;
            this.DGV_OpdateSelectProduct.Size = new System.Drawing.Size(699, 514);
            this.DGV_OpdateSelectProduct.TabIndex = 97;
            // 
            // TB_OpdateSalesPrice
            // 
            this.TB_OpdateSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateSalesPrice.Location = new System.Drawing.Point(605, 798);
            this.TB_OpdateSalesPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_OpdateSalesPrice.Name = "TB_OpdateSalesPrice";
            this.TB_OpdateSalesPrice.Size = new System.Drawing.Size(356, 55);
            this.TB_OpdateSalesPrice.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(53, 805);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 48);
            this.label8.TabIndex = 110;
            this.label8.Text = "Indkøbspris :";
            // 
            // TB_OpdateVATSup
            // 
            this.TB_OpdateVATSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateVATSup.Location = new System.Drawing.Point(605, 894);
            this.TB_OpdateVATSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_OpdateVATSup.Name = "TB_OpdateVATSup";
            this.TB_OpdateVATSup.Size = new System.Drawing.Size(356, 55);
            this.TB_OpdateVATSup.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(53, 901);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 48);
            this.label7.TabIndex = 108;
            this.label7.Text = "CVR leverandør:";
            // 
            // TB_OpdatePurchasePrice
            // 
            this.TB_OpdatePurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdatePurchasePrice.Location = new System.Drawing.Point(605, 702);
            this.TB_OpdatePurchasePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_OpdatePurchasePrice.Name = "TB_OpdatePurchasePrice";
            this.TB_OpdatePurchasePrice.Size = new System.Drawing.Size(356, 55);
            this.TB_OpdatePurchasePrice.TabIndex = 107;
            // 
            // TB_OpdateDiscription
            // 
            this.TB_OpdateDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OpdateDiscription.Location = new System.Drawing.Point(605, 607);
            this.TB_OpdateDiscription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_OpdateDiscription.Name = "TB_OpdateDiscription";
            this.TB_OpdateDiscription.Size = new System.Drawing.Size(356, 55);
            this.TB_OpdateDiscription.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(53, 614);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 48);
            this.label3.TabIndex = 101;
            this.label3.Text = "Produkt Beskrivelse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(53, 709);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 48);
            this.label9.TabIndex = 103;
            this.label9.Text = "Indkøbspris";
            // 
            // OpdaterProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(2012, 958);
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
            this.Name = "OpdaterProdukt";
            this.Text = "OpdaterProdukt";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OpdateSelectProduct)).EndInit();
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
    }
}