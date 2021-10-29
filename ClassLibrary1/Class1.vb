Imports System.Data.SqlClient
Public Class Class1
    Dim cnx As New SqlConnection("Data Source=DARIO-LAPTOP\MSSQLSERVER001;Integrated Security=True")

    Public Function listarinfo() As DataTable

        Dim da As New SqlDataAdapter("pb_listar", cnx)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl
    End Function


    Public Function insertar(corr As String, usu As String, nom As String, ape As String, cont As String)
        Dim da As New SqlCommand("pb_nuevo", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@correo", corr)
        da.Parameters.AddWithValue("@usuario", usu)
        da.Parameters.AddWithValue("@nombre", nom)
        da.Parameters.AddWithValue("@apellido", ape)
        da.Parameters.AddWithValue("@contraseña", cont)

        cnx.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cnx.Close()

        Catch ex As Exception

            MsgBox("error al registrar usuario")
        End Try

        Return resp

    End Function



    Public Function eliminar(correo As String)

        Dim elim As New SqlCommand("pb_eliminar", cnx)
        elim.CommandType = CommandType.StoredProcedure
        elim.Parameters.AddWithValue("@correo", correo)
        cnx.Open()
        Dim elim1 As String = elim.ExecuteNonQuery
        cnx.Close()
        Return elim1
    End Function



    Public Function modificar(corr As String, usu As String, nom As String, ape As String, cont As String)
        Dim act As New SqlCommand("pb_nuevo", cnx)
        act.CommandType = CommandType.StoredProcedure
        act.Parameters.AddWithValue("@correo", corr)
        act.Parameters.AddWithValue("@usuario", usu)
        act.Parameters.AddWithValue("@nombre", nom)
        act.Parameters.AddWithValue("@apellido", ape)
        act.Parameters.AddWithValue("@contraseña", cont)
        cnx.Open()
        Dim actu1 As String = act.ExecuteNonQuery
        cnx.Close()
        Return actu1


    End Function















End Class
