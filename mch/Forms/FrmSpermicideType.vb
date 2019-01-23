Imports System.Data.Odbc

Public Class FrmSpermicideType
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
    Private Sub FrmSpermicideType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        TxtSpermicideType.Select()

    End Sub
    Private Sub LoadSpermicideType()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `STID`, `Spermicide_Name` FROM `spermicide_type` ORDER BY Spermicide_Name ASC", conn)
        DA.Fill(DT)
        DGVSpermicideType.DataSource = DT
        DGVSpermicideType.Columns(0).Visible = False
    End Sub
    'SAVE
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim DrClinic As OdbcDataReader
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim GetClinic As New OdbcCommand
        With GetClinic
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "SELECT `STID`, `Spermicide_Name` FROM `spermicide_type WHERE  `Spermicide_Name`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Trim(TxtSpermicideType.Text)
            DrClinic = .ExecuteReader
        End With
        If DrClinic.HasRows Then

            MessageBox.Show("The Spermicide Name: " & DrClinic.Item(1) & "  Has Already Been Registered", "Duplicate Data Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MyTrans.Rollback()
            'intertrans.Rollback()
            Exit Sub
        End If
        Dim CMDSave As New OdbcCommand
        With CMDSave
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `spermicide_type`(`Spermicide_Name`) VALUES (?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpermicideType.Text
            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        TxtSpermicideType.Text = ""
        'MessageBox.Show("OK")
        LoadSpermicideType()
    End Sub

    Private Sub DGVSpermicideType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVSpermicideType.Click
        Dim DrClinics As OdbcDataReader
        With DGVSpermicideType
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                LBLSTID.Text = .Item(0, currentRow).Value

                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT `STID`, `Spermicide_Name` FROM `spermicide_type` WHERE `STID`=?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLSTID.Text
                    DrClinics = .ExecuteReader
                End With
                If DrClinics.HasRows Then
                    LBLSTID.Text = DrClinics.Item(0)
                    TxtSpermicideType.Text = DrClinics.Item(1)
                End If
            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub
    'UPDATE
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim CMDUpdate As New OdbcCommand
        With CMDUpdate
            .Connection = conn
            .CommandText = "UPDATE `spermicide_type` SET `Spermicide_Name`=? WHERE `STID`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = TxtSpermicideType.Text
            .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLSTID.Text
            .ExecuteNonQuery()
            TxtSpermicideType.Text = ""
            TxtSpermicideType.Select()
            LoadSpermicideType()
        End With
    End Sub
    'DELETE
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        If LBLSTID.Text = 1 Then

            MessageBox.Show("This record cannot be deleted because it is default record", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            MyTrans.Rollback()
            TxtSpermicideType.Text = ""
            TxtSpermicideType.Select()
            Exit Sub
        Else
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If Result = Windows.Forms.DialogResult.Yes Then
                Dim CMDDelete As New OdbcCommand
                With CMDDelete
                    .Connection = conn
                    .Transaction = MyTrans
                    .CommandText = "DELETE FROM `spermicide_type`  WHERE STID=? "
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLSTID.Text
                    .ExecuteNonQuery()
                End With
                MyTrans.Commit()

            Else
                MessageBox.Show("Nothing was deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MyTrans.Rollback()
                Exit Sub
            End If
        End If
        TxtSpermicideType.Text = ""
        TxtSpermicideType.Select()
        LoadSpermicideType()
    End Sub

    Private Sub BtnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        LoadSpermicideType()
    End Sub
End Class