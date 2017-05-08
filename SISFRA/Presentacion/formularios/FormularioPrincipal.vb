Public Class FormularioPrincipal

    Private Sub AdministracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem.Click

    End Sub

    Private Sub PatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatenteToolStripMenuItem.Click
        Dim frm As New FormularioPatentes
        frm.ShowDialog()
    End Sub

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pnllogin.Left = (Me.Width - Pnllogin.Width) / 2
        Pnllogin.Top = (Me.Height - Pnllogin.Height) / 2

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


    Private Sub ptbingresar_Click(sender As Object, e As EventArgs) Handles ptbingresar.Click
        ptbingresar.Size = New Size(40, 32)
    End Sub

   
    Private Sub ptbsalir_Click(sender As Object, e As EventArgs) Handles ptbsalir.Click
        ptbsalir.Size = New Size(843, 468)
    End Sub
End Class