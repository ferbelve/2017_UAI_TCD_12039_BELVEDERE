Imports Persistencia
Public Class nclientes
    Private _idcliente As Integer
    Private _nombre, _apellido, _dni, _mail, _telefono, _direccion As String


    Public Property idcliente
        Get
            Return _idcliente
        End Get
        Set(value)
            _idcliente = value
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

    Public Property apellido
        Get
            Return _apellido
        End Get
        Set(value)
            _apellido = value
        End Set
    End Property

    Public Property dni
        Get
            Return _dni
        End Get
        Set(value)
            _dni = value
        End Set
    End Property
    Public Property mail
        Get
            Return _mail
        End Get
        Set(value)
            _mail = value
        End Set
    End Property
    Public Property telefono
        Get
            Return _telefono
        End Get
        Set(value)
            _telefono = value
        End Set
    End Property
    Public Property direccion
        Get
            Return _direccion
        End Get
        Set(value)
            _direccion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal dni As String)
        idcliente = _idcliente
        nombre = _nombre
        apellido = _apellido
        dni = _dni
        mail = _mail
        telefono = _telefono
        direccion = _direccion
    End Sub

    Public Sub insertar()
        pclientes.insertar(nombre, apellido, dni, mail, telefono, direccion)

    End Sub

    Public Shared Function mostrar() As DataTable
        Return pclientes.mostrar()

    End Function

End Class
