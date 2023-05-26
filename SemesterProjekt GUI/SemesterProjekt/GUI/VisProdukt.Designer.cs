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
            this.LB_ShowProduct = new System.Windows.Forms.Label();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.TB_FindKategory = new System.Windows.Forms.TextBox();
            this.TB_FindProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BTN_FindProduct = new System.Windows.Forms.Button();
            this.DGV_ShowFindProduct = new System.Windows.Forms.DataGridView();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowFindProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(546, 28);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(164, 31);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "Vis Produkt";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(1067, 93);
            this.PANEL_FindOrder.TabIndex = 33;
            this.PANEL_FindOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_FindOrder_Paint);
            // 
            // TB_FindKategory
            // 
            this.TB_FindKategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_FindKategory.Location = new System.Drawing.Point(395, 193);
            this.TB_FindKategory.Name = "TB_FindKategory";
            this.TB_FindKategory.Size = new System.Drawing.Size(394, 37);
            this.TB_FindKategory.TabIndex = 88;
            // 
            // TB_FindProductName
            // 
            this.TB_FindProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_FindProductName.Location = new System.Drawing.Point(395, 117);
            this.TB_FindProductName.Name = "TB_FindProductName";
            this.TB_FindProductName.Size = new System.Drawing.Size(394, 37);
            this.TB_FindProductName.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(27, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 85;
            this.label4.Text = "Kategori:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(27, 122);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(182, 31);
            this.Label2.TabIndex = 83;
            this.Label2.Text = "Produkt navn:";
            // 
            // BTN_FindProduct
            // 
            this.BTN_FindProduct.Location = new System.Drawing.Point(813, 150);
            this.BTN_FindProduct.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_FindProduct.Name = "BTN_FindProduct";
            this.BTN_FindProduct.Size = new System.Drawing.Size(232, 78);
            this.BTN_FindProduct.TabIndex = 89;
            this.BTN_FindProduct.Text = "SØG";
            this.BTN_FindProduct.UseVisualStyleBackColor = true;
            // 
            // DGV_ShowFindProduct
            // 
            this.DGV_ShowFindProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_ShowFindProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowFindProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_ShowFindProduct.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_ShowFindProduct.Location = new System.Drawing.Point(0, 274);
            this.DGV_ShowFindProduct.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_ShowFindProduct.Name = "DGV_ShowFindProduct";
            this.DGV_ShowFindProduct.RowHeadersWidth = 82;
            this.DGV_ShowFindProduct.RowTemplate.Height = 33;
            this.DGV_ShowFindProduct.Size = new System.Drawing.Size(1067, 280);
            this.DGV_ShowFindProduct.TabIndex = 90;
            // 
            // VisProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowFindProduct)).EndInit();
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
    }
}