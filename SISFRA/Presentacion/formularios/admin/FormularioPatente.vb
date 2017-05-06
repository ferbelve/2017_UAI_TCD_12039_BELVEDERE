Imports Negocio

'Public Class FormularioPatentes

'    Public Sub New()

'        ' Llamada necesaria para el diseñador.
'        InitializeComponent()




'        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
'        Modelo.GetInstance().PatenteRaiz.MostrarEnTreeview(Me.treePatentes.Nodes)
'    End Sub

'    Private Sub agregarPatenteToolStripMenuItem_Click(sender As Object, e As EventArgs)


'    End Sub

'    Private Sub AgregarPatenteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AgregarPatenteToolStripMenuItem.Click
'        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

'        If TypeOf nodo.Tag Is GrupoPatentes Then

'            Dim padre As GrupoPatentes = nodo.Tag

'            Dim frm As New FormularioDialogoPatentes
'            frm.ShowDialog()

'            Dim nombre As String = frm.Nombre
'            Dim formulario As String = frm.Formulario

'            If (nombre.Length > 0) And (formulario.Length > 0) Then

'                Dim patente As New Patente
'                Dim nodoNuevo As New TreeNode

'                nodoNuevo.Text = nombre
'                patente.Nombre = nombre
'                patente.Formulario = formulario
'                nodoNuevo.Tag = patente

'                nodo.Nodes.Add(nodoNuevo)
'                padre.Patentes.Add(patente)
'            End If
'        End If
'    End Sub

'    Private Sub AgregarGruposDePatenteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AgregarGruposDePatenteToolStripMenuItem.Click
'        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

'        If TypeOf nodo.Tag Is GrupoPatentes Then

'            Dim padre As GrupoPatentes = nodo.Tag

'            Dim nombre As String = InputBox("Ingrese el nombre")

'            If nombre.Length > 0 Then

'                Dim grupo As New GrupoPatentes
'                Dim nodoNuevo As New TreeNode

'                nodoNuevo.Text = nombre
'                grupo.Nombre = nombre
'                nodoNuevo.Tag = grupo

'                nodo.Nodes.Add(nodoNuevo)
'                padre.Patentes.Add(grupo)
'            End If
'        End If
'    End Sub

'    Private Sub EliminarElementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarElementoToolStripMenuItem.Click
'        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

'        If TypeOf nodo.Tag Is GrupoPatentes Then

'            If Not nodo.Parent Is Nothing Then

'                Dim padre As GrupoPatentes = nodo.Parent.Tag()

'                nodo.Remove()
'                padre.Patentes.Remove(nodo.Tag)
'            End If
'        End If

'    End Sub

'    Private Sub Familia_Click(sender As Object, e As EventArgs) Handles Familia.Click

'    End Sub

'    Private Sub FormularioPatentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub

'    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
'        Me.Close()

'    End Sub

'    Private Sub treePatentes_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treePatentes.AfterSelect

'    End Sub

'    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

'    End Sub

'    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel1.Paint

'    End Sub

'End Class

Public Class FormularioPatentes

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()




        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Modelo.GetInstance().PatenteRaiz.MostrarEnTreeview(Me.treePatentes.Nodes)
    End Sub

    Private Sub agregarPatenteToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AgregarPatenteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AgregarPatenteToolStripMenuItem.Click
        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

        If TypeOf nodo.Tag Is GrupoPatentes Then

            Dim padre As GrupoPatentes = nodo.Tag

            Dim frm As New FormularioDialogoPatentes
            frm.ShowDialog()

            Dim nombre As String = frm.Nombre
            Dim formulario As String = frm.Formulario

            If (nombre.Length > 0) And (formulario.Length > 0) Then

                Dim patente As New Patente
                Dim nodoNuevo As New TreeNode

                nodoNuevo.Text = nombre
                patente.Nombre = nombre
                patente.Formulario = formulario
                nodoNuevo.Tag = patente

                nodo.Nodes.Add(nodoNuevo)
                padre.Patentes.Add(patente)
            End If
        End If
    End Sub

    Private Sub AgregarGruposDePatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarGruposDePatenteToolStripMenuItem.Click
        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

        If TypeOf nodo.Tag Is GrupoPatentes Then

            Dim padre As GrupoPatentes = nodo.Tag

            Dim nombre As String = InputBox("Ingrese el nombre")

            If nombre.Length > 0 Then

                Dim grupo As New GrupoPatentes
                Dim nodoNuevo As New TreeNode

                nodoNuevo.Text = nombre
                grupo.Nombre = nombre
                nodoNuevo.Tag = grupo

                nodo.Nodes.Add(nodoNuevo)
                padre.Patentes.Add(grupo)
            End If
        End If
    End Sub

    Private Sub EliminarElementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarElementoToolStripMenuItem.Click
        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

        If TypeOf nodo.Tag Is GrupoPatentes Then

            If Not nodo.Parent Is Nothing Then

                Dim padre As GrupoPatentes = nodo.Parent.Tag()

                nodo.Remove()
                padre.Patentes.Remove(nodo.Tag)
            End If
        End If

    End Sub

    Private Sub Familia_Click(sender As Object, e As EventArgs) Handles Familia.Click

    End Sub

    Private Sub FormularioPatentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()

    End Sub

    Private Sub treePatentes_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treePatentes.AfterSelect

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel1.Paint

    End Sub
End Class