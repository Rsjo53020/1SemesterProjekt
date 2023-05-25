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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LB_OrderDateEnd = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LB_OrderDateStart = new System.Windows.Forms.Label();
            this.LB_Orders = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PANEL_FindOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_FindOrder);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(1259, 100);
            this.PANEL_FindOrder.TabIndex = 31;
            // 
            // LB_FindOrder
            // 
            this.LB_FindOrder.AutoSize = true;
            this.LB_FindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_FindOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_FindOrder.Location = new System.Drawing.Point(44, 28);
            this.LB_FindOrder.Name = "LB_FindOrder";
            this.LB_FindOrder.Size = new System.Drawing.Size(165, 37);
            this.LB_FindOrder.TabIndex = 16;
            this.LB_FindOrder.Text = "Søg Ordre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 43);
            this.dateTimePicker1.TabIndex = 33;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker2.Location = new System.Drawing.Point(324, 140);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(318, 43);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // LB_OrderDateStart
            // 
            this.LB_OrderDateStart.AutoSize = true;
            this.LB_OrderDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderDateStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderDateStart.Location = new System.Drawing.Point(44, 146);
            this.LB_OrderDateStart.Name = "LB_OrderDateStart";
            this.LB_OrderDateStart.Size = new System.Drawing.Size(249, 37);
            this.LB_OrderDateStart.TabIndex = 34;
            this.LB_OrderDateStart.Text = "Ordre Dato Slut:";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(964, 391);
            this.dataGridView1.TabIndex = 37;
            // 
            // SøgOrdre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1259, 674);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LB_Orders);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.LB_OrderDateStart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LB_OrderDateEnd);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Name = "SøgOrdre";
            this.Text = "SøgOrdre";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_FindOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LB_OrderDateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LB_OrderDateStart;
        private System.Windows.Forms.Label LB_Orders;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}