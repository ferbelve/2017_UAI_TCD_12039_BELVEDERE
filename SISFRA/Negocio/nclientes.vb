
Public Class nclientes
    Private _idcliente As Integer
    Private _nombre, _apellido, _dni, _mail, _telefono, _direccion As String


    Public Property idcliente
        Get
            Return _idcliente
        End Get
        Set(value)
            _idcliente = idcliente
        End Set
    End Property


    Public Property nombre
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = nombre
        End Set
    End Property

    Public Property apellido
        Get
            Return _apellido
        End Get
        Set(value)
            _apellido = apellido
        End Set
    End Property

    Public Property dni
        Get
            Return _dni
        End Get
        Set(value)
            _dni = dni
        End Set
    End Property

    Public Property direccion
        Get
            Return _direccion
        End Get
        Set(value)
            _direccion = direccion
        End Set
    End Property


End Class
