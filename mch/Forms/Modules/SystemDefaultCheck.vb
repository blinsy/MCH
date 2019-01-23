Imports System.Data.Odbc

Module SystemDefaultCheck
    Public DefaultDataResults As Boolean = False
    Public SystemCodeListResults As Boolean = False
    Dim ContactTypeResults As Boolean = False
    Public DefaultBackUpDataResults As Boolean = False
    Dim BackUpContactTypeResults As Boolean = False
    Public Function DefaultDataCheck(ByVal trans As OdbcTransaction)
        'Try
        Dim Dr_DDD As OdbcDataReader
        'Dim Check_Default_Supplier As New OdbcCommand
        'With Check_Default_Supplier
        '    .Connection = conn
        '    .Transaction = trans
        '    .CommandText = "SELECT `Company_ID` FROM `supplier_company_info` WHERE `Company_ID`=1 AND `Company_Name`='N/A'"
        '    Dr_DDD = .ExecuteReader
        'End With
        'If Dr_DDD.HasRows = False Then
        '    Dim Delete_unnecesary_Record As New OdbcCommand
        '    With Delete_unnecesary_Record
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "DELETE FROM `supplier_company_info` WHERE `Company_ID`=1 OR `Company_Name`='N/A'"
        '        .ExecuteNonQuery()
        '    End With
        '    Dim Insert_Default_Compay_Details As New OdbcCommand
        '    With Insert_Default_Compay_Details
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "INSERT INTO `supplier_company_info`(`Company_Name`,`Company_Registration_Number`,`Company_PIN`)VALUES(?,?,?)"
        '        .Parameters.Add("p1", OdbcType.VarChar, 45).Value = "N/A"
        '        .Parameters.Add("p1", OdbcType.BigInt, 45).Value = 0
        '        .Parameters.Add("p1", OdbcType.BigInt, 45).Value = 0
        '        .ExecuteNonQuery()
        '    End With
        'End If

        Dim Establish_Users As New OdbcCommand
        With Establish_Users
            .Connection = conn
            .Transaction = trans
            .CommandText = "SELECT  `Staff_Name` FROM `staff_details`  WHERE SDID='1' AND `PersonalFileNo`= '12345'"
            Dr_DDD = .ExecuteReader
            'MsgBox("OK")
        End With
        If Dr_DDD.HasRows Then
            Dim Delete_Staff_1 As New OdbcCommand
            With Delete_Staff_1
                .Connection = conn
                .Transaction = trans

                .CommandText = "DELETE FROM `staff_details` WHERE `SDID`=1"
                .ExecuteNonQuery()
            End With
            Dim Insert_Into_Staff As New OdbcCommand
            With Insert_Into_Staff
                .Connection = conn
                .Transaction = trans
                .CommandText = "INSERT INTO `staff_details`(`SDID`, `PersonalFileNo`, `Staff_Name`, `Gender`, `RegistrationDate`, `IdNumber`) VALUES(1,'12345','Admin','Others','2017-07-02 09:01:08','112233')"
                .ExecuteNonQuery()
            End With
        End If

        'Dim Users As New OdbcCommand
        'With Users
        '    .Connection = conn
        '    .Transaction = trans
        '    .CommandText = "SELECT `First_Name`,`Middle_Name`,`Last_Name` FROM staff_details WHERE Staff_ID='2' AND `Personal_File_Number`= '123456'"
        '    Dr_DDD = .ExecuteReader
        'End With
        'If Dr_DDD.HasRows = False Then
        '    Dim Delete_Staff_1 As New OdbcCommand
        '    With Delete_Staff_1
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "DELETE FROM `staff_details` WHERE `Staff_ID`=2"
        '        .ExecuteNonQuery()
        '    End With
        '    Dim Insert_Into_Staff As New OdbcCommand
        '    With Insert_Into_Staff
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "INSERT INTO `staff_details`(`Staff_ID`, `First_Name`, `Middle_Name`, `Last_Name`, `Gender`, `Id_Number`, `Personal_File_Number`, `DateAndTime`) VALUES(2,'System','System','System','Others','123456','123456','2017-07-02 09:01:08')"
        '        .ExecuteNonQuery()
        '    End With
        'End If


        Dim AccountName As New OdbcCommand
        With AccountName
            .Connection = conn
            .Transaction = trans
            .CommandText = "SELECT log_in.`LogInAccount`, log_in.`SDID`, log_in.`User_Name`,  log_in.`Password`, log_in.`Secret_Word`,  log_in.`Login_Time`, log_in.`LogOut_Time`,  log_in.`Account_Status` FROM `log_in`,staff_details WHERE log_in.SDID =staff_details.SDID AND log_in.LogInAccount='1001'"
            Dr_DDD = .ExecuteReader
        End With
        If Dr_DDD.HasRows Then
            Dim Delete_Staff_1 As New OdbcCommand
            With Delete_Staff_1
                .Connection = conn
                .Transaction = trans
                .CommandText = "DELETE FROM `log_in` WHERE `LogInAccount`=1001"
                .ExecuteNonQuery()
            End With
            Dim Insert_Into_Staff As New OdbcCommand
            With Insert_Into_Staff
                .Connection = conn
                .Transaction = trans
                .CommandText = "INSERT INTO `log_in`(`LogInAccount`, `SDID`, `User_Name`, `Password`, `Secret_Word`, `Login_Time`, `LogOut_Time`, `Account_Status`) VALUES('1001','1','Admin','81dc9bdb52d04dc20036dbd8313ed055','Admin','2017-07-02 09:01:08','2017-07-02 09:01:08','Active')"
                .ExecuteNonQuery()
            End With

        End If



        'Dim AccountName2 As New OdbcCommand
        'With AccountName2
        '    .Connection = conn
        '    .Transaction = trans
        '    .CommandText = "SELECT login.`LIAC_Serial`, login.`UserName`, login.`PassWord`,login.`SecretWord`,login.`AccountStatus`, login.`LogInTime`, login.`LogOutTime`, staff_details.`Staff_ID`, login.`AccountName`FROM `login`,`staff_details` WHERE login.Staff_ID =staff_details.Staff_ID AND login.LIAC_Serial='7701'"
        '    Dr_DDD = .ExecuteReader
        'End With
        'If Dr_DDD.HasRows = False Then
        '    Dim Delete_Staff_2 As New OdbcCommand
        '    With Delete_Staff_2
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "DELETE FROM `login` WHERE `LIAC_Serial`=7701"
        '        .ExecuteNonQuery()
        '    End With
        '    Dim Insert_Into_Staff2 As New OdbcCommand
        '    With Insert_Into_Staff2
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "INSERT INTO `login`(`LIAC_Serial`, `UserName`, `PassWord`, `SecretWord`, `AccountStatus`, `LogInTime`, `LogOutTime`, `Staff_ID`, `AccountName`) VALUES('7701','System','ae5e3ce40e0404a45ecacaaf05e5f735','System','Active','2017-07-02 09:01:08','2017-07-02 09:01:08','2','NariphonMCH')"
        '        .ExecuteNonQuery()
        '    End With

        'End If


        'Dim DrLogInAtt As OdbcDataReader
        'Dim CheckLogInAtt As New OdbcCommand
        'With CheckLogInAtt
        '    .Connection = conn
        '    .Transaction = trans
        '    .CommandText = "SELECT login_attempts.`LIA_ID`, login_attempts.`LIAC_Serial`, `PassWord_Attempts` FROM `login_attempts`,login WHERE login_attempts.LIAC_Serial =login.LIAC_Serial AND login_attempts.`LIA_ID`=1 "
        '    DrLogInAtt = .ExecuteReader
        'End With
        'If DrLogInAtt.HasRows = False Then
        '    Dim Delete_unnecesary_Record As New OdbcCommand
        '    With Delete_unnecesary_Record
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "DELETE FROM `login_attempts` WHERE `LIA_ID`=1"
        '        .ExecuteNonQuery()
        '    End With
        '    Dim Insert_Default_Compay_Details As New OdbcCommand
        '    With Insert_Default_Compay_Details
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "INSERT INTO `login_attempts`(`LIA_ID`, `LIAC_Serial`, `PassWord_Attempts`)VALUES(1,'7700',0)"
        '        '.Parameters.Add("p1", OdbcType.BigInt, 45).Value = 1
        '        '.Parameters.Add("p1", OdbcType.BigInt, 45).Value = 7700
        '        '.Parameters.Add("p1", OdbcType.BigInt, 45).Value = 0
        '        .ExecuteNonQuery()
        '    End With
        'End If

        'Dim DrLogInAtt As OdbcDataReader
        'Dim CheckLogInAtt2 As New OdbcCommand
        'With CheckLogInAtt2
        '    .Connection = conn
        '    .Transaction = trans
        '    .CommandText = "SELECT login_attempts.`LIA_ID`, login_attempts.`LIAC_Serial`, `PassWord_Attempts` FROM `login_attempts`,login WHERE login_attempts.LIAC_Serial =login.LIAC_Serial AND login_attempts.`LIA_ID`=2 "
        '    DrLogInAtt = .ExecuteReader
        'End With
        'If DrLogInAtt.HasRows = False Then
        '    Dim Delete_unnecesary_Record As New OdbcCommand
        '    With Delete_unnecesary_Record
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "DELETE FROM `login_attempts` WHERE `LIA_ID`=2"
        '        .ExecuteNonQuery()
        '    End With
        '    Dim Insert_Default_Compay_Details As New OdbcCommand
        '    With Insert_Default_Compay_Details
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "INSERT INTO `login_attempts`(`LIA_ID`, `LIAC_Serial`, `PassWord_Attempts`)VALUES(2,'7701',0)"
        '        '.Parameters.Add("p1", OdbcType.BigInt, 45).Value = 1
        '        '.Parameters.Add("p1", OdbcType.BigInt, 45).Value = 7700
        '        '.Parameters.Add("p1", OdbcType.BigInt, 45).Value = 0
        '        .ExecuteNonQuery()
        '    End With
        'End If

        'Dim ClientOne As New OdbcCommand
        'With ClientOne
        '    .Connection = conn
        '    .Transaction = trans
        '    .CommandText = "SELECT `CFVNo`, `CardNo`, `Date`, `ClinicNo`, `FirstName`, `MiddleName`, `LastName`, `VillageEstate`, `SubLocHseHoldNo`, `MaritalStatus`, `AgeAtFirstMarriage`, `HusbandName`, `HusbandOccupation`, `Age`, `ClientOccupation`, `EL_ID`, `NumberOfLivingChildren`, `AgesOfLivingChildren`, `DiedChildren`, `PreviousContPrac`, `PrevContClinic`, `PrevClentNo`, `PrevContMethod`, `PrevLastDate`, `Smoking`, `SmokingNumber`, `InfoGroup` FROM `client_first_visit` WHERE `CFVNo`='1'"
        '    Dr_DDD = .ExecuteReader
        'End With
        'If Dr_DDD.HasRows = False Then
        '    Dim Delete_Staff_1 As New OdbcCommand
        '    With Delete_Staff_1
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "DELETE FROM `client_first_visit` WHERE `CFVNo`=1"
        '        .ExecuteNonQuery()
        '    End With
        '    Dim Insert_Into_Staff As New OdbcCommand
        '    With Insert_Into_Staff
        '        .Connection = conn
        '        .Transaction = trans
        '        .CommandText = "INSERT INTO `client_first_visit`(`CFVNo`, `CardNo`, `Date`, `ClinicNo`, `FirstName`, `MiddleName`, `LastName`, `VillageEstate`, `SubLocHseHoldNo`, `MaritalStatus`, `AgeAtFirstMarriage`, `HusbandName`, `HusbandOccupation`, `Age`, `ClientOccupation`, `EL_ID`, `NumberOfLivingChildren`, `AgesOfLivingChildren`, `DiedChildren`, `PreviousContPrac`, `PrevContClinic`, `PrevClentNo`, `PrevContMethod`, `PrevLastDate`, `Smoking`, `SmokingNumber`, `InfoGroup`) VALUES('1','1000','1999-12-31 00:00:00','14207','N/A','N/A','N/A','N/A','N/A','N/A','N/A','N/A','N/A','N/A','N/A','1','N/A','N/A','N/A','N/A','1','N/A','1','1999-12-31','N/A','0','BASIC INFORMATION')"
        '        .ExecuteNonQuery()
        '    End With

        'End If

        trans.Commit()

        DefaultDataResults = True
        'Catch ex As Exception
        '    Define_Default_Data_Results = False
        'End Try
        Return DefaultDataResults
    End Function
End Module
