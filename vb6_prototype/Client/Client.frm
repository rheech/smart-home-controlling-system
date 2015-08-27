VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Begin VB.Form frmClient 
   Caption         =   "Client"
   ClientHeight    =   2565
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   4920
   LinkTopic       =   "Form1"
   ScaleHeight     =   2565
   ScaleWidth      =   4920
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtCurrentSystem 
      Height          =   315
      Left            =   675
      TabIndex        =   1
      Text            =   "Current System: "
      Top             =   525
      Width           =   3090
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   495
      Left            =   3375
      TabIndex        =   0
      Top             =   1800
      Width           =   1215
   End
   Begin MSWinsockLib.Winsock wsClient 
      Left            =   150
      Top             =   1800
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
End
Attribute VB_Name = "frmClient"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Const BROADCAST_PORT As Integer = 421
Const CURRENT_SYSTEM As String = "humidifier"

Dim sCurrentSystem As String

Private Sub Command1_Click()
    SendHelloPacket sCurrentSystem
End Sub

Private Sub Form_Load()
    If Command = "" Then
        sCurrentSystem = CURRENT_SYSTEM
    Else
        sCurrentSystem = Command
    End If
    
    txtCurrentSystem.Text = "Current System: " & sCurrentSystem
    SendHelloPacket sCurrentSystem
End Sub

Private Sub SendHelloPacket(Message As String)
    wsClient.Close
    wsClient.Protocol = sckUDPProtocol
    wsClient.RemoteHost = "255.255.255.255"
    wsClient.RemotePort = BROADCAST_PORT
    wsClient.SendData Message
End Sub

Private Sub ActivateHumidifier()
    
End Sub
