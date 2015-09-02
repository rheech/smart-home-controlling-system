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
            this.lblStatus = new System.Windows.Forms.Label();
            this.wsTCPClient = new AxMSWinsockLib.AxWinsock();
            this.wsMainTCPServer = new AxMSWinsockLib.AxWinsock();
            this.txtMessage = new SystemServer.ConsoleTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wsBroadcast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsTCPClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsMainTCPServer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunServer
            // 
            this.btnRunServer.Location = new System.Drawing.Point(330, 247);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Size = new System.Drawing.Size(105, 26);
            this.btnRunServer.TabIndex = 0;
            this.btnRunServer.Text = "Run Server";
            this.btnRunServer.UseVisualStyleBackColor = true;
            this.btnRunServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // wsBroadcast
            // 
            this.wsBroadcast.Enabled = true;
            this.wsBroadcast.Location = new System.Drawing.Point(169, 247);
            this.wsBroadcast.Name = "wsBroadcast";
            this.wsBroadcast.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsBroadcast.OcxState")));
            this.wsBroadcast.Size = new System.Drawing.Size(28, 28);
            this.wsBroadcast.TabIndex = 1;
            this.wsBroadcast.DataArrival += new AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEventHandler(this.wsBroadcast_DataArrival);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 255);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 12);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready";
            // 
            // wsTCPClient
            // 
            this.wsTCPClient.Enabled = true;
            this.wsTCPClient.Location = new System.Drawing.Point(203, 247);
            this.wsTCPClient.Name = "wsTCPClient";
            this.wsTCPClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsTCPClient.OcxState")));
            this.wsTCPClient.Size = new System.Drawing.Size(28, 28);
            this.wsTCPClient.TabIndex = 4;
            this.wsTCPClient.Error += new AxMSWinsockLib.DMSWinsockControlEvents_ErrorEventHandler(this.wsTCPClient_Error);
            // 
            // wsMainTCPServer
            // 
            this.wsMainTCPServer.Enabled = true;
            this.wsMainTCPServer.Location = new System.Drawing.Point(237, 247);
            this.wsMainTCPServer.Name = "wsMainTCPServer";
            this.wsMainTCPServer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsMainTCPServer.OcxState")));
            this.wsMainTCPServer.Size = new System.Drawing.Size(28, 28);
            this.wsMainTCPServer.TabIndex = 5;
            this.wsMainTCPServer.Error += new AxMSWinsockLib.DMSWinsockControlEvents_ErrorEventHandler(this.wsMainTCPServer_Error);
            this.wsMainTCPServer.DataArrival += new AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEventHandler(this.wsMainTCPServer_DataArrival);
            this.wsMainTCPServer.ConnectEvent += new System.EventHandler(this.wsMainTCPServer_ConnectEvent);
            this.wsMainTCPServer.ConnectionRequest += new AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEventHandler(this.wsMainTCPServer_ConnectionRequest);
            this.wsMainTCPServer.CloseEvent += new System.EventHandler(this.wsMainTCPServer_CloseEvent);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(14, 11);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(420, 221);
            this.txtMessage.TabIndex = 2;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 284);
            this.Controls.Add(this.wsMainTCPServer);
            this.Controls.Add(this.wsTCPClient);
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
            ((System.ComponentModel.ISupportInitialize)(this.wsTCPClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsMainTCPServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunServer;
        private AxMSWinsockLib.AxWinsock wsBroadcast;
        private ConsoleTextBox txtMessage;
        private System.Windows.Forms.Label lblStatus;
        private AxMSWinsockLib.AxWinsock wsTCPClient;
        private AxMSWinsockLib.AxWinsock wsMainTCPServer;
    }
}

