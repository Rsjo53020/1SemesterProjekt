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
            this.BT_Butik = new System.Windows.Forms.Button();
            this.BT_Kunde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Butik
            // 
            this.BT_Butik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Butik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BT_Butik.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_Butik.Location = new System.Drawing.Point(244, 270);
            this.BT_Butik.Name = "BT_Butik";
            this.BT_Butik.Size = new System.Drawing.Size(688, 369);
            this.BT_Butik.TabIndex = 0;
            this.BT_Butik.Text = "BUTIK";
            this.BT_Butik.UseVisualStyleBackColor = true;
            this.BT_Butik.Visible = false;
            // 
            // BT_Kunde
            // 
            this.BT_Kunde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BT_Kunde.ForeColor = System.Drawing.Color.Gainsboro;
            this.BT_Kunde.Location = new System.Drawing.Point(1176, 270);
            this.BT_Kunde.Name = "BT_Kunde";
            this.BT_Kunde.Size = new System.Drawing.Size(688, 369);
            this.BT_Kunde.TabIndex = 1;
            this.BT_Kunde.Text = "KUNDE";
            this.BT_Kunde.UseVisualStyleBackColor = true;
            // 
            // BGFStartside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(2067, 944);
            this.Controls.Add(this.BT_Kunde);
            this.Controls.Add(this.BT_Butik);
            this.Name = "BGFStartside";
            this.Text = "BGFStartside";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Butik;
        private System.Windows.Forms.Button BT_Kunde;
    }
}