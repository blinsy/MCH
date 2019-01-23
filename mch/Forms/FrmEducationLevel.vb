Imports System.Data.Odbc

Public Class FrmEducationLevel
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter

    Private Sub LoadEducationLevel()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `ELID`, `Education_Level` FROM `education_level`  ORDER BY Education_Level ASC", conn)
        DA.Fill(DT)
        DGVEducationLevel.DataSource = DT
        DGVEducationLevel.Columns(0).Visible = False
        DGVEducationLevel.Columns(0).Visible = False
    End Sub
    Private Sub FormEducationLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        TxtEducationLevel.Select()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim DrClinic As OdbcDataReader
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim GetClinic As New OdbcCommand
        With GetClinic
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "SELECT `ELID`, `Education_Level` FROM `education_level` WHERE  `education_level`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Trim(TxtEducationLevel.Text)
            DrClinic = .ExecuteReader
        End With
        If DrClinic.HasRows Then
            MyTrans.Rollback()

            MessageBox.Show("The Education Level Name: " & DrClinic.Item(1) & "  Has Already Been Registered", "Duplicate Data Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'intertrans.Rollback()
            Exit Sub
        End If
        Dim CMDSave As New OdbcCommand
        With CMDSave
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `education_level`(`Education_Level`) VALUES (?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtEducationLevel.Text
            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        LoadEducationLevel()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim CMDUpdate As New OdbcCommand
        With CMDUpdate
            .Connection = conn
            .CommandText = "UPDATE `education_level` SET `ELID`=? WHERE `ELID"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = TxtEducationLevel.Text
            .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblELID.Text
            .ExecuteNonQuery()
            LoadEducationLevel()
        End With
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim CMDDelete As New OdbcCommand
            With CMDDelete
                .Connection = conn
                .CommandText = "DELETE FROM `education_level` WHERE `ELID`=?"
                .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblELID.Text
                .ExecuteNonQuery()
                LoadEducationLevel()
            End With
        Else
            MessageBox.Show("Nothing was deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BtnRegistry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistry.Click
        LoadEducationLevel()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class