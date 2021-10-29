Imports ClassLibrary1
Public Class Form1

    Dim obj As New Class1






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvinfo.DataSource = obj.listarinfo

    End Sub

    Private Sub dgvinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinfo.CellContentClick
        txtcorreo.Text = dgvinfo.Item(0, e.RowIndex).Value
        txtusuario.Text = dgvinfo.Item(1, e.RowIndex).Value
        txtnombre.Text = dgvinfo.Item(2, e.RowIndex).Value
        txtapellido.Text = dgvinfo.Item(3, e.RowIndex).Value
        txtcontraseña.Text = dgvinfo.Item(4, e.RowIndex).Value
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click

        Try
            obj.insertar(txtcorreo.Text, txtusuario.Text, txtnombre.Text, txtapellido.Text, txtcontraseña.Text)
            dgvinfo.DataSource = obj.listarinfo
            MsgBox("Usuario " + txtusuario.Text + " resigtrado")
            txtcorreo.Text = ""
            txtusuario.Text = ""
            txtnombre.Text = ""
            txtapellido.Text = ""
            txtcontraseña.Text = ""
        Catch ex As Exception
            MsgBox("Error en registro")
        End Try

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            obj.insertar(txtcorreo.Text, txtusuario.Text, txtnombre.Text, txtapellido.Text, txtcontraseña.Text)
            dgvinfo.DataSource = obj.listarinfo
            MsgBox("Modificado")
            txtcorreo.Text = ""
            txtusuario.Text = ""
            txtnombre.Text = ""
            txtapellido.Text = ""
            txtcontraseña.Text = ""
        Catch ex As Exception
            MsgBox("Error en modificación")
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            obj.eliminar(txtcorreo.Text)
            dgvinfo.DataSource = obj.listarinfo


            MsgBox("Eliminacion completada")
            txtcorreo.Text = ""
            txtusuario.Text = ""
            txtnombre.Text = ""
            txtapellido.Text = ""
            txtcontraseña.Text = ""
        Catch ex As Exception
            MsgBox("Error en eliminación")
        End Try
    End Sub
End Class