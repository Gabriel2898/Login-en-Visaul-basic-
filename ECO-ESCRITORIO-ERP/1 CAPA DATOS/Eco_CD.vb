Imports System.Data.SqlClient
Public Class Eco_CD
    Private CN As New Conexion
    Public Function LOGINSESION(ByVal vchUruario As String, ByVal vchPassword As String) As DataTable
        Dim da As New SqlDataAdapter("LOGINSESION", CN.getCN)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.CommandTimeout = 0
        da.SelectCommand.Parameters.AddWithValue("@vchUsuario", vchUruario)
        da.SelectCommand.Parameters.AddWithValue("@vchPassword", vchPassword)
        Dim tb As New DataTable
        da.Fill(tb)
        Return tb
    End Function
    'Public Function PERMISOS(ByVal intIdUsuario As Integer, ByVal vchUsuario As String) As DataTable
    '    Dim da As New SqlDataAdapter("PERMISOS_USUARIO", CN.getCN)
    '    da.SelectCommand.CommandType = CommandType.StoredProcedure
    '    da.SelectCommand.CommandTimeout = 0
    '    da.SelectCommand.Parameters.AddWithValue("@intIdUsuario", intIdUsuario)
    '    da.SelectCommand.Parameters.AddWithValue("@vchUsuario", vchUsuario)
    '    Dim tb As New DataTable
    '    da.Fill(tb)
    '    Return tb
    'End Function
    'Public Function VALIDAR_FRM(ByVal vchUsuario As String, ByVal vchNombre As String, ByVal vchCodigo As String) As DataTable
    '    Dim da As New SqlDataAdapter("VALIDAD_MODULO", CN.getCN)
    '    da.SelectCommand.CommandType = CommandType.StoredProcedure
    '    da.SelectCommand.CommandTimeout = 0
    '    da.SelectCommand.Parameters.AddWithValue("@vchUsuario", vchUsuario)
    '    da.SelectCommand.Parameters.AddWithValue("@vchNombre", vchNombre)
    '    da.SelectCommand.Parameters.AddWithValue("@vchCodigo", vchCodigo)
    '    Dim tb As New DataTable
    '    da.Fill(tb)
    '    Return tb
    'End Function
End Class
