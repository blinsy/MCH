Imports System.Data.Odbc

Public Class FrmClinics
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
    Private Sub FrmClinics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        TxtClinicName.Select()

    End Sub
    Private Sub LoadClinics()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `CID`, `Clinic_Name` FROM `clinics` ORDER BY Clinic_Name ASC", conn)
        DA.Fill(DT)
        DGVClinic.DataSource = DT
        DGVClinic.Columns(0).Visible = False
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim DrClinic As OdbcDataReader
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim GetClinic As New OdbcCommand
        With GetClinic
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "SELECT `CID`, `Clinic_Name` FROM `clinics` WHERE  `Clinic_Name`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Trim(TxtClinicName.Text)
            DrClinic = .ExecuteReader
        End With
        If DrClinic.HasRows Then

            MessageBox.Show("The Clinic Name: " & DrClinic.Item(1) & "  Has Already Been Registered", "Duplicate Data Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtClinicName.Text = ""
            TxtClinicName.Select()
            MyTrans.Rollback()
            'intertrans.Rollback()
            Exit Sub
        End If
        Dim CMDSave As New OdbcCommand
        With CMDSave
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `clinics`(`Clinic_Name`) VALUES (?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtClinicName.Text
            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        TxtClinicName.Text = ""
        TxtClinicName.Select()
        'MessageBox.Show("OK")
        LoadClinics()
    End Sub

    Private Sub DGVClinic_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVClinic.Click
        Dim DrClinics As OdbcDataReader
        With DGVClinic
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                LblCID.Text = .Item(0, currentRow).Value

                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT `CID`, `Clinic_Name` FROM `clinics`  WHERE `CID`=?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblCID.Text
                    DrClinics = .ExecuteReader
                End With
                If DrClinics.HasRows Then
                    LblCID.Text = DrClinics.Item(0)
                    TxtClinicName.Text = DrClinics.Item(1)
                End If
            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim CMDUpdate As New OdbcCommand
        With CMDUpdate
            .Connection = conn
            .CommandText = "UPDATE `clinics` SET `Clinic_Name`=? WHERE `CID`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = TxtClinicName.Text
            .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblCID.Text
            .ExecuteNonQuery()
            TxtClinicName.Text = ""
            TxtClinicName.Select()
            LoadClinics()
        End With
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        If LblCID.Text = 1 Then

            MessageBox.Show("This record cannot be deleted because it is default record", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            MyTrans.Rollback()
            TxtClinicName.Text = ""
            TxtClinicName.Select()
            Exit Sub
        Else
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If Result = Windows.Forms.DialogResult.Yes Then
                Dim CMDDelete As New OdbcCommand
                With CMDDelete
                    .Connection = conn
                    .Transaction = MyTrans
                    .CommandText = "DELETE FROM `clinics` WHERE `CID`=?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblCID.Text
                    .ExecuteNonQuery()
                End With
                MyTrans.Commit()

            Else
                MessageBox.Show("Nothing was deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MyTrans.Rollback()
                Exit Sub
            End If
        End If
        TxtClinicName.Text = ""
        TxtClinicName.Select()
        LoadClinics()
        
    End Sub

    Private Sub BtnRegistry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistry.Click
        LoadClinics()
    End Sub
End Class