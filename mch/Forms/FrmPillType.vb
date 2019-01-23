Imports System.Data.Odbc

Public Class FrmPillType
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
    Private Sub FrmPillType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        TxtPillType.Select()

    End Sub
    Private Sub loadPillType()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `PTID`, `PillName` FROM `pill_type` ORDER BY PillName ASC", conn)
        DA.Fill(DT)
        DGVPillType.DataSource = DT
        DGVPillType.Columns(0).Visible = False
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim DrClinic As OdbcDataReader
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim GetClinic As New OdbcCommand
        With GetClinic
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "SELECT `PTID`, `PillName` FROM `pill_type` WHERE  `PillName`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Trim(TxtPillType.Text)
            DrClinic = .ExecuteReader
        End With
        If DrClinic.HasRows Then

            MessageBox.Show("The Pill Name: " & DrClinic.Item(1) & "  Has Already Been Registered", "Duplicate Data Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPillType.Text = ""
            TxtPillType.Select()
            MyTrans.Rollback()
            'intertrans.Rollback()
            Exit Sub
        End If
        Dim CMDSave As New OdbcCommand
        With CMDSave
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `pill_type`( `PillName`) VALUES (?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPillType.Text
            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        TxtPillType.Text = ""
        TxtPillType.Select()
        'MessageBox.Show("OK")
        loadPillType()
    End Sub

    Private Sub DGVPillType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVPillType.Click
        Dim DrClinics As OdbcDataReader
        With DGVPillType
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                lblptid.Text = .Item(0, currentRow).Value

                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT `PTID`, `PillName` FROM `pill_type` WHERE `PTID`=?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLPTID.Text
                    DrClinics = .ExecuteReader
                End With
                If DrClinics.HasRows Then
                    LBLPTID.Text = DrClinics.Item(0)
                    TxtPillType.Text = DrClinics.Item(1)
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
            .CommandText = "UPDATE `pill_type` SET `PillName`=? WHERE `PTID`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = TxtPillType.Text
            .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLPTID.Text
            .ExecuteNonQuery()
            TxtPillType.Text = ""
            TxtPillType.Select()
            loadPillType()
        End With
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        If LBLPTID.Text = 1 Then

            MessageBox.Show("This record cannot be deleted because it is default record", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            MyTrans.Rollback()
            TxtPillType.Text = ""
            TxtPillType.Select()
            Exit Sub
        Else
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If Result = Windows.Forms.DialogResult.Yes Then
                Dim CMDDelete As New OdbcCommand
                With CMDDelete
                    .Connection = conn
                    .Transaction = MyTrans
                    .CommandText = "DELETE FROM `pill_type` WHERE`PTID`=?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLPTID.Text
                    .ExecuteNonQuery()
                End With
                MyTrans.Commit()

            Else
                MessageBox.Show("Nothing was deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MyTrans.Rollback()
                Exit Sub
            End If
        End If
        TxtPillType.Text = ""
        TxtPillType.Select()
        loadPillType()
    End Sub

    Private Sub BtnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        loadPillType()
    End Sub
End Class