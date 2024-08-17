Imports System.Data.SqlClient
Public Class fProyecto
    Inherits cls_conexion
    Dim cmmd As SqlCommand
    Dim query As String

    Public Function insertar(ByVal dts As vProyecto) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_ProyectoCli_ins")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@id_clien", dts.gCliente)
            cmmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmmd.Parameters.AddWithValue("@idtPro", dts.gIdTipo)
            cmmd.Parameters.AddWithValue("@desc", dts.gDescr)
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

    Public Function editar(ByVal dts As vProyecto) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_ProyectoCli_upd")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@id_proyec", dts.gProyecto)
            cmmd.Parameters.AddWithValue("@id_clien", dts.gCliente)
            cmmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmmd.Parameters.AddWithValue("@idtPro", dts.gIdTipo)
            cmmd.Parameters.AddWithValue("@desc", dts.gDescr)
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

    Public Function aceptarProyecto(ByVal dts As vProyecto) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_ProyectoInfo_upd")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@id_proyecto", dts.gProyecto)
            cmmd.Parameters.AddWithValue("@id_infor", dts.gInfo)
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
