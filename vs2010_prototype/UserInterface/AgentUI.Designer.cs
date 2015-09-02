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
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wsBroadcastClient
            // 
            this.wsBroadcastClient.Enabled = true;
            this.wsBroadcastClient.Location = new System.Drawing.Point(12, 7);
            this.wsBroadcastClient.Name = "wsBroadcastClient";
            this.wsBroadcastClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsBroadcastClient.OcxState")));
            this.wsBroadcastClient.Size = new System.Drawing.Size(28, 28);
            this.wsBroadcastClient.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(321, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // wsTCPServer
            // 
            this.wsTCPServer.Enabled = true;
            this.wsTCPServer.Location = new System.Drawing.Point(46, 7);
            this.wsTCPServer.Name = "wsTCPServer";
            this.wsTCPServer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsTCPServer.OcxState")));
            this.wsTCPServer.Size = new System.Drawing.Size(28, 28);
            this.wsTCPServer.TabIndex = 1;
            this.wsTCPServer.ConnectionRequest += new AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEventHandler(this.wsTCPServer_ConnectionRequest);
            // 
            // wsMainTCPClient
            // 
            this.wsMainTCPClient.Enabled = true;
            this.wsMainTCPClient.Location = new System.Drawing.Point(80, 7);
            this.wsMainTCPClient.Name = "wsMainTCPClient";
            this.wsMainTCPClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wsMainTCPClient.OcxState")));
            this.wsMainTCPClient.Size = new System.Drawing.Size(28, 28);
            this.wsMainTCPClient.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wsMainTCPClient);
            this.splitContainer1.Panel2.Controls.Add(this.btnConnect);
            this.splitContainer1.Panel2.Controls.Add(this.wsBroadcastClient);
            this.splitContainer1.Panel2.Controls.Add(this.wsTCPServer);
            this.splitContainer1.Size = new System.Drawing.Size(408, 253);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // AgentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AgentUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.AgentUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wsBroadcastClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsTCPServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsMainTCPClient)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSWinsockLib.AxWinsock wsBroadcastClient;
        private System.Windows.Forms.Button btnConnect;
        private AxMSWinsockLib.AxWinsock wsTCPServer;
        private AxMSWinsockLib.AxWinsock wsMainTCPClient;
        public System.Windows.Forms.SplitContainer splitContainer1;
    }
}