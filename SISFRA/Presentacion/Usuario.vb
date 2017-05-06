Public Class Usuario

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _familia As Familia
    Public Property Familia() As Familia
        Get
            Return _familia
        End Get
        Set(ByVal value As Familia)
            _familia = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

End Class
