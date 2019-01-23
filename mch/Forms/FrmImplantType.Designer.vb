<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImplantType
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LBLITID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DGVImplantType = New System.Windows.Forms.DataGridView()
        Me.TxtImplantType = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BTnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGVImplantType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LBLITID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(344, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LBLITID
        '
        Me.LBLITID.Name = "LBLITID"
        Me.LBLITID.Size = New System.Drawing.Size(47, 17)
        Me.LBLITID.Text = "LBLITID"
        Me.LBLITID.Visible = False
        '
        'DGVImplantType
        '
        Me.DGVImplantType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVImplantType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGVImplantType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGVImplantType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVImplantType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVImplantType.Location = New System.Drawing.Point(0, 94)
        Me.DGVImplantType.Name = "DGVImplantType"
        Me.DGVImplantType.Size = New System.Drawing.Size(344, 145)
        Me.DGVImplantType.TabIndex = 1
        '
        'TxtImplantType
        '
        Me.TxtImplantType.Location = New System.Drawing.Point(95, 21)
        Me.TxtImplantType.Name = "TxtImplantType"
        Me.TxtImplantType.Size = New System.Drawing.Size(157, 20)
        Me.TxtImplantType.TabIndex = 2
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(15, 65)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BTnUpdate
        '
        Me.BTnUpdate.Location = New System.Drawing.Point(95, 65)
        Me.BTnUpdate.Name = "BTnUpdate"
        Me.BTnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BTnUpdate.TabIndex = 4
        Me.BTnUpdate.Text = "Update"
        Me.BTnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(177, 65)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(259, 65)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpen.TabIndex = 6
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type Name :"
        '
        'FrmImplantType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BTnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtImplantType)
        Me.Controls.Add(Me.DGVImplantType)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmImplantType"
        Me.Text = "Implant Type"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGVImplantType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LBLITID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DGVImplantType As System.Windows.Forms.DataGridView
    Friend WithEvents TxtImplantType As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BTnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
