<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelector
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
        Me.DGVSelector = New System.Windows.Forms.DataGridView()
        Me.LblPointer = New System.Windows.Forms.Label()
        CType(Me.DGVSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVSelector
        '
        Me.DGVSelector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSelector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVSelector.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVSelector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSelector.Location = New System.Drawing.Point(1, 2)
        Me.DGVSelector.Name = "DGVSelector"
        Me.DGVSelector.ReadOnly = True
        Me.DGVSelector.Size = New System.Drawing.Size(406, 317)
        Me.DGVSelector.TabIndex = 0
        '
        'LblPointer
        '
        Me.LblPointer.AutoSize = True
        Me.LblPointer.Location = New System.Drawing.Point(353, 318)
        Me.LblPointer.Name = "LblPointer"
        Me.LblPointer.Size = New System.Drawing.Size(54, 13)
        Me.LblPointer.TabIndex = 1
        Me.LblPointer.Text = "LblPointer"
        Me.LblPointer.Visible = False
        '
        'FrmSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 331)
        Me.Controls.Add(Me.LblPointer)
        Me.Controls.Add(Me.DGVSelector)
        Me.Name = "FrmSelector"
        Me.Text = "Select Item"
        CType(Me.DGVSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVSelector As System.Windows.Forms.DataGridView
    Friend WithEvents LblPointer As System.Windows.Forms.Label
End Class
