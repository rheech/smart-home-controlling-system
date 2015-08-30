namespace SystemServer
{
    partial class frmServer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.btnRunServer = new System.Windows.Forms.Button();
            this.wsBroadcast = new AxMSWinsockLib.AxWinsock();
            this.txtMessage = new SystemServer.ConsoleTextBox(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wsBroadcast)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunServer
            // 
            this.btnRunServer.Location = new System.Drawing.Point(283, 268);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Size = new System.Drawing.Size(90, 28);
            this.btnRunServer.TabIndex = 0;
            this.btnRunServer.Text = "Run Server";
            this.btnRunServer.UseVisualStyleBackColor = true;
            this.btnRunServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // wsBroadcast
            // 
            this.wsBroadcast.Enabled = true;
            this.wsBroadcast.Location = new System.Drawing.Point(216, 268);
            this.wsBroadcast.Name = "wsBroadcast";
            this.wsBroadcast.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsBroadcast.OcxState")));
            this.wsBroadcast.Size = new System.Drawing.Size(28, 28);
            this.wsBroadcast.TabIndex = 1;
            this.wsBroadcast.DataArrival += new AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEventHandler(this.wsBroadcast_DataArrival);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 12);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(361, 239);
            this.txtMessage.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 276);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 308);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.wsBroadcast);
            this.Controls.Add(this.btnRunServer);
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wsBroadcast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunServer;
        private AxMSWinsockLib.AxWinsock wsBroadcast;
        private ConsoleTextBox txtMessage;
        private System.Windows.Forms.Label lblStatus;
    }
}

