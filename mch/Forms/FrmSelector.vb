Imports System.Data.Odbc

Public Class FrmSelector
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
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
        ElseIf LblPointer.Text = 3 Then
            DA = New OdbcDataAdapter("SELECT `MTID`, `Type_Name` FROM `method_type` ORDER BY Type_Name ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 4 Then
            DA = New OdbcDataAdapter("SELECT `CTID`, `Type` FROM `contact_type` ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 5 Then
            DA = New OdbcDataAdapter("SELECT `CTID`, `Type` FROM `contact_type` ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False

          ElseIf LblPointer.Text = 6 Then
        DA = New OdbcDataAdapter("SELECT `CTID`, `Type` FROM `contact_type` ", conn)
        DT = New DataTable
        DA.Fill(DT)
        DGVSelector.DataSource = DT
        DGVSelector.Columns(0).Visible = False

          ElseIf LblPointer.Text = 7 Then
        DA = New OdbcDataAdapter("SELECT `CTID`, `Type` FROM `contact_type` ", conn)
        DT = New DataTable
        DA.Fill(DT)
        DGVSelector.DataSource = DT
        DGVSelector.Columns(0).Visible = False

          ElseIf LblPointer.Text = 8 Then
        DA = New OdbcDataAdapter("SELECT `CTID`, `Type` FROM `contact_type` ", conn)
        DT = New DataTable
        DA.Fill(DT)
        DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False

        ElseIf LblPointer.Text = 9 Then
            DA = New OdbcDataAdapter("SELECT `MTID`, `Type_Name` FROM `method_type` ORDER BY Type_Name ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 10 Then
            DA = New OdbcDataAdapter("SELECT `ITID`, `ImplantType` FROM `implant_type` ORDER BY ImplantType ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 11 Then
            DA = New OdbcDataAdapter("SELECT `IID`, `Injection_Name` FROM `injection_type` ORDER BY Injection_Name ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 12 Then
            DA = New OdbcDataAdapter("SELECT `IUCDTID`, `IUCD_Name` FROM `iucd_type` ORDER BY IUCD_Name ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 13 Then
            DA = New OdbcDataAdapter("SELECT `PTID`, `PillName` FROM `pill_type` ORDER BY PillName ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 14 Then
            DA = New OdbcDataAdapter("SELECT `STID`, `Spermicide_Name` FROM `spermicide_type` ORDER BY Spermicide_Name ASC  ", conn)
            DT = New DataTable
            DA.Fill(DT)
            DGVSelector.DataSource = DT
            DGVSelector.Columns(0).Visible = False
        ElseIf LblPointer.Text = 15 Then
            DA = New OdbcDataAdapter("SELECT `CHANGEID`, `Reasons` FROM `reason_for_change` ORDER BY Reasons ASC  ", conn)
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
            ElseIf LblPointer.Text = 3 Then
                FirstVistiForm.LblMTID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtPrevMethod.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 4 Then
                FirstVistiForm.LblCTID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtContactType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 5 Then
                FirstVistiForm.LblCTID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtAdressType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 6 Then
                FrmStaffDetail.LBLCTID.Text = .Item(0, currentRow).Value
                FrmStaffDetail.TxtContactType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 7 Then
                FrmStaffDetail.LBLCTID.Text = .Item(0, currentRow).Value
                FrmStaffDetail.TxtAdressType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 8 Then
                FrmStaffDetail.LBLCTID.Text = .Item(0, currentRow).Value
                FrmStaffDetail.TxtEmailAdressType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 9 Then
                FirstVistiForm.LblMTID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtMethodAdopted.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 10 Then
                FirstVistiForm.LblITID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtImplantType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 11 Then
                FirstVistiForm.LBLIID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtInjectionType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 12 Then
                FirstVistiForm.LBLIUCDTID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtIUCDType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 13 Then
                FirstVistiForm.LBLPTID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtPillType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 14 Then
                FirstVistiForm.LBLSTID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtSpermicidesType.Text = .Item(1, currentRow).Value
            ElseIf LblPointer.Text = 15 Then
                FirstVistiForm.lblCHANGEID.Text = .Item(0, currentRow).Value
                FirstVistiForm.TxtResonsChange.Text = .Item(1, currentRow).Value
            End If
            Me.Close()
        End With
    End Sub

End Class