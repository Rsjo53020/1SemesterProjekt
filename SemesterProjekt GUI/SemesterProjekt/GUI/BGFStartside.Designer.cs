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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Butik
            // 
            this.BTN_Butik.BackColor = System.Drawing.Color.White;
            this.BTN_Butik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Butik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Butik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BTN_Butik.ForeColor = System.Drawing.Color.Black;
            this.BTN_Butik.Location = new System.Drawing.Point(0, 344);
            this.BTN_Butik.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Butik.Name = "BTN_Butik";
            this.BTN_Butik.Size = new System.Drawing.Size(1067, 210);
            this.BTN_Butik.TabIndex = 0;
            this.BTN_Butik.Text = "BUTIK";
            this.BTN_Butik.UseVisualStyleBackColor = false;
            this.BTN_Butik.Click += new System.EventHandler(this.BTN_Butik_Click);
            // 
            // BTN_Kunde
            // 
            this.BTN_Kunde.BackColor = System.Drawing.Color.White;
            this.BTN_Kunde.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Kunde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BTN_Kunde.ForeColor = System.Drawing.Color.Black;
            this.BTN_Kunde.Location = new System.Drawing.Point(0, 134);
            this.BTN_Kunde.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Kunde.Name = "BTN_Kunde";
            this.BTN_Kunde.Size = new System.Drawing.Size(1067, 210);
            this.BTN_Kunde.TabIndex = 1;
            this.BTN_Kunde.Text = "KUNDE";
            this.BTN_Kunde.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "SYNSPUNKT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(480, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vælg Handling";
            // 
            // BGFStartside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Kunde);
            this.Controls.Add(this.BTN_Butik);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BGFStartside";
            this.Text = "BGFStartside";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Butik;
        private System.Windows.Forms.Button BTN_Kunde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}