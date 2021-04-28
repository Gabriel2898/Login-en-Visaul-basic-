Imports System.Data.SqlClient
Public Class Conexion
    Private CN As New SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=ECO;server=ALEX-PC\SQLEXPRESS")
    Public ReadOnly Property getCN As SqlConnection
        Get
            Return CN
        End Get
    End Property
End Class
