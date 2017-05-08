Imports Persistencia
Public Class npermisos
    Private _id As Integer
    Private _nombre As String
    Private _activo As Boolean


    Public Property id
        Get
            Return _id
        End Get
        Set(value)
            _id = value
        End Set
    End Property


    Public Property nombre
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property

    Public Property activo
        Get
            Return _activo
        End Get
        Set(value)
            _activo = value
        End Set
    End Property

    Public Sub New()

    End Sub

    'Public Sub New(ByVal idcliente As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal dni As String)
    '    idcliente = _idcliente
    '    nombre = _nombre
    '    apellido = _apellido
    '    dni = _dni
    '    mail = _mail
    '    telefono = _telefono
    '    direccion = _direccion
    'End Sub

    Public Sub insertar()
        ppermisos.insertar(nombre)

    End Sub

End Class
