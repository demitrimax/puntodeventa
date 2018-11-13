Imports BaseDatos

Public Class LoginForm

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If Operaciones.Buscar("select * from usuarios where username='" & txtUser.Text & "' and clave='" & txtPassword.Text & "'") = True Then
            MainForm.Show()
            Dim fila As DataRow
            For Each fila In Acceso.ds.Tables(0).Rows
                MainForm.lbNombreUsuario.Text = fila("username")
                MainForm.lbIDusuario.Text = fila("id")
            Next
            Me.Hide()
        Else
            MessageBox.Show("Nombre de usuario o Contraseña incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        Timer1.Enabled = True
        If Operaciones.Buscar("select * from usuarios") = False Then
            MainForm.Show()
            MainForm.lbNombreUsuario.Text = "Aministrador"
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class