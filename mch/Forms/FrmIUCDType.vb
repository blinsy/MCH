Imports System.Data.Odbc

Public Class FrmIUCDType

    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
    Private Sub FrmIUCDType_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        TxtIUCDType.Select()

    End Sub
    Private Sub loadIucdType()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `IUCDTID`, `IUCD_Name` FROM `iucd_type`  ORDER BY IUCD_Name ASC", conn)
        DA.Fill(DT)
        DGVIUCDType.DataSource = DT
        DGVIUCDType.Columns(0).Visible = False
    End Sub

    Private Sub DGVIUCDType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVIUCDType.Click

        Dim DrClinics As OdbcDataReader
        With DGVIUCDType
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                LBLIUCDTID.Text = .Item(0, currentRow).Value

                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT `IUCDTID`, `IUCD_Name` FROM `iucd_type` WHERE `IUCDTID`=?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLIUCDTID.Text
                    DrClinics = .ExecuteReader
                End With
                If DrClinics.HasRows Then
                    LBLIUCDTID.Text = DrClinics.Item(0)
                    TxtIUCDType.Text = DrClinics.Item(1)
                End If
            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub
    'save
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DrClinic As OdbcDataReader
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim GetClinic As New OdbcCommand
        With GetClinic
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "SELECT `IUCDTID`, `IUCD_Name` FROM `iucd_type WHERE  `IUCD_Name`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Trim(TxtIUCDType.Text)
            DrClinic = .ExecuteReader
        End With
        If DrClinic.HasRows Then

            MessageBox.Show("The IUCD Name: " & DrClinic.Item(1) & "  Has Already Been Registered", "Duplicate Data Entry Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtIUCDType.Text = ""
            TxtIUCDType.Select()
            MyTrans.Rollback()
            'intertrans.Rollback()
            Exit Sub
        End If
        Dim CMDSave As New OdbcCommand
        With CMDSave
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `iucd_type`( `IUCD_Name`) VALUES (?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtIUCDType.Text
            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        TxtIUCDType.Text = ""
        TxtIUCDType.Select()
        'MessageBox.Show("OK")
        loadIucdType()
    End Sub
    'update
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim CMDUpdate As New OdbcCommand
        With CMDUpdate
            .Connection = conn
            .CommandText = "UPDATE `iucd_type` SET `IUCD_Name`=? WHERE `IUCDTID`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = TxtIUCDType.Text
            .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLIUCDTID.Text
            .ExecuteNonQuery()
            TxtIUCDType.Text = ""
            TxtIUCDType.Select()
            loadIucdType()
        End With
    End Sub
    'delete
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        If LBLIUCDTID.Text = 1 Then

            MessageBox.Show("This record cannot be deleted because it is default record", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            MyTrans.Rollback()
            TxtIUCDType.Text = ""
            TxtIUCDType.Select()
            Exit Sub
        Else
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If Result = Windows.Forms.DialogResult.Yes Then
                Dim CMDDelete As New OdbcCommand
                With CMDDelete
                    .Connection = conn
                    .Transaction = MyTrans
                    .CommandText = "DELETE FROM `iucd_type` WHERE IUCDTID=? "
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLIUCDTID.Text
                    .ExecuteNonQuery()
                End With
                MyTrans.Commit()

            Else
                MessageBox.Show("Nothing was deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MyTrans.Rollback()
                Exit Sub
            End If
        End If
        TxtIUCDType.Text = ""
        TxtIUCDType.Select()
        loadIucdType()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loadIucdType()
    End Sub
End Class