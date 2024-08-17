Imports System.Data.SqlClient

Public Class cls_conexion
    Protected cnn As New SqlConnection
    Public Shared conex As String = "Data source=user; Initial Catalog=bd; integrated security=true"
    Public Function openConnection()
        Try
            cnn = New SqlConnection("Data source=user; Initial Catalog=bd; integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al conectar" + ex.Message)
            Return False
        End Try
    End Function

    Public Function closeConnection()
        Try
            If (cnn.State <> ConnectionState.Closed) Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al desconectar" + ex.Message)
            Return False
        End Try
    End Function
End Class
