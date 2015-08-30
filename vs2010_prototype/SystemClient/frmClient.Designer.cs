namespace SystemClient
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.wsClient = new AxMSWinsockLib.AxWinsock();
            this.btnCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wsClient)).BeginInit();
            this.SuspendLayout();
            // 
            // wsClient
            // 
            this.wsClient.Enabled = true;
            this.wsClient.Location = new System.Drawing.Point(12, 216);
            this.wsClient.Name = "wsClient";
            this.wsClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsClient.OcxState")));
            this.wsClient.Size = new System.Drawing.Size(28, 28);
            this.wsClient.TabIndex = 0;
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(308, 219);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(64, 25);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "button1";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.wsClient);
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.wsClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSWinsockLib.AxWinsock wsClient;
        private System.Windows.Forms.Button btnCommand;
    }
}

