VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3180
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   4785
   LinkTopic       =   "Form1"
   ScaleHeight     =   3180
   ScaleWidth      =   4785
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   495
      Left            =   1800
      TabIndex        =   0
      Top             =   1320
      Width           =   1215
   End
   Begin MSWinsockLib.Winsock Winsock1 
      Left            =   3960
      Top             =   2520
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
 
Private Sub Form_Load()
     Winsock1.Close
     Winsock1.Protocol = sckUDPProtocol
     Winsock1.Bind 420
End Sub
 
Private Sub Winsock1_DataArrival(ByVal bytesTotal As Long)
    Dim str As String
    Winsock1.GetData str, vbString
    MsgBox str
End Sub
 
Private Sub Form_Unload(Cancel As Integer)
    Winsock1.Close
End Sub
