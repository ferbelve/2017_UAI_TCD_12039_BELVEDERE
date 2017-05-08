Imports System.Data.SqlClient

Public Class pclientes
    Inherits conexion
    Shared cmd As New SqlCommand
    Public Shared Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("select * from clientes")
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    'Public Shared Function insertar(ByVal dts As nclientes) As Boolean
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("Insert into Clientes ([idcliente, nombre, apellido, dni, mail, telefono, direccion]) VALUES ([idcliente, nombre, apellido, dni, mail, telefono, direccion]")
    '        cmd.Connection = cnn

    '        If cmd.ExecuteNonQuery Then
    '            Return True
    '        Else
    '            Return False
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    Finally
    '        desconectado()
    '    End Try
    'End Function

    Public Shared Function insertar(nombre As String, apellido As String, dni As String, mail As String, telefono As String, direccion As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insert into Clientes VALUES ('" & nombre &
                                 "', '" & apellido & "', '" & dni & "', '" & mail & "', '" & telefono & "', '" & direccion & "')")
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
