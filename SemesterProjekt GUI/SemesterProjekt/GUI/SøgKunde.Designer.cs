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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_FindOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Tlf = new System.Windows.Forms.TextBox();
            this.TB_EMail = new System.Windows.Forms.TextBox();
            this.dataGridView1_SearchCustomer = new System.Windows.Forms.DataGridView();
            this.BTN_SearchCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_SearchCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.LB_FindOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 79);
            this.panel1.TabIndex = 0;
            // 
            // LB_FindOrder
            // 
            this.LB_FindOrder.AutoSize = true;
            this.LB_FindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LB_FindOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_FindOrder.Location = new System.Drawing.Point(430, 28);
            this.LB_FindOrder.Name = "LB_FindOrder";
            this.LB_FindOrder.Size = new System.Drawing.Size(184, 37);
            this.LB_FindOrder.TabIndex = 17;
            this.LB_FindOrder.Text = "Søg Kunde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kunde Tlf + 45 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(63, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kunde E-Mail :";
            // 
            // TB_Tlf
            // 
            this.TB_Tlf.Location = new System.Drawing.Point(300, 136);
            this.TB_Tlf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Tlf.Name = "TB_Tlf";
            this.TB_Tlf.Size = new System.Drawing.Size(365, 26);
            this.TB_Tlf.TabIndex = 20;
            // 
            // TB_EMail
            // 
            this.TB_EMail.Location = new System.Drawing.Point(300, 188);
            this.TB_EMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_EMail.Name = "TB_EMail";
            this.TB_EMail.Size = new System.Drawing.Size(365, 26);
            this.TB_EMail.TabIndex = 21;
            // 
            // dataGridView1_SearchCustomer
            // 
            this.dataGridView1_SearchCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1_SearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_SearchCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1_SearchCustomer.Location = new System.Drawing.Point(0, 267);
            this.dataGridView1_SearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1_SearchCustomer.Name = "dataGridView1_SearchCustomer";
            this.dataGridView1_SearchCustomer.RowHeadersWidth = 51;
            this.dataGridView1_SearchCustomer.RowTemplate.Height = 24;
            this.dataGridView1_SearchCustomer.Size = new System.Drawing.Size(978, 525);
            this.dataGridView1_SearchCustomer.TabIndex = 22;
            // 
            // BTN_SearchCustomer
            // 
            this.BTN_SearchCustomer.BackColor = System.Drawing.Color.White;
            this.BTN_SearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SearchCustomer.Location = new System.Drawing.Point(702, 136);
            this.BTN_SearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_SearchCustomer.Name = "BTN_SearchCustomer";
            this.BTN_SearchCustomer.Size = new System.Drawing.Size(183, 79);
            this.BTN_SearchCustomer.TabIndex = 23;
            this.BTN_SearchCustomer.Text = "Søg Kunde";
            this.BTN_SearchCustomer.UseVisualStyleBackColor = false;
            // 
            // SøgKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(978, 792);
            this.Controls.Add(this.BTN_SearchCustomer);
            this.Controls.Add(this.dataGridView1_SearchCustomer);
            this.Controls.Add(this.TB_EMail);
            this.Controls.Add(this.TB_Tlf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SøgKunde";
            this.Text = "SøgKunde";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_SearchCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_FindOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Tlf;
        private System.Windows.Forms.TextBox TB_EMail;
        private System.Windows.Forms.DataGridView dataGridView1_SearchCustomer;
        private System.Windows.Forms.Button BTN_SearchCustomer;
    }
}