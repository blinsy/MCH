<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInjectionType
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BTnUpdate = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtInjectionType = New System.Windows.Forms.TextBox()
        Me.DGVInjectionType = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LBLIID = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DGVInjectionType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Type Name :"
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(259, 55)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpen.TabIndex = 14
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(177, 55)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 13
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BTnUpdate
        '
        Me.BTnUpdate.Location = New System.Drawing.Point(95, 55)
        Me.BTnUpdate.Name = "BTnUpdate"
        Me.BTnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BTnUpdate.TabIndex = 12
        Me.BTnUpdate.Text = "Update"
        Me.BTnUpdate.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(15, 55)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtInjectionType
        '
        Me.TxtInjectionType.Location = New System.Drawing.Point(95, 11)
        Me.TxtInjectionType.Name = "TxtInjectionType"
        Me.TxtInjectionType.Size = New System.Drawing.Size(157, 20)
        Me.TxtInjectionType.TabIndex = 10
        '
        'DGVInjectionType
        '
        Me.DGVInjectionType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVInjectionType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGVInjectionType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGVInjectionType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInjectionType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVInjectionType.Location = New System.Drawing.Point(0, 89)
        Me.DGVInjectionType.Name = "DGVInjectionType"
        Me.DGVInjectionType.Size = New System.Drawing.Size(377, 145)
        Me.DGVInjectionType.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LBLIID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 234)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(377, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LBLIID
        '
        Me.LBLIID.Name = "LBLIID"
        Me.LBLIID.Size = New System.Drawing.Size(40, 17)
        Me.LBLIID.Text = "LBLIID"
        Me.LBLIID.Visible = False
        '
        'FrmInjectionType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 256)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BTnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtInjectionType)
        Me.Controls.Add(Me.DGVInjectionType)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmInjectionType"
        Me.Text = "FrmInjectionType"
        CType(Me.DGVInjectionType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BTnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtInjectionType As System.Windows.Forms.TextBox
    Friend WithEvents DGVInjectionType As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LBLIID As System.Windows.Forms.ToolStripStatusLabel
End Class
