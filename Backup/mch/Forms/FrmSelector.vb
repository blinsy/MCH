Imports System.Data.Odbc

Public Class FrmSelector
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter

    Private Sub DGVSelector_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVSelector.CellContentClick

    End Sub

    Private Sub FrmSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()

        If LblPointer.Text = 1 Then

            DA = New OdbcDataAdapter("SELECT `ELID`, `Education_Level` FROM `education_level` ORDER BY Education_Level ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 2 Then
            DA = New OdbcDataAdapter("SELECT `CID`, `Clinic_Name` FROM `clinics` ORDER BY Clinic_Name ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        End If

    End Sub
    Private Sub DGVSelector_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVSelector.DoubleClick
        With DGVSelector
            Dim currentRow As Integer = .CurrentRow.Index
            If LblPointer.Text = 1 Then
                FirstVistiForm.LblELID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtEduLevel.Text = .Item(1, currentRow).Value

            ElseIf LblPointer.Text = 2 Then
                FirstVistiForm.LblCID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtClinic.Text = .Item(1, currentRow).Value
            End If
            Me.Close()
        End With


    End Sub
End Class