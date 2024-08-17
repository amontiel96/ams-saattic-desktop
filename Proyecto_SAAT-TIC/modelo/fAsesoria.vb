Imports System.Data.SqlClient
Public Class fAsesoria
    Inherits cls_conexion
    Dim cmmd As SqlCommand
    Dim query As String

    Public Function insertar(ByVal dts As vAsesoria) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_AsesoriaCli_ins")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@id_cliente", dts.gId_clie)
            cmmd.Parameters.AddWithValue("@tema", dts.gTema)
            cmmd.Parameters.AddWithValue("@descri", dts.gDesc)
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

    Public Function editar(ByVal dts As vAsesoria) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_AsesoriaCli_upd")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@id_asesoria", dts.gId)
            cmmd.Parameters.AddWithValue("@id_cliente", dts.gId_clie)
            cmmd.Parameters.AddWithValue("@tema", dts.gTema)
            cmmd.Parameters.AddWithValue("@descri", dts.gDesc)
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

    Public Function aceptarAsesoria(ByVal dts As vAsesoria) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_AsesoriaInfo_upd")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@id_asesoria", dts.gId)
            cmmd.Parameters.AddWithValue("@id_infor", dts.gId_info)
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
