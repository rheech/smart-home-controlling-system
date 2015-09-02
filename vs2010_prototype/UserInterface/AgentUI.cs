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
        const int TCP_PORT = Communication.SocketSettings.TCP_PORT;
        const int MAIN_TCP_PORT = Communication.SocketSettings.MAIN_TCP_PORT;

        private string sDeviceName;

        public AgentUI()
        {
            sDeviceName = "NOT_SET";
            InitializeComponent();
        }

        public string DeviceName
        {
            get
            {
                return sDeviceName;
            }

            set
            {
                sDeviceName = value;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            wsTCPServer.Close();
            wsTCPServer.Bind(TCP_PORT, "");
            wsTCPServer.Listen();

            sendHelloPacket(DeviceName);
        }

        private void sendHelloPacket(string message)
        {
            wsBroadcastClient.Close();
            wsBroadcastClient.Protocol = MSWinsockLib.ProtocolConstants.sckUDPProtocol;
            wsBroadcastClient.RemoteHost = "255.255.255.255";
            wsBroadcastClient.RemotePort = BROADCAST_PORT;
            wsBroadcastClient.SendData(message);
        }

        private void wsTCPServer_ConnectionRequest(object sender, AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent e)
        {
            wsTCPServer.Close();
            wsTCPServer.Accept(e.requestID);

            wsMainTCPClient.Connect(wsTCPServer.RemoteHostIP, MAIN_TCP_PORT);

            wsTCPServer.Close();
        }

    }
}
