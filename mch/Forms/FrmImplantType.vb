Imports System.Data.Odbc

Public Class FrmImplantType
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
   
    Private Sub FrmImplantType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        TxtImplantType.Select()
    End Sub
    Private Sub LoadImplantType()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `ITID`, `ImplantType` FROM `implant_type` ORDER BY ImplantType ASC", conn)
        DA.Fill(DT)
        DGVImplantType.DataSource = DT
        DGVImplantType.Columns(0).Visible = False
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim DrClinic As OdbcDataReader
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim GetClinic As New OdbcCommand
        With GetClinic
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "SELECT `ITID`, `ImplantType` FROM `implant_type` WHERE  `ImplantType`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Trim(TxtImplantType.Text)
            DrClinic = .ExecuteReader
        End With
        If DrClinic.HasRows Then

            MessageBox.Show("The Type Name: " & DrClinic.Item(1) & "  Has Already Been Registered", "Duplicate Data Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MyTrans.Rollback()
            'intertrans.Rollback()
            Exit Sub
        End If
        Dim CMDSave As New OdbcCommand
        With CMDSave
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `implant_type`(`ImplantType`) VALUES (?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtImplantType.Text
            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        TxtImplantType.Text = ""
        'MessageBox.Show("OK")
        LoadImplantType()
    End Sub

    Private Sub DGVImplantType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVImplantType.Click
        Dim DrClinics As OdbcDataReader
        With DGVImplantType
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                LBLITID.Text = .Item(0, currentRow).Value

                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT `ITID`, `ImplantType` FROM `implant_type` WHERE  `ImplantType`=?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLITID.Text
                    DrClinics = .ExecuteReader
                End With
                If DrClinics.HasRows Then
                    LBLITID.Text = DrClinics.Item(0)
                    TxtImplantType.Text = DrClinics.Item(1)
                End If
            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub

    Private Sub BTnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTnUpdate.Click
        Dim CMDUpdate As New OdbcCommand
        With CMDUpdate
            .Connection = conn
            .CommandText = "UPDATE `implant_type` SET `ImplantType`=? WHERE `ITID`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = TxtImplantType.Text
            .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLITID.Text
            .ExecuteNonQuery()
            LoadImplantType()
        End With
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim CMDDelete As New OdbcCommand
            With CMDDelete
                .Connection = conn
                .CommandText = "DELETE FROM `clinics` WHERE `CID`=?"
                .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLITID.Text
                .ExecuteNonQuery()
                LoadImplantType()
            End With
        Else
            MessageBox.Show("Nothing was deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        LoadImplantType()
    End Sub
End Class
