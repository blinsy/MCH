Imports System.Data.Odbc
Imports System.Text.RegularExpressions

Public Class FirstVistiForm
    Dim DT As DataTable
    Dim DA As OdbcDataAdapter
    Private Sub FirstVistiForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SystemConnect()
        ClinicNoTextBox.Text = "1234"
        LastVisitDateTimePicker.Value = Now
        DTPFVisit.Value = Now
        DTPLMP.Value = Now
        DTPDelivery.Value = Now
        DTPReturnDate.Value = Now
        DtpRevisitDate.Value = Now
        DtpDateLMPRevisit.Value = Now
        DtpReturnDateRevisit.Value = Now

        CMBPrevPra.SelectedIndex = 0
        CMBMaritalStatus.SelectedIndex = 0
        CmbSmoking.SelectedIndex = 0
        CMBFlow.SelectedIndex = 0
        CMBBreastFeeding.SelectedIndex = 0
        CMBSevereVaricosis.SelectedIndex = 0
        CMBJaundice.SelectedIndex = 0
        CMBRenalDisease.SelectedIndex = 0
        CMBHypertention.SelectedIndex = 0
        CMBSTD.SelectedIndex = 0
        CMBDiabetes.SelectedIndex = 0
        CMBEpilepsy.SelectedIndex = 0
        CMBTB.SelectedIndex = 0
        CMBPID.SelectedIndex = 0
        CMBGoitre.SelectedIndex = 0
        CMBTakingMed.SelectedIndex = 0
        CmbHIVTest.SelectedIndex = 0
        CmbBreast.SelectedIndex = 0
        CmbUterus.SelectedIndex = 0
        CmbAdnexa.SelectedIndex = 0
        CmbCervix.SelectedIndex = 0
        CmbGenetalia.SelectedIndex = 0
        CmbVaginal.SelectedIndex = 0
        CmbDischarge.SelectedIndex = 0
        CmbPapSmear.SelectedIndex = 0
        CmbPSA.SelectedIndex = 0
        CmbPregnacyTest.SelectedIndex = 0
        cmbCondomType.SelectedIndex = 0
        CmbCondomRevisit.SelectedIndex = 0

        ClientOccupationTextBox.Text = "N/A"
        HusbandOccupationTextBox.Text = "N/A"
        AgesLivingTextBox.Text = "N/A"
        DiedTextBox.Text = "N/A"
        HowManyDailyTextBox.Text = "N/A"
        TxtPrevMethod.Text = "N/A"
        PreviousNoTextBox.Text = "N/A"
        HouseholdNoTextBox.Text = "N/A"
        FirstMarriageTextBox.Text = "N/A"
        LivingChildrenTextBox.Text = "N/A"
        TxtEduLevel.Text = "N/A"
        TxtClinic.Text = "N/A"
        TxtspecifyType.Text = "N/A"
        TxtSpecifyBreast.Text = "N/A"
        TxtSpecifyUterus.Text = "N/A"
        TxtSpecifyAdnexa.Text = "N/A"
        TxtSpecifyCervix.Text = "N/A"
        TxtSpecifyGenetalia.Text = "N/A"
        TxtSpecifyVaginal.Text = "N/A"
        TxtSpecifyDischarge.Text = "N/A"
        TxtSpecifyPapSmear.Text = "N/A"
        TxtSpecifyPSA.Text = "N/A"
        TxtPillCycles.Text = "N/A"
        TxtIucdSize.Text = "N/A"
        TxtInjectionNumberofmonths.Text = "N/A"
        TxtSpermicideAmountIssued.Text = "N/A"
        TxtClinicNo.Text = "N/A"
        RichTextBox1.Text = "N/A"
        TxtSpecifyReasonChange.Text = "N/A"

        LblCID.Text = 1
        LblELID.Text = 1
        LblMTID.Text = 1
        LBLPTID.Text = 1
        LBLIUCDTID.Text = 1
        LBLIID.Text = 1
        LBLSTID.Text = 1
        LblITID.Text = 1

        'Get Next Client Number
        Dim DrClientNum As OdbcDataReader
        Dim PrevClientNumber As Integer
        Dim GetPrevClientNumber As New OdbcCommand
        With GetPrevClientNumber
            .Connection = conn
            ' .Transaction = mytrans
            .CommandText = "SELECT MAX(`BID`) FROM  `basic_ information`"
            DrClientNum = .ExecuteReader
        End With
        If DrClientNum.HasRows Then
            If DrClientNum(0).Equals(DBNull.Value) Then
                PrevClientNumber = 0
            Else
                PrevClientNumber = Convert.ToInt64(DrClientNum(0))
            End If
        Else
            PrevClientNumber = 0
        End If
        PrevClientNumber = PrevClientNumber + 1
        ClientNoTextBox.Text = PrevClientNumber

        'End Of Getting Next Client Number

    End Sub
    'CLEAR METTHOD FOR BASIC INFORMATION
    Private Sub ClearFields()
        ClinicNoTextBox.Text = ""
        ClientAgeTextBox.Text = ""
        HusbandNameTextBox.Text = ""
        VillageTextBox.Text = ""
        NameTextBox.Text = ""
        ClientOccupationTextBox.Text = "N/A"
        HusbandOccupationTextBox.Text = "N/A"
        AgesLivingTextBox.Text = "N/A"
        DiedTextBox.Text = "N/A"
        HowManyDailyTextBox.Text = "N/A"
        TxtPrevMethod.Text = "N/A"
        PreviousNoTextBox.Text = "N/A"
        HouseholdNoTextBox.Text = "N/A"
        FirstMarriageTextBox.Text = "N/A"
        LivingChildrenTextBox.Text = "N/A"
        TxtEduLevel.Text = "N/A"
        TxtClinic.Text = "N/A"
        LblCID.Text = 1
        LblELID.Text = 1
        LblMTID.Text = 1
        CMBPrevPra.SelectedIndex = 0
        CMBMaritalStatus.SelectedIndex = 0
        CmbSmoking.SelectedIndex = 0
    End Sub
    'CLEAR METHOD FOR MEDICAL HISTORY
    Private Sub clearfieldMedicalHistory()
        txtCycleLength.Text = ""
        TxtBleedingDays.Text = ""
        TxtspecifyType.Text = "N/A"
        CMBFlow.SelectedIndex = 0
        CMBBreastFeeding.SelectedIndex = 0
        CMBSevereVaricosis.SelectedIndex = 0
        CMBJaundice.SelectedIndex = 0
        CMBRenalDisease.SelectedIndex = 0
        CMBHypertention.SelectedIndex = 0
        CMBSTD.SelectedIndex = 0
        CMBDiabetes.SelectedIndex = 0
        CMBEpilepsy.SelectedIndex = 0
        CMBTB.SelectedIndex = 0
        CMBPID.SelectedIndex = 0
        CMBGoitre.SelectedIndex = 0
        CMBTakingMed.SelectedIndex = 0
    End Sub
    'CLEAR METHOD FOR EXAMINATION
    Private Sub ClearafieldsExamination()
        TxtBloodPressure.Text = ""
        TxtWeight.Text = ""
        TxtUrineSugar.Text = ""
        TxtUrineAlbumin.Text = ""
        TxtSpecifyBreast.Text = "N/A"
        TxtSpecifyUterus.Text = "N/A"
        TxtSpecifyAdnexa.Text = "N/A"
        TxtSpecifyCervix.Text = "N/A"
        TxtSpecifyGenetalia.Text = "N/A"
        TxtSpecifyVaginal.Text = "N/A"
        TxtSpecifyDischarge.Text = "N/A"
        TxtSpecifyPapSmear.Text = "N/A"
        TxtSpecifyPSA.Text = "N/A"
    End Sub
    Private Sub clearfieldsmethodAdopted()
        TxtMethodAdopted.Text = ""
        LblMTID.Text = 1
        TxtReasonsWhy.Text = "N/A"
        TxtPillType.Text = "N/A"
        LBLPTID.Text = 1
        TxtIUCDType.Text = "N/A"
        LBLIUCDTID.Text = 1
        TxtInjectionType.Text = "N/A"
        LBLIID.Text = 1
        TxtSpermicidesType.Text = "N/A"
        LBLSTID.Text = 1
        TxtImplantType.Text = "N/A"
        LblITID.Text = 1
        cmbCondomType.SelectedIndex = 0
        TxtPillCycles.Text = "N/A"
        TxtIucdSize.Text = "N/A"
        TxtInjectionNumberofmonths.Text = "N/A"
        TxtSpermicideAmountIssued.Text = "N/A"
        TxtClinicNo.Text = "N/A"
        RichTextBox1.Text = "N/A"

    End Sub
    Private Sub clearfieldRevisitCard()
        TxtName.Text = ""
        TxtClientNoDisp.Text = ""
        txtbloodpressureRevisit.Text = ""
        TxtBreastRevisit.Text = ""
        TxtPapSmearRevisit.Text = ""
        TxtResonsChange.Text = ""
        TxtSpecifyReasonChange.Text = "N/A"
        TxtPrescriberRevisit.Text = ""
        TxtWeightRevisit.Text = ""
        TxtRevisitNo.Text = ""
        TxtLastMethodRevisit.Text = ""
        TxtTypeRevisit.Text = ""
        TxtPillRevisit.Text = ""
        TxtIUCDRevisit.Text = ""
        TxtImplantRevisit.Text = ""
        TxtInjectionRevisit.Text = ""
        TxtSpermicidesRevisit.Text = ""
        CmbCondomRevisit.SelectedIndex = 0

    End Sub
    'CLEAR METHOD FOR CONTACT
    Private Sub clearfieldContact()
        TxtPhoneNumber.Text = ""
        LblCTID.Text = 0
        TxtContactType.Text = ""
    End Sub
    'CLEAR METHOD FOR POSTAL ADRESS
    Private Sub clearfieldPostalAddress()
        TxtPostalAdress.Text = ""
        LblCTID.Text = 0
        TxtAdressType.Text = "P.O BOX:"
    End Sub
    'LOAD DGVBASIC INFORMATIOM

    Private Sub LoadBasicInfo()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        `basic_ information`.BID, `basic_ information`.Clinic_No, `basic_ information`.Card_No, `basic_ information`.First_Visit_Date, `basic_ information`.Name, `basic_ information`.MaritalStatus AS Marital_Status, `basic_ information`.Age_First_Marriage, `basic_ information`.Husband_Or_Father, `basic_ information`.Husband_Or_Father_occupation, `basic_ information`.Client_Age, `basic_ information`.Client_Occupation, education_level.Education_Level, `basic_ information`.No_Of_Children_living, `basic_ information`.Ages_Of_Children, `basic_ information`.No_Of_Dead_Children, `basic_ information`.Previous_Contraceptive_Practice, clinics.Clinic_Name, `basic_ information`.Previous_Client_No, method_type.Type_Name, `basic_ information`.Date_Last_Visit, `basic_ information`.Smoking, `basic_ information`.How_Many_Daily, `basic_ information`.Village_Or_Estate, `basic_ information`.Sub_Location_Or_House_No FROM            `basic_ information`, education_level, clinics, method_type WHERE        `basic_ information`.ELID = education_level.ELID AND `basic_ information`.CID = clinics.CID AND `basic_ information`.MTID = method_type.MTID", conn)
        DA.Fill(DT)
        DGVBasicInfo.DataSource = DT
        DGVBasicInfo.Columns(0).Visible = False

    End Sub
    'LOAD DGVMEDICAL HISTORY
    Private Sub loadMedicalHistory()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        `basic_ information`.BID, medical_history.MHID, medical_history.Lmp, medical_history.No_Of_Bleeding_Days, medical_history.Cycle_Length, medical_history.Flow, medical_history.Date_Of_Last_Or_Abortion, medical_history.Breast_Feeding, medical_history.Severe_Varicosis, medical_history.Jaundice, medical_history.Renal_Disease, medical_history.Hypertention, medical_history.Std, medical_history.Diabetes, medical_history.Epilepsy, medical_history.Specify_Type, medical_history.Taking_Medicine, medical_history.Goitre, medical_history.Pid, medical_history.Tuberculosis FROM `basic_ information`, medical_history WHERE `basic_ information`.BID = medical_history.BID and medical_history.BID = '" & LblBID.Text & "'", conn)

        DA.Fill(DT)
        DGVMedicalHistory.DataSource = DT
        DGVMedicalHistory.Columns(0).Visible = False
        DGVMedicalHistory.Columns(1).Visible = False
    End Sub
    'LOAD DGVEXAMINATION
    Private Sub LoadExamination()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT `basic_ information`.BID, examination.EID, examination.Blood_Pressure,examination.Weight, examination.Urine_Sugar, examination.Urine_Albumin,examination.HIV_Testing, examination.Breast, examination.Specify_Breast, examination.Uterus, examination.Specify_Uterus, examination.Adnexa, examination.Specify_Adnexa, examination.Cervix, examination.Specify_Cervix, examination.Ext_Genitalia, examination.Specify_Ext_Genitalia, examination.Vaginal, examination.Specify_Vaginal, examination.Discharge, examination.Specify_Discharge, examination.Pap_Smear, examination.Specify_Pas_Smear, examination.Pregnancy_Test_Result, examination.Specify_PSA, examination.PSA FROM `basic_ information`, examination WHERE `basic_ information`.BID = examination.BID and  examination.BID='" & LblBID.Text & "'", conn)
        DA.Fill(DT)
        DGVExamination.DataSource = DT
        DGVExamination.Columns(0).Visible = False
        DGVExamination.Columns(1).Visible = False
    End Sub
    Private Sub loadMethodOfContraceptionAdopted()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT         method_type.Type_Name, pill_type.PillName, method_of_contraception_adopted.No_Of_Cycle, iucd_type.IUCD_Name, method_of_contraception_adopted.`Size`,  injection_type.Injection_Name, method_of_contraception_adopted.No_Of_Months, spermicide_type.Spermicide_Name, method_of_contraception_adopted.Amount_Issued, implant_type.ImplantType, method_of_contraception_adopted.No_of_years, method_of_contraception_adopted.CondomType, method_of_contraception_adopted.NO_Issued, method_of_contraception_adopted.Reason, method_of_contraception_adopted.Remarks_Or_Refferals, staff_details.Staff_Name, method_of_contraception_adopted.Return_Date FROM staff_details, method_of_contraception_adopted, method_type, implant_type, injection_type, iucd_type, pill_type, spermicide_type, `basic_ information` WHERE staff_details.SDID = method_of_contraception_adopted.SDID AND method_of_contraception_adopted.MTID = method_type.MTID AND method_of_contraception_adopted.ITID = implant_type.ITID AND method_of_contraception_adopted.IID = injection_type.IID AND method_of_contraception_adopted.IUCDTID = iucd_type.IUCDTID AND method_of_contraception_adopted.PTID = pill_type.PTID AND method_of_contraception_adopted.STID = spermicide_type.STID AND method_of_contraception_adopted.BID = `basic_ information`.BID='" & LblBID.Text & "'", conn)
        DA.Fill(DT)
        DGVMethodAdopted.DataSource = DT
        DGVMethodAdopted.Columns(0).Visible = False
        DGVMethodAdopted.Columns(1).Visible = False
    End Sub
    'Private Sub loadRevisitCard()
    '    DT = New DataTable
    '    DA = New OdbcDataAdapter("SELECT         method_type.Type_Name, pill_type.PillName, method_of_contraception_adopted.No_Of_Cycle, iucd_type.IUCD_Name, method_of_contraception_adopted.`Size`,  injection_type.Injection_Name, method_of_contraception_adopted.No_Of_Months, spermicide_type.Spermicide_Name, method_of_contraception_adopted.Amount_Issued, implant_type.ImplantType, method_of_contraception_adopted.No_of_years, method_of_contraception_adopted.CondomType, method_of_contraception_adopted.NO_Issued, method_of_contraception_adopted.Reason, method_of_contraception_adopted.Remarks_Or_Refferals, staff_details.Staff_Name, method_of_contraception_adopted.Return_Date FROM staff_details, method_of_contraception_adopted, method_type, implant_type, injection_type, iucd_type, pill_type, spermicide_type, `basic_ information` WHERE staff_details.SDID = method_of_contraception_adopted.SDID AND method_of_contraception_adopted.MTID = method_type.MTID AND method_of_contraception_adopted.ITID = implant_type.ITID AND method_of_contraception_adopted.IID = injection_type.IID AND method_of_contraception_adopted.IUCDTID = iucd_type.IUCDTID AND method_of_contraception_adopted.PTID = pill_type.PTID AND method_of_contraception_adopted.STID = spermicide_type.STID AND method_of_contraception_adopted.BID = `basic_ information`.BID='" & LblBID.Text & "'", conn)
    '    DA.Fill(DT)
    '    DGVRevisit.DataSource = DT
    '    DGVRevisit.Columns(0).Visible = False
    '    DGVRevisit.Columns(1).Visible = False
    'End Sub

    Private Sub loadClientPhone()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        clinet_phone_contact.phone, contact_type.Type FROM            clinet_phone_contact, contact_type, `basic_ information` WHERE        clinet_phone_contact.Contact_Type = contact_type.CTID AND clinet_phone_contact.BID = `basic_ information`.BID and clinet_phone_contact.BID='" & LblBID.Text & "'", conn)

        DA.Fill(DT)
        DGVPhoneContact.DataSource = DT
        DGVPhoneContact.Columns(0).Visible = True
        DGVPhoneContact.Columns(1).Visible = True
    End Sub
    Private Sub loadPostalAdress()
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT   contact_type.Type, client_postal_address.BID, client_postal_address.address FROM contact_type, client_postal_address, `basic_ information` WHERE        contact_type.CTID = client_postal_address.CTID AND client_postal_address.BID = `basic_ information`.BID='" & LblBID.Text & "'", conn)

        DA.Fill(DT)
        DGVPostalAdress.DataSource = DT
        DGVPostalAdress.Columns(0).Visible = True
        DGVPostalAdress.Columns(1).Visible = False
    End Sub
    'DGC CLICK BASIC INFO
    Private Sub DGVBasicInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVBasicInfo.Click
        Dim DrClinics As OdbcDataReader
        With DGVBasicInfo
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                LblBID.Text = .Item(0, currentRow).Value
                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT        `basic_ information`.BID, `basic_ information`.Clinic_No, `basic_ information`.Card_No, `basic_ information`.First_Visit_Date, `basic_ information`.Name, `basic_ information`.MaritalStatus, `basic_ information`.Age_First_Marriage, `basic_ information`.Husband_Or_Father, `basic_ information`.Husband_Or_Father_occupation, `basic_ information`.Client_Age, `basic_ information`.Client_Occupation, education_level.ELID, education_level.Education_Level, `basic_ information`.No_Of_Children_living, `basic_ information`.Ages_Of_Children, `basic_ information`.No_Of_Dead_Children, `basic_ information`.Previous_Contraceptive_Practice, clinics.CID, clinics.Clinic_Name, `basic_ information`.Previous_Client_No, method_type.Type_Name, method_type.MTID, `basic_ information`.Date_Last_Visit, `basic_ information`.Smoking, `basic_ information`.How_Many_Daily, `basic_ information`.Village_Or_Estate, `basic_ information`.Sub_Location_Or_House_No FROM            `basic_ information`, education_level, clinics, method_type WHERE        `basic_ information`.ELID = education_level.ELID AND `basic_ information`.CID = clinics.CID AND `basic_ information`.MTID = method_type.MTID AND `basic_ information`.BID=? "
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LblBID.Text
                    DrClinics = .ExecuteReader
                End With
                If DrClinics.HasRows Then
                    LblBID.Text = DrClinics.Item(0)
                    ClientNoTextBox.Text = DrClinics.Item(0)
                    ClinicNoTextBox.Text = DrClinics.Item(1)
                    TxtClinicNo.Text = DrClinics.Item(1)
                    TxtCardNo.Text = DrClinics.Item(2)
                    TxtcardNoDisp.Text = DrClinics.Item(2)
                    DTPFVisit.Value = DrClinics.Item(3)
                    NameTextBox.Text = DrClinics.Item(4)
                    TxtClientNameDisp.Text = DrClinics.Item(4)
                    TxtContactName.Text = DrClinics.Item(4)
                    TxtExaminationName.Text = DrClinics.Item(4)
                    txtclientNameMethod.Text = DrClinics.Item(4)
                    TxtName.Text = DrClinics.Item(4)
                    CMBMaritalStatus.Text = DrClinics.Item(5)
                    HusbandNameTextBox.Text = DrClinics.Item(6)
                    FirstMarriageTextBox.Text = DrClinics.Item(7)
                    HusbandOccupationTextBox.Text = DrClinics.Item(8)
                    ClientAgeTextBox.Text = DrClinics.Item(9)
                    ClientOccupationTextBox.Text = DrClinics.Item(10)
                    LblELID.Text = DrClinics.Item(11)
                    TxtEduLevel.Text = DrClinics.Item(12)
                    LivingChildrenTextBox.Text = DrClinics.Item(13)
                    AgesLivingTextBox.Text = DrClinics.Item(14)
                    DiedTextBox.Text = DrClinics.Item(15)
                    CMBPrevPra.Text = DrClinics.Item(16)
                    LblCID.Text = DrClinics.Item(17)
                    TxtClinic.Text = DrClinics.Item(18)
                    PreviousNoTextBox.Text = DrClinics.Item(19)
                    TxtPrevMethod.Text = DrClinics.Item(20)
                    LblMTID.Text = DrClinics.Item(21)
                    LastVisitDateTimePicker.Value = DrClinics.Item(22)
                    CmbSmoking.Text = DrClinics.Item(23)
                    HowManyDailyTextBox.Text = DrClinics.Item(24)
                    VillageTextBox.Text = DrClinics.Item(25)
                    HouseholdNoTextBox.Text = DrClinics.Item(26)

                End If
                loadMedicalHistory()
                LoadExamination()
                loadClientPhone()
                loadPostalAdress()
                loadMethodOfContraceptionAdopted()
            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub
    'DGV CLICK MEDICAL HISTORY
    Private Sub DGVMedicalHistory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVMedicalHistory.Click
        Dim DrClinics As OdbcDataReader
        With DGVMedicalHistory
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                lblMHID.Text = .Item(0, currentRow).Value

                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT  medical_history.MHID, medical_history.Lmp, medical_history.No_Of_Bleeding_Days, medical_history.Cycle_Length, medical_history.Flow, medical_history.Breast_Feeding,medical_history.Date_Of_Last_Or_Abortion, medical_history.Severe_Varicosis, medical_history.Jaundice, medical_history.Hypertention, medical_history.Renal_Disease, medical_history.Std, medical_history.Diabetes, medical_history.Epilepsy, medical_history.Tuberculosis, medical_history.Pid, medical_history.Taking_Medicine, medical_history.Specify_Type, medical_history.Goitre FROM `basic_ information`, medical_history WHERE `basic_ information`.BID = medical_history.BID  and medical_history.MHID= ?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = lblMHID.Text
                    DrClinics = .ExecuteReader
                End With

                If DrClinics.HasRows Then

                    'LblBID.Text = DrClinics.Item(0)
                    lblMHID.Text = DrClinics.Item(0)
                    DTPLMP.Value = DrClinics.Item(1)
                    TxtBleedingDays.Text = DrClinics.Item(2)
                    txtCycleLength.Text = DrClinics.Item(3)
                    CMBFlow.Text = DrClinics.Item(4)

                    CMBBreastFeeding.Text = DrClinics.Item(5)
                    DTPDelivery.Value = DrClinics.Item(6)
                    CMBSevereVaricosis.Text = DrClinics.Item(7)
                    CMBJaundice.Text = DrClinics.Item(8)
                    CMBRenalDisease.Text = DrClinics.Item(9)
                    CMBHypertention.Text = DrClinics.Item(10)
                    CMBSTD.Text = DrClinics.Item(11)
                    CMBDiabetes.Text = DrClinics.Item(12)
                    CMBEpilepsy.Text = DrClinics.Item(13)
                    CMBTB.Text = DrClinics.Item(14)
                    CMBPID.Text = DrClinics.Item(15)
                    CMBGoitre.Text = DrClinics.Item(16)
                    CMBTakingMed.Text = DrClinics.Item(17)
                    TxtspecifyType.Text = DrClinics.Item(18)
                Else
                    MsgBox("NO DATA")

                End If
                loadMedicalHistory()
            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub
    'DGV CLICK EXAMINATION
    Private Sub DGVExamination_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVExamination.Click

        Dim DrClinics As OdbcDataReader
        With DGVExamination
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                LBLEID.Text = .Item(1, currentRow).Value

                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT `basic_ information`.BID, examination.EID, examination.Blood_Pressure,examination.Weight, examination.Urine_Sugar, examination.Urine_Albumin,examination.HIV_Testing, examination.Breast, examination.Specify_Breast, examination.Uterus, examination.Specify_Uterus, examination.Adnexa, examination.Specify_Adnexa, examination.Cervix, examination.Specify_Cervix, examination.Ext_Genitalia, examination.Specify_Ext_Genitalia, examination.Vaginal, examination.Specify_Vaginal, examination.Discharge, examination.Specify_Discharge, examination.Pap_Smear, examination.Specify_Pas_Smear, examination.Pregnancy_Test_Result, examination.Specify_PSA, examination.PSA FROM `basic_ information`, examination WHERE `basic_ information`.BID = examination.BID and  examination.EID= ?"

                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLEID.Text
                    DrClinics = .ExecuteReader
                End With

                If DrClinics.HasRows Then

                    'LblBID.Text = DrClinics.Item(0)
                    LBLEID.Text = DrClinics.Item(0)
                    TxtBloodPressure.Text = DrClinics.Item(1)
                    TxtWeight.Text = DrClinics.Item(2)
                    TxtUrineSugar.Text = DrClinics.Item(3)
                    TxtUrineAlbumin.Text = DrClinics.Item(4)
                    CmbHIVTest.Text = DrClinics.Item(5)
                    CmbBreast.Text = DrClinics.Item(6)
                    TxtSpecifyBreast.Text = DrClinics.Item(7)
                    CmbUterus.Text = DrClinics.Item(8)
                    TxtSpecifyUterus.Text = DrClinics.Item(9)
                    CmbAdnexa.Text = DrClinics.Item(10)
                    TxtSpecifyAdnexa.Text = DrClinics.Item(11)
                    CmbCervix.Text = DrClinics.Item(12)
                    TxtSpecifyCervix.Text = DrClinics.Item(13)
                    CmbGenetalia.Text = DrClinics.Item(14)
                    TxtSpecifyGenetalia.Text = DrClinics.Item(15)
                    CmbVaginal.Text = DrClinics.Item(16)
                    TxtSpecifyVaginal.Text = DrClinics.Item(17)
                    CmbDischarge.Text = DrClinics.Item(18)
                    TxtSpecifyDischarge.Text = DrClinics.Item(19)
                    CmbPapSmear.Text = DrClinics.Item(20)
                    TxtSpecifyPapSmear.Text = DrClinics.Item(21)
                    CmbPregnacyTest.Text = DrClinics.Item(22)
                    TxtSpecifyPSA.Text = DrClinics.Item(23)
                    CmbPSA.Text = DrClinics.Item(24)
                Else
                    MsgBox("NO DATA")

                End If
                LoadExamination()
            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub
    'SAVE BASIC INFORMATION
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInfoSaveButton.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If HusbandNameTextBox.Text = "" Then
            HusbandNameTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If FirstMarriageTextBox.Text = "" Then
            FirstMarriageTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If HouseholdNoTextBox.Text = "" Then
            HouseholdNoTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtEduLevel.Text = "" Then
            TxtEduLevel.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If AgesLivingTextBox.Text = "" Then
            AgesLivingTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If DiedTextBox.Text = "" Then
            DiedTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If PreviousNoTextBox.Text = "" Then
            PreviousNoTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If LivingChildrenTextBox.Text = "" Then
            LivingChildrenTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtPrevMethod.Text = "" Then
            TxtPrevMethod.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtClinic.Text = "" Then
            TxtClinic.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If HowManyDailyTextBox.Text = "" Then
            HowManyDailyTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If ClientOccupationTextBox.Text = "" Then
            ClientOccupationTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If CMBMaritalStatus.SelectedIndex = 0 Or CMBMaritalStatus.Text = "-select-" Then
            MessageBox.Show("Select a valid marital status", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        If CMBPrevPra.SelectedIndex = 0 Then
            MessageBox.Show("Select a valid Previous Practice", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `basic_ information`(`Clinic_No`, `Card_No`, `First_Visit_Date`, `Name`, `MaritalStatus`, `Age_First_Marriage`, `Husband_Or_Father`, `Husband_Or_Father_occupation`, `Client_Age`, `Client_Occupation`, `ELID`, `No_Of_Children_living`, `Ages_Of_Children`, `No_Of_Dead_Children`, `Previous_Contraceptive_Practice`, `CID`, `Previous_Client_No`, `MTID`, `Date_Last_Visit`, `Smoking`, `How_Many_Daily`, `Village_Or_Estate`, `Sub_Location_Or_House_No`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = ClinicNoTextBox.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = TxtCardNo.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DTPFVisit.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = NameTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = CMBMaritalStatus.Text
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
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = CmbSmoking.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = HowManyDailyTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = VillageTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = HouseholdNoTextBox.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadBasicInfo()
        ClearFields()

    End Sub
    'save of medical history
    Private Sub MedicalSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicalSave.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtspecifyType.Text = "" Then
            TxtspecifyType.Text = "N/A"

        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `medical_history`(`BID`, `Lmp`, `No_Of_Bleeding_Days`, `Cycle_Length`, `Flow`, `Date_Of_Last_Or_Abortion`, `Breast_Feeding`, `Severe_Varicosis`, `Jaundice`, `Renal_Disease`, `Hypertention`, `Std`, `Diabetes`, `Epilepsy`, `Tuberculosis`, `Pid`, `Goitre`, `Taking_Medicine`, `Specify_Type`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblBID.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DTPLMP.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtBleedingDays.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = txtCycleLength.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBFlow.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DTPDelivery.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBBreastFeeding.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBSevereVaricosis.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBJaundice.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBRenalDisease.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBHypertention.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBSTD.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBDiabetes.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBEpilepsy.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBTB.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBPID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBGoitre.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = CMBTakingMed.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtspecifyType.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadMedicalHistory()
        clearfieldMedicalHistory()
    End Sub
    'SAVE EXAMINATION
    Private Sub ToolStripLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel6.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtSpecifyBreast.Text = "" Then
            TxtSpecifyBreast.Text = "N/A"
        ElseIf TxtSpecifyUterus.Text = "" Then
            TxtSpecifyUterus.Text = "N/A"
        ElseIf TxtSpecifyAdnexa.Text = "" Then
            TxtSpecifyAdnexa.Text = "N/A"
        ElseIf TxtSpecifyCervix.Text = "" Then
            TxtSpecifyCervix.Text = "N/A"
        ElseIf TxtSpecifyGenetalia.Text = "" Then
            TxtSpecifyGenetalia.Text = "N/A"
        ElseIf TxtSpecifyVaginal.Text = "" Then
            TxtSpecifyVaginal.Text = "N/A"
        ElseIf TxtSpecifyVaginal.Text = "" Then
            TxtSpecifyVaginal.Text = "N/A"
        ElseIf TxtSpecifyDischarge.Text = "" Then
            TxtSpecifyDischarge.Text = "N/A"
        ElseIf TxtSpecifyPapSmear.Text = "" Then
            TxtSpecifyPapSmear.Text = "N/A"
        ElseIf TxtSpecifyPSA.Text = "" Then
            TxtSpecifyPSA.Text = "N/A"

        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `examination`(`BID`, `Blood_Pressure`, `Weight`, `Urine_Sugar`, `Urine_Albumin`, `HIV_Testing`, `Breast`, `Specify_Breast`, `Uterus`, `Specify_Uterus`, `Adnexa`, `Specify_Adnexa`, `Cervix`, `Specify_Cervix`, `Ext_Genitalia`, `Specify_Ext_Genitalia`, `Vaginal`, `Specify_Vaginal`, `Discharge`, `Specify_Discharge`, `Pap_Smear`, `Specify_Pas_Smear`, `PSA`, `Specify_PSA`, `Pregnancy_Test_Result`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblBID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtBloodPressure.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtWeight.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = TxtUrineSugar.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtUrineAlbumin.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbHIVTest.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbBreast.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyBreast.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbUterus.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyUterus.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbAdnexa.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyAdnexa.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbCervix.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyCervix.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbGenetalia.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyGenetalia.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbVaginal.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = TxtSpecifyVaginal.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbDischarge.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyDischarge.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbPapSmear.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyPapSmear.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbPSA.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyPSA.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbPregnacyTest.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadExamination()
        ClearafieldsExamination()
    End Sub
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
    'SAVE BUTTON CONTACT INFORMATION
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
                .CommandText = "INSERT INTO `clinet_phone_contact`( `BID`, `Contact_Type`, `phone`) VALUES (?,?,?)"

                .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LblBID.Text
                .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LblCTID.Text
                .Parameters.Add("par1", OdbcType.VarChar, 10).Value = TxtPhoneNumber.Text
                .ExecuteNonQuery()
                myTrans.Commit()
                loadClientPhone()
                clearfieldContact()

            End With
        Else
            ''if the Phone is not valid
            'Call Phone Validation Function
            MessageBox.Show("The Phone Number You Provided Is Not Valid.Please Ensure The Number Is In The Valid Format.Example:0737702144", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
    End Sub
    'SAVE BUTTON POSTAL ADDRESS INFORMATION
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
            .CommandText = "INSERT INTO `client_postal_address`( `BID`, `address`, `CTID`) VALUES (?,?,?)"
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LblBID.Text
            .Parameters.Add("par1", OdbcType.VarChar, 45).Value = TxtPostalAdress.Text
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LblCTID.Text

            .ExecuteNonQuery()
            myTrans.Commit()
            loadPostalAdress()
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
    'UPDATE BASIC INFORMATION
    Private Sub BasicInfoUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInfoUpdateButton.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If HusbandNameTextBox.Text = "" Then
            HusbandNameTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If FirstMarriageTextBox.Text = "" Then
            FirstMarriageTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If HouseholdNoTextBox.Text = "" Then
            HouseholdNoTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtEduLevel.Text = "" Then
            TxtEduLevel.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If AgesLivingTextBox.Text = "" Then
            AgesLivingTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If DiedTextBox.Text = "" Then
            DiedTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If PreviousNoTextBox.Text = "" Then
            PreviousNoTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If LivingChildrenTextBox.Text = "" Then
            LivingChildrenTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtPrevMethod.Text = "" Then
            TxtPrevMethod.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtClinic.Text = "" Then
            TxtClinic.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If HowManyDailyTextBox.Text = "" Then
            HowManyDailyTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If ClientOccupationTextBox.Text = "" Then
            ClientOccupationTextBox.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If CMBMaritalStatus.SelectedIndex = 0 Or CMBMaritalStatus.Text = "-select-" Then
            MessageBox.Show("Select a valid marital status", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        If CMBPrevPra.SelectedIndex = 0 Then
            MessageBox.Show("Select a valid Previous Practice", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "UPDATE `basic_ information` SET `Clinic_No`=?,`Card_No`=?,`First_Visit_Date`=?,`Name`=?,`MaritalStatus`=?,`Age_First_Marriage`=?,`Husband_Or_Father`=?,`Husband_Or_Father_occupation`=?,`Client_Age`=?,`Client_Occupation`=?,`ELID`=?,`No_Of_Children_living`=?,`Ages_Of_Children`=?,`No_Of_Dead_Children`=?,`Previous_Contraceptive_Practice`=?,`CID`=?,`Previous_Client_No`=?,`MTID`=?,`Date_Last_Visit`=?,`Smoking`=?,`How_Many_Daily`=?,`Village_Or_Estate`=?,`Sub_Location_Or_House_No`=? WHERE `BID`=?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = ClinicNoTextBox.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = TxtCardNo.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DTPFVisit.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = NameTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = CMBMaritalStatus.Text
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
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = CmbSmoking.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = HowManyDailyTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = VillageTextBox.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = HouseholdNoTextBox.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblBID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadBasicInfo()
        ClearFields()
    End Sub
    'UPDATE MEDICAL HISTORY
    Private Sub TSLUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSLUpdate.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtspecifyType.Text = "" Then
            TxtspecifyType.Text = "N/A"

        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "UPDATE `medical_history` SET `BID`=?,`Lmp`=?,`No_Of_Bleeding_Days`=?,`Cycle_Length`=?,`Flow`=?,`Date_Of_Last_Or_Abortion`=?,`Breast_Feeding`=?,`Severe_Varicosis`=?,`Jaundice`=?,`Renal_Disease`=?,`Hypertention`=?,`Std`=?,`Diabetes`=?,`Epilepsy`=?,`Tuberculosis`=?,`Pid`=?,`Goitre`=?,`Taking_Medicine`=?,`Specify_Type`=? WHERE `MHID`=?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblBID.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DTPLMP.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtBleedingDays.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = txtCycleLength.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBFlow.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DTPDelivery.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBBreastFeeding.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBSevereVaricosis.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBJaundice.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBRenalDisease.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBHypertention.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBSTD.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBDiabetes.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBEpilepsy.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBTB.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBPID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CMBGoitre.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = CMBTakingMed.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtspecifyType.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = lblMHID.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadMedicalHistory()
        clearfieldMedicalHistory()
    End Sub
    'UPDATE BUTTON FOR EXAMINATION
    Private Sub ToolStripLabel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel7.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtSpecifyBreast.Text = "" Then
            TxtSpecifyBreast.Text = "N/A"
        ElseIf TxtSpecifyUterus.Text = "" Then
            TxtSpecifyUterus.Text = "N/A"
        ElseIf TxtSpecifyAdnexa.Text = "" Then
            TxtSpecifyAdnexa.Text = "N/A"
        ElseIf TxtSpecifyCervix.Text = "" Then
            TxtSpecifyCervix.Text = "N/A"
        ElseIf TxtSpecifyGenetalia.Text = "" Then
            TxtSpecifyGenetalia.Text = "N/A"
        ElseIf TxtSpecifyVaginal.Text = "" Then
            TxtSpecifyVaginal.Text = "N/A"
        ElseIf TxtSpecifyVaginal.Text = "" Then
            TxtSpecifyVaginal.Text = "N/A"
        ElseIf TxtSpecifyDischarge.Text = "" Then
            TxtSpecifyDischarge.Text = "N/A"
        ElseIf TxtSpecifyPapSmear.Text = "" Then
            TxtSpecifyPapSmear.Text = "N/A"
        ElseIf TxtSpecifyPSA.Text = "" Then
            TxtSpecifyPSA.Text = "N/A"

        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "UPDATE `examination` SET `BID`=?,`Blood_Pressure`=?,`Weight`=?,`Urine_Sugar`=?,`Urine_Albumin`=?,`HIV_Testing`=?,`Breast`=?,`Specify_Breast`=?,`Uterus`=?,`Specify_Uterus`=?,`Adnexa`=?,`Specify_Adnexa`=?,`Cervix`=?,`Specify_Cervix`=?,`Ext_Genitalia`=?,`Specify_Ext_Genitalia`=?,`Vaginal`=?,`Specify_Vaginal`=?,`Discharge`=?,`Specify_Discharge`=?,`Pap_Smear`=?,`Specify_Pas_Smear`=?,`PSA`=?,`Specify_PSA`=?,`Pregnancy_Test_Result`=? WHERE `EID`=?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblBID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtBloodPressure.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtWeight.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = TxtUrineSugar.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtUrineAlbumin.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbHIVTest.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbBreast.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyBreast.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbUterus.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyUterus.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbAdnexa.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyAdnexa.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbCervix.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyCervix.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbGenetalia.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyGenetalia.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbVaginal.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = TxtSpecifyVaginal.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbDischarge.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyDischarge.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbPapSmear.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyPapSmear.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbPSA.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyPSA.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = CmbPregnacyTest.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadExamination()
        ClearafieldsExamination()
    End Sub
    'UPDATE PHONE CONTACT INFORMATION
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
                .CommandText = "UPDATE `clinet_phone_contact` SET `BID`=?,`Contact_Type`=?,`phone`=? WHERE `PCID`=?"

                .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LblBID.Text
                .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LblCTID.Text
                .Parameters.Add("par1", OdbcType.VarChar, 10).Value = TxtPhoneNumber.Text
                .ExecuteNonQuery()
                myTrans.Commit()
                loadClientPhone()
                clearfieldContact()

            End With
        Else
            ''if the Phone is not valid
            'Call Phone Validation Function
            MessageBox.Show("The Phone Number You Provided Is Not Valid.Please Ensure The Number Is In The Valid Format.Example:0737702144", "Invalid Contact Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myTrans.Rollback()
            Exit Sub
        End If
    End Sub
    'UPDATE POSTAL INFORMATION
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
            .CommandText = "UPDATE `client_postal_address` SET `BID`=?,`address`=?,`CTID`=? WHERE `PAID`=?"
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LblBID.Text
            .Parameters.Add("par1", OdbcType.VarChar, 45).Value = TxtPostalAdress.Text
            .Parameters.Add("par1", OdbcType.BigInt, 45).Value = LblCTID.Text

            .ExecuteNonQuery()
            myTrans.Commit()
            loadPostalAdress()
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
    'DELETE MEDICAL HISTORY
    Private Sub TSLDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSLDelete.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `medical_history` WHERE MHID= ?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = lblMHID.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadMedicalHistory()
        clearfieldMedicalHistory()
    End Sub
    'DELETE BASIC INFORMATION
    Private Sub BasicInfoDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInfoDeleteButton.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `basic_ information` WHERE BID =?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblBID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadBasicInfo()
        ClearFields()
    End Sub
    'DELETE EXAMINATION
    Private Sub ToolStripLabel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel8.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `examination` WHERE `EID` =?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLEID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        LoadExamination()
        ClearafieldsExamination()
    End Sub
    'DELETE PHONE CONTACT INFORMATION
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `clinet_phone_contact` WHERE PCID= ?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblCTID.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadClientPhone()
        clearfieldContact()
    End Sub
    'DELETE POSTAL ADRESS
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `client_postal_address` WHERE  PCID= ?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblCTID.Text
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadPostalAdress()
        clearfieldPostalAddress()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub BasicInfoClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInfoClearButton.Click
        ClearFields()
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
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmClinics.Show()

    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        With FrmSelector
            .LblPointer.Text = 3
            .Text = "Method Type"
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmMethods.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmEducationLevel.Show()
    End Sub

    Private Sub ClientOccupationTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClientOccupationTextBox.Click
        ClientOccupationTextBox.Text = ""
    End Sub

    Private Sub LivingChildrenTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LivingChildrenTextBox.Click
        LivingChildrenTextBox.Text = ""
    End Sub

    Private Sub HusbandNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HusbandNameTextBox.Click
        HusbandNameTextBox.Text = ""
    End Sub
    Private Sub PreviousNoTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PreviousNoTextBox.Click
        PreviousNoTextBox.Text = ""
    End Sub

    Private Sub HusbandOccupationTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HusbandOccupationTextBox.Click
        HusbandOccupationTextBox.Text = ""
    End Sub

    Private Sub HouseholdNoTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HouseholdNoTextBox.Click
        HouseholdNoTextBox.Text = ""
    End Sub

    Private Sub FirstMarriageTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstMarriageTextBox.Click
        FirstMarriageTextBox.Text = ""
    End Sub

    Private Sub DiedTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiedTextBox.Click
        DiedTextBox.Text = ""
    End Sub

    Private Sub HowManyDailyTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HowManyDailyTextBox.Click
        HowManyDailyTextBox.Text = ""
    End Sub

    Private Sub AgesLivingTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AgesLivingTextBox.Click
        AgesLivingTextBox.Text = ""
    End Sub

    Private Sub TxtEduLevel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEduLevel.Click
        TxtEduLevel.Text = ""
    End Sub

    Private Sub TxtClinic_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtClinic.Click
        TxtClinic.Text = ""
    End Sub

    Private Sub TxtPrevMethod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrevMethod.Click
        TxtPrevMethod.Text = ""
    End Sub

    Private Sub TSLClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSLClear.Click
        clearfieldMedicalHistory()
    End Sub
    Private Sub TxtspecifyType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtspecifyType.Click
        TxtspecifyType.Text = ""
    End Sub

    Private Sub ToolStripLabel9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel9.Click
        ClearafieldsExamination()
    End Sub
    Private Sub TxtSpecifyBreast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyBreast.Click
        TxtSpecifyBreast.Text = ""
    End Sub

    Private Sub TxtSpecifyCervix_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyCervix.Click
        TxtSpecifyCervix.Text = ""
    End Sub

    Private Sub TxtSpecifyDischarge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyDischarge.Click
        TxtSpecifyDischarge.Text = ""
    End Sub

    Private Sub TxtSpecifyGenetalia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyGenetalia.Click
        TxtSpecifyGenetalia.Text = ""
    End Sub

    Private Sub TxtSpecifyPapSmear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyPapSmear.Click
        TxtSpecifyPapSmear.Text = ""
    End Sub

    Private Sub TxtSpecifyPSA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyPSA.Click
        TxtSpecifyPSA.Text = ""
    End Sub

    Private Sub TxtSpecifyAdnexa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyAdnexa.Click
        TxtSpecifyAdnexa.Text = ""
    End Sub

    Private Sub TxtSpecifyUterus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyUterus.Click
        TxtSpecifyUterus.Text = ""
    End Sub

    Private Sub TxtSpecifyVaginal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSpecifyVaginal.Click
        TxtSpecifyVaginal.Text = ""
    End Sub

    Private Sub BasicInfoOpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicInfoOpenButton.Click
        LoadBasicInfo()
    End Sub

    Private Sub TSLOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSLOpen.Click
        loadMedicalHistory()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        With FrmSelector
            .Text = "Pill Type"
            .LblPointer.Text = 13
            .Show()
        End With
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        With FrmSelector
            .Text = "Injection Type"
            .LblPointer.Text = 11
            .Show()
        End With
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        With FrmSelector
            .Text = "Implant Type"
            .LblPointer.Text = 10
            .Show()
        End With
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        With FrmSelector
            .Text = "Spermiside Type"
            .LblPointer.Text = 14
            .Show()
        End With
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        With FrmSelector
            .Text = "Contact Type"
            .LblPointer.Text = 4
            .Show()
        End With
    End Sub
    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        With FrmSelector
            .Text = "Postal Address Type"
            .LblPointer.Text = 5
            .Show()
        End With
    End Sub
    Private Sub TxtSearchName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSearchName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 13) Or (Microsoft.VisualBasic.Asc(e.KeyChar) = 3) Then
            Try
                DT = New DataTable
                DA = New OdbcDataAdapter("SELECT        `basic_ information`.BID, `basic_ information`.Clinic_No, `basic_ information`.Card_No, `basic_ information`.First_Visit_Date, `basic_ information`.Name, `basic_ information`.MaritalStatus AS Marital_Status, `basic_ information`.Age_First_Marriage, `basic_ information`.Husband_Or_Father, `basic_ information`.Husband_Or_Father_occupation, `basic_ information`.Client_Age, `basic_ information`.Client_Occupation, education_level.Education_Level, `basic_ information`.No_Of_Children_living, `basic_ information`.Ages_Of_Children, `basic_ information`.No_Of_Dead_Children, `basic_ information`.Previous_Contraceptive_Practice, clinics.Clinic_Name, `basic_ information`.Previous_Client_No, method_type.Type_Name, `basic_ information`.Date_Last_Visit, `basic_ information`.Smoking, `basic_ information`.How_Many_Daily, `basic_ information`.Village_Or_Estate, `basic_ information`.Sub_Location_Or_House_No FROM            `basic_ information`, education_level, clinics, method_type WHERE        `basic_ information`.ELID = education_level.ELID AND `basic_ information`.CID = clinics.CID AND `basic_ information`.MTID = method_type.MTID AND  `basic_ information`.Name  LIKE " + " '" + "%" + TxtSearchName.Text + "%" + "'  ORDER BY `basic_ information`.Name ASC  ", conn)
                DA.Fill(DT)
                DGVBasicInfo.DataSource = DT
                DGVBasicInfo.Columns(0).Visible = False
            Catch ex As OdbcException
                MessageBox.Show(ex.Message, "LOAD GRID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub TxtSearchName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchName.TextChanged
        DT = New DataTable
        DA = New OdbcDataAdapter("SELECT        `basic_ information`.BID, `basic_ information`.Clinic_No, `basic_ information`.Card_No, `basic_ information`.First_Visit_Date, `basic_ information`.Name, `basic_ information`.MaritalStatus AS Marital_Status, `basic_ information`.Age_First_Marriage, `basic_ information`.Husband_Or_Father, `basic_ information`.Husband_Or_Father_occupation, `basic_ information`.Client_Age, `basic_ information`.Client_Occupation, education_level.Education_Level, `basic_ information`.No_Of_Children_living, `basic_ information`.Ages_Of_Children, `basic_ information`.No_Of_Dead_Children, `basic_ information`.Previous_Contraceptive_Practice, clinics.Clinic_Name, `basic_ information`.Previous_Client_No, method_type.Type_Name, `basic_ information`.Date_Last_Visit, `basic_ information`.Smoking, `basic_ information`.How_Many_Daily, `basic_ information`.Village_Or_Estate, `basic_ information`.Sub_Location_Or_House_No FROM            `basic_ information`, education_level, clinics, method_type WHERE        `basic_ information`.ELID = education_level.ELID AND `basic_ information`.CID = clinics.CID AND `basic_ information`.MTID = method_type.MTID AND  `basic_ information`.Name  LIKE " + " '" + "%" + TxtSearchName.Text + "%" + "'  ORDER BY `basic_ information`.Name ASC ", conn)
        DT = New DataTable
        DA.Fill(DT)
        DGVBasicInfo.DataSource = DT
        DGVBasicInfo.Columns(0).Visible = False
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        With FrmSelector
            .Text = "Method Type"
            .LblPointer.Text = 9
            .Show()
        End With
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        With FrmSelector
            .Text = "IUCD Type"
            .LblPointer.Text = 12
            .Show()
        End With
    End Sub
    'save button methos of comtraception adopted
    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtPillType.Text = "" Then
            TxtPillType.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtIUCDType.Text = "" Then
            TxtIUCDType.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtInjectionType.Text = "" Then
            TxtInjectionType.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtSpermicidesType.Text = "" Then
            TxtSpermicidesType.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtReasonsWhy.Text = "" Then
            TxtReasonsWhy.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtPillCycles.Text = "" Then
            TxtPillCycles.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtIucdSize.Text = "" Then
            TxtIucdSize.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtInjectionNumberofmonths.Text = "" Then
            TxtInjectionNumberofmonths.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtCondomNoIssued.Text = "" Then
            TxtCondomNoIssued.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtSpermicideAmountIssued.Text = "" Then
            TxtSpermicideAmountIssued.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtImplantNumberofYears.Text = "" Then
            TxtImplantNumberofYears.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If cmbCondomType.SelectedIndex = 0 Or CMBMaritalStatus.Text = "-select-" Then
            MessageBox.Show("Select a valid Condom Type", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `method_of_contraception_adopted`( `BID`, `MTID`, `No_Of_Cycle`, `Size`, `No_Of_Months`, `NO_Issued`, `Amount_Issued`, `Reason`, `Remarks_Or_Refferals`, `SDID`, `Return_Date`, `No_of_years`, `STID`, `IUCDTID`, `ITID`, `PTID`, `CondomType`, `IID`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblBID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblMTID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPillCycles.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = TxtIucdSize.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtInjectionNumberofmonths.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtCondomNoIssued.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpermicideAmountIssued.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtReasonsWhy.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = RichTextBox1.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSDID.Text
            .Parameters.Add("par", OdbcType.Date).Value = Format(DTPReturnDate.Value, "yyyy-MM-dd")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtImplantNumberofYears.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLIUCDTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblITID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLPTID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = cmbCondomType.Text
            .Parameters.Add("par", OdbcType.BigInt, 15).Value = LBLIID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadMethodOfContraceptionAdopted()
        clearfieldsmethodAdopted()

    End Sub
    'DGV CliCk method of contraception Adopted
    Private Sub DGVMethodAdopted_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVMethodAdopted.Click
        Dim DrClinics As OdbcDataReader
        With DGVMethodAdopted
            Try
                Dim currentRow As Integer = .CurrentRow.Index
                LBLMCAID.Text = .Item(0, currentRow).Value

                Dim Get_details As New OdbcCommand
                With Get_details
                    .Connection = conn
                    .CommandText = "SELECT         method_type.Type_Name, pill_type.PillName, method_of_contraception_adopted.No_Of_Cycle, iucd_type.IUCD_Name, method_of_contraception_adopted.`Size`,  injection_type.Injection_Name, method_of_contraception_adopted.No_Of_Months, spermicide_type.Spermicide_Name, method_of_contraception_adopted.Amount_Issued, implant_type.ImplantType, method_of_contraception_adopted.No_of_years, method_of_contraception_adopted.CondomType, method_of_contraception_adopted.NO_Issued, method_of_contraception_adopted.Reason, method_of_contraception_adopted.Remarks_Or_Refferals, staff_details.Staff_Name, method_of_contraception_adopted.Return_Date FROM staff_details, method_of_contraception_adopted, method_type, implant_type, injection_type, iucd_type, pill_type, spermicide_type, `basic_ information` WHERE staff_details.SDID = method_of_contraception_adopted.SDID AND method_of_contraception_adopted.MTID = method_type.MTID AND method_of_contraception_adopted.ITID = implant_type.ITID AND method_of_contraception_adopted.IID = injection_type.IID AND method_of_contraception_adopted.IUCDTID = iucd_type.IUCDTID AND method_of_contraception_adopted.PTID = pill_type.PTID AND method_of_contraception_adopted.STID = spermicide_type.STID AND method_of_contraception_adopted.BID = `basic_ information`.BID= ?"
                    .Parameters.Add("p1", OdbcType.BigInt, 45).Value = LBLMCAID.Text
                    DrClinics = .ExecuteReader
                End With

                If DrClinics.HasRows Then

                    'LblBID.Text = DrClinics.Item(0)
                    TxtMethodAdopted.Text = DrClinics.Item(0)
                    TxtPillType.Text = DrClinics.Item(1)
                    TxtPillCycles.Text = DrClinics.Item(2)
                    TxtIUCDType.Text = DrClinics.Item(3)
                    TxtIucdSize.Text = DrClinics.Item(4)
                    TxtInjectionType.Text = DrClinics.Item(5)
                    TxtInjectionNumberofmonths.Text = DrClinics.Item(6)
                    TxtSpermicidesType.Text = DrClinics.Item(7)
                    TxtSpermicideAmountIssued.Text = DrClinics.Item(8)
                    TxtImplantType.Text = DrClinics.Item(9)
                    TxtImplantNumberofYears.Text = DrClinics.Item(10)
                    cmbCondomType.Text = DrClinics.Item(11)
                    TxtCondomNoIssued.Text = DrClinics.Item(12)
                    TxtReasonsWhy.Text = DrClinics.Item(13)
                    RichTextBox1.Text = DrClinics.Item(14)
                    Txtprescriber.Text = DrClinics.Item(15)
                    DTPReturnDate.Text = DrClinics.Item(16)
                    CMBTakingMed.Text = DrClinics.Item(17)
                    TxtspecifyType.Text = DrClinics.Item(18)
                    LBLSDID.Text = DrClinics.Item(19)
                    LblMTID.Text = DrClinics.Item(20)
                    LblITID.Text = DrClinics.Item(21)
                    LBLIID.Text = DrClinics.Item(22)
                    LBLIUCDTID.Text = DrClinics.Item(23)
                    LBLPTID.Text = DrClinics.Item(24)
                    LBLSTID.Text = DrClinics.Item(25)
                    LblBID.Text = DrClinics.Item(26)

                Else
                    MsgBox("NO DATA")

                End If
                loadMethodOfContraceptionAdopted()
            Catch ex As Exception

                MessageBox.Show("Sorry.The current row does not contain any data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub
    'save revisit card
    Private Sub ToolStripLabel1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
       
        If TxtSpecifyReasonChange.Text = "" Then
            TxtSpecifyReasonChange.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "INSERT INTO `revisit_card`( `RevisitNo`, `CardNo`, `Date`, `Name`, `BID`, `ClinicNo`, `Blood_Pressure`, `Weight`, `Breast`, `Pap_Smear`, `Date_Of_LMP`, `MTID`, `MCAID`, `No_Of_Cycles`, `Size`, `No_Of_Months`, `No_Of_Issued`, `Amount_Issued`, `NoOfYears`, `Reasons_for_Change`, `Specify_Other`, `Remarks_Or_Refferals`, `SID`, `Return_Date`, `ITID`, `IID`, `PTID`, `IUCDID`, `STID`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtRevisitNo.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = TxtcardNoDisp.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DtpRevisitDate.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtName.Text
            .Parameters.Add("par", OdbcType.BigInt, 15).Value = LblBID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtClinicNo.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = txtbloodpressureRevisit.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtWeightRevisit.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtBreastRevisit.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPapSmearRevisit.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DtpDateLMPRevisit.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblMTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLMCAID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPillCycles.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtIucdSize.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtInjectionNumberofmonths.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtCondomNoIssued.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpermicideAmountIssued.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtImplantNumberofYears.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtResonsChange.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyReasonChange.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = txtRemarksRevisit.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSDID.Text
            .Parameters.Add("par", OdbcType.Date).Value = Format(DtpReturnDateRevisit.Value, "yyyy-MM-dd")
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblITID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLIID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLPTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLIUCDTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSTID.Text
 
            .ExecuteNonQuery()

        End With
        MyTrans.Commit()

        clearfieldRevisitCard()
    End Sub
    'update Revisit card
    Private Sub ToolStripLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel4.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtSpecifyReasonChange.Text = "" Then
            TxtSpecifyBreast.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "UPDATE `revisit_card` SET `RevisitNo`=?,`CardNo`=?,`Date`=?,`Name`=?,`BID`=?,`ClinicNo`=?,`Blood_Pressure`=?,`Weight`=?,`Breast`=?,`Pap_Smear`=?,`Date_Of_LMP`=?,`MTID`=?,`MCAID`=?,`No_Of_Cycles`=?,`Size`=?,`No_Of_Months`=?,`No_Of_Issued`=?,`Amount_Issued`=?,`NoOfYears`=?,`Reasons_for_Change`=?,`Specify_Other`=?,`Remarks_Or_Refferals`=?,`SDID`=?,`Return_Date`=?,`ITID`=?,`IID`=?,`PTID`=?,`IUCDID`=?,`STID`=? WHERE `RCID`=?"
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtRevisitNo.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = TxtcardNoDisp.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DtpRevisitDate.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtName.Text
            .Parameters.Add("par", OdbcType.BigInt, 15).Value = LblBID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtClinicNo.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = txtbloodpressureRevisit.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtWeightRevisit.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtBreastRevisit.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPapSmearRevisit.Text
            .Parameters.Add("par", OdbcType.DateTime).Value = Format(DtpDateLMPRevisit.Value, "yyyy-MM-dd HH:mm:ss")
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblMTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLMCAID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPillCycles.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtIucdSize.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtInjectionNumberofmonths.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtCondomNoIssued.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpermicideAmountIssued.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtImplantNumberofYears.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtResonsChange.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpecifyReasonChange.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = txtRemarksRevisit.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSDID.Text
            .Parameters.Add("par", OdbcType.Date).Value = Format(DtpReturnDateRevisit.Value, "yyyy-MM-dd")
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblITID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLIID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLPTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLIUCDTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSTID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()

        clearfieldRevisitCard()
    End Sub
    'delete revisit card
    Private Sub ToolStripLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel5.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `revisit_card` WHERE `RCID` =?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = lblRCID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()

        clearfieldRevisitCard()
    End Sub
    'Update method of cintraception adopted
    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        If TxtPillType.Text = "" Then
            TxtPillType.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtIUCDType.Text = "" Then
            TxtIUCDType.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtInjectionType.Text = "" Then
            TxtInjectionType.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtSpermicidesType.Text = "" Then
            TxtSpermicidesType.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtReasonsWhy.Text = "" Then
            TxtReasonsWhy.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtPillCycles.Text = "" Then
            TxtPillCycles.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtIucdSize.Text = "" Then
            TxtIucdSize.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtInjectionNumberofmonths.Text = "" Then
            TxtInjectionNumberofmonths.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtCondomNoIssued.Text = "" Then
            TxtCondomNoIssued.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtSpermicideAmountIssued.Text = "" Then
            TxtSpermicideAmountIssued.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If TxtImplantNumberofYears.Text = "" Then
            TxtImplantNumberofYears.Text = "N/A"
            MyTrans.Rollback()
            Exit Sub
        End If
        If cmbCondomType.SelectedIndex = 0 Or CMBMaritalStatus.Text = "-select-" Then
            MessageBox.Show("Select a valid Condom Type", "Data input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyTrans.Rollback()
            Exit Sub
        End If
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "UPDATE `method_of_contraception_adopted` SET `BID`=?,`MTID`=?,`No_Of_Cycle`=?,`Size`=?,`No_Of_Months`=?,`NO_Issued`=?,`Amount_Issued`=?,`Reason`=?,`Remarks_Or_Refferals`=?,`SDID`=?,`Return_Date`=?,`No_of_years`=?,`STID`=?,`IUCDTID`=?,`ITID`=?,`PTID`=?,`CondomType`=?,`IID`=? WHERE `MCAID`=?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblBID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblMTID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtPillCycles.Text
            .Parameters.Add("par", OdbcType.VarChar, 15).Value = TxtIucdSize.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtInjectionNumberofmonths.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtCondomNoIssued.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtSpermicideAmountIssued.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtReasonsWhy.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = RichTextBox1.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSDID.Text
            .Parameters.Add("par", OdbcType.Date).Value = Format(DTPReturnDate.Value, "yyyy-MM-dd")
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = TxtImplantNumberofYears.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLSTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLIUCDTID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LblITID.Text
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLPTID.Text
            .Parameters.Add("par", OdbcType.VarChar, 45).Value = cmbCondomType.Text
            .Parameters.Add("par", OdbcType.BigInt, 15).Value = LBLIID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadMethodOfContraceptionAdopted()
        clearfieldsmethodAdopted()
    End Sub
    'delete method of contraception adopted
    Private Sub ToolStripLabel11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel11.Click
        Dim MyTrans As OdbcTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim CMD As New OdbcCommand
        With CMD
            .Connection = conn
            .Transaction = MyTrans
            .CommandText = "DELETE FROM `method_of_contraception_adopted`  WHERE `MCAID` =?"
            .Parameters.Add("par", OdbcType.BigInt, 45).Value = LBLMCAID.Text

            .ExecuteNonQuery()

        End With
        MyTrans.Commit()
        loadMethodOfContraceptionAdopted()
        clearfieldsmethodAdopted()
    End Sub

    Private Sub ToolStripLabel10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel10.Click
        LoadExamination()
    End Sub

    Private Sub ToolStripLabel13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel13.Click
        loadMethodOfContraceptionAdopted()
    End Sub

    Private Sub ToolStripLabel12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel12.Click
        clearfieldsmethodAdopted()
    End Sub

    Private Sub ToolStripLabel14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel14.Click
        clearfieldRevisitCard()
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        With FrmSelector
            .Text = "Reasons or change or termination"
            .LblPointer.Text = 15
            .Show()
        End With
    End Sub
End Class
