Imports System.Runtime.InteropServices
Public Class frmInfoGeneral
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
        Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
        End Sub
        Private Sub lblCerrar_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        Close()
    End Sub

    Private Sub frmInfoGeneral_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class