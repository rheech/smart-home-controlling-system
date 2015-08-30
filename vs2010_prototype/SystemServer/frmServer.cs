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
        const int BROADCAST_PORT = 421;

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
        private void btnRunServer_Click(object sender, EventArgs e)
        {
            wsBroadcast.Close();
            wsBroadcast.Protocol = MSWinsockLib.ProtocolConstants.sckUDPProtocol;
            wsBroadcast.Bind(BROADCAST_PORT, "");
            lblStatus.Text = "Running";
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
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            wsBroadcast.Close();
        }
    }
}
