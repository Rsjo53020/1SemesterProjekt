namespace SemesterProjekt.GUI
{
    partial class OpdaterOrdre
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
            this.LB_OpdaterOrdre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_ShowOrderStatus = new System.Windows.Forms.Label();
            this.LB_ShowTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_NewStatus = new System.Windows.Forms.TextBox();
            this.TB_NewTotalPrice = new System.Windows.Forms.TextBox();
            this.BTN_UpdateOrdre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_OpdaterOrdre
            // 
            this.LB_OpdaterOrdre.AutoSize = true;
            this.LB_OpdaterOrdre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_OpdaterOrdre.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OpdaterOrdre.Location = new System.Drawing.Point(245, 9);
            this.LB_OpdaterOrdre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_OpdaterOrdre.Name = "LB_OpdaterOrdre";
            this.LB_OpdaterOrdre.Size = new System.Drawing.Size(162, 25);
            this.LB_OpdaterOrdre.TabIndex = 17;
            this.LB_OpdaterOrdre.Text = "Opdater Ordre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.LB_OpdaterOrdre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 51);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(40, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ordre Status :";
            // 
            // LB_ShowOrderStatus
            // 
            this.LB_ShowOrderStatus.AutoSize = true;
            this.LB_ShowOrderStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.LB_ShowOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowOrderStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowOrderStatus.Location = new System.Drawing.Point(203, 97);
            this.LB_ShowOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowOrderStatus.Name = "LB_ShowOrderStatus";
            this.LB_ShowOrderStatus.Size = new System.Drawing.Size(236, 25);
            this.LB_ShowOrderStatus.TabIndex = 19;
            this.LB_ShowOrderStatus.Text = "LB_ShowOrderStatus";
            // 
            // LB_ShowTotalPrice
            // 
            this.LB_ShowTotalPrice.AutoSize = true;
            this.LB_ShowTotalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.LB_ShowTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowTotalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowTotalPrice.Location = new System.Drawing.Point(245, 142);
            this.LB_ShowTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ShowTotalPrice.Name = "LB_ShowTotalPrice";
            this.LB_ShowTotalPrice.Size = new System.Drawing.Size(217, 25);
            this.LB_ShowTotalPrice.TabIndex = 21;
            this.LB_ShowTotalPrice.Text = "LB_ShowTotalPrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(40, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ordre Total Pris :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(40, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ny Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(40, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ny TotalPris :";
            // 
            // TB_NewStatus
            // 
            this.TB_NewStatus.Location = new System.Drawing.Point(250, 193);
            this.TB_NewStatus.Name = "TB_NewStatus";
            this.TB_NewStatus.Size = new System.Drawing.Size(212, 20);
            this.TB_NewStatus.TabIndex = 24;
            // 
            // TB_NewTotalPrice
            // 
            this.TB_NewTotalPrice.Location = new System.Drawing.Point(250, 238);
            this.TB_NewTotalPrice.Name = "TB_NewTotalPrice";
            this.TB_NewTotalPrice.Size = new System.Drawing.Size(212, 20);
            this.TB_NewTotalPrice.TabIndex = 25;
            // 
            // BTN_UpdateOrdre
            // 
            this.BTN_UpdateOrdre.BackColor = System.Drawing.Color.White;
            this.BTN_UpdateOrdre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_UpdateOrdre.Location = new System.Drawing.Point(343, 280);
            this.BTN_UpdateOrdre.Name = "BTN_UpdateOrdre";
            this.BTN_UpdateOrdre.Size = new System.Drawing.Size(119, 45);
            this.BTN_UpdateOrdre.TabIndex = 26;
            this.BTN_UpdateOrdre.Text = "OpdaterOrdre";
            this.BTN_UpdateOrdre.UseVisualStyleBackColor = false;
            // 
            // OpdaterOrdre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.BTN_UpdateOrdre);
            this.Controls.Add(this.TB_NewTotalPrice);
            this.Controls.Add(this.TB_NewStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_ShowTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_ShowOrderStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "OpdaterOrdre";
            this.Text = "OpdaterOrdre";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_OpdaterOrdre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_ShowOrderStatus;
        private System.Windows.Forms.Label LB_ShowTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_NewStatus;
        private System.Windows.Forms.TextBox TB_NewTotalPrice;
        private System.Windows.Forms.Button BTN_UpdateOrdre;
    }
}