<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioDialogoPatentes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbFormularios = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(18, 76)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(248, 20)
        Me.txtNombre.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 166)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbFormularios
        '
        Me.cmbFormularios.FormattingEnabled = True
        Me.cmbFormularios.Location = New System.Drawing.Point(18, 108)
        Me.cmbFormularios.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFormularios.Name = "cmbFormularios"
        Me.cmbFormularios.Size = New System.Drawing.Size(248, 21)
        Me.cmbFormularios.TabIndex = 3
        '
        'FormularioDialogoPatente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbFormularios)
        Me.Name = "FormularioDialogoPatente"
        Me.Text = "FormularioDialogoPatente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbFormularios As System.Windows.Forms.ComboBox
End Class
