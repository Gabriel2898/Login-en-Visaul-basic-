Imports cn = _2_CAPA_NEGOCIO
'Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class Login
    Private WithEvents CNS As New cn.Eco_CN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Login()
            If ValorDGV1 = 1 Then
                Dim frm As New Principal
                frm.Show()
                'PermisosDo()
                Me.Hide()
            Else
                MsgBox("Contraseña Incorrecta")
            End If
            VARIALES.USER = txt_Usuario.Text


            'Me.Close() 
        Catch ex As Exception
            'MsgBox("Contraseña Incorrecta")
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public ValorDGV1 As Integer
    Private Sub Login()
        DataGridView1.DataSource = CNS.LOGINSESION(txt_Usuario.Text, txt_Contrasena.Text)

        ValorDGV1 = DataGridView1.Item(0, 0).Value
        '= txt_Usuario.Text

    End Sub
    'Private Sub PermisosDo()
    '    Try
    '        DataGridView2.DataSource = CNS.PERMISOS(0, txt_Usuario.Text)
    '    Catch ex As Exception
    '        MsgBox("Usted no cuenta con permisos sobre esta aplicación.")
    '    End Try
    'End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
    'Captura de movimiento de módulo
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles titleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
