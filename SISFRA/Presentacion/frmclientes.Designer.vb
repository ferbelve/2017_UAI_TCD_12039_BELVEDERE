<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmclientes))
        Me.PnlListadoClientes = New System.Windows.Forms.Panel()
        Me.grblistadoclientes = New System.Windows.Forms.GroupBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Lnlinexitente = New System.Windows.Forms.LinkLabel()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grbmatenimiento = New System.Windows.Forms.GroupBox()
        Me.lbldni = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.PnlListadoClientes.SuspendLayout()
        Me.grblistadoclientes.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbmatenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlListadoClientes
        '
        Me.PnlListadoClientes.BackgroundImage = CType(resources.GetObject("PnlListadoClientes.BackgroundImage"), System.Drawing.Image)
        Me.PnlListadoClientes.Controls.Add(Me.grblistadoclientes)
        Me.PnlListadoClientes.Controls.Add(Me.grbmatenimiento)
        Me.PnlListadoClientes.Location = New System.Drawing.Point(12, 0)
        Me.PnlListadoClientes.Name = "PnlListadoClientes"
        Me.PnlListadoClientes.Size = New System.Drawing.Size(842, 485)
        Me.PnlListadoClientes.TabIndex = 0
        '
        'grblistadoclientes
        '
        Me.grblistadoclientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grblistadoclientes.BackColor = System.Drawing.Color.Transparent
        Me.grblistadoclientes.Controls.Add(Me.btneliminar)
        Me.grblistadoclientes.Controls.Add(Me.Lnlinexitente)
        Me.grblistadoclientes.Controls.Add(Me.cbocampo)
        Me.grblistadoclientes.Controls.Add(Me.txtbuscar)
        Me.grblistadoclientes.Controls.Add(Me.datalistado)
        Me.grblistadoclientes.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grblistadoclientes.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.grblistadoclientes.Location = New System.Drawing.Point(387, 0)
        Me.grblistadoclientes.Name = "grblistadoclientes"
        Me.grblistadoclientes.Size = New System.Drawing.Size(455, 450)
        Me.grblistadoclientes.TabIndex = 5
        Me.grblistadoclientes.TabStop = False
        Me.grblistadoclientes.Text = "Listado de Clientes"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneliminar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.Aquamarine
        Me.btneliminar.Location = New System.Drawing.Point(27, 401)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(109, 34)
        Me.btneliminar.TabIndex = 17
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'Lnlinexitente
        '
        Me.Lnlinexitente.AutoSize = True
        Me.Lnlinexitente.Location = New System.Drawing.Point(156, 220)
        Me.Lnlinexitente.Name = "Lnlinexitente"
        Me.Lnlinexitente.Size = New System.Drawing.Size(125, 19)
        Me.Lnlinexitente.TabIndex = 4
        Me.Lnlinexitente.TabStop = True
        Me.Lnlinexitente.Text = "Datos inexistentes"
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"nombre", "apellido", "dni", "telefono"})
        Me.cbocampo.Location = New System.Drawing.Point(17, 34)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(138, 27)
        Me.cbocampo.TabIndex = 3
        Me.cbocampo.Text = "DNI"
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(171, 34)
        Me.txtbuscar.Multiline = True
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(259, 27)
        Me.txtbuscar.TabIndex = 2
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(17, 79)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(413, 298)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'grbmatenimiento
        '
        Me.grbmatenimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbmatenimiento.BackColor = System.Drawing.Color.Transparent
        Me.grbmatenimiento.Controls.Add(Me.lbldni)
        Me.grbmatenimiento.Controls.Add(Me.txtdni)
        Me.grbmatenimiento.Controls.Add(Me.btncancelar)
        Me.grbmatenimiento.Controls.Add(Me.btneditar)
        Me.grbmatenimiento.Controls.Add(Me.btnnuevo)
        Me.grbmatenimiento.Controls.Add(Me.txtdireccion)
        Me.grbmatenimiento.Controls.Add(Me.txttelefono)
        Me.grbmatenimiento.Controls.Add(Me.txtmail)
        Me.grbmatenimiento.Controls.Add(Me.txtapellido)
        Me.grbmatenimiento.Controls.Add(Me.lbldireccion)
        Me.grbmatenimiento.Controls.Add(Me.lbltelefono)
        Me.grbmatenimiento.Controls.Add(Me.lblmail)
        Me.grbmatenimiento.Controls.Add(Me.lblapellido)
        Me.grbmatenimiento.Controls.Add(Me.lblnombre)
        Me.grbmatenimiento.Controls.Add(Me.txtnombre)
        Me.grbmatenimiento.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbmatenimiento.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.grbmatenimiento.Location = New System.Drawing.Point(-1, 49)
        Me.grbmatenimiento.Name = "grbmatenimiento"
        Me.grbmatenimiento.Size = New System.Drawing.Size(377, 344)
        Me.grbmatenimiento.TabIndex = 4
        Me.grbmatenimiento.TabStop = False
        Me.grbmatenimiento.Text = "Mantenimiento"
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldni.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lbldni.Location = New System.Drawing.Point(20, 115)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(42, 19)
        Me.lbldni.TabIndex = 18
        Me.lbldni.Text = "DNI:"
        '
        'txtdni
        '
        Me.txtdni.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(114, 114)
        Me.txtdni.Multiline = True
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(235, 20)
        Me.txtdni.TabIndex = 17
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Aquamarine
        Me.btncancelar.Location = New System.Drawing.Point(240, 294)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(109, 34)
        Me.btncancelar.TabIndex = 16
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btneditar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.ForeColor = System.Drawing.Color.Aquamarine
        Me.btneditar.Location = New System.Drawing.Point(117, 294)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(117, 34)
        Me.btneditar.TabIndex = 15
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Aquamarine
        Me.btnnuevo.Location = New System.Drawing.Point(6, 294)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 14
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtdireccion
        '
        Me.txtdireccion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(113, 230)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(235, 20)
        Me.txtdireccion.TabIndex = 13
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(113, 190)
        Me.txttelefono.Multiline = True
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(235, 20)
        Me.txttelefono.TabIndex = 12
        '
        'txtmail
        '
        Me.txtmail.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmail.Location = New System.Drawing.Point(113, 152)
        Me.txtmail.Multiline = True
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(235, 20)
        Me.txtmail.TabIndex = 11
        '
        'txtapellido
        '
        Me.txtapellido.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(113, 78)
        Me.txtapellido.Multiline = True
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(235, 20)
        Me.txtapellido.TabIndex = 10
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lbldireccion.Location = New System.Drawing.Point(20, 230)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(73, 19)
        Me.lbldireccion.TabIndex = 9
        Me.lbldireccion.Text = "Direccion:"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lbltelefono.Location = New System.Drawing.Point(20, 191)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(70, 19)
        Me.lbltelefono.TabIndex = 7
        Me.lbltelefono.Text = "Telefono:"
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmail.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblmail.Location = New System.Drawing.Point(20, 152)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(41, 19)
        Me.lblmail.TabIndex = 5
        Me.lblmail.Text = "Mail:"
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellido.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblapellido.Location = New System.Drawing.Point(20, 77)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(66, 19)
        Me.lblapellido.TabIndex = 3
        Me.lblapellido.Text = "Apellido:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblnombre.Location = New System.Drawing.Point(20, 40)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(64, 19)
        Me.lblnombre.TabIndex = 1
        Me.lblnombre.Text = "Nombre:"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(113, 41)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(235, 20)
        Me.txtnombre.TabIndex = 0
        '
        'frmclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(866, 488)
        Me.Controls.Add(Me.PnlListadoClientes)
        Me.Name = "frmclientes"
        Me.Text = "Listado de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlListadoClientes.ResumeLayout(False)
        Me.grblistadoclientes.ResumeLayout(False)
        Me.grblistadoclientes.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbmatenimiento.ResumeLayout(False)
        Me.grbmatenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlListadoClientes As System.Windows.Forms.Panel
    Friend WithEvents grblistadoclientes As System.Windows.Forms.GroupBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents Lnlinexitente As System.Windows.Forms.LinkLabel
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grbmatenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents lblmail As System.Windows.Forms.Label
    Friend WithEvents lblapellido As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
End Class
