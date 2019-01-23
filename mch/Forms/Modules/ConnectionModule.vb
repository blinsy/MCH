Imports System.Data.Odbc

Module ConnectionModule
    Dim da As OdbcDataAdapter
    Public InsertionForm As String
    Public conn As OdbcConnection
    Public connectionString As String
    Public SuccessfulConection As Boolean

    Public Sub SystemConnect()
        Try
            connectionString = "DSN=mch;UID=root;"
            conn = New OdbcConnection(connectionString)
            conn.Open()
            SuccessfulConection = True
        Catch ex As Exception
            SuccessfulConection = False
            MessageBox.Show("Connection To The Database Failed.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
