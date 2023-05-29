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
            this.LL_Forklaring = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_OpdaterOrdre
            // 
            this.LB_OpdaterOrdre.AutoSize = true;
            this.LB_OpdaterOrdre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_OpdaterOrdre.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_OpdaterOrdre.Location = new System.Drawing.Point(368, 14);
            this.LB_OpdaterOrdre.Name = "LB_OpdaterOrdre";
            this.LB_OpdaterOrdre.Size = new System.Drawing.Size(237, 37);
            this.LB_OpdaterOrdre.TabIndex = 17;
            this.LB_OpdaterOrdre.Text = "Opdater Ordre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.LB_OpdaterOrdre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 78);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(60, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ordre Status :";
            // 
            // LB_ShowOrderStatus
            // 
            this.LB_ShowOrderStatus.AutoSize = true;
            this.LB_ShowOrderStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.LB_ShowOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowOrderStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowOrderStatus.Location = new System.Drawing.Point(304, 149);
            this.LB_ShowOrderStatus.Name = "LB_ShowOrderStatus";
            this.LB_ShowOrderStatus.Size = new System.Drawing.Size(345, 37);
            this.LB_ShowOrderStatus.TabIndex = 19;
            this.LB_ShowOrderStatus.Text = "LB_ShowOrderStatus";
            // 
            // LB_ShowTotalPrice
            // 
            this.LB_ShowTotalPrice.AutoSize = true;
            this.LB_ShowTotalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.LB_ShowTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_ShowTotalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_ShowTotalPrice.Location = new System.Drawing.Point(368, 218);
            this.LB_ShowTotalPrice.Name = "LB_ShowTotalPrice";
            this.LB_ShowTotalPrice.Size = new System.Drawing.Size(315, 37);
            this.LB_ShowTotalPrice.TabIndex = 21;
            this.LB_ShowTotalPrice.Text = "LB_ShowTotalPrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(60, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ordre Total Pris :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(60, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ny Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(60, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ny TotalPris :";
            // 
            // TB_NewStatus
            // 
            this.TB_NewStatus.Location = new System.Drawing.Point(375, 297);
            this.TB_NewStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NewStatus.Name = "TB_NewStatus";
            this.TB_NewStatus.Size = new System.Drawing.Size(316, 26);
            this.TB_NewStatus.TabIndex = 24;
            // 
            // TB_NewTotalPrice
            // 
            this.TB_NewTotalPrice.Location = new System.Drawing.Point(375, 366);
            this.TB_NewTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_NewTotalPrice.Name = "TB_NewTotalPrice";
            this.TB_NewTotalPrice.Size = new System.Drawing.Size(316, 26);
            this.TB_NewTotalPrice.TabIndex = 25;
            // 
            // BTN_UpdateOrdre
            // 
            this.BTN_UpdateOrdre.BackColor = System.Drawing.Color.White;
            this.BTN_UpdateOrdre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_UpdateOrdre.Location = new System.Drawing.Point(514, 431);
            this.BTN_UpdateOrdre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_UpdateOrdre.Name = "BTN_UpdateOrdre";
            this.BTN_UpdateOrdre.Size = new System.Drawing.Size(178, 69);
            this.BTN_UpdateOrdre.TabIndex = 26;
            this.BTN_UpdateOrdre.Text = "OpdaterOrdre";
            this.BTN_UpdateOrdre.UseVisualStyleBackColor = false;
            // 
            // LL_Forklaring
            // 
            this.LL_Forklaring.AutoSize = true;
            this.LL_Forklaring.LinkColor = System.Drawing.Color.White;
            this.LL_Forklaring.Location = new System.Drawing.Point(858, 231);
            this.LL_Forklaring.Name = "LL_Forklaring";
            this.LL_Forklaring.Size = new System.Drawing.Size(79, 20);
            this.LL_Forklaring.TabIndex = 88;
            this.LL_Forklaring.TabStop = true;
            this.LL_Forklaring.Text = "Forklaring";
            this.LL_Forklaring.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Forklaring_LinkClicked);
            // 
            // OpdaterOrdre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(978, 792);
            this.Controls.Add(this.LL_Forklaring);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.LinkLabel LL_Forklaring;
    }
}