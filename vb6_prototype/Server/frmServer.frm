VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Begin VB.Form frmServer 
   Caption         =   "Server"
   ClientHeight    =   4185
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   5700
   LinkTopic       =   "Form1"
   ScaleHeight     =   4185
   ScaleWidth      =   5700
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtMessage 
      Height          =   3045
      Left            =   225
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   1
      Top             =   225
      Width           =   5175
   End
   Begin VB.CommandButton btnRunServer 
      Caption         =   "Run Server"
      Height          =   495
      Left            =   4200
      TabIndex        =   0
      Top             =   3450
      Width           =   1215
   End
   Begin MSWinsockLib.Winsock wsBroadcast 
      Left            =   3075
      Top             =   3600
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
   Begin VB.Label lblStatus 
      Caption         =   "Not Running"
      Height          =   240
      Left            =   225
      TabIndex        =   2
      Top             =   3600
      Width           =   1215
   End
End
Attribute VB_Name = "frmServer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Const BROADCAST_PORT As Integer = 421

Private Sub btnRunServer_Click()
     wsBroadcast.Close
     wsBroadcast.Protocol = sckUDPProtocol
     wsBroadcast.Bind BROADCAST_PORT
     lblStatus.Caption = "Running"
End Sub

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
