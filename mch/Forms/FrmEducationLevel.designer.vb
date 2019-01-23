<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEducationLevel
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
        Me.DGVEducationLevel = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblELID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnRegistry = New System.Windows.Forms.Button()
        Me.TxtEducationLevel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.DGVEducationLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVEducationLevel
        '
        Me.DGVEducationLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEducationLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVEducationLevel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGVEducationLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEducationLevel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVEducationLevel.Location = New System.Drawing.Point(0, 98)
        Me.DGVEducationLevel.Name = "DGVEducationLevel"
        Me.DGVEducationLevel.ReadOnly = True
        Me.DGVEducationLevel.Size = New System.Drawing.Size(349, 123)
        Me.DGVEducationLevel.TabIndex = 25
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblELID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 221)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(349, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblELID
        '
        Me.LblELID.Name = "LblELID"
        Me.LblELID.Size = New System.Drawing.Size(46, 17)
        Me.LblELID.Text = "LblELID"
        Me.LblELID.Visible = False
        '
        'BtnRegistry
        '
        Me.BtnRegistry.Location = New System.Drawing.Point(253, 67)
        Me.BtnRegistry.Name = "BtnRegistry"
        Me.BtnRegistry.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistry.TabIndex = 23
        Me.BtnRegistry.Text = "Open Registry"
        Me.BtnRegistry.UseVisualStyleBackColor = True
        '
        'TxtEducationLevel
        '
        Me.TxtEducationLevel.Location = New System.Drawing.Point(91, 22)
        Me.TxtEducationLevel.Name = "TxtEducationLevel"
        Me.TxtEducationLevel.Size = New System.Drawing.Size(147, 20)
        Me.TxtEducationLevel.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Education Level:"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(172, 67)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 20
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(91, 67)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 19
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(10, 67)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 18
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FrmEducationLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 243)
        Me.Controls.Add(Me.DGVEducationLevel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnRegistry)
        Me.Controls.Add(Me.TxtEducationLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "FrmEducationLevel"
        Me.Text = "Education Level"
        CType(Me.DGVEducationLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVEducationLevel As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LblELID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BtnRegistry As System.Windows.Forms.Button
    Friend WithEvents TxtEducationLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
