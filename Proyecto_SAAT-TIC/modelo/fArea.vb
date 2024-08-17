Imports System.Data.SqlClient

Public Class fArea

    Inherits cls_conexion
    Dim cmmd As SqlCommand
    Dim query As String

    Public Function insertar(ByVal dts As vArea) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_area_ins")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@pArea", dts.gArea)
            cmmd.Connection = cnn
            If cmmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al insertar" + ex.Message)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Function mostrar(ByVal query As String) As DataTable
        Try
            openConnection()
            'query = "select intId_area as Clave,vchArea as Area from tbl_areasConocimiento"
            cmmd = New SqlCommand(query, cnn)
            If cmmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim datos As New SqlDataAdapter(cmmd)
                datos.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener los datos" + ex.Message)
            Return Nothing
        Finally
            closeConnection()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vArea) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_area_del")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@pId", dts.gId)
            cmmd.Connection = cnn
            If cmmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar" + ex.Message)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Function editar(ByVal dts As vArea) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_area_upd")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@pId", dts.gId)
            cmmd.Parameters.AddWithValue("@pArea", dts.gArea)
            cmmd.Connection = cnn
            If cmmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

End Class
