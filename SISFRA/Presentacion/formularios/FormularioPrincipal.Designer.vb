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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pnllogin = New System.Windows.Forms.Panel()
        Me.txtloginpass = New System.Windows.Forms.TextBox()
        Me.txtloginuser = New System.Windows.Forms.TextBox()
        Me.ptbsalir = New System.Windows.Forms.PictureBox()
        Me.ptbingresar = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Pnllogin.SuspendLayout()
        CType(Me.ptbsalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbingresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracionToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
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
        Me.PatenteToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.PatenteToolStripMenuItem.Text = "Patente"
        '
        'FamiliaToolStripMenuItem
        '
        Me.FamiliaToolStripMenuItem.Name = "FamiliaToolStripMenuItem"
        Me.FamiliaToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.FamiliaToolStripMenuItem.Text = "Familia"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'Pnllogin
        '
        Me.Pnllogin.BackColor = System.Drawing.Color.Transparent
        Me.Pnllogin.BackgroundImage = CType(resources.GetObject("Pnllogin.BackgroundImage"), System.Drawing.Image)
        Me.Pnllogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnllogin.Controls.Add(Me.txtloginpass)
        Me.Pnllogin.Controls.Add(Me.txtloginuser)
        Me.Pnllogin.Controls.Add(Me.ptbsalir)
        Me.Pnllogin.Controls.Add(Me.ptbingresar)
        Me.Pnllogin.Location = New System.Drawing.Point(12, 27)
        Me.Pnllogin.Name = "Pnllogin"
        Me.Pnllogin.Size = New System.Drawing.Size(512, 283)
        Me.Pnllogin.TabIndex = 1
        '
        'txtloginpass
        '
        Me.txtloginpass.BackColor = System.Drawing.Color.SkyBlue
        Me.txtloginpass.Location = New System.Drawing.Point(120, 157)
        Me.txtloginpass.Name = "txtloginpass"
        Me.txtloginpass.Size = New System.Drawing.Size(236, 20)
        Me.txtloginpass.TabIndex = 3
        '
        'txtloginuser
        '
        Me.txtloginuser.BackColor = System.Drawing.Color.SkyBlue
        Me.txtloginuser.Location = New System.Drawing.Point(119, 105)
        Me.txtloginuser.Name = "txtloginuser"
        Me.txtloginuser.Size = New System.Drawing.Size(237, 20)
        Me.txtloginuser.TabIndex = 2
        '
        'ptbsalir
        '
        Me.ptbsalir.BackColor = System.Drawing.Color.Transparent
        Me.ptbsalir.BackgroundImage = CType(resources.GetObject("ptbsalir.BackgroundImage"), System.Drawing.Image)
        Me.ptbsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbsalir.Location = New System.Drawing.Point(463, 13)
        Me.ptbsalir.Name = "ptbsalir"
        Me.ptbsalir.Size = New System.Drawing.Size(37, 29)
        Me.ptbsalir.TabIndex = 1
        Me.ptbsalir.TabStop = False
        '
        'ptbingresar
        '
        Me.ptbingresar.BackColor = System.Drawing.Color.Transparent
        Me.ptbingresar.BackgroundImage = CType(resources.GetObject("ptbingresar.BackgroundImage"), System.Drawing.Image)
        Me.ptbingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbingresar.Location = New System.Drawing.Point(376, 85)
        Me.ptbingresar.Name = "ptbingresar"
        Me.ptbingresar.Size = New System.Drawing.Size(124, 107)
        Me.ptbingresar.TabIndex = 0
        Me.ptbingresar.TabStop = False
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(824, 426)
        Me.Controls.Add(Me.Pnllogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormularioPrincipal"
        Me.Text = "FormularioPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Pnllogin.ResumeLayout(False)
        Me.Pnllogin.PerformLayout()
        CType(Me.ptbsalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbingresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pnllogin As System.Windows.Forms.Panel
    Friend WithEvents txtloginpass As System.Windows.Forms.TextBox
    Friend WithEvents txtloginuser As System.Windows.Forms.TextBox
    Friend WithEvents ptbsalir As System.Windows.Forms.PictureBox
    Friend WithEvents ptbingresar As System.Windows.Forms.PictureBox
End Class
