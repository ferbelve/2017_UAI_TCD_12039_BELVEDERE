Public Class FormularioFamilia
    Dim family As New Familia

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.family.PatenteAbstracta = Modelo.GetInstance().PatenteRaiz.Clone()
        Me.family.PatenteAbstracta.MostrarEnTreeview(Me.treePatentes.Nodes)
    End Sub
End Class