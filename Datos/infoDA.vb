Imports Entidad

Imports System.Data.SqlClient


Public Class infoDA

    Public Function listar_info() As DataTable

        Using cn As New SqlConnection()
            Dim cmd As New SqlCommand()
            cmd.Connection = cn
            cmd.CommandText = "listar_info"
            cmd.CommandType = CommandType.StoredProcedure

            Dim da = New SqlDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd
            cn.Open()
            da.Fill(dt)
            Return dt



        End Using

    End Function



End Class
