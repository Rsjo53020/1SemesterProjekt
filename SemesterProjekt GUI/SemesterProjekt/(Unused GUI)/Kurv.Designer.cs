namespace SemesterProjekt.GUI
{
    partial class Kurv
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.LL_Forklaring = new System.Windows.Forms.LinkLabel();
            this.BTN_RemoveItem = new System.Windows.Forms.Button();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.label1);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(1200, 95);
            this.PANEL_FindOrder.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(555, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kurv";
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Customers.Location = new System.Drawing.Point(0, 244);
            this.DGV_Customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.RowHeadersWidth = 62;
            this.DGV_Customers.Size = new System.Drawing.Size(1200, 448);
            this.DGV_Customers.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 98;
            this.label3.Text = "Produkter:";
            // 
            // LL_Forklaring
            // 
            this.LL_Forklaring.AutoSize = true;
            this.LL_Forklaring.LinkColor = System.Drawing.Color.White;
            this.LL_Forklaring.Location = new System.Drawing.Point(1049, 202);
            this.LL_Forklaring.Name = "LL_Forklaring";
            this.LL_Forklaring.Size = new System.Drawing.Size(79, 20);
            this.LL_Forklaring.TabIndex = 99;
            this.LL_Forklaring.TabStop = true;
            this.LL_Forklaring.Text = "Forklaring";
            this.LL_Forklaring.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Forklaring_LinkClicked);
            // 
            // BTN_RemoveItem
            // 
            this.BTN_RemoveItem.BackColor = System.Drawing.Color.White;
            this.BTN_RemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_RemoveItem.Location = new System.Drawing.Point(512, 165);
            this.BTN_RemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_RemoveItem.Name = "BTN_RemoveItem";
            this.BTN_RemoveItem.Size = new System.Drawing.Size(178, 69);
            this.BTN_RemoveItem.TabIndex = 100;
            this.BTN_RemoveItem.Text = "Fjern vare fra kurv";
            this.BTN_RemoveItem.UseVisualStyleBackColor = false;
            // 
            // Kurv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BTN_RemoveItem);
            this.Controls.Add(this.LL_Forklaring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGV_Customers);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Name = "Kurv";
            this.Text = "Form1";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LL_Forklaring;
        private System.Windows.Forms.Button BTN_RemoveItem;
    }
}