<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class boleta
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
        Me.dgvtodo = New System.Windows.Forms.DataGrid()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnmostrartodo = New System.Windows.Forms.Button()
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvtodo
        '
        Me.dgvtodo.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvtodo.CaptionBackColor = System.Drawing.Color.Peru
        Me.dgvtodo.CaptionFont = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvtodo.DataMember = ""
        Me.dgvtodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvtodo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvtodo.Location = New System.Drawing.Point(12, 224)
        Me.dgvtodo.Name = "dgvtodo"
        Me.dgvtodo.PreferredColumnWidth = 94
        Me.dgvtodo.Size = New System.Drawing.Size(983, 323)
        Me.dgvtodo.TabIndex = 245
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.Color.Transparent
        Me.BTNIMPRIMIR.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.apps_printer_15747
        Me.BTNIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIMPRIMIR.FlatAppearance.BorderSize = 0
        Me.BTNIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(793, 177)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(53, 42)
        Me.BTNIMPRIMIR.TabIndex = 340
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.actions_document_print_preview_15786
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(861, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 42)
        Me.Button3.TabIndex = 339
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnmostrartodo
        '
        Me.btnmostrartodo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnmostrartodo.FlatAppearance.BorderSize = 0
        Me.btnmostrartodo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnmostrartodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmostrartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmostrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmostrartodo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrartodo.Location = New System.Drawing.Point(588, 183)
        Me.btnmostrartodo.Name = "btnmostrartodo"
        Me.btnmostrartodo.Size = New System.Drawing.Size(107, 35)
        Me.btnmostrartodo.TabIndex = 341
        Me.btnmostrartodo.Text = "MOSTRAR TODO"
        Me.btnmostrartodo.UseVisualStyleBackColor = False
        '
        'boleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 594)
        Me.Controls.Add(Me.btnmostrartodo)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvtodo)
        Me.Name = "boleta"
        Me.Text = "boleta"
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvtodo As System.Windows.Forms.DataGrid
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnmostrartodo As System.Windows.Forms.Button
End Class
