namespace SemesterProjekt.GUI
{
    partial class OpretProduct
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
            this.TB_Discription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TB_EAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_FoundOrder = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.TB_NameProduct = new System.Windows.Forms.TextBox();
            this.TB_Kategory = new System.Windows.Forms.TextBox();
            this.TB_PurchasePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_VATSup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_SalesPrice = new System.Windows.Forms.TextBox();
            this.BTN_CreateProduct = new System.Windows.Forms.Button();
            this.PANEL_FindOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Discription
            // 
            this.TB_Discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_Discription.Location = new System.Drawing.Point(403, 237);
            this.TB_Discription.Name = "TB_Discription";
            this.TB_Discription.Size = new System.Drawing.Size(376, 37);
            this.TB_Discription.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(35, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 62;
            this.label4.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(35, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 31);
            this.label3.TabIndex = 60;
            this.label3.Text = "Produkt Beskrivelse";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(35, 180);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(182, 31);
            this.Label2.TabIndex = 58;
            this.Label2.Text = "Produkt navn:";
            // 
            // TB_EAN
            // 
            this.TB_EAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_EAN.Location = new System.Drawing.Point(403, 114);
            this.TB_EAN.Name = "TB_EAN";
            this.TB_EAN.Size = new System.Drawing.Size(376, 37);
            this.TB_EAN.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(35, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "EAN";
            // 
            // LB_FoundOrder
            // 
            this.LB_FoundOrder.AutoSize = true;
            this.LB_FoundOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_FoundOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_FoundOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_FoundOrder.Location = new System.Drawing.Point(302, 27);
            this.LB_FoundOrder.Name = "LB_FoundOrder";
            this.LB_FoundOrder.Size = new System.Drawing.Size(262, 31);
            this.LB_FoundOrder.TabIndex = 16;
            this.LB_FoundOrder.Text = "OPRET PRODUKT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(35, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 31);
            this.label5.TabIndex = 64;
            this.label5.Text = "Indkøbspris";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_FoundOrder);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(869, 80);
            this.PANEL_FindOrder.TabIndex = 55;
            // 
            // TB_NameProduct
            // 
            this.TB_NameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_NameProduct.Location = new System.Drawing.Point(403, 176);
            this.TB_NameProduct.Name = "TB_NameProduct";
            this.TB_NameProduct.Size = new System.Drawing.Size(376, 37);
            this.TB_NameProduct.TabIndex = 79;
            // 
            // TB_Kategory
            // 
            this.TB_Kategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_Kategory.Location = new System.Drawing.Point(403, 299);
            this.TB_Kategory.Name = "TB_Kategory";
            this.TB_Kategory.Size = new System.Drawing.Size(376, 37);
            this.TB_Kategory.TabIndex = 80;
            // 
            // TB_PurchasePrice
            // 
            this.TB_PurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_PurchasePrice.Location = new System.Drawing.Point(403, 360);
            this.TB_PurchasePrice.Name = "TB_PurchasePrice";
            this.TB_PurchasePrice.Size = new System.Drawing.Size(376, 37);
            this.TB_PurchasePrice.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(35, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 31);
            this.label7.TabIndex = 82;
            this.label7.Text = "CVR leverandør:";
            // 
            // TB_VATSup
            // 
            this.TB_VATSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_VATSup.Location = new System.Drawing.Point(403, 483);
            this.TB_VATSup.Name = "TB_VATSup";
            this.TB_VATSup.Size = new System.Drawing.Size(376, 37);
            this.TB_VATSup.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(35, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 31);
            this.label8.TabIndex = 84;
            this.label8.Text = "Indkøbspris :";
            // 
            // TB_SalesPrice
            // 
            this.TB_SalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_SalesPrice.Location = new System.Drawing.Point(403, 422);
            this.TB_SalesPrice.Name = "TB_SalesPrice";
            this.TB_SalesPrice.Size = new System.Drawing.Size(376, 37);
            this.TB_SalesPrice.TabIndex = 85;
            // 
            // BTN_CreateProduct
            // 
            this.BTN_CreateProduct.BackColor = System.Drawing.Color.White;
            this.BTN_CreateProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_CreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CreateProduct.Location = new System.Drawing.Point(0, 556);
            this.BTN_CreateProduct.Name = "BTN_CreateProduct";
            this.BTN_CreateProduct.Size = new System.Drawing.Size(869, 78);
            this.BTN_CreateProduct.TabIndex = 86;
            this.BTN_CreateProduct.Text = "Opret Produkt";
            this.BTN_CreateProduct.UseVisualStyleBackColor = false;
            // 
            // OpretProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(869, 634);
            this.Controls.Add(this.BTN_CreateProduct);
            this.Controls.Add(this.TB_SalesPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_VATSup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_PurchasePrice);
            this.Controls.Add(this.TB_Kategory);
            this.Controls.Add(this.TB_NameProduct);
            this.Controls.Add(this.TB_Discription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TB_EAN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OpretProduct";
            this.Text = "OpretProduct";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Discription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TB_EAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_FoundOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.TextBox TB_NameProduct;
        private System.Windows.Forms.TextBox TB_Kategory;
        private System.Windows.Forms.TextBox TB_PurchasePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_VATSup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_SalesPrice;
        private System.Windows.Forms.Button BTN_CreateProduct;
    }
}