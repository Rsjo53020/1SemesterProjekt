namespace SemesterProjekt.GUI
{
    partial class FundetOrdre
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
            this.LB_FoundOrder = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TB_LineID = new System.Windows.Forms.TextBox();
            this.LB_LineID = new System.Windows.Forms.Label();
            this.TB_CustomerID = new System.Windows.Forms.TextBox();
            this.LB_CustomerID = new System.Windows.Forms.Label();
            this.TB_VAT = new System.Windows.Forms.TextBox();
            this.LB_VAT = new System.Windows.Forms.Label();
            this.TB_TotalPrice = new System.Windows.Forms.TextBox();
            this.LB_TotalPrice = new System.Windows.Forms.Label();
            this.TB_OrderStatus = new System.Windows.Forms.TextBox();
            this.LB_OrderStatus = new System.Windows.Forms.Label();
            this.LB_OrderDate = new System.Windows.Forms.Label();
            this.TB_OrderID = new System.Windows.Forms.TextBox();
            this.LB_OrderID = new System.Windows.Forms.Label();
            this.BTN_PrintToTxt = new System.Windows.Forms.Button();
            this.BTN_UpdateOrder = new System.Windows.Forms.Button();
            this.PANEL_FindOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_FindOrder
            // 
            this.PANEL_FindOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PANEL_FindOrder.Controls.Add(this.LB_FoundOrder);
            this.PANEL_FindOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_FindOrder.Location = new System.Drawing.Point(0, 0);
            this.PANEL_FindOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PANEL_FindOrder.Name = "PANEL_FindOrder";
            this.PANEL_FindOrder.Size = new System.Drawing.Size(1067, 80);
            this.PANEL_FindOrder.TabIndex = 30;
            // 
            // LB_FoundOrder
            // 
            this.LB_FoundOrder.AutoSize = true;
            this.LB_FoundOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_FoundOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_FoundOrder.Location = new System.Drawing.Point(481, 28);
            this.LB_FoundOrder.Name = "LB_FoundOrder";
            this.LB_FoundOrder.Size = new System.Drawing.Size(187, 31);
            this.LB_FoundOrder.TabIndex = 16;
            this.LB_FoundOrder.Text = "Fundet Ordre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 173);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 37);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // TB_LineID
            // 
            this.TB_LineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_LineID.Location = new System.Drawing.Point(638, 116);
            this.TB_LineID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_LineID.Multiline = true;
            this.TB_LineID.Name = "TB_LineID";
            this.TB_LineID.Size = new System.Drawing.Size(417, 285);
            this.TB_LineID.TabIndex = 28;
            // 
            // LB_LineID
            // 
            this.LB_LineID.AutoSize = true;
            this.LB_LineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_LineID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_LineID.Location = new System.Drawing.Point(438, 111);
            this.LB_LineID.Name = "LB_LineID";
            this.LB_LineID.Size = new System.Drawing.Size(140, 31);
            this.LB_LineID.TabIndex = 27;
            this.LB_LineID.Text = "Produkter:";
            // 
            // TB_CustomerID
            // 
            this.TB_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_CustomerID.Location = new System.Drawing.Point(242, 233);
            this.TB_CustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_CustomerID.Name = "TB_CustomerID";
            this.TB_CustomerID.Size = new System.Drawing.Size(344, 37);
            this.TB_CustomerID.TabIndex = 26;
            // 
            // LB_CustomerID
            // 
            this.LB_CustomerID.AutoSize = true;
            this.LB_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_CustomerID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_CustomerID.Location = new System.Drawing.Point(51, 238);
            this.LB_CustomerID.Name = "LB_CustomerID";
            this.LB_CustomerID.Size = new System.Drawing.Size(100, 31);
            this.LB_CustomerID.TabIndex = 25;
            this.LB_CustomerID.Text = "Kunde:";
            // 
            // TB_VAT
            // 
            this.TB_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_VAT.Location = new System.Drawing.Point(242, 298);
            this.TB_VAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_VAT.Name = "TB_VAT";
            this.TB_VAT.Size = new System.Drawing.Size(232, 37);
            this.TB_VAT.TabIndex = 24;
            // 
            // LB_VAT
            // 
            this.LB_VAT.AutoSize = true;
            this.LB_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_VAT.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_VAT.Location = new System.Drawing.Point(51, 302);
            this.LB_VAT.Name = "LB_VAT";
            this.LB_VAT.Size = new System.Drawing.Size(83, 31);
            this.LB_VAT.TabIndex = 23;
            this.LB_VAT.Text = "Butik:";
            // 
            // TB_TotalPrice
            // 
            this.TB_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_TotalPrice.Location = new System.Drawing.Point(823, 488);
            this.TB_TotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_TotalPrice.Name = "TB_TotalPrice";
            this.TB_TotalPrice.Size = new System.Drawing.Size(232, 37);
            this.TB_TotalPrice.TabIndex = 22;
            // 
            // LB_TotalPrice
            // 
            this.LB_TotalPrice.AutoSize = true;
            this.LB_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_TotalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_TotalPrice.Location = new System.Drawing.Point(632, 493);
            this.LB_TotalPrice.Name = "LB_TotalPrice";
            this.LB_TotalPrice.Size = new System.Drawing.Size(137, 31);
            this.LB_TotalPrice.TabIndex = 21;
            this.LB_TotalPrice.Text = "Pris Total:";
            // 
            // TB_OrderStatus
            // 
            this.TB_OrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OrderStatus.Location = new System.Drawing.Point(242, 359);
            this.TB_OrderStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_OrderStatus.Name = "TB_OrderStatus";
            this.TB_OrderStatus.Size = new System.Drawing.Size(136, 37);
            this.TB_OrderStatus.TabIndex = 20;
            // 
            // LB_OrderStatus
            // 
            this.LB_OrderStatus.AutoSize = true;
            this.LB_OrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderStatus.Location = new System.Drawing.Point(51, 364);
            this.LB_OrderStatus.Name = "LB_OrderStatus";
            this.LB_OrderStatus.Size = new System.Drawing.Size(176, 31);
            this.LB_OrderStatus.TabIndex = 19;
            this.LB_OrderStatus.Text = "Ordre Status:";
            // 
            // LB_OrderDate
            // 
            this.LB_OrderDate.AutoSize = true;
            this.LB_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderDate.Location = new System.Drawing.Point(51, 178);
            this.LB_OrderDate.Name = "LB_OrderDate";
            this.LB_OrderDate.Size = new System.Drawing.Size(156, 31);
            this.LB_OrderDate.TabIndex = 18;
            this.LB_OrderDate.Text = "Ordre Dato:";
            // 
            // TB_OrderID
            // 
            this.TB_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TB_OrderID.Location = new System.Drawing.Point(242, 111);
            this.TB_OrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_OrderID.Name = "TB_OrderID";
            this.TB_OrderID.Size = new System.Drawing.Size(136, 37);
            this.TB_OrderID.TabIndex = 17;
            // 
            // LB_OrderID
            // 
            this.LB_OrderID.AutoSize = true;
            this.LB_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LB_OrderID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OrderID.Location = new System.Drawing.Point(51, 116);
            this.LB_OrderID.Name = "LB_OrderID";
            this.LB_OrderID.Size = new System.Drawing.Size(126, 31);
            this.LB_OrderID.TabIndex = 16;
            this.LB_OrderID.Text = "Ordre ID:";
            // 
            // BTN_PrintToTxt
            // 
            this.BTN_PrintToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTN_PrintToTxt.Location = new System.Drawing.Point(330, 451);
            this.BTN_PrintToTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_PrintToTxt.Name = "BTN_PrintToTxt";
            this.BTN_PrintToTxt.Size = new System.Drawing.Size(288, 73);
            this.BTN_PrintToTxt.TabIndex = 31;
            this.BTN_PrintToTxt.Text = "Udskriv til .txt fil";
            this.BTN_PrintToTxt.UseVisualStyleBackColor = true;
            // 
            // BTN_UpdateOrder
            // 
            this.BTN_UpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BTN_UpdateOrder.Location = new System.Drawing.Point(22, 451);
            this.BTN_UpdateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_UpdateOrder.Name = "BTN_UpdateOrder";
            this.BTN_UpdateOrder.Size = new System.Drawing.Size(288, 73);
            this.BTN_UpdateOrder.TabIndex = 32;
            this.BTN_UpdateOrder.Text = "Opdater Ordre";
            this.BTN_UpdateOrder.UseVisualStyleBackColor = true;
            // 
            // FundetOrdre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BTN_UpdateOrder);
            this.Controls.Add(this.BTN_PrintToTxt);
            this.Controls.Add(this.PANEL_FindOrder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TB_LineID);
            this.Controls.Add(this.LB_LineID);
            this.Controls.Add(this.TB_CustomerID);
            this.Controls.Add(this.LB_CustomerID);
            this.Controls.Add(this.TB_VAT);
            this.Controls.Add(this.LB_VAT);
            this.Controls.Add(this.TB_TotalPrice);
            this.Controls.Add(this.LB_TotalPrice);
            this.Controls.Add(this.TB_OrderStatus);
            this.Controls.Add(this.LB_OrderStatus);
            this.Controls.Add(this.LB_OrderDate);
            this.Controls.Add(this.TB_OrderID);
            this.Controls.Add(this.LB_OrderID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FundetOrdre";
            this.Text = "FundetOrdre";
            this.PANEL_FindOrder.ResumeLayout(false);
            this.PANEL_FindOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_FindOrder;
        private System.Windows.Forms.Label LB_FoundOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TB_LineID;
        private System.Windows.Forms.Label LB_LineID;
        private System.Windows.Forms.TextBox TB_CustomerID;
        private System.Windows.Forms.Label LB_CustomerID;
        private System.Windows.Forms.TextBox TB_VAT;
        private System.Windows.Forms.Label LB_VAT;
        private System.Windows.Forms.TextBox TB_TotalPrice;
        private System.Windows.Forms.Label LB_TotalPrice;
        private System.Windows.Forms.TextBox TB_OrderStatus;
        private System.Windows.Forms.Label LB_OrderStatus;
        private System.Windows.Forms.Label LB_OrderDate;
        private System.Windows.Forms.TextBox TB_OrderID;
        private System.Windows.Forms.Label LB_OrderID;
        private System.Windows.Forms.Button BTN_PrintToTxt;
        private System.Windows.Forms.Button BTN_UpdateOrder;
    }
}