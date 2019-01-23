Imports System.Data.Odbc

Public Class FrmInjectionType
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
    Private Sub FrmInjectionType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        TxtInjectionType.Select()
    End Sub
    Private Sub loadinjectiontype()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `IID`, `Injection_Name` FROM `injection_type` ORDER BY Injection_Name ASC", conn)
        DA.Fill(DT)
        DGVInjectionType.DataSource = DT
        DGVInjectionType.Columns(0).Visible = False

    End Sub
    'SAVE
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim DrClinic As OdbcDataReader
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim GetClinic As New OdbcCommand
        With GetClinic
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "SELECT `IID`, `Injection_Name` FROM `injection_type` WHERE  `Injection_Name`=?"
            .Parameters.Add("p1", OdbcType.VarChar, 45).Value = Trim(TxtInjectionType.Text)
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
            .CommandText = "INSERT INTO `injection_type`(`Injection_Name`) VALUES (?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtInjectionType.Text
            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        TxtInjectionType.Text = ""
        'MessageBox.Show("OK")
        loadinjectiontype()
    End Sub
End Class