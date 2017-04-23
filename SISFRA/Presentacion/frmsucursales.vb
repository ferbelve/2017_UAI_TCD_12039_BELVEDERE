Imports Persistencia
Imports Negocio



Public Class frmsucursales
    Private dt As New DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New Sucursales
            dt = func.mostrar

            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
