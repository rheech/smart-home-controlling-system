namespace Client_Humidifier
{
    partial class frmHumidifier
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
            this.btnReleaseMoist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReleaseMoist);
            // 
            // btnReleaseMoist
            // 
            this.btnReleaseMoist.Location = new System.Drawing.Point(130, 81);
            this.btnReleaseMoist.Name = "btnReleaseMoist";
            this.btnReleaseMoist.Size = new System.Drawing.Size(148, 43);
            this.btnReleaseMoist.TabIndex = 0;
            this.btnReleaseMoist.Text = "Release Moist";
            this.btnReleaseMoist.UseVisualStyleBackColor = true;
            this.btnReleaseMoist.Click += new System.EventHandler(this.btnReleaseMoist_Click);
            // 
            // frmHumidifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Name = "frmHumidifier";
            this.Text = "Client Humidifier";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReleaseMoist;
    }
}

