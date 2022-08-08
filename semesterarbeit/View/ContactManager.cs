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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CmdAddUser_Click(object sender, EventArgs e)
        {

        }

        /*---------------------------------------------------------------------
        Text Boxes and Labels
        -----------------------------------------------------------------------*/

        //Enables all Person fields
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

        //Enables all Employee fields
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

        //Enables all Customer fields
        private void EnableAllCust()
        {
            TxtCompanyName.ReadOnly = false;
            TxtCustomerType.ReadOnly = false;
            TxtContacPerson.ReadOnly = false;
        }

        //Enables all Apprentice fields
        private void EnableAllAppr()
        {
            TxtApprentYears.ReadOnly = false;
            TxtCurrentApprentYear.ReadOnly = false;
        }

        //Disables all Employee fields
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

        //Disable all Employee fields
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

        //Disables all Customer fields
        private void DisableAllCust()
        {
            TxtCompanyName.ReadOnly = true;
            TxtCustomerType.ReadOnly = true;
            TxtContacPerson.ReadOnly = true;
        }

        //Disables all Apprentice fields
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

        //Function which hides all "Employee" related textboxes and labels
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

        //Function which hides all "Customer" related textboxes and labels
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

        //Function which hides all "Apprentice" related textboxes and labels
        private void HideAllAppr()
        {
            TxtApprentYears.Visible = false;
            TxtCurrentApprentYear.Visible = false;
            LblApprentYears.Visible = false;
            LblCurrentApprentYear.Visible = false;
        }

        //Function which makes all "Employee" related textboxes and labels visible
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

        //Function which makes all "Customer" related textboxes and labels visible
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

        //Function which makes all "Apprentice" related textboxes and labels visible
        private void ShowAllAppr()
        {
            TxtApprentYears.Visible = true;
            TxtCurrentApprentYear.Visible = true;
            LblApprentYears.Visible = true;
            LblCurrentApprentYear.Visible = true;
        }

        //Function which clears all textboxes
        private void ClearAllTextboxes()
        {
            TxtSalutation.Text = "";
            TxtFirstname.Text = "";
            TxtSecondname.Text = "";
            TxtLastname.Text = "";
            TxtBirthdate.Text = "";
            TxtGender.Text = "";
            TxtTitle.Text = "";
            TxtBusinessPhone.Text = ""; ;
            TxtBusinessFax.Text = "";
            TxtMobileNumber.Text = "";
            TxtEmail.Text = "";
            TxtCity.Text = "";
            TxtStreet.Text = "";
            TxtZipcode.Text = "";
            TxtDepartment.Text = "";
            TxtAHVNumber.Text = "";
            TxtStartDate.Text = "";
            TxtLeaveDate.Text = "";
            TxtDenomination.Text = "";
            TxtBirthplace.Text = "";
            TxtNationality.Text = "";
            TxtRole.Text = "";
            TxtMgmtLevel.Text = "";
            TxtDirectReports.Text = "";
            TxtWorkPensum.Text = "";
            TxtCivilStatus.Text = "";
            TxtPrivatePhone.Text = "";
            TxtCompanyName.Text = "";
            TxtCustomerType.Text = "";
            TxtContacPerson.Text = "";
            TxtApprentYears.Text = "";
            TxtCurrentApprentYear.Text = "";
        }

        //Function which makes all radio buttons visible
        private void ShowAllRad()
        {
            RadApprentice.Visible = true;
            RadCustomer.Visible = true;
            RadEmployee.Visible = true;
        }

        //Function which hides all radio buttons 
        private void HideAllRad()
        {
            RadApprentice.Visible = false;
            RadCustomer.Visible = false;
            RadEmployee.Visible = false;
        }

        //Function to make the button "Reset Search Results" and lable visible
        private void ShowResetSearchResults()
        {
            CmdResetSearchResults.Visible = true;
            LblResetSearchResults.Visible = true;
        }

        //Function to hide the button "Reset Search Results" and lable
        private void HideResetSearchResults()
        {
            CmdResetSearchResults.Visible = false;
            LblResetSearchResults.Visible = false;
        }

        //Function to make all combo boxes visible (Person)
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
                DtpBirthdate.Value = Convert.ToDateTime("01.01.1900");
        }

        //Function to hide all combo boxes (Person)
        private void HideAllCmbPers()
        {
            CmbSalutation.Visible = false;
            CmbGender.Visible = false;
            DtpBirthdate.Visible = false;
        }

        //Function to make all combo boxes visible (Customer)
        private void ShowAllCmbCust()
        {
            CmbCustomerType.Visible = true;

            //Set default selected item of combo box
            CmbCustomerType.SelectedItem = TxtCustomerType.Text;
        }

        //Function to hide all combo boxes (Customer)
        private void HideAllCmbCust()
        {
            CmbCustomerType.Visible = false;
        }

        //Function to make all combo boxes visible (Employee)
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
                DtpStartDate.Value = Convert.ToDateTime("01.01.1900");

            if (TxtLeaveDate.Text != "")
                DtpLeaveDate.Value = Convert.ToDateTime(TxtLeaveDate.Text);
            else
                DtpLeaveDate.Value = Convert.ToDateTime("01.01.1900");
        }

        //Function to hide all combo boxes (Employee)
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
        //Function to make all combo boxes visible (Apprentice)
        private void ShowAllCmbAppr()
        {
            CmbApprentYears.Visible = true;
            CmbCurrentApprentYear.Visible = true;

            //Set default selected item of combo box
            CmbApprentYears.SelectedItem = TxtApprentYears.Text;
            CmbCurrentApprentYear.SelectedItem = TxtCurrentApprentYear.Text;
        }

        //Function to hide all combo boxes (Apprentice)
        private void HideAllCmbAppr()
        {
            CmbApprentYears.Visible = false;
            CmbCurrentApprentYear.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
