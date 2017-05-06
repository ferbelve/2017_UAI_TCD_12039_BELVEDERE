Public Class Familia

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _patenteRaiz As PatenteAbstracta
    Public Property PatenteAbstracta() As PatenteAbstracta
        Get
            Return _patenteRaiz
        End Get
        Set(ByVal value As PatenteAbstracta)
            _patenteRaiz = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nombre
    End Function


End Class
