namespace SemesterProjekt.GUI
{
    partial class SøgKunde
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
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.LB_ShowProduct = new System.Windows.Forms.Label();
            this.TB_SearchEMailAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_SearchPhoneNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.BTN_SearchCustomer = new System.Windows.Forms.Button();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(800, 62);
            this.PANEL_FindOrder.TabIndex = 91;
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(333, 20);
            this.LB_ShowProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(129, 26);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "Søg Kunde";
            this.LB_ShowProduct.Click += new System.EventHandler(this.LB_ShowProduct_Click);
            // 
            // TB_SearchEMailAdress
            // 
            this.TB_SearchEMailAdress.Location = new System.Drawing.Point(236, 113);
            this.TB_SearchEMailAdress.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SearchEMailAdress.Name = "TB_SearchEMailAdress";
            this.TB_SearchEMailAdress.Size = new System.Drawing.Size(296, 20);
            this.TB_SearchEMailAdress.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(61, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 94;
            this.label4.Text = "E-Mail :";
            // 
            // TB_SearchPhoneNr
            // 
            this.TB_SearchPhoneNr.Location = new System.Drawing.Point(236, 80);
            this.TB_SearchPhoneNr.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SearchPhoneNr.Name = "TB_SearchPhoneNr";
            this.TB_SearchPhoneNr.Size = new System.Drawing.Size(296, 20);
            this.TB_SearchPhoneNr.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tlf +45 :";
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Location = new System.Drawing.Point(66, 159);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.Size = new System.Drawing.Size(699, 261);
            this.DGV_Customers.TabIndex = 96;
            // 
            // BTN_SearchCustomer
            // 
            this.BTN_SearchCustomer.BackColor = System.Drawing.Color.White;
            this.BTN_SearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SearchCustomer.Location = new System.Drawing.Point(548, 86);
            this.BTN_SearchCustomer.Name = "BTN_SearchCustomer";
            this.BTN_SearchCustomer.Size = new System.Drawing.Size(120, 47);
            this.BTN_SearchCustomer.TabIndex = 97;
            this.BTN_SearchCustomer.Text = "Søg ";
            this.BTN_SearchCustomer.UseVisualStyleBackColor = false;
            // 
            // SøgKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_SearchCustomer);
            this.Controls.Add(this.DGV_Customers);
            this.Controls.Add(this.TB_SearchEMailAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_SearchPhoneNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Name = "SøgKunde";
            this.Text = "SøgKunde";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_ShowProduct;
        private System.Windows.Forms.TextBox TB_SearchEMailAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_SearchPhoneNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private System.Windows.Forms.Button BTN_SearchCustomer;
    }
}