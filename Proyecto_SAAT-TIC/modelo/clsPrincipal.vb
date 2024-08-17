Imports System.Data
Imports System.Data.SqlClient
Public Class clsPrincipal
    Public Shared Function consultaDSSQL(ByVal cadena As String) As DataSet
        Dim cnx As New SqlConnection(cls_conexion.conex)
        Dim sda As New SqlDataAdapter(cadena, cnx)
        Dim ds As New DataSet
        sda.Fill(ds)
        Return ds
    End Function
    Public Shared Sub comandosSQL(ByVal cadena As String)
        Dim cnx As New SqlConnection(cls_conexion.conex)
        cnx.Open()
        Dim scmd As New SqlCommand(cadena, cnx)
        scmd.ExecuteNonQuery()
        cnx.Close()
    End Sub
End Class
