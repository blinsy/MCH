
Imports System.Data.Odbc

Public Class FirstVistiForm
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInfoSaveButton.Click
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .CommandText = "INSERT INTO `basic_ information`(`Clinic_No`, `Card_No`, `First_Visit_Date`, `Name`, `MaritalStatus`, `Age_First_Marriage`, `Husband_Or_Father`, `Husband_Or_Father_occupation`, `Client_Age`, `Client_Occupation`, `ELID`, `No_Of_Children_living`, `Ages_Of_Children`, `No_Of_Dead_Children`, `Previous_Contraceptive_Practice`, `CID`, `Previous_Client_No`, `MTID`, `Date_Last_Visit`, `Smoking`, `How_Many_Daily`, `Village_Or_Estate`, `Sub_Location_Or_House_No`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = ClinicNoTextBox.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = TxtCardNo.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DTPFVisit.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = NameTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = MaritalStatusComboBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = FirstMarriageTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = HusbandNameTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = HusbandOccupationTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = ClientAgeTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = ClientOccupationTextBox.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblELID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = LivingChildrenTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = AgesLivingTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = DiedTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBPrevPra.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblCID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = PreviousNoTextBox.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblMTID.Text
            .Parameters.Add("par", OdbcType.Date).Value = Format(LastVisitDateTimePicker.Value, "yyyy-MM-dd")
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = SmokingComboBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = HowManyDailyTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = VillageTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = HouseholdNoTextBox.Text
            
            .ExecuteNonQuery()

        End With

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClinicNoTextBox.Text = ""
        ClientAgeTextBox.Text = ""
        ClientNoTextBox.Text = ""
        ClientOccupationTextBox.Text = ""
        HusbandNameTextBox.Text = ""
        HusbandOccupationTextBox.Text = ""
        AgesLivingTextBox.Text = ""
        DiedTextBox.Text = ""
        HowManyDailyTextBox.Text = ""
        VillageTextBox.Text = ""
        PreviousMethodTextBox.Text = ""
        PreviousNoTextBox.Text = ""
        NameTextBox.Text = ""
        HouseholdNoTextBox.Text = ""
        FirstMarriageTextBox.Text = ""
        LivingChildrenTextBox.Text = ""
    End Sub

    Private Sub BasicInfoClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInfoClearButton.Click
        ClinicNoTextBox.Text = ""
        ClientAgeTextBox.Text = ""
        ClientNoTextBox.Text = ""
        ClientOccupationTextBox.Text = ""
        HusbandNameTextBox.Text = ""
        HusbandOccupationTextBox.Text = ""
        AgesLivingTextBox.Text = ""
        DiedTextBox.Text = ""
        HowManyDailyTextBox.Text = ""
        VillageTextBox.Text = ""
        PreviousMethodTextBox.Text = ""
        PreviousNoTextBox.Text = ""
        NameTextBox.Text = ""
        HouseholdNoTextBox.Text = ""
        FirstMarriageTextBox.Text = ""
        LivingChildrenTextBox.Text = ""
    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCardNo.TextChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        With FrmSelector
            .LblPointer.Text = 1
            .Text = "Education Level"
            .Show()

        End With
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        With FrmSelector
            .LblPointer.Text = 2
            .Text = "Clinic"
            .Show()

        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmClinics.Show()

    End Sub

    Private Sub FirstVistiForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()

    End Sub

    Private Sub BasicInfoGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInfoGroupBox.Enter

    End Sub
End Class
