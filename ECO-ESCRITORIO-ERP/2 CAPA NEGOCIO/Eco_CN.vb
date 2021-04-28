Imports _1_CAPA_DATOS
Public Class Eco_CN
    Private Eco As New Eco_CD
    Public Function LOGINSESION(ByVal vchUruario As String, ByVal vchPassword As String)
        Return Eco.LOGINSESION(vchUruario, vchPassword)
    End Function
    'Public Function PERMISOS(ByVal intIdUsuario As Integer, ByVal vchUsuario As String)
    '    Return Eco.PERMISOS(intIdUsuario, vchUsuario)
    'End Function
    'Public Function VALIDAR_FRM(ByVal vchUsuario As String, ByVal vchNombre As String, ByVal vchCodigo As String)
    '    Return Eco.VALIDAR_FRM(vchUsuario, vchNombre, vchCodigo)
    'End Function
End Class
