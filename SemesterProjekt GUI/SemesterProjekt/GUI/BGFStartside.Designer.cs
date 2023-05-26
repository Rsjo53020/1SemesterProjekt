namespace SemesterProjekt.GUI
{
    partial class BGFStartside
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
            this.BTN_Butik = new System.Windows.Forms.Button();
            this.BTN_Kunde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Butik
            // 
            this.BTN_Butik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Butik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BTN_Butik.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTN_Butik.Location = new System.Drawing.Point(163, 173);
            this.BTN_Butik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Butik.Name = "BTN_Butik";
            this.BTN_Butik.Size = new System.Drawing.Size(459, 236);
            this.BTN_Butik.TabIndex = 0;
            this.BTN_Butik.Text = "BUTIK";
            this.BTN_Butik.UseVisualStyleBackColor = true;
            this.BTN_Butik.Visible = false;
            // 
            // BTN_Kunde
            // 
            this.BTN_Kunde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BTN_Kunde.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTN_Kunde.Location = new System.Drawing.Point(784, 173);
            this.BTN_Kunde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Kunde.Name = "BTN_Kunde";
            this.BTN_Kunde.Size = new System.Drawing.Size(459, 236);
            this.BTN_Kunde.TabIndex = 1;
            this.BTN_Kunde.Text = "KUNDE";
            this.BTN_Kunde.UseVisualStyleBackColor = true;
            // 
            // BGFStartside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1283, 604);
            this.Controls.Add(this.BTN_Kunde);
            this.Controls.Add(this.BTN_Butik);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BGFStartside";
            this.Text = "BGFStartside";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Butik;
        private System.Windows.Forms.Button BTN_Kunde;
    }
}