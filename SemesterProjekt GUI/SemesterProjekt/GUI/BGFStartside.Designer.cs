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
            this.bt_butik = new System.Windows.Forms.Button();
            this.bt_kunde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_butik
            // 
            this.bt_butik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_butik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bt_butik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_butik.Location = new System.Drawing.Point(226, 276);
            this.bt_butik.Name = "bt_butik";
            this.bt_butik.Size = new System.Drawing.Size(667, 331);
            this.bt_butik.TabIndex = 0;
            this.bt_butik.Text = "BUTIK";
            this.bt_butik.UseVisualStyleBackColor = true;
            // 
            // bt_kunde
            // 
            this.bt_kunde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_kunde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bt_kunde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_kunde.Location = new System.Drawing.Point(1254, 276);
            this.bt_kunde.Name = "bt_kunde";
            this.bt_kunde.Size = new System.Drawing.Size(667, 331);
            this.bt_kunde.TabIndex = 1;
            this.bt_kunde.Text = "KUNDE";
            this.bt_kunde.UseVisualStyleBackColor = true;
            // 
            // BGFStartside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(2197, 951);
            this.Controls.Add(this.bt_kunde);
            this.Controls.Add(this.bt_butik);
            this.Name = "BGFStartside";
            this.ShowIcon = false;
            this.Text = "BGFStartside";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_butik;
        private System.Windows.Forms.Button bt_kunde;
    }
}