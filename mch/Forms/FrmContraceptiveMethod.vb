Imports System.Data.Odbc

Public Class FrmMethods
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
    Private Sub FrmMethods_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        Txtmethod.Select()

    End Sub
    Private Sub LoadMethods()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `MTID`, `Type_Name` FROM `method_type` ORDER BY Type_Name ASC", conn)
        DA.Fill(DT)
        DGVMethods.DataSource = DT
        DGVMethods.Columns(0).Visible = False
        DGVMethods.Columns(0).Visible = False
    End Sub

   
    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Dim DrClinic As OdbcDataReader
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim GetClinic As New OdbcCommand
        With GetClinic
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "SELECT `MTID`, `Type_Name` FROM `method_type` WHERE  `Type_Name`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Trim(Txtmethod.Text)

            DrClinic = .ExecuteReader
        End With
        If DrClinic.HasRows Then
            MyTrans.Rollback()

            MessageBox.Show("The Method Name: " & DrClinic.Item(1) & "  Has Already Been Registered", "Duplicate Data Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'intertrans.Rollback()
            Exit Sub
        End If
        Dim CMDSave As New OdbcCommand
        With CMDSave
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `method_type`(`Type_Name`) VALUES (?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = Txtmethod.Text

            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        LoadMethods()
    End Sub


    Private Sub DGVMethods_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVMethods.Click
        Dim DrClinics As OdbcDataReader
        With DGVMethods
            'Try
            Dim currentRow As Integer = .CurrentRow.Index
            LblMTID.Text = .Item(0, currentRow).Value

            Dim Get_details As New OdbcCommand
            With Get_details
                .Connection = conn
                .CommandText = "SELECT `MTID`, `Type_Name` FROM `method_type` WHERE  `Type_Name`=?"
                .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblMTID.Text
                DrClinics = .ExecuteReader
            End With
            If DrClinics.HasRows Then
                LblMTID.Text = DrClinics.Item(0)
                Txtmethod.Text = DrClinics.Item(1)

            End If
            'Catch ex As Exception

            'MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
        End With
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim CMDUpdate As New OdbcCommand
        With CMDUpdate
            .Connection = conn
            .CommandText = "UPDATE `method_type` SET `Type_Name`=? WHERE `MTID`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Txtmethod.Text
            .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblMTID.Text
            .ExecuteNonQuery()
            LoadMethods()
        End With
    End Sub


    Private Sub BtnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        LoadMethods()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Result = Windows.Forms.DialogResult.Yes Then
            Dim CMDDelete As New OdbcCommand
            With CMDDelete
                .Connection = conn
                .CommandText = "DELETE FROM `method_type` WHERE `MTID`=?"
                .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblMTID.Text
                .ExecuteNonQuery()
                LoadMethods()
            End With
        Else
            MessageBox.Show("Nothing was deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class