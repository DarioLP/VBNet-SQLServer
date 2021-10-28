Imports System.Data.SqlClient


Public Class conexion
    Public conexion As String = "Data Source = DARIO-LAPTOP\MSSQLSERVER001 ; DataBase = Asignacion8Soft8 ; Integrated Security = false;"

    Public objconexion As New SqlConnection(conexion)



End Class
