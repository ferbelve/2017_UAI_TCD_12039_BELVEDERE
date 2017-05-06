Public Class Patente
    Inherits PatenteAbstracta

    Private _formulario As String
    Public Property Formulario() As String
        Get
            Return _formulario
        End Get
        Set(ByVal value As String)
            _formulario = value
        End Set
    End Property


    Public Overrides Sub MostrarEnTreeview(ByRef padres As TreeNodeCollection)
        Dim node As TreeNode = padres.Add(Me.Nombre)
        node.Tag = Me
    End Sub

    Public Overrides Function Clone() As PatenteAbstracta
        Dim pat As New Patente
        pat.Nombre = Me.Nombre
        Return pat
    End Function

    Public Overrides Sub Execute()
        MsgBox(Me.Nombre)
    End Sub
End Class
