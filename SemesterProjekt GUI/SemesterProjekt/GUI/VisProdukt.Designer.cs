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
            this.BTN_FIND = new System.Windows.Forms.Button();
            this.DGV_ShowProduct = new System.Windows.Forms.DataGridView();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(819, 44);
            this.LB_ShowProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(243, 51);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "Vis Produkt";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(4);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(1994, 145);
            this.PANEL_FindOrder.TabIndex = 33;
            this.PANEL_FindOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_FindOrder_Paint);
            // 
            // TB_FindKategory
            // 
            this.TB_FindKategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_FindKategory.Location = new System.Drawing.Point(592, 301);
            this.TB_FindKategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_FindKategory.Name = "TB_FindKategory";
            this.TB_FindKategory.Size = new System.Drawing.Size(589, 55);
            this.TB_FindKategory.TabIndex = 88;
            // 
            // TB_FindProductName
            // 
            this.TB_FindProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_FindProductName.Location = new System.Drawing.Point(592, 183);
            this.TB_FindProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_FindProductName.Name = "TB_FindProductName";
            this.TB_FindProductName.Size = new System.Drawing.Size(589, 55);
            this.TB_FindProductName.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(40, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 48);
            this.label4.TabIndex = 85;
            this.label4.Text = "Kategori:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(40, 190);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(277, 48);
            this.Label2.TabIndex = 83;
            this.Label2.Text = "Produkt navn:";
            // 
            // BTN_FIND
            // 
            this.BTN_FIND.Location = new System.Drawing.Point(1360, 207);
            this.BTN_FIND.Name = "BTN_FIND";
            this.BTN_FIND.Size = new System.Drawing.Size(348, 122);
            this.BTN_FIND.TabIndex = 89;
            this.BTN_FIND.Text = "SØG";
            this.BTN_FIND.UseVisualStyleBackColor = true;
            // 
            // DGV_ShowProduct
            // 
            this.DGV_ShowProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_ShowProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowProduct.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_ShowProduct.Location = new System.Drawing.Point(48, 469);
            this.DGV_ShowProduct.Name = "DGV_ShowProduct";
            this.DGV_ShowProduct.RowHeadersWidth = 82;
            this.DGV_ShowProduct.RowTemplate.Height = 33;
            this.DGV_ShowProduct.Size = new System.Drawing.Size(1660, 438);
            this.DGV_ShowProduct.TabIndex = 90;
            // 
            // VisProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1994, 948);
            this.Controls.Add(this.DGV_ShowProduct);
            this.Controls.Add(this.BTN_FIND);
            this.Controls.Add(this.TB_FindKategory);
            this.Controls.Add(this.TB_FindProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Name = "VisProdukt";
            this.Text = "VisProdukt";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowProduct)).EndInit();
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
        private System.Windows.Forms.Button BTN_FIND;
        private System.Windows.Forms.DataGridView DGV_ShowProduct;
    }
}