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
            this.wsBroadcastClient = new AxMSWinsockLib.AxWinsock();
            this.btnConnect = new System.Windows.Forms.Button();
            this.wsTCPServer = new AxMSWinsockLib.AxWinsock();
            this.wsMainTCPClient = new AxMSWinsockLib.AxWinsock();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.wsBroadcastClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsTCPServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsMainTCPClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wsBroadcastClient
            // 
            this.wsBroadcastClient.Enabled = true;
            this.wsBroadcastClient.Location = new System.Drawing.Point(124, 279);
            this.wsBroadcastClient.Name = "wsBroadcastClient";
            this.wsBroadcastClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsBroadcastClient.OcxState")));
            this.wsBroadcastClient.Size = new System.Drawing.Size(28, 28);
            this.wsBroadcastClient.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(409, 284);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // wsTCPServer
            // 
            this.wsTCPServer.Enabled = true;
            this.wsTCPServer.Location = new System.Drawing.Point(158, 279);
            this.wsTCPServer.Name = "wsTCPServer";
            this.wsTCPServer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsTCPServer.OcxState")));
            this.wsTCPServer.Size = new System.Drawing.Size(28, 28);
            this.wsTCPServer.TabIndex = 4;
            this.wsTCPServer.ConnectionRequest += new AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEventHandler(this.wsTCPServer_ConnectionRequest);
            // 
            // wsMainTCPClient
            // 
            this.wsMainTCPClient.Enabled = true;
            this.wsMainTCPClient.Location = new System.Drawing.Point(192, 279);
            this.wsMainTCPClient.Name = "wsMainTCPClient";
            this.wsMainTCPClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsMainTCPClient.OcxState")));
            this.wsMainTCPClient.Size = new System.Drawing.Size(28, 28);
            this.wsMainTCPClient.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(90, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 6;
            // 
            // AgentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 382);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.wsMainTCPClient);
            this.Controls.Add(this.wsTCPServer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.wsBroadcastClient);
            this.Name = "AgentUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.wsBroadcastClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsTCPServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsMainTCPClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSWinsockLib.AxWinsock wsBroadcastClient;
        private System.Windows.Forms.Button btnConnect;
        private AxMSWinsockLib.AxWinsock wsTCPServer;
        private AxMSWinsockLib.AxWinsock wsMainTCPClient;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}