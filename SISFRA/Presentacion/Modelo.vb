
Public Class Modelo

    Private Shared _instance As Modelo
    Public Shared Function GetInstance() As Modelo

        If _instance Is Nothing Then
            _instance = New Modelo
        End If

        Return _instance
    End Function

    Private _familias As New List(Of Familia)
    Public Property Familias() As List(Of Familia)
        Get
            Return _familias
        End Get
        Set(ByVal value As List(Of Familia))
            _familias = value
        End Set
    End Property

    Private _usuarios As New List(Of Usuario)
    Public Property Usuarios() As List(Of Usuario)
        Get
            Return _usuarios
        End Get
        Set(ByVal value As List(Of Usuario))
            _usuarios = value
        End Set
    End Property


    Private _patenteRaiz As PatenteAbstracta
    Public Property PatenteRaiz() As PatenteAbstracta
        Get
            Return _patenteRaiz
        End Get
        Set(ByVal value As PatenteAbstracta)
            _patenteRaiz = value
        End Set
    End Property

    Public Sub New()
        Dim raiz As New GrupoPatentes()
        raiz.Nombre = "Patentes Sistema"
        Me._patenteRaiz = raiz
    End Sub
End Class
