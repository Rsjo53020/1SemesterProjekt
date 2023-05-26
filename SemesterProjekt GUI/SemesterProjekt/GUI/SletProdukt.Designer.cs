namespace SemesterProjekt.GUI
{
    partial class SletProdukt
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
            this.DGV_DeleteSelectProduct = new System.Windows.Forms.DataGridView();
            this.BTN_DeleteProduct = new System.Windows.Forms.Button();
            this.BTN_DeleteFindProdukt = new System.Windows.Forms.Button();
            this.TB_DeleteFindKategory = new System.Windows.Forms.TextBox();
            this.TB_DeleteFindProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PANEL_FindOrder = new System.Windows.Forms.Panel();
            this.LB_ShowProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DeleteSelectProduct)).BeginInit();
            this.PANEL_FindOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_DeleteSelectProduct
            // 
            this.DGV_DeleteSelectProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_DeleteSelectProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DeleteSelectProduct.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_DeleteSelectProduct.Location = new System.Drawing.Point(41, 336);
            this.DGV_DeleteSelectProduct.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_DeleteSelectProduct.Name = "DGV_DeleteSelectProduct";
            this.DGV_DeleteSelectProduct.RowHeadersWidth = 82;
            this.DGV_DeleteSelectProduct.RowTemplate.Height = 33;
            this.DGV_DeleteSelectProduct.Size = new System.Drawing.Size(802, 184);
            this.DGV_DeleteSelectProduct.TabIndex = 119;
            // 
            // BTN_DeleteProduct
            // 
            this.BTN_DeleteProduct.BackColor = System.Drawing.Color.White;
            this.BTN_DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DeleteProduct.Location = new System.Drawing.Point(626, 531);
            this.BTN_DeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DeleteProduct.Name = "BTN_DeleteProduct";
            this.BTN_DeleteProduct.Size = new System.Drawing.Size(217, 92);
            this.BTN_DeleteProduct.TabIndex = 118;
            this.BTN_DeleteProduct.Text = "Slet Produkt";
            this.BTN_DeleteProduct.UseVisualStyleBackColor = false;
            // 
            // BTN_DeleteFindProdukt
            // 
            this.BTN_DeleteFindProdukt.BackColor = System.Drawing.Color.White;
            this.BTN_DeleteFindProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DeleteFindProdukt.Location = new System.Drawing.Point(626, 246);
            this.BTN_DeleteFindProdukt.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DeleteFindProdukt.Name = "BTN_DeleteFindProdukt";
            this.BTN_DeleteFindProdukt.Size = new System.Drawing.Size(217, 86);
            this.BTN_DeleteFindProdukt.TabIndex = 117;
            this.BTN_DeleteFindProdukt.Text = "Vis Produkt";
            this.BTN_DeleteFindProdukt.UseVisualStyleBackColor = false;
            // 
            // TB_DeleteFindKategory
            // 
            this.TB_DeleteFindKategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_DeleteFindKategory.Location = new System.Drawing.Point(403, 194);
            this.TB_DeleteFindKategory.Name = "TB_DeleteFindKategory";
            this.TB_DeleteFindKategory.Size = new System.Drawing.Size(389, 37);
            this.TB_DeleteFindKategory.TabIndex = 116;
            // 
            // TB_DeleteFindProductName
            // 
            this.TB_DeleteFindProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_DeleteFindProductName.Location = new System.Drawing.Point(403, 118);
            this.TB_DeleteFindProductName.Name = "TB_DeleteFindProductName";
            this.TB_DeleteFindProductName.Size = new System.Drawing.Size(389, 37);
            this.TB_DeleteFindProductName.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(35, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 114;
            this.label4.Text = "Kategori:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Label2.Location = new System.Drawing.Point(35, 123);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(182, 31);
            this.Label2.TabIndex = 113;
            this.Label2.Text = "Produkt navn:";
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_ShowProduct);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(869, 93);
            this.PANEL_FindOrder.TabIndex = 112;
            // 
            // LB_ShowProduct
            // 
            this.LB_ShowProduct.AutoSize = true;
            this.LB_ShowProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LB_ShowProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowProduct.Location = new System.Drawing.Point(397, 39);
            this.LB_ShowProduct.Name = "LB_ShowProduct";
            this.LB_ShowProduct.Size = new System.Drawing.Size(235, 31);
            this.LB_ShowProduct.TabIndex = 16;
            this.LB_ShowProduct.Text = "SLET PRODUKT";
            // 
            // SletProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(869, 634);
            this.Controls.Add(this.DGV_DeleteSelectProduct);
            this.Controls.Add(this.BTN_DeleteProduct);
            this.Controls.Add(this.BTN_DeleteFindProdukt);
            this.Controls.Add(this.TB_DeleteFindKategory);
            this.Controls.Add(this.TB_DeleteFindProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SletProdukt";
            this.Text = "SletProdukt";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DeleteSelectProduct)).EndInit();
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_DeleteSelectProduct;
        private System.Windows.Forms.Button BTN_DeleteProduct;
        private System.Windows.Forms.Button BTN_DeleteFindProdukt;
        private System.Windows.Forms.TextBox TB_DeleteFindKategory;
        private System.Windows.Forms.TextBox TB_DeleteFindProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_ShowProduct;
    }
}