using semesterarbeit.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semesterarbeit
{
    public partial class Dashboard : Form
    {
        //Create variable for id
        private int id;

        //Create Contact List for Listbox
        public Database Db = new Database();

        public Dashboard()
        {
            InitializeComponent();

            //Show contact list in database
            LsbOutput.DataSource = Db.contactList;

            //Get the last ID
            id = Db.ReturnLastID();

            //Disable all text boxes
            DisableAllTxtboxes();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        /*---------------------------------------------------------------------
        Listbox
        -----------------------------------------------------------------------*/
        private void LsbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select first entry
            if (LsbOutput.SelectedItem == null)
            {
                LsbOutput.SetSelected(0, true);
            }

            //Cast the selected object into  tyoe "Person"
            Person selectedPerson = (Person)LsbOutput.SelectedItem;

            //
            TxtSalutation.Text = selectedPerson.Salutation;
            TxtFirstname.Text = selectedPerson.Firstname;
            TxtSecondname.Text = selectedPerson.Secondname;
            TxtLastname.Text = selectedPerson.Lastname;
            TxtBirthdate.Text = Convert.ToString(selectedPerson.Birthdate);
            TxtGender.Text = selectedPerson.Gender;
            TxtTitle.Text = selectedPerson.Title;
            TxtBusinessPhone.Text = selectedPerson.BusinessPhone;
            TxtBusinessFax.Text = selectedPerson.BusinessFax;
            TxtMobileNumber.Text = selectedPerson.MobileNumber;
            TxtEmail.Text = selectedPerson.Email;
            TxtCity.Text = selectedPerson.City;
            TxtStreet.Text = selectedPerson.Street;
            TxtZipcode.Text = Convert.ToString(selectedPerson.Zipcode);
            TxtCreationDate.Text = Convert.ToString(selectedPerson.CreationDate);
            TxtLastModified.Text = Convert.ToString(selectedPerson.LastModified);
        }

        /*---------------------------------------------------------------------
        Buttons
        -----------------------------------------------------------------------*/
        private void CmdAddUser_Click(object sender, EventArgs e)
        {
            //Change buttons
            CmdAddUser.Visible = false;
            CmdSave.Visible = true;
            CmdCancel.Visible = true;

            //Uncheck radio buttons
            UncheckAllRad();

            //Enables all "Person" related fields
            EnableAllPers();

            //Clears all textboxes
            ClearAllTextboxes();

            //Makes all radio buttos visible
            ShowAllRad();

            //Makes all comboboxes visible
            ShowAllCmbPers();

            //Hides all "Apprentice", "Customer" and "Employee" related textboxes and labels
            HideAllAppr();
            HideAllCust();
            HideAllEmp();

            //Disables unusable buttons, combo boxes, and list boxes
            ChkStatus.Enabled = false;
            CmdTakeNotes.Enabled = false;
            LsbOutput.Enabled = false;
            CmdAddUser.Enabled = false;
            CmdDeleteUser.Enabled = false;
            CmdEditUser.Enabled = false;
            CmdExport.Enabled = false;
            CmdSearch.Enabled = false;
            
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            if(RadEmployee.Checked)
            {
                //Increase the value of the variable id
                id++;


                Employee empl1 = new Employee
                    (
                        true,
                        id,
                        TxtTitle.Text,
                        Convert.ToString(CmbSalutation.SelectedItem),
                        TxtFirstname.Text,
                        TxtLastname.Text,
                        DtpBirthdate.Value,


                    )
            }
            else if (RadTrainee.Checked)
            {

            }
            else if (RadCustomer.Checked)
            {

            }
            else
            {
                MessageBox.Show("Please select contact type!");
            }

            //Change buttons
            CmdAddUser.Visible = true;
            CmdSave.Visible = false;
            CmdCancel.Visible = false;
        }


        /*---------------------------------------------------------------------
        Radio Buttons
        -----------------------------------------------------------------------*/
        private void RadEmployee_CheckedChanged(object sender, EventArgs e)
        {
            //Make all Employee textboxes visible & enabled
            ShowAllEmp();
            EnableAllEmp();
            ShowAllCmbEmp();

            //hides all others
            HideAllAppr();
            HideAllCust();
            HideAllCmbCust();
            HideAllCmbAppr();
        }

        private void RadApprentice_CheckedChanged(object sender, EventArgs e)
        {
            //Make all Trainee textboxes visible & enabled
            ShowAllEmp();
            EnableAllEmp();
            ShowAllAppr();
            EnableAllAppr();
            ShowAllCmbEmp();
            ShowAllCmbAppr();

            //hides all others
            HideAllCust();
            HideAllCmbCust();
        }
        private void RadCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //Make all Customer textboxes visible & enabled
            ShowAllCust();
            EnableAllCust();
            ShowAllCmbCust();

            //hides all others
            HideAllAppr();
            HideAllEmp();
            HideAllCmbAppr();
            HideAllCmbEmp();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        /*---------------------------------------------------------------------
        Text Boxes and Labels
        -----------------------------------------------------------------------*/

        //Enables all Person Textboxes
        private void EnableAllPers()
        {
            TxtSalutation.ReadOnly = false;
            TxtFirstname.ReadOnly = false;
            TxtSecondname.ReadOnly = false;
            TxtLastname.ReadOnly = false;
            TxtBirthdate.ReadOnly = false;
            TxtGender.ReadOnly = false;
            TxtTitle.ReadOnly = false;
            TxtBusinessPhone.ReadOnly = false;
            TxtBusinessFax.ReadOnly = false;
            TxtMobileNumber.ReadOnly = false;
            TxtEmail.ReadOnly = false;
            TxtCity.ReadOnly = false;
            TxtStreet.ReadOnly = false;
            TxtZipcode.ReadOnly = false;
        }

        //Enables all Employee Textboxes
        private void EnableAllEmp()
        {
            TxtDepartment.ReadOnly = false;
            TxtAHVNumber.ReadOnly = false;
            TxtStartDate.ReadOnly = false;
            TxtLeaveDate.ReadOnly = false;
            TxtDenomination.ReadOnly = false;
            TxtBirthplace.ReadOnly = false;
            TxtNationality.ReadOnly = false;
            TxtRole.ReadOnly = false;
            TxtMgmtLevel.ReadOnly = false;
            TxtDirectReports.ReadOnly = false;
            TxtWorkPensum.ReadOnly = false;
            TxtCivilStatus.ReadOnly = false;
            TxtPrivatePhone.ReadOnly = false;
        }

        //Enables all Customer Textboxes
        private void EnableAllCust()
        {
            TxtCompanyName.ReadOnly = false;
            TxtCustomerType.ReadOnly = false;
            TxtContacPerson.ReadOnly = false;
        }

        //Enables all Apprentice Textboxes
        private void EnableAllAppr()
        {
            TxtApprentYears.ReadOnly = false;
            TxtCurrentApprentYear.ReadOnly = false;
        }

        //Enable all textboxes
        private void EnableAllTxtboxes()
        {
            EnableAllAppr();
            EnableAllCust();
            EnableAllEmp();
            EnableAllPers();
        }

        //Disables all Employee Textboxes
        private void DisableAllPers()
        {
            TxtSalutation.ReadOnly = true;
            TxtFirstname.ReadOnly = true;
            TxtSecondname.ReadOnly = true;
            TxtLastname.ReadOnly = true;
            TxtBirthdate.ReadOnly = true;
            TxtGender.ReadOnly = true;
            TxtTitle.ReadOnly = true;
            TxtBusinessPhone.ReadOnly = true;
            TxtBusinessFax.ReadOnly = true;
            TxtMobileNumber.ReadOnly = true;
            TxtEmail.ReadOnly = true;
            TxtCity.ReadOnly = true;
            TxtStreet.ReadOnly = true;
            TxtZipcode.ReadOnly = true;
        }

        //Disable all Employee Textboxes
        private void DisableAllEmp()
        {
            TxtDepartment.ReadOnly = true;
            TxtAHVNumber.ReadOnly = true;
            TxtStartDate.ReadOnly = true;
            TxtLeaveDate.ReadOnly = true;
            TxtDenomination.ReadOnly = true;
            TxtBirthplace.ReadOnly = true;
            TxtNationality.ReadOnly = true;
            TxtRole.ReadOnly = true;
            TxtMgmtLevel.ReadOnly = true;
            TxtDirectReports.ReadOnly = true;
            TxtWorkPensum.ReadOnly = true;
            TxtCivilStatus.ReadOnly = true;
            TxtPrivatePhone.ReadOnly = true;
        }

        //Disables all Customer Textboxes
        private void DisableAllCust()
        {
            TxtCompanyName.ReadOnly = true;
            TxtCustomerType.ReadOnly = true;
            TxtContacPerson.ReadOnly = true;
        }

        //Disables all Apprentice Textboxes
        private void DisableAllAppr()
        {
            TxtApprentYears.ReadOnly = true;
            TxtCurrentApprentYear.ReadOnly = true;
        }

        //Disables all textboxes
        private void DisableAllTxtboxes()
        {
            DisableAllAppr();
            DisableAllCust();
            DisableAllEmp();
            DisableAllPers();
        }

        //Hide all Employee textboxes and labels
        private void HideAllEmp()
        {
            TxtDepartment.Visible = false;
            TxtAHVNumber.Visible = false;
            TxtStartDate.Visible = false;
            TxtLeaveDate.Visible = false;
            TxtDenomination.Visible = false;
            TxtBirthplace.Visible = false;
            TxtNationality.Visible = false;
            TxtRole.Visible = false;
            TxtMgmtLevel.Visible = false;
            TxtDirectReports.Visible = false;
            TxtWorkPensum.Visible = false;
            TxtCivilStatus.Visible = false;
            TxtPrivatePhone.Visible = false;
            LblDepartment.Visible = false;
            LblAHVNumber.Visible = false;
            LblStartDate.Visible = false;
            LblLeaveDate.Visible = false;
            LblDenomination.Visible = false;
            LblBirthplace.Visible = false;
            LblNationality.Visible = false;
            LblRole.Visible = false;
            LblMgmtLevel.Visible = false;
            LblDirectReports.Visible = false;
            LblWorkPensum.Visible = false;
            LblCivilStatus.Visible = false;
            LblPrivatePhone.Visible = false;
        }

        //Hides all Customer textboxes and labels
        private void HideAllCust()
        {
            TxtCompanyName.Visible = false;
            TxtCustomerType.Visible = false;
            TxtContacPerson.Visible = false;
            LblCompanyName.Visible = false;
            LblCustomerType.Visible = false;
            LblContactPerson.Visible = false;
            CmdTakeNotes.Visible = false;
            TxtNotes.Visible = false;
            TxtNotesHistory.Visible = false;
            LblNotesHistory.Visible = false;
        }

        //Hide all Apprentice textboxes and labels
        private void HideAllAppr()
        {
            TxtApprentYears.Visible = false;
            TxtCurrentApprentYear.Visible = false;
            LblApprentYears.Visible = false;
            LblCurrentApprentYear.Visible = false;
        }

        //Make all Employee textboxes and labels visible
        private void ShowAllEmp()
        {
            TxtDepartment.Visible = true;
            TxtAHVNumber.Visible = true;
            TxtStartDate.Visible = true;
            TxtLeaveDate.Visible = true;
            TxtDenomination.Visible = true;
            TxtBirthplace.Visible = true;
            TxtNationality.Visible = true;
            TxtRole.Visible = true;
            TxtMgmtLevel.Visible = true;
            TxtDirectReports.Visible = true;
            TxtWorkPensum.Visible = true;
            TxtCivilStatus.Visible = true;
            TxtPrivatePhone.Visible = true;
            LblDepartment.Visible = true;
            LblAHVNumber.Visible = true;
            LblStartDate.Visible = true;
            LblLeaveDate.Visible = true;
            LblDenomination.Visible = true;
            LblBirthplace.Visible = true;
            LblNationality.Visible = true;
            LblRole.Visible = true;
            LblMgmtLevel.Visible = true;
            LblDirectReports.Visible = true;
            LblWorkPensum.Visible = true;
            LblCivilStatus.Visible = true;
            LblPrivatePhone.Visible = true;
        }

        //Make all Customer textboxes and labels visible
        private void ShowAllCust()
        {
            TxtCompanyName.Visible = true;
            TxtCustomerType.Visible = true;
            TxtContacPerson.Visible = true;
            LblCompanyName.Visible = true;
            LblCustomerType.Visible = true;
            LblContactPerson.Visible = true;
            CmdTakeNotes.Visible = true;
            TxtNotes.Visible = true;
            TxtNotesHistory.Visible = true;
            LblNotesHistory.Visible = true;
        }

        //Make all Apprentice textboxes and labels visible
        private void ShowAllAppr()
        {
            TxtApprentYears.Visible = true;
            TxtCurrentApprentYear.Visible = true;
            LblApprentYears.Visible = true;
            LblCurrentApprentYear.Visible = true;
        }

        //Clear all textboxes
        private void ClearAllTextboxes()
        {
            TxtSalutation.ResetText();
            TxtFirstname.ResetText();
            TxtSecondname.ResetText();
            TxtLastname.ResetText();
            TxtBirthdate.ResetText();
            TxtGender.ResetText();
            TxtTitle.ResetText();
            TxtBusinessPhone.ResetText();
            TxtBusinessFax.ResetText();
            TxtMobileNumber.ResetText();
            TxtEmail.ResetText();
            TxtCity.ResetText();
            TxtStreet.ResetText();
            TxtZipcode.ResetText();
            TxtDepartment.ResetText();
            TxtAHVNumber.ResetText();
            TxtStartDate.ResetText();
            TxtLeaveDate.ResetText();
            TxtDenomination.ResetText();
            TxtBirthplace.ResetText();
            TxtNationality.ResetText();
            TxtRole.ResetText();
            TxtMgmtLevel.ResetText();
            TxtDirectReports.ResetText();
            TxtWorkPensum.ResetText();
            TxtCivilStatus.ResetText();
            TxtPrivatePhone.ResetText();
            TxtCompanyName.ResetText();
            TxtCustomerType.ResetText();
            TxtContacPerson.ResetText();
            TxtApprentYears.ResetText();
            TxtCurrentApprentYear.ResetText();
        }

        //Make all radio buttons visible
        private void ShowAllRad()
        {
            RadTrainee.Visible = true;
            RadCustomer.Visible = true;
            RadEmployee.Visible = true;
        }

        //Hide all radio buttons 
        private void HideAllRad()
        {
            RadTrainee.Visible = false;
            RadCustomer.Visible = false;
            RadEmployee.Visible = false;
        }

        //Uncheck all redio buttons
        private void UncheckAllRad()
        {
            RadTrainee.Checked = false;
            RadCustomer.Checked = false;
            RadEmployee.Checked = false;

            HideAllAppr();
            HideAllCmbAppr();
            HideAllCust();
            HideAllEmp();
            HideAllCmbEmp();
        }

        /*
        //Make the button Reset Search Results and lable visible
        private void ShowResetSearchResults()
        {
            CmdResetSearchResults.Visible = true;
            LblResetSearchResults.Visible = true;
        }

        //Hide the button Reset Search Results and lable
        private void HideResetSearchResults()
        {
            CmdResetSearchResults.Visible = false;
            LblResetSearchResults.Visible = false;
        }
        */


        //Make all Person combo boxes visible 
        private void ShowAllCmbPers()
        {
            CmbSalutation.Visible = true;
            CmbGender.Visible = true;
            DtpBirthdate.Visible = true;

            //Set default selected item of combo box
            CmbSalutation.SelectedItem = TxtSalutation.Text;
            CmbGender.SelectedItem = TxtGender.Text;

            //Set default selected value of date time picker
            if (TxtBirthdate.Text != "")
                DtpBirthdate.Value = Convert.ToDateTime(TxtBirthdate.Text);
            else
                DtpBirthdate.Value = Convert.ToDateTime("01.01.1990");
        }

        //Hide all Person combo boxes 
        private void HideAllCmbPers()
        {
            CmbSalutation.Visible = false;
            CmbGender.Visible = false;
            DtpBirthdate.Visible = false;
        }

        //Make all Customer combo boxes visible 
        private void ShowAllCmbCust()
        {
            CmbCustomerType.Visible = true;

            //Set default selected item of combo box
            CmbCustomerType.SelectedItem = TxtCustomerType.Text;
        }

        //Hide all Customer combo boxes 
        private void HideAllCmbCust()
        {
            CmbCustomerType.Visible = false;
        }

        //Make all Employee combo boxes visible 
        private void ShowAllCmbEmp()
        {
            CmbDepartment.Visible = true;
            CmbCivilStatus.Visible = true;
            CmbMgmtLevel.Visible = true;
            CmbDirectReports.Visible = true;
            CmbWorkPensum.Visible = true;
            DtpStartDate.Visible = true;
            DtpLeaveDate.Visible = true;

            //Set default selected item of combo box
            CmbDepartment.SelectedItem = TxtDepartment.Text;
            CmbCivilStatus.SelectedItem = TxtCivilStatus.Text;
            CmbMgmtLevel.SelectedItem = TxtMgmtLevel.Text;
            CmbDirectReports.SelectedItem = TxtDirectReports.Text;
            CmbWorkPensum.SelectedItem = TxtWorkPensum.Text;

            //Set default selected value of date time picker
            if (TxtStartDate.Text != "")
                DtpStartDate.Value = Convert.ToDateTime(TxtStartDate.Text);
            else
                DtpStartDate.Value = Convert.ToDateTime("01.01.2022");

            if (TxtLeaveDate.Text != "")
                DtpLeaveDate.Value = Convert.ToDateTime(TxtLeaveDate.Text);
            else
                DtpLeaveDate.Value = Convert.ToDateTime("01.01.2022");
        }

        //Hide all Employee combo boxes
        private void HideAllCmbEmp()
        {
            CmbDepartment.Visible = false;
            CmbCivilStatus.Visible = false;
            CmbMgmtLevel.Visible = false;
            CmbDirectReports.Visible = false;
            CmbWorkPensum.Visible = false;
            DtpStartDate.Visible = false;
            DtpLeaveDate.Visible = false;
        }
        //Make all Person combo boxes visible
        private void ShowAllCmbAppr()
        {
            CmbApprentYears.Visible = true;
            CmbCurrentApprentYear.Visible = true;

            //Set default selected item of combo box
            CmbApprentYears.SelectedItem = TxtApprentYears.Text;
            CmbCurrentApprentYear.SelectedItem = TxtCurrentApprentYear.Text;
        }

        //Hide all Apprentice combo boxes 
        private void HideAllCmbAppr()
        {
            CmbApprentYears.Visible = false;
            CmbCurrentApprentYear.Visible = false;
        }


    }
}
