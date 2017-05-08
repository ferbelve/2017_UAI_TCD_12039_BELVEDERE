﻿Imports System.Reflection
Imports Negocio

Public Class FormularioDialogoPatentes

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim Asm As Assembly = Reflection.Assembly.GetExecutingAssembly()

        For Each t As Type In Asm.GetTypes()
            If t.IsSubclassOf(GetType(Form)) Then
                Me.cmbFormularios.Items.Add(t.FullName)
            End If

        Next
    End Sub

    Public Function Nombre() As String
        Return Me.txtNombre.Text
    End Function

    Public Function Formulario() As String
        Return Me.cmbFormularios.Text
    End Function

    Private Sub FormularioDialogoPatentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbFormularios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormularios.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim permiso As New npermisos
        permiso.nombre = cmbFormularios.SelectedItem.ToString


        permiso.insertar()



        'npermisos.



    End Sub
End Class