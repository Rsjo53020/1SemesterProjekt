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
            this.BTN_Butik.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_Butik.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_Butik.FlatAppearance.BorderSize = 0;
            this.BTN_Butik.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BTN_Butik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BTN_Butik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Butik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BTN_Butik.ForeColor = System.Drawing.Color.White;
            this.BTN_Butik.Location = new System.Drawing.Point(459, 176);
            this.BTN_Butik.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTN_Butik.Name = "BTN_Butik";
            this.BTN_Butik.Size = new System.Drawing.Size(285, 170);
            this.BTN_Butik.TabIndex = 0;
            this.BTN_Butik.Text = "BUTIK";
            this.BTN_Butik.UseVisualStyleBackColor = false;
            this.BTN_Butik.Click += new System.EventHandler(this.BTN_Butik_Click);
            // 
            // BTN_Kunde
            // 
            this.BTN_Kunde.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_Kunde.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.BTN_Kunde.FlatAppearance.BorderSize = 0;
            this.BTN_Kunde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BTN_Kunde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BTN_Kunde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BTN_Kunde.ForeColor = System.Drawing.Color.White;
            this.BTN_Kunde.Location = new System.Drawing.Point(99, 176);
            this.BTN_Kunde.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTN_Kunde.Name = "BTN_Kunde";
            this.BTN_Kunde.Size = new System.Drawing.Size(285, 170);
            this.BTN_Kunde.TabIndex = 1;
            this.BTN_Kunde.Text = "KUNDE";
            this.BTN_Kunde.UseVisualStyleBackColor = false;
            this.BTN_Kunde.Click += new System.EventHandler(this.BTN_Kunde_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "SYNSPUNKT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(360, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vælg Handling";
            // 
            // BGFStartside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Kunde);
            this.Controls.Add(this.BTN_Butik);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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