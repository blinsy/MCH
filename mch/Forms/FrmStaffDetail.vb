Imports System.Data.Odbc
Imports System.Text.RegularExpressions

Public Class FrmStaffDetail
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter

    Private Sub FrmStaffDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        DTPRegStaff.Value = Now
    End Sub
    Private Sub clearFieldStaffBasicInfo()
        CmbGender.Text = ""
        TxtIDNo.Text = ""
        TxtPFNo.Text = ""
        TxtStaffName.Text = ""
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        clearFieldStaffBasicInfo()
    End Sub
    'CLEAR METHOD FOR CONTACT
    Private Sub clearfieldPhoneContact()
        TxtPhoneNumber.Text = ""
        LblCTID.Text = 0
        TxtContactType.Text = ""
    End Sub
    'CLEAR METHOD FOR POSTAL ADRESS
    Private Sub clearfieldPostalAddress()
        TxtPostalAdress.Text = ""
        LblCTID.Text = 0
        TxtAdressType.Text = "P.O BOX:"
        'LOAD DGVStaffDetails INFORMATIOM
    End Sub
    'CLEAR METHOD FOR email ADRESS
    Private Sub clearfieldEmailAddress()
        TxtPostalAdress.Text = ""
        LBLCTID.Text = 0
        TxtAdressType.Text = ""
    End Sub
    'LOAD DGVStaffDetails INFORMATIOM
    Private Sub LoadStaffBasicInfo()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT SDID, PersonalFileNo, Staff_Name, Gender, RegistrationDate, IdNumber FROM staff_details", conn)
        DA.Fill(DT)
        DGVStaffBasicInfo.DataSource = DT
        DGVStaffBasicInfo.Columns(0).Visible = False
    End Sub
    Private Sub loadStaffPhone()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        staff_phone_contact.Phone, contact_type.Type FROM            contact_type, staff_phone_contact, staff_details WHERE        contact_type.CTID = staff_phone_contact.CTID AND staff_phone_contact.SDID = staff_details.SDID AND staff_details.SDID='" & LBLSDID.Text & "'", conn)

        DA.Fill(DT)
        DGVPhoneContact.DataSource = DT
        DGVPhoneContact.Columns(0).Visible = True
        DGVPhoneContact.Columns(1).Visible = True
    End Sub
    Private Sub LoadPostalAdress()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT staff_postal_address.box, contact_type.Type FROM            staff_postal_address, staff_details, contact_type WHERE        staff_postal_address.SDID = staff_details.SDID AND staff_postal_address.CTID = contact_type.CTID AND staff_details.SDID='" & LBLSDID.Text & "'", conn)

        DA.Fill(DT)
        DGVPostalAdress.DataSource = DT
        DGVPostalAdress.Columns(0).Visible = True
        DGVPostalAdress.Columns(1).Visible = True
    End Sub
    Private Sub LoadEMailADDRESS()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        staff_email_address.Email_address, contact_type.Type FROM contact_type, staff_email_address, staff_details WHERE contact_type.CTID = staff_email_address.CTID AND staff_email_address.SDID = staff_details.SDID AND staff_details.SDID='" & LBLSDID.Text & "'", conn)

        DA.Fill(DT)
        DGVEmailAdress.DataSource = DT
        DGVEmailAdress.Columns(0).Visible = True
        DGVEmailAdress.Columns(1).Visible = True
    End Sub
    'DGV CLICK STAFF DETAILS
    Private Sub DGVStaffBasicInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVStaffBasicInfo.Click
        Dim DrClinics As OdbcDataReader
        With DGVStaffBasicInfo
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                LBLSDID.Text = .Item(0, currentRow).Value
                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT `SDID`, `PersonalFileNo`, `Staff_Name`, `Gender`, `RegistrationDate`, `IdNumber` FROM `staff_details` WHERE SDID=?  "
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLSDID.Text
                    DrClinics = .ExecuteReader
                End With
                If DrClinics.HasRows Then
                    LBLSDID.Text = DrClinics.Item(0)
                    TxtPFNo.Text = DrClinics.Item(1)
                    TxtStaffName.Text = DrClinics.Item(2)
                    TxtStaffNameDisp.Text = DrClinics.Item(2)
                    CmbGender.Text = DrClinics.Item(3)
                    DTPRegStaff.Value = DrClinics.Item(4)
                    TxtIDNo.Text = DrClinics.Item(5)
                End If

            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub
    'SAVE BUTTON FOR STAFF BASIC INFORMATION
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)


        If TxtStaffName.Text = "" Then
            MessageBox.Show("Please Write Valid Staff Name", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If

        If TxtIDNo.Text = "" Then
            MessageBox.Show("Please Write Valid ID NO.", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtPFNo.Text = "" Then
            MessageBox.Show("Please Write Valid Personal File", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        If CmbGender.SelectedIndex = 0 Then
            MessageBox.Show("Select a valid Gender", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `staff_details`(`PersonalFileNo`, `Staff_Name`, `Gender`, `RegistrationDate`, `IdNumber`) VALUES (?,?,?,?,?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPFNo.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtStaffName.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbGender.Text
            .Parameters.Add("par", OdbcType.Date).Value = Format(DTPRegStaff.Value, "yyyy-MM-dd")
            .Parameters.Add("par", OdbcType.BigInt, 15).Value = TxtIDNo.Text
            .ExecuteNonQuery()
        End With
        MyTrans.Commit()
        LoadStaffBasicInfo()
        clearFieldStaffBasicInfo()
    End Sub
    'UPDATE BUTTON FOR STAFF BASIC INFORMATION
    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtStaffName.Text = "" Then
            MessageBox.Show("Please Write Valid Staff Name", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If

        If TxtIDNo.Text = "" Then
            MessageBox.Show("Please Write Valid ID NO.", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If

        If TxtPFNo.Text = "" Then
            MessageBox.Show("Please Write Valid Personal File", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        If CmbGender.SelectedIndex = 0 Then
            MessageBox.Show("Select a valid Gender", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "UPDATE `staff_details` SET `PersonalFileNo`=?,`Staff_Name`=?,`Gender`=?,`RegistrationDate`=?,`IdNumber`=? WHERE `SDID`=?"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPFNo.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtStaffName.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbGender.Text
            .Parameters.Add("par", OdbcType.Date).Value = Format(DTPRegStaff.Value, "yyyy-MM-dd")
            .Parameters.Add("par", OdbcType.BigInt, 15).Value = TxtIDNo.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSDID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadStaffBasicInfo()
        clearFieldStaffBasicInfo()
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        With FrmSelector
            .Text = "Contact Type"
            .LblPointer.Text = 6
            .Show()
        End With
    End Sub
    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        With FrmSelector
            .Text = "Address Type"
            .LblPointer.Text = 7
            .Show()
        End With
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        With FrmSelector
            .Text = "Email Type"
            .LblPointer.Text = 8
            .Show()
        End With
    End Sub
    Private Sub TxtSearchStaffName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSearchStaffName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 13) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 3) Then
            Try
                DT = New DataTable
                DA = New OdbcDataAdapter("SELECT        SDID, PersonalFileNo, Staff_Name, Gender, RegistrationDate, IdNumber FROM staff_details  LIKE " + " '" + "%" + TxtSearchStaffName.Text + "%" + "'  ORDER BY `staff_details`.Name ASC  ", conn)
                DA.Fill(DT)
                DGVStaffBasicInfo.DataSource = DT
                DGVStaffBasicInfo.Columns(0).Visible = False
            Catch ex As OdbcException
                MessageBox.Show(ex.Message, "LOAD GRID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'open directory for the basic information
    Private Sub ToolStripLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel6.Click
        LoadStaffBasicInfo()
    End Sub
    'search by staff by name
    Private Sub TxtSearchStaffName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchStaffName.TextChanged
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        SDID, PersonalFileNo, Staff_Name, Gender, RegistrationDate, IdNumber FROM staff_details WHERE Staff_Name  LIKE " + " '" + "%" + TxtSearchStaffName.Text + "%" + "'  ORDER BY `Staff_Name` ASC  ", conn)
        DT = New DataTable
        DA.Fill(DT)
        DGVStaffBasicInfo.DataSource = DT
        DGVStaffBasicInfo.Columns(0).Visible = False
    End Sub
    'search by staff by persinal file no.
    Private Sub TxtSearchPFNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSearchPFNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 13) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 3) Then
            Try
                DT = New DataTable
                DA = New OdbcDataAdapter("SELECT        SDID, PersonalFileNo, Staff_Name, Gender, RegistrationDate, IdNumber FROM staff_details  LIKE " + " '" + "%" + TxtSearchPFNo.Text + "%" + "'  ORDER BY `staff_details`.Name ASC  ", conn)
                DA.Fill(DT)
                DGVStaffBasicInfo.DataSource = DT
                DGVStaffBasicInfo.Columns(0).Visible = False
            Catch ex As OdbcException
                MessageBox.Show(ex.Message, "LOAD GRID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TxtSearchPFNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchPFNo.TextChanged
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        SDID, PersonalFileNo, Staff_Name, Gender, RegistrationDate, IdNumber FROM staff_details WHERE Staff_Name  LIKE " + " '" + "%" + TxtSearchPFNo.Text + "%" + "'  ORDER BY `Staff_Name` ASC  ", conn)
        DT = New DataTable
        DA.Fill(DT)
        DGVStaffBasicInfo.DataSource = DT
        DGVStaffBasicInfo.Columns(0).Visible = False
    End Sub
    'SEARCH BY ID NUMBER
    Private Sub TxtSearchID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSearchID.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 13) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 3) Then
            Try
                DT = New DataTable
                DA = New OdbcDataAdapter("SELECT        SDID, PersonalFileNo, Staff_Name, Gender, RegistrationDate, IdNumber FROM staff_details  LIKE " + " '" + "%" + TxtSearchID.Text + "%" + "'  ORDER BY `staff_details`.Name ASC  ", conn)
                DA.Fill(DT)
                DGVStaffBasicInfo.DataSource = DT
                DGVStaffBasicInfo.Columns(0).Visible = False
            Catch ex As OdbcException
                MessageBox.Show(ex.Message, "LOAD GRID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'SEARCH BY ID NUMBER
    Private Sub TxtSearchID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchID.TextChanged
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        SDID, PersonalFileNo, Staff_Name, Gender, RegistrationDate, IdNumber FROM staff_details WHERE Staff_Name  LIKE " + " '" + "%" + TxtSearchID.Text + "%" + "'  ORDER BY `Staff_Name` ASC  ", conn)
        DT = New DataTable
        DA.Fill(DT)
        DGVStaffBasicInfo.DataSource = DT
        DGVStaffBasicInfo.Columns(0).Visible = False
    End Sub
    'Function FOR VALIDATING PHONE
    Public Function ValidatePhone(ByVal strPhoneNum As String) As Boolean
        Dim PhoneValid As Boolean
        ''Create Reg Exp Pattern - Kenyan Phone Number Format
        Dim strPhonePattern As String = "^[0-9]{10}$"

        'Create Reg Ex Object - reading the phone
        Dim rePhone As New Regex(strPhonePattern)

        'Something Typed In
        If Not String.IsNullOrEmpty(strPhoneNum) Then

            PhoneValid = rePhone.IsMatch(strPhoneNum) 'Check Validity

        Else

            PhoneValid = False 'Not Valid / Empty

        End If

        Return PhoneValid 'Return True / False

    End Function

    'save phone contact staff
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim myTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtContactType.Text = "" Then
            MessageBox.Show("Provide a valid Contact Type", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        If ValidatePhone(TxtPhoneNumber.Text) Then
            Dim save As New OdbcCommand
            With save
                .Connection = conn
                .Transaction = myTrans
                .CommandText = " INSERT INTO `staff_phone_contact`( `SDID`, `Phone`, `CTID`) VALUES (?,?,?)"

                .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLSDID.Text
                .Parameters.Add("par1", OdbcType.BigInt, 45).Value = TxtPhoneNumber.Text
                .Parameters.Add("par1", OdbcType.VarChar, 10).Value = LBLCTID.Text
                .ExecuteNonQuery()
                myTrans.Commit()
                loadStaffPhone()
                clearfieldPhoneContact()

            End With
        Else
            ''if the Phone is not valid
            'Call Phone Validation Function
            MessageBox.Show("The Phone Number You Provided Is Not Valid.Please Ensure The Number Is In The Valid Format.Example:0737702144", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
    End Sub
    'UPDATE STAFF CONTACT INFORMATION
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim myTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtContactType.Text = "" Then
            MessageBox.Show("Provide a valid Contact Type", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        If ValidatePhone(TxtPhoneNumber.Text) Then
            Dim save As New OdbcCommand
            With save
                .Connection = conn
                .Transaction = myTrans
                .CommandText = "UPDATE `staff_phone_contact` SET `SDID`=?,`Phone`=?,`CTID`=? WHERE `SCDID`=?"

                .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLSDID.Text
                .Parameters.Add("par1", OdbcType.BigInt, 45).Value = TxtPhoneNumber.Text
                .Parameters.Add("par1", OdbcType.VarChar, 10).Value = LBLCTID.Text
                .ExecuteNonQuery()
                myTrans.Commit()
                loadStaffPhone()
                clearfieldPhoneContact()

            End With
        Else
            ''if the Phone is not valid
            'Call Phone Validation Function
            MessageBox.Show("The Phone Number You Provided Is Not Valid.Please Ensure The Number Is In The Valid Format.Example:0737702144", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
    End Sub
    'SAVE BUTTON POSTAL ADDRESS
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim myTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtPostalAdress.Text = "" Or TxtPostalAdress.Text = "P.O BOX:" Then
            MessageBox.Show("Provide a valid postal Address", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        If TxtAdressType.Text = "" Then
            MessageBox.Show("Provide a valid Address Type", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        'If ValidatePhone(TxtPhoneNumber.Text) Then
        Dim save As New OdbcCommand
        With save
            .Connection = conn
            .Transaction = myTrans
            .CommandText = "INSERT INTO `staff_postal_address`(`SDID`, `box`, `CTID`) VALUES (?,?,?)"
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLSDID.Text
            .Parameters.Add("par1", OdbcType.VarChar, 45).Value = TxtPostalAdress.Text
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLCTID.Text

            .ExecuteNonQuery()
            myTrans.Commit()
            LoadPostalAdress()
            clearfieldPostalAddress()

        End With
        'Else
        ' ''if the Phone is not valid
        ''Call Phone Validation Function
        'MessageBox.Show("The Phone Number You Provided Is Not Valid.Please Ensure The Number Is In The Valid Format.Example:0737702144", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'myTrans.Rollback()
        Exit Sub
        'End If
    End Sub
    'SAVE BUTTON EMAIL ADDRESS
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtEmailAdress.Text = "" Then
            MessageBox.Show("Provide a valid Email Address", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        If TxtEmailAdressType.Text = "" Then
            MessageBox.Show("Provide a valid Address Type", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        'If ValidatePhone(TxtPhoneNumber.Text) Then
        Dim save As New OdbcCommand
        With save
            .Connection = conn
            .Transaction = myTrans
            .CommandText = "INSERT INTO `staff_email_address`( `SDID`, `Email_address`, `CTID`) VALUES (?,?,?)"
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLSDID.Text
            .Parameters.Add("par1", OdbcType.VarChar, 45).Value = TxtPostalAdress.Text
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLCTID.Text

            .ExecuteNonQuery()
            myTrans.Commit()
            LoadEMailADDRESS()
            clearfieldEmailAddress()

        End With
        'Else
        ' ''if the Phone is not valid
        ''Call Phone Validation Function
        'MessageBox.Show("The Phone Number You Provided Is Not Valid.Please Ensure The Number Is In The Valid Format.Example:0737702144", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'myTrans.Rollback()
        Exit Sub
        'End If
    End Sub
    'update staff postal address
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim myTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtPostalAdress.Text = "" Or TxtPostalAdress.Text = "P.O BOX:" Then
            MessageBox.Show("Provide a valid postal Address", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        If TxtAdressType.Text = "" Then
            MessageBox.Show("Provide a valid Address Type", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        'If ValidatePhone(TxtPhoneNumber.Text) Then
        Dim save As New OdbcCommand
        With save
            .Connection = conn
            .Transaction = myTrans
            .CommandText = "UPDATE `staff_postal_address` SET `SDID`=?,`box`=?,`CTID`=? WHERE `SPAID`=?"
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLSDID.Text
            .Parameters.Add("par1", OdbcType.VarChar, 45).Value = TxtPostalAdress.Text
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLCTID.Text

            .ExecuteNonQuery()
            myTrans.Commit()
            LoadPostalAdress()
            clearfieldPostalAddress()

        End With
        'Else
        ' ''if the Phone is not valid
        ''Call Phone Validation Function
        'MessageBox.Show("The Phone Number You Provided Is Not Valid.Please Ensure The Number Is In The Valid Format.Example:0737702144", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'myTrans.Rollback()
        Exit Sub
        'End If
    End Sub

    'delete staff postal address
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `staff_postal_address` WHERE SPAID= ?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLCTID.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadPostalAdress()
        clearfieldPostalAddress()
    End Sub
    'Delete button staff email address
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `staff_email_address` WHERE SEAID= ?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLCTID.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadPostalAdress()
        clearfieldPostalAddress()
    End Sub
    'Delete staff phone
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `staff_phone_contact` WHERE `SCDID`= ?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLCTID.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadStaffPhone()
        clearfieldPhoneContact()
    End Sub
    'DELETE STAFF BASIC INFORMATION
    Private Sub ToolStripLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel4.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `staff_details` WHERE  SDID =?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSDID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadStaffBasicInfo()
        clearFieldStaffBasicInfo()
    End Sub
    'Update Staff Email Address 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtEmailAdress.Text = "" Then
            MessageBox.Show("Provide a valid Email Address", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        If TxtEmailAdressType.Text = "" Then
            MessageBox.Show("Provide a valid Address Type", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
        'If ValidatePhone(TxtPhoneNumber.Text) Then
        Dim save As New OdbcCommand
        With save
            .Connection = conn
            .Transaction = myTrans
            .CommandText = "UPDATE `staff_email_address` SET `SDID`=?,`Email_address`=?,`CTID`=? WHERE `SEAID`=?"
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLSDID.Text
            .Parameters.Add("par1", OdbcType.VarChar, 45).Value = TxtPostalAdress.Text
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LBLCTID.Text

            .ExecuteNonQuery()
            myTrans.Commit()
            LoadEMailADDRESS()
            clearfieldEmailAddress()

        End With
        'Else
        ' ''if the Phone is not valid
        ''Call Phone Validation Function
        'MessageBox.Show("The Phone Number You Provided Is Not Valid.Please Ensure The Number Is In The Valid Format.Example:0737702144", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'myTrans.Rollback()
        Exit Sub
        'End If
    End Sub
End Class