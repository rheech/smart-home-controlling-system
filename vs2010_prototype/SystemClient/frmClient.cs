using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemClient
{
    public partial class frmClient : Form
    {
        const int BROADCAST_PORT = 421;

        public frmClient()
        {
            InitializeComponent();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            sendHelloPacket("Hello World!");
        }

        private void sendHelloPacket(string message)
        {
            wsClient.Close();
            wsClient.Protocol = MSWinsockLib.ProtocolConstants.sckUDPProtocol;
            wsClient.RemoteHost = "255.255.255.255";
            wsClient.RemotePort = BROADCAST_PORT;
            wsClient.SendData(message);
        }

        private void wsClient_ConnectEvent(object sender, EventArgs e)
        {

        }

    }
}
