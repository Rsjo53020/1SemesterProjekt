namespace SemesterProjekt.GUI
{
    partial class SøgOrdre
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
            this.LB_FindOrder = new System.Windows.Forms.Label();
            this.DTP_EndDate = new System.Windows.Forms.DateTimePicker();
            this.LB_OrderDateEnd = new System.Windows.Forms.Label();
            this.DTP_StartDate = new System.Windows.Forms.DateTimePicker();
            this.LB_OrderDateStart = new System.Windows.Forms.Label();
            this.LB_Orders = new System.Windows.Forms.Label();
            this.DGV_ShowOrder = new System.Windows.Forms.DataGridView();
            this.BTN_SearchOrder = new System.Windows.Forms.Button();
            this.BTN_DeleteOrder = new System.Windows.Forms.Button();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_FindOrder);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(978, 100);
            this.PANEL_FindOrder.TabIndex = 31;
            // 
            // LB_FindOrder
            // 
            this.LB_FindOrder.AutoSize = true;
            this.LB_FindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_FindOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_FindOrder.Location = new System.Drawing.Point(558, 31);
            this.LB_FindOrder.Name = "LB_FindOrder";
            this.LB_FindOrder.Size = new System.Drawing.Size(174, 37);
            this.LB_FindOrder.TabIndex = 16;
            this.LB_FindOrder.Text = "Søg Ordre";
            // 
            // DTP_EndDate
            // 
            this.DTP_EndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DTP_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DTP_EndDate.Location = new System.Drawing.Point(324, 189);
            this.DTP_EndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP_EndDate.Name = "DTP_EndDate";
            this.DTP_EndDate.Size = new System.Drawing.Size(318, 43);
            this.DTP_EndDate.TabIndex = 33;
            // 
            // LB_OrderDateEnd
            // 
            this.LB_OrderDateEnd.AutoSize = true;
            this.LB_OrderDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderDateEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderDateEnd.Location = new System.Drawing.Point(44, 195);
            this.LB_OrderDateEnd.Name = "LB_OrderDateEnd";
            this.LB_OrderDateEnd.Size = new System.Drawing.Size(249, 37);
            this.LB_OrderDateEnd.TabIndex = 32;
            this.LB_OrderDateEnd.Text = "Ordre Dato Slut:";
            // 
            // DTP_StartDate
            // 
            this.DTP_StartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DTP_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DTP_StartDate.Location = new System.Drawing.Point(324, 140);
            this.DTP_StartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP_StartDate.Name = "DTP_StartDate";
            this.DTP_StartDate.Size = new System.Drawing.Size(318, 43);
            this.DTP_StartDate.TabIndex = 35;
            // 
            // LB_OrderDateStart
            // 
            this.LB_OrderDateStart.AutoSize = true;
            this.LB_OrderDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderDateStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderDateStart.Location = new System.Drawing.Point(44, 146);
            this.LB_OrderDateStart.Name = "LB_OrderDateStart";
            this.LB_OrderDateStart.Size = new System.Drawing.Size(262, 37);
            this.LB_OrderDateStart.TabIndex = 34;
            this.LB_OrderDateStart.Text = "Ordre Dato Start:";
            // 
            // LB_Orders
            // 
            this.LB_Orders.AutoSize = true;
            this.LB_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_Orders.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_Orders.Location = new System.Drawing.Point(44, 271);
            this.LB_Orders.Name = "LB_Orders";
            this.LB_Orders.Size = new System.Drawing.Size(185, 37);
            this.LB_Orders.TabIndex = 36;
            this.LB_Orders.Text = "Ordre Dato:";
            // 
            // DGV_ShowOrder
            // 
            this.DGV_ShowOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_ShowOrder.Location = new System.Drawing.Point(0, 377);
            this.DGV_ShowOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_ShowOrder.Name = "DGV_ShowOrder";
            this.DGV_ShowOrder.RowHeadersWidth = 62;
            this.DGV_ShowOrder.RowTemplate.Height = 28;
            this.DGV_ShowOrder.Size = new System.Drawing.Size(978, 415);
            this.DGV_ShowOrder.TabIndex = 37;
            // 
            // BTN_SearchOrder
            // 
            this.BTN_SearchOrder.BackColor = System.Drawing.Color.White;
            this.BTN_SearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTN_SearchOrder.Location = new System.Drawing.Point(677, 119);
            this.BTN_SearchOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_SearchOrder.Name = "BTN_SearchOrder";
            this.BTN_SearchOrder.Size = new System.Drawing.Size(289, 91);
            this.BTN_SearchOrder.TabIndex = 38;
            this.BTN_SearchOrder.Text = "Søg Ordre";
            this.BTN_SearchOrder.UseVisualStyleBackColor = false;
            // 
            // BTN_DeleteOrder
            // 
            this.BTN_DeleteOrder.BackColor = System.Drawing.Color.White;
            this.BTN_DeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_DeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTN_DeleteOrder.Location = new System.Drawing.Point(677, 261);
            this.BTN_DeleteOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_DeleteOrder.Name = "BTN_DeleteOrder";
            this.BTN_DeleteOrder.Size = new System.Drawing.Size(289, 91);
            this.BTN_DeleteOrder.TabIndex = 39;
            this.BTN_DeleteOrder.Text = "Slet Ordre";
            this.BTN_DeleteOrder.UseVisualStyleBackColor = false;
            // 
            // SøgOrdre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(978, 792);
            this.Controls.Add(this.BTN_DeleteOrder);
            this.Controls.Add(this.BTN_SearchOrder);
            this.Controls.Add(this.DGV_ShowOrder);
            this.Controls.Add(this.LB_Orders);
            this.Controls.Add(this.DTP_StartDate);
            this.Controls.Add(this.LB_OrderDateStart);
            this.Controls.Add(this.DTP_EndDate);
            this.Controls.Add(this.LB_OrderDateEnd);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SøgOrdre";
            this.Text = "SøgOrdre";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_FindOrder;
        private System.Windows.Forms.DateTimePicker DTP_EndDate;
        private System.Windows.Forms.Label LB_OrderDateEnd;
        private System.Windows.Forms.DateTimePicker DTP_StartDate;
        private System.Windows.Forms.Label LB_OrderDateStart;
        private System.Windows.Forms.Label LB_Orders;
        private System.Windows.Forms.DataGridView DGV_ShowOrder;
        private System.Windows.Forms.Button BTN_SearchOrder;
        private System.Windows.Forms.Button BTN_DeleteOrder;
    }
}