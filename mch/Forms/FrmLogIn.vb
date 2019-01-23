Imports System.Data.Odbc
Imports System.Security.Cryptography
Public Class FrmLogIn

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub ClearLogInDetails()
        TxtPassword.Text = ""
        TxtUserName.Text = ""
    End Sub
    Public Function Check_Blanks(ByVal ParamArray BlankCtrl() As Object) As Boolean
        'check whether Text Box Has Any Data
        'loop
        For MyBlankChecker As Integer = 0 To UBound(BlankCtrl)
            'çondition
            If BlankCtrl(MyBlankChecker).Text = "" Then
                'using the error provider
                ErrorProvider1.SetError(BlankCtrl(MyBlankChecker), BlankCtrl(MyBlankChecker).tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim PassWord, UserName As String
        PassWord = TxtPassword.Text
        UserName = TxtUserName.Text
        Dim UAccPass As String = ""
        Dim UAccUName As String = ""
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        ' check whether the credentials text boxes are blank
        If Check_Blanks(TxtUserName) = False Then
            MyTrans.Rollback()
            MessageBox.Show("The User Name Field Is Blank", "BLANK USER NAME", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUserName.Select()
        ElseIf Check_Blanks(TxtPassword) = False Then
            MyTrans.Rollback()
            MessageBox.Show("The Pass Word Field Is Blank", "BLANK PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword.Select()
            Exit Sub
        Else
            Dim Dr_LogIn As OdbcDataReader

            'start logging in process'
            Dim get_LogInAccount As New OdbcCommand
            With get_LogInAccount
                '.Transaction = MyTrans
                .Connection = conn
                .Transaction = MyTrans

                .CommandText = "SELECT `User_Name`,`Password` FROM `log_in` WHERE `User_Name`= '" & TxtUserName.Text & "' AND `Password`=MD5 (?)"
                .Parameters.Add("@P2", OdbcType.VarChar, 45).Value = Trim(TxtPassword.Text)
                Dr_LogIn = .ExecuteReader

                'check case sensitivity
                While Dr_LogIn.Read()
                    UAccUName = Dr_LogIn.Item(0)
                    UAccPass = Dr_LogIn.Item(1)
                    'UAccPass = Dr_LogIn.Item(2)
                End While

                If UAccUName = TxtUserName.Text AndAlso UAccPass = TxtPassword.Text Then
                    'MessageBox.Show("Correct")

                    'start capturing account info
                    'if credentials are correct'
                    'MsgBox("data found")
                    'Get Account Status'
                    Dim Dr_Account_Status As OdbcDataReader
                    Dim get_LogStatus As New OdbcCommand
                    With get_LogStatus
                        .Transaction = MyTrans
                        .Connection = conn
                        .Transaction = MyTrans
                        .CommandText = "SELECT `User_Name`,Account_Status FROM `log_in` WHERE `User_Name` LIKE '" & TxtUserName.Text & "'"
                        Dr_Account_Status = .ExecuteReader
                        'get accounts status
                        If Dr_Account_Status.HasRows Then
                            'MessageBox.Show("Account Correct")
                            LblLIAccStatus.Text = Dr_Account_Status.Item(1)
                            MDIMain.LblLogInAccountStatus.Text = Dr_Account_Status.Item(1)
                            'if the account has inactive status 
                            If LblLIAccStatus.Text = "Inactive" Then
                                'this is a new a account
                                'get the account serial
                                'Dim Dr_New_Account As OdbcDataReader
                                'Dim get_Serial As New OdbcCommand
                                'With get_Serial

                                '    .Connection = conn
                                '    .Transaction = MyTrans
                                '    .CommandText = "SELECT LogInAccount,User_Name FROM `log_in` WHERE User_Name like '" & TxtUserName.Text & "'"
                                '    Dr_New_Account = .ExecuteReader

                                '    If Dr_New_Account.HasRows Then
                                '        ''MsgBox("data found")
                                '        'frm_User_Account_NewPassWord.LblNewAccSerial.Text = Dr_New_Account.Item(0)
                                '        'MessageBox.Show("Your Account Is Inactive. Please Consult System Adim For Account Activation", "New Account Activation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                '        'Me.Close()
                                '        'frm_User_Account_NewPassWord.Show()
                                '        'frm_System_Refresh_End.Show()
                                '    Else
                                '        'MsgBox("No Data Here")
                                '        ClearLogInDetails()
                                '        MessageBox.Show("Failed To Launch A Log In Session:ACC Serial Did Not Load!!!Please Contact The System Admin Before Retrying", "CRITICAL ERROR SYSTEM MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                '        Me.Close()
                                '        MyTrans.Rollback()
                                '        Me.Hide()
                                '        'FrmUserCredsCaseSensitive.Show()
                                '        Exit Sub
                                '    End If
                                'End With
                            ElseIf LblLIAccStatus.Text = "Blocked" Then
                                MessageBox.Show("Your Account Has Been Blocked", "Account Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Me.Hide()
                                'FrmPassWordBlocked.Show()
                                MyTrans.Rollback()
                                Exit Sub
                            ElseIf LblLIAccStatus.Text = "Locked" Then
                                MessageBox.Show("Your Account Has Been Locked", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Me.Hide()
                                'frm_LockAndUnLockAccount.Show()
                                MyTrans.Rollback()
                                Exit Sub
                            Else
                                Dim Dr_New_Account As OdbcDataReader
                                Dim get_Serial As New OdbcCommand
                                With get_Serial

                                    .Connection = conn
                                    .Transaction = MyTrans
                                    .CommandText = "SELECT LogInAccount,User_Name FROM `log_in` WHERE User_Name like '" & TxtUserName.Text & "'"
                                    Dr_New_Account = .ExecuteReader

                                    If Dr_New_Account.HasRows Then
                                        LblLIAccSerial.Text = Dr_New_Account.Item(0)

                                    End If
                                End With
                                Me.Hide()

                                'save the log in time
                                Dim cmd_save As New OdbcCommand
                                With cmd_save
                                    .Transaction = MyTrans
                                    .Connection = conn
                                    .CommandText = "UPDATE `log_in` SET `Login_Time`='" & Format(DTPLogInTimeCheck.Value, "yyyy-MM-dd HH:mm:ss") & "' WHERE LogInAccount='" & LblLIAccSerial.Text & "'"
                                    .ExecuteNonQuery()
                                    'MyTrans.Commit()
                                    ClearLogInDetails()
                                    'MessageBox.Show("Updated")
                                End With
                                ' end of saving log in time
                                    End If
                        Else
                            Exit Sub
                        End If
                    End With

                    'end of capturing account info
                    'Timer1.Enabled = False
                    'TimerLogIn.Enabled = False

                Else
                    'if the system was unable to return any serial from the DB based on the provided account details
                    'MsgBox("data NOT found")
                    ClearLogInDetails()
                    MessageBox.Show("Failed To Launch A Log In Session:ACC Serial Did Not Load!!!Please Contact The System Admin Before Retrying", "CRITICAL ERROR SYSTEM MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Me.Close()
                    MyTrans.Rollback()
                    Me.Hide()
                    'FrmUserCredsCaseSensitive.Show()
                End If
                'end of getting account serial
            End With
            Exit Sub
        End If

        'end of logging in process'
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
