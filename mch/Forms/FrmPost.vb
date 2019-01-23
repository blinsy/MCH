Imports System.Data.Odbc

Public Class FrmPost

    Private Sub FrmPost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        UseWaitCursor = True
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        DefaultDataCheck(MyTrans)
        MyTrans.Dispose()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PBPOST.Increment(1)
        If PBPOST.Value = PBPOST.Maximum Then
            Timer1.Stop()
            Me.Hide()
            FrmLogIn.Show()
        End If
    End Sub
End Class