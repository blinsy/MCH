<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClinics
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtClinicName = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblCID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DGVClinic = New System.Windows.Forms.DataGridView()
        Me.BtnRegistry = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGVClinic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(13, 87)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(94, 87)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(180, 87)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Clinic Name:"
        '
        'TxtClinicName
        '
        Me.TxtClinicName.Location = New System.Drawing.Point(84, 26)
        Me.TxtClinicName.Name = "TxtClinicName"
        Me.TxtClinicName.Size = New System.Drawing.Size(171, 20)
        Me.TxtClinicName.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblCID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(370, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblCID
        '
        Me.LblCID.Name = "LblCID"
        Me.LblCID.Size = New System.Drawing.Size(42, 17)
        Me.LblCID.Text = "LblCID"
        Me.LblCID.Visible = False
        '
        'DGVClinic
        '
        Me.DGVClinic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClinic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVClinic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DGVClinic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClinic.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVClinic.Location = New System.Drawing.Point(0, 116)
        Me.DGVClinic.Name = "DGVClinic"
        Me.DGVClinic.ReadOnly = True
        Me.DGVClinic.Size = New System.Drawing.Size(370, 123)
        Me.DGVClinic.TabIndex = 7
        '
        'BtnRegistry
        '
        Me.BtnRegistry.Location = New System.Drawing.Point(261, 87)
        Me.BtnRegistry.Name = "BtnRegistry"
        Me.BtnRegistry.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistry.TabIndex = 8
        Me.BtnRegistry.Text = "Open Registry"
        Me.BtnRegistry.UseVisualStyleBackColor = True
        '
        'FrmClinics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 261)
        Me.Controls.Add(Me.BtnRegistry)
        Me.Controls.Add(Me.DGVClinic)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TxtClinicName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmClinics"
        Me.Text = "Clinics"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGVClinic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtClinicName As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LblCID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DGVClinic As System.Windows.Forms.DataGridView
    Friend WithEvents BtnRegistry As System.Windows.Forms.Button
End Class
