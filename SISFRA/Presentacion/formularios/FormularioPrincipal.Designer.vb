<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracionToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatenteToolStripMenuItem, Me.FamiliaToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'PatenteToolStripMenuItem
        '
        Me.PatenteToolStripMenuItem.Name = "PatenteToolStripMenuItem"
        Me.PatenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PatenteToolStripMenuItem.Text = "Patente"
        '
        'FamiliaToolStripMenuItem
        '
        Me.FamiliaToolStripMenuItem.Name = "FamiliaToolStripMenuItem"
        Me.FamiliaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FamiliaToolStripMenuItem.Text = "Familia"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 309)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormularioPrincipal"
        Me.Text = "FormularioPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
