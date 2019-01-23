<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPillType
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
        Me.TxtPillType = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LBLPTID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DGVPillType = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGVPillType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type  Name :"
        '
        'TxtPillType
        '
        Me.TxtPillType.Location = New System.Drawing.Point(109, 19)
        Me.TxtPillType.Name = "TxtPillType"
        Me.TxtPillType.Size = New System.Drawing.Size(157, 20)
        Me.TxtPillType.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(24, 60)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(109, 60)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(191, 59)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(272, 59)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpen.TabIndex = 5
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LBLPTID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 211)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(362, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LBLPTID
        '
        Me.LBLPTID.Name = "LBLPTID"
        Me.LBLPTID.Size = New System.Drawing.Size(51, 17)
        Me.LBLPTID.Text = "LBLPTID"
        Me.LBLPTID.Visible = False
        '
        'DGVPillType
        '
        Me.DGVPillType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVPillType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGVPillType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPillType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVPillType.Location = New System.Drawing.Point(0, 84)
        Me.DGVPillType.Name = "DGVPillType"
        Me.DGVPillType.Size = New System.Drawing.Size(362, 127)
        Me.DGVPillType.TabIndex = 7
        '
        'FrmPillType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 233)
        Me.Controls.Add(Me.DGVPillType)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtPillType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPillType"
        Me.Text = "Pill Type"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGVPillType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPillType As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DGVPillType As System.Windows.Forms.DataGridView
    Friend WithEvents LBLPTID As System.Windows.Forms.ToolStripStatusLabel
End Class
