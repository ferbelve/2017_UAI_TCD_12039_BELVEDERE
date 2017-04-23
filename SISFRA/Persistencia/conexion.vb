Imports System.Data.SqlClient
Public Class conexion
    Protected cnn As New SqlConnection

    Protected Function conectado()
        Try
            cnn = New SqlConnection(My.Settings.Conexion)
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
