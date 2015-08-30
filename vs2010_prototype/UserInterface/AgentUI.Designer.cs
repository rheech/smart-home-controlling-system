namespace UserInterface
{
    partial class AgentUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentUI));
            this.btnCommand = new System.Windows.Forms.Button();
            this.wsClient = new AxMSWinsockLib.AxWinsock();
            ((System.ComponentModel.ISupportInitialize)(this.wsClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(308, 219);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(64, 25);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "button1";
            this.btnCommand.UseVisualStyleBackColor = true;
            // 
            // wsClient
            // 
            this.wsClient.Enabled = true;
            this.wsClient.Location = new System.Drawing.Point(12, 216);
            this.wsClient.Name = "wsClient";
            this.wsClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsClient.OcxState")));
            this.wsClient.Size = new System.Drawing.Size(28, 28);
            this.wsClient.TabIndex = 2;
            // 
            // AgentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.wsClient);
            this.Controls.Add(this.btnCommand);
            this.Name = "AgentUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.wsClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCommand;
        private AxMSWinsockLib.AxWinsock wsClient;
    }
}