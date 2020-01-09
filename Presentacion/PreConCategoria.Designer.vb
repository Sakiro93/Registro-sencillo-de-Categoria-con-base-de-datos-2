<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreConCategoria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GBox = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GBoxBuscar = New System.Windows.Forms.GroupBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.RbDesc = New System.Windows.Forms.RadioButton()
        Me.RbCod = New System.Windows.Forms.RadioButton()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBox.SuspendLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dg.BackgroundColor = System.Drawing.Color.White
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(43, 255)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dg.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(337, 150)
        Me.Dg.TabIndex = 0
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Enabled = False
        Me.BtnGrabar.Location = New System.Drawing.Point(164, 209)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabar.TabIndex = 6
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Location = New System.Drawing.Point(289, 209)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(43, 209)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 9
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'GBox
        '
        Me.GBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GBox.Controls.Add(Me.TxtDescripcion)
        Me.GBox.Controls.Add(Me.TxtCodigo)
        Me.GBox.Controls.Add(Me.LblDescripcion)
        Me.GBox.Controls.Add(Me.LblCodigo)
        Me.GBox.Location = New System.Drawing.Point(43, 68)
        Me.GBox.Name = "GBox"
        Me.GBox.Size = New System.Drawing.Size(337, 118)
        Me.GBox.TabIndex = 11
        Me.GBox.TabStop = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(166, 82)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(155, 20)
        Me.TxtDescripcion.TabIndex = 8
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(166, 27)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(82, 20)
        Me.TxtCodigo.TabIndex = 7
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.LblDescripcion.Location = New System.Drawing.Point(21, 81)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(127, 18)
        Me.LblDescripcion.TabIndex = 6
        Me.LblDescripcion.Text = "DESCRIPCION:"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.ForeColor = System.Drawing.Color.Red
        Me.LblCodigo.Location = New System.Drawing.Point(21, 27)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(80, 18)
        Me.LblCodigo.TabIndex = 5
        Me.LblCodigo.Text = "CODIGO:"
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(524, 422)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'GBoxBuscar
        '
        Me.GBoxBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBoxBuscar.Controls.Add(Me.TxtBuscar)
        Me.GBoxBuscar.Controls.Add(Me.RbDesc)
        Me.GBoxBuscar.Controls.Add(Me.RbCod)
        Me.GBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxBuscar.Location = New System.Drawing.Point(395, 68)
        Me.GBoxBuscar.Name = "GBoxBuscar"
        Me.GBoxBuscar.Size = New System.Drawing.Size(249, 118)
        Me.GBoxBuscar.TabIndex = 13
        Me.GBoxBuscar.TabStop = False
        Me.GBoxBuscar.Text = "Buscar"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(129, 55)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(114, 22)
        Me.TxtBuscar.TabIndex = 8
        '
        'RbDesc
        '
        Me.RbDesc.AutoSize = True
        Me.RbDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDesc.Location = New System.Drawing.Point(6, 85)
        Me.RbDesc.Name = "RbDesc"
        Me.RbDesc.Size = New System.Drawing.Size(109, 20)
        Me.RbDesc.TabIndex = 1
        Me.RbDesc.Text = "Descripción"
        Me.RbDesc.UseVisualStyleBackColor = True
        '
        'RbCod
        '
        Me.RbCod.AutoSize = True
        Me.RbCod.Checked = True
        Me.RbCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCod.Location = New System.Drawing.Point(6, 30)
        Me.RbCod.Name = "RbCod"
        Me.RbCod.Size = New System.Drawing.Size(76, 20)
        Me.RbCod.TabIndex = 0
        Me.RbCod.TabStop = True
        Me.RbCod.Text = "Código"
        Me.RbCod.UseVisualStyleBackColor = True
        '
        'PreConCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(656, 457)
        Me.Controls.Add(Me.GBoxBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GBox)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.Dg)
        Me.Name = "PreConCategoria"
        Me.Text = "PreConCategoria"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBox.ResumeLayout(False)
        Me.GBox.PerformLayout()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxBuscar.ResumeLayout(False)
        Me.GBoxBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents GBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents GBoxBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents RbDesc As System.Windows.Forms.RadioButton
    Friend WithEvents RbCod As System.Windows.Forms.RadioButton
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
End Class
