Imports cn = _2_CAPA_NEGOCIO

Public Class Principal
    Dim FrmName, FrmCod, UserName As String
    Private WithEvents CNS As New cn.Eco_CN

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = VARIALES.USER
        FrmName = "PRINCIPAL"
        FrmCod = "M0001"
        Dim frm As New Login

        'UserName = "alex"
        ' VALIDAR_FRM()
        'Label1.Text = 

        'If DATODGV <> 1 Then
        '    MsgBox("USTED NO TIENE PERMISOS AL SISTEMA")
        '    Dim FRMLOGIN As New Login
        '    FRMLOGIN.Show()
        '    Me.Hide()
        'End If

    End Sub
    Dim DATODGV As Integer
    'Private Sub VALIDAR_FRM()
    '    dgvIden.DataSource = CNS.VALIDAR_FRM(UserName, FrmName, FrmCod)
    '    DATODGV = dgvIden.Item(0, 0).Value
    'End Sub
End Class