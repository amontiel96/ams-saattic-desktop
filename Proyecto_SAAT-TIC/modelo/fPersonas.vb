Imports System.Data.SqlClient
Public Class fPersonas

    Inherits cls_conexion
    Dim cmmd As SqlCommand
    Dim query As String

    Public Function insertar(ByVal dts As vPersonas) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_personas_ins")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmmd.Parameters.AddWithValue("@aPaterno", dts.gAP)
            cmmd.Parameters.AddWithValue("@aMaterno", dts.gAM)
            cmmd.Parameters.AddWithValue("@idMunicipio", dts.gIdMun)
            cmmd.Parameters.AddWithValue("@correo", dts.gCorreo)
            cmmd.Parameters.AddWithValue("@idtUser", dts.gIdtUser)
            cmmd.Parameters.AddWithValue("@usuario", dts.gUser)
            cmmd.Parameters.AddWithValue("@pwd", dts.gPwd)
            cmmd.Parameters.AddWithValue("@FechaReg", dts.gFecha)
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

    Public Function editar(ByVal dts As vPersonas) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_personas_upd")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@idPersona", dts.gId)
            cmmd.Parameters.AddWithValue("@nombre", dts.gNombre)
            cmmd.Parameters.AddWithValue("@aPaterno", dts.gAP)
            cmmd.Parameters.AddWithValue("@aMaterno", dts.gAM)
            cmmd.Parameters.AddWithValue("@idMunicipio", dts.gIdMun)
            cmmd.Parameters.AddWithValue("@correo", dts.gCorreo)
            cmmd.Parameters.AddWithValue("@idtUser", dts.gIdtUser)
            cmmd.Parameters.AddWithValue("@usuario", dts.gUser)
            cmmd.Parameters.AddWithValue("@pwd", dts.gPwd)
            cmmd.Parameters.AddWithValue("@FechaReg", dts.gFecha)
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
    Public Function eliminarInfo(ByVal dts As vPersonas) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_perInfo_del")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@idPersona", dts.gId)
            cmmd.Parameters.AddWithValue("@inInfo", dts.gId_info)
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
    Public Function eliminarClien(ByVal dts As vPersonas) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("usp_perClie_del")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@idPersona", dts.gId)
            'cmmd.Parameters.AddWithValue("@idCliente", dts.gId_clie)
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
    Public Function eliminarAdmi(ByVal dts As vPersonas) As Boolean
        Try
            openConnection()
            cmmd = New SqlCommand("ups_perAdmi_del")
            cmmd.CommandType = CommandType.StoredProcedure
            cmmd.Parameters.AddWithValue("@idPersona", dts.gId)
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
End Class
