using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AgentUI : Form
    {
        const int BROADCAST_PORT = Communication.SocketSettings.BROADCAST_PORT;

        public AgentUI()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
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
    }
}
