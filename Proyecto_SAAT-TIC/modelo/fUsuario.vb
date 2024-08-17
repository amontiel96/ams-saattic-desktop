Imports System.Data.SqlClient
Public Class fUsuario
    Inherits cls_conexion
    Dim cmmd As SqlCommand

    Public Function validarusuario(ByVal dts As vUsuario) As DataTable
        openConnection()
        cmmd = New SqlCommand("_iniciasesion")
        cmmd.CommandType = CommandType.StoredProcedure
        cmmd.Connection = cnn
        cmmd.Parameters.AddWithValue("@users", dts._users)
        cmmd.Parameters.AddWithValue("@pass", dts._pass)

        If cmmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmmd)
                    da.Fill(dt)
                    Return dt

                End Using
            End Using
        Else
            Return Nothing
        End If

    End Function
End Class
