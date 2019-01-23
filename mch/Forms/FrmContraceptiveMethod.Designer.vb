<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMethods
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
        Me.Txtmethod = New System.Windows.Forms.TextBox()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblMTID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DGVMethods = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGVMethods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Method Name :"
        '
        'Txtmethod
        '
        Me.Txtmethod.Location = New System.Drawing.Point(108, 24)
        Me.Txtmethod.Name = "Txtmethod"
        Me.Txtmethod.Size = New System.Drawing.Size(167, 20)
        Me.Txtmethod.TabIndex = 1
        '
        'Btnsave
        '
        Me.Btnsave.Location = New System.Drawing.Point(15, 69)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 23)
        Me.Btnsave.TabIndex = 2
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(108, 69)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(200, 69)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(293, 69)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpen.TabIndex = 5
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblMTID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 245)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(380, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblMTID
        '
        Me.LblMTID.Name = "LblMTID"
        Me.LblMTID.Size = New System.Drawing.Size(52, 17)
        Me.LblMTID.Text = "LblMTID"
        Me.LblMTID.Visible = False
        '
        'DGVMethods
        '
        Me.DGVMethods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVMethods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMethods.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVMethods.Location = New System.Drawing.Point(0, 98)
        Me.DGVMethods.Name = "DGVMethods"
        Me.DGVMethods.ReadOnly = True
        Me.DGVMethods.Size = New System.Drawing.Size(380, 147)
        Me.DGVMethods.TabIndex = 7
        '
        'FrmMethods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 267)
        Me.Controls.Add(Me.DGVMethods)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Txtmethod)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMethods"
        Me.Text = "Methods"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGVMethods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtmethod As System.Windows.Forms.TextBox
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DGVMethods As System.Windows.Forms.DataGridView
    Friend WithEvents LblMTID As System.Windows.Forms.ToolStripStatusLabel
End Class
