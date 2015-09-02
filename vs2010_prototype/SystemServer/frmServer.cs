using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemServer
{
    public partial class frmServer : Form
    {
        const int BROADCAST_PORT = Communication.SocketSettings.BROADCAST_PORT;
        const int TCP_PORT = Communication.SocketSettings.TCP_PORT;
        const int MAIN_TCP_PORT = Communication.SocketSettings.MAIN_TCP_PORT;

        public frmServer()
        {
            InitializeComponent();
        }

        /*
Private Sub Form_Load()
    btnRunServer_Click
End Sub

Private Sub PrintMessage(ByVal Message As String)
    If Len(txtMessage.Text) < 1 Then
        txtMessage.Text = Message
    Else
        txtMessage.Text = txtMessage.Text & vbCrLf & Message
    End If
End Sub

Private Sub wsBroadcast_DataArrival(ByVal bytesTotal As Long)
    Dim str As String
    wsBroadcast.GetData str, vbString
    PrintMessage str & "(IP address: " & wsBroadcast.RemoteHostIP & ") entered the system."
End Sub
 
Private Sub Form_Unload(Cancel As Integer)
    wsBroadcast.Close
End Sub

Private Sub wsBroadcast_Error(ByVal Number As Integer, Description As String, ByVal Scode As Long, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Long, CancelDisplay As Boolean)
    lblStatus.Caption = "Error"
End Sub
*/

        private void InitSockets()
        {
            wsBroadcast.Close();
            wsBroadcast.Protocol = MSWinsockLib.ProtocolConstants.sckUDPProtocol;
            wsBroadcast.Bind(BROADCAST_PORT, "");

            wsMainTCPServer.Close();
            wsMainTCPServer.Bind(MAIN_TCP_PORT, "");
            wsMainTCPServer.Listen();

            lblStatus.Text = "Running";
        }

        private void btnRunServer_Click(object sender, EventArgs e)
        {
            InitSockets();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            btnRunServer_Click(sender, e);
        }

        private void wsBroadcast_DataArrival(object sender, AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent e)
        {
            StringBuilder sbMessage = new StringBuilder();

            object str = "";
            wsBroadcast.GetData(ref str, 8, 255);

            sbMessage.AppendFormat("{0} (IP Address: {1}:{2}) entered the system.", str.ToString(), wsBroadcast.RemoteHostIP, wsBroadcast.RemotePort);

            txtMessage.printLine(sbMessage.ToString());

            InitSockets();

            // Connect to client
            wsTCPClient.Close();
            wsTCPClient.Connect(wsBroadcast.RemoteHostIP, TCP_PORT);
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            wsBroadcast.Close();
        }

        private void wsMainTCPServer_ConnectEvent(object sender, EventArgs e)
        {
            
        }

        private void wsMainTCPServer_ConnectionRequest(object sender, AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent e)
        {
            wsMainTCPServer.Close();
            wsMainTCPServer.Accept(e.requestID);
            txtMessage.printLine(String.Format("Connected to {0}:{1}.", wsMainTCPServer.RemoteHostIP, wsMainTCPServer.RemotePort));
        }

        private void wsMainTCPServer_Error(object sender, AxMSWinsockLib.DMSWinsockControlEvents_ErrorEvent e)
        {
            wsMainTCPServer.Close();
            wsMainTCPServer.Listen();
        }

        private void wsTCPClient_Error(object sender, AxMSWinsockLib.DMSWinsockControlEvents_ErrorEvent e)
        {
            txtMessage.printLine(String.Format("Socket error: {0}", e.description));
        }

        private void wsMainTCPServer_CloseEvent(object sender, EventArgs e)
        {
            wsMainTCPServer.Close();
            wsMainTCPServer.Listen();
        }

        private void wsMainTCPServer_DataArrival(object sender, AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent e)
        {
            object oData = "";
            string sData;
            wsMainTCPServer.GetData(ref oData);
            sData = oData.ToString();

            txtMessage.printLine(String.Format("Received data from {0}:{1}: {2}",
                        wsMainTCPServer.RemoteHostIP, wsMainTCPServer.RemotePort, sData));
        }
    }
}
