Public Class FormularioPrincipal

    Private Sub AdministracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem.Click

    End Sub

    Private Sub PatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatenteToolStripMenuItem.Click
        Dim frm As New FormularioPatentes
        frm.ShowDialog()
    End Sub

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frm As New frmclientes
        frm.ShowDialog()
    End Sub

    Private Sub FamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliaToolStripMenuItem.Click
        Dim frm As New FormularioFamilia
        frm.ShowDialog()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Dim frm As New FormularioUsuarios
        frm.ShowDialog()
    End Sub
End Class