Imports Negocio

Public Class frmclientes
    Private dt As New DataTable
    Private Sub frmclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try

            dt = nclientes.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                Lnlinexitente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                Lnlinexitente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btnnuevo.Visible = True
        btneditar.Enabled = False

        buscar()

    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.tables.add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                Lnlinexitente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                Lnlinexitente.Visible = True
                datalistado.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        Dim cliente As New nclientes

        If txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And txtmail.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" Then
            cliente.nombre = txtnombre.Text
            cliente.apellido = txtapellido.Text
            cliente.dni = txtdni.Text
            cliente.mail = txtmail.Text
            cliente.telefono = txttelefono.Text
            cliente.direccion = txtdireccion.Text
            cliente.insertar()
            limpiar()
            mostrar()
        Else
            MessageBox.Show("Por favor complete todos los datos para completar la operacion")

        End If
    End Sub
    Public Sub limpiar()
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtdni.Text = ""
        txtmail.Text = ""
        txttelefono.Text = ""
        txtdireccion.Text = ""
    End Sub

End Class