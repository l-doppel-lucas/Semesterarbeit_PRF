﻿using semesterarbeit.Controller;
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

            //set dropdown items
            CmbMgmtLevel.DataSource = ;

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

            //Cast the selected object into  Type "Person"
            Person selectedPerson = (Person)LsbOutput.SelectedItem;

            //
            TxtSalutation.Text = selectedPerson.Salutation;
            TxtFirstname.Text = selectedPerson.Firstname;
            TxtLastname.Text = selectedPerson.Lastname;
            TxtBirthdate.Text = Convert.ToString(selectedPerson.Birthdate);
            TxtGender.Text = selectedPerson.Gender;
            TxtTitle.Text = selectedPerson.Title;
            TxtBusinessPhone.Text = selectedPerson.Businessphone;
            TxtBusinessFax.Text = selectedPerson.Businessfax;
            TxtMobileNumber.Text = selectedPerson.Mobilephone;
            TxtEmail.Text = selectedPerson.Mail;
            TxtCity.Text = selectedPerson.City;
            TxtStreet.Text = selectedPerson.Street;
            TxtZipcode.Text = Convert.ToString(selectedPerson.Zipcode);
            TxtCreationDate.Text = Convert.ToString(selectedPerson.CreationDate);
            TxtLastModified.Text = Convert.ToString(selectedPerson.ChangeHistory);

            // If the object is type of one of the subclasses (Employee, Apprentice or Customer) 
            switch (selectedPerson.GetClassName())
            {
                case "Employee":
                    //make all relevant textboxes and lables visible
                    ShowAllEmp();

                    //Hide irrelvant textboxes and lables
                    HideAllCust();
                    HideAllAppr();

                    //Cast the selected object of the list into type "Employee" and write into the variable "selectedEmployee"
                    Employee selectedEmployee = (Employee)selectedPerson;

                    //Write the properties of the object of type "Employee" into the specific textboxes
                    TxtDepartment.Text = selectedEmployee.Departement;
                    TxtAHVNumber.Text = selectedEmployee.Ahv;
                    TxtStartDate.Text = Convert.ToString(selectedEmployee.Entrydate);
                    TxtLeaveDate.Text = Convert.ToString(selectedEmployee.Exitdate);
                    TxtEmplNr.Text = Convert.ToString(selectedEmployee.EmplNr);
                    TxtBirthplace.Text = selectedEmployee.Birthplace;
                    TxtNationality.Text = selectedEmployee.Nationality;
                    TxtRole.Text = selectedEmployee.Role;
                    TxtMgmtLevel.Text = Convert.ToString(selectedEmployee.Lvl);
                    TxtWorkPensum.Text = selectedEmployee.Workpensum;
                    TxtPrivatePhone.Text = selectedEmployee.Privatephone;
                    break;
                case "Apprentice":
                    //make all relevant textboxes and lables visible
                    ShowAllEmp();
                    ShowAllAppr();

                    //Hide irrelvant textboxes and lables
                    HideAllCust();

                    //Cast the selected object of the list into type "Apprentice" and write into the variable "selectedApprentice"
                    Trainee selectedApprentice = (Trainee)selectedPerson;

                    //Write the properties of the object of type "Apprentice" into the specific textboxes
                    TxtDepartment.Text = selectedApprentice.Departement;
                    TxtAHVNumber.Text = selectedApprentice.Ahv;
                    TxtStartDate.Text = Convert.ToString(selectedApprentice.Entrydate);
                    TxtLeaveDate.Text = Convert.ToString(selectedApprentice.Exitdate);
                    TxtEmplNr.Text = Convert.ToString(selectedApprentice.EmplNr);
                    TxtBirthplace.Text = selectedApprentice.Birthplace;
                    TxtNationality.Text = selectedApprentice.Nationality;
                    TxtRole.Text = selectedApprentice.Role;
                    TxtMgmtLevel.Text = Convert.ToString(selectedApprentice.Lvl);
                    TxtWorkPensum.Text = selectedApprentice.Workpensum;
                    TxtPrivatePhone.Text = selectedApprentice.Privatephone;
                    TxtApprentYears.Text = Convert.ToString(selectedApprentice.Appyears);
                    TxtCurrentApprentYear.Text = Convert.ToString(selectedApprentice.Currappyear);
                    break;

                    case "Customer":
                    //make all relevant textboxes and lables visible
                    ShowAllCust();

                    //Hide irrelvant textboxes and lables
                    HideAllEmp();
                    HideAllAppr();

                    //Cast the selected object of the list into type "Customer" and write into the variable "selectedCustomer"
                    Customer selectedCustomer = (Customer)selectedPerson;

                    //Write the properties of the object of type "Customer" into the specific textboxes
                    TxtCompanyName.Text = selectedCustomer.Companyname;
                    TxtCustomerType.Text = Convert.ToString(selectedCustomer.Type);
                    TxtContacPerson.Text = selectedCustomer.Companycontact;
                    TxtNotesHistory.Text = selectedCustomer.NotesHistory;
                    break;
            }

            /*
            //Check if the user is active or not
            if (selectedPerson.Status == false)
            {
                //Call function for user status inactive
                DeactivateUser();
            }
            else if (selectedPerson.Status == true)
            {
                //Call function for user status active
                ActivateUser();
            }
            */
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
            //CmdAddUser.Enabled = false;
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
                        id,
                        Convert.ToString(CmbSalutation.SelectedItem),
                        TxtFirstname.Text,
                        TxtLastname.Text,
                        DtpBirthdate.Value, //Birthdate
                        DateTime.Now, //Creation date
                        Convert.ToString(CmbGender.SelectedItem),
                        TxtEmail.Text,
                        true, //User enabled
                        TxtStreet.Text,
                        TxtCity.Text,
                        Convert.ToInt32(TxtZipcode.Text),
                        Convert.ToString(DateTime.Now) + Environment.NewLine, //change history
                        Convert.ToInt32(TxtEmplNr.Text), //EmplNumber
                        Convert.ToString(CmbDepartment.SelectedItem),
                        TxtWorkPensum.Text,
                        DtpStartDate.Value, //EntryDate
                        TxtRole.Text
                    ) ;

                //Add Employee to contact list (database)
                Db.AddPerson(empl1);

                //Set optional fields
                

                //Deselect the affected radio button
                RadEmployee.Checked = false;
            }
            else if (RadTrainee.Checked)
            {
                //Increase the value of the variable id
                id++;
            }
            else if (RadCustomer.Checked)
            {
                //Increase the value of the variable id
                id++;
            }
            else
            {
                MessageBox.Show("Please select contact type!");
            }

            //Change buttons
            CmdAddUser.Visible = true;
            CmdSave.Visible = false;
            CmdCancel.Visible = false;

            //Activate buttons, combo boxes, and list boxes
            ChkStatus.Enabled = true;
            CmdTakeNotes.Enabled = true;
            LsbOutput.Enabled = true;
            CmdAddUser.Enabled = true;
            CmdDeleteUser.Enabled = true;
            CmdEditUser.Enabled = true;
            CmdExport.Enabled = true;
            CmdSearch.Enabled = true;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControl.SelectedIndex == 0)
            {
                HideButtons();
            }
            else
            {
                ShowButtons();
            }
        }

        private void ShowButtons ()
        {
            CmdAddUser.Visible = true;
            CmdDeleteUser.Visible = true;
            CmdEditUser.Visible = true;
            CmdExport.Visible = true;
            CmdSearch.Visible = true;
            TxtSearch.Visible = true;
            LblSearch.Visible = true;
            LsbOutput.Visible = true;
        }

        private void HideButtons ()
        {
            CmdAddUser.Visible = false;
            CmdDeleteUser.Visible = false;
            CmdEditUser.Visible = false;
            CmdExport.Visible = false;
            CmdSearch.Visible = false;
            TxtSearch.Visible = false;
            LblSearch.Visible = false;
            LsbOutput.Visible = false;
        }

        /*---------------------------------------------------------------------
         * Functions
         * -------------------------------------------------------------------*/

        //Set all mandatory attributes for employees
        public void SetAttributesEmp_mandatory(Person p)
        {
            //Cast person into employee
            Employee emp = (Employee)p;

            //Call method to set mandatory attributes
            emp.SetMandatoryAttributes(
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                birthdate: DtpBirthdate.Value,
                gender: Convert.ToString(CmbGender.SelectedItem),
                mail: TxtEmail.Text,
                street: TxtStreet.Text,
                city: TxtCity.Text,
                zip: Convert.ToInt32(TxtZipcode.Text),
                emplnum: Convert.ToInt32(TxtEmplNr.Text),
                departement: Convert.ToString(CmbDepartment.SelectedItem),
                role: TxtRole.Text,
                pens: Convert.ToString(CmbWorkPensum.SelectedItem),
                entrdate: DtpStartDate.Value
                );
        }

        //Set all optional attributes for employees
        public void SetOptionalAttributes(Person p)
        {
            //Cast person into employee
            Employee emp = (Employee)p;

            //Call method to set optional attributes
            emp.SetOptionalAttributes(
                    title: TxtTitle.Text,
                    mph: TxtMobileNumber.Text,
                    bph: TxtBusinessPhone.Text,
                    bfa: TxtBusinessFax.Text,
                    ahv: TxtAHVNumber.Text,
                    nat: TxtNationality.Text,
                    pph: TxtPrivatePhone.Text,
                    birthpl: TxtBirthplace.Text,
                    exdate: DtpLeaveDate.Value,
                    mgmtl: Convert.ToInt32(CmbMgmtLevel.SelectedItem)
                    );
        }
        
        //Set all mandatory attributes for Customers
        public void SetAttributesCust_mandatory(Person p)
        {
            //Cast person into customer
            Customer cust = (Customer)p;

            //Call method to set mandatory attributes
            cust.SetMandatoryAttributes(
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                birthdate: DtpBirthdate.Value,
                gender: Convert.ToString(CmbGender.SelectedItem),
                mail: TxtEmail.Text,
                street: TxtStreet.Text,
                city: TxtCity.Text,
                zip: Convert.ToInt32(TxtZipcode.Text),
                compname: TxtCompanyName.Text,
                type: (CustType)CmbCustomerType.SelectedItem
                );
        }

        //Set all optional attributes for customers
        /*
        public void SetAttributesCust_optional(Person p)
        {
            //Cast person into customer
            Customer cust = (Customer)p;

            //Call method to set optional attributes
            cust.SetOptionalAttributes(
                    t: TxtTitle.Text,
                    bp: TxtBusinessPhone.Text,
                    bf: TxtBusinessFax.Text,
                    mn: TxtMobileNumber.Text,
                    s: TxtStreet.Text,
                    cp: TxtContacPerson.Text
                    );
        }
        */
        //Function to set all mandatory attributes for apprentices
        public void SetAttributesAppr_mandatory(Person p)
        {
            //Cast person into Trainee
            Trainee appr = (Trainee)p;

            //Call method to set mandatory attributes
            appr.SetMandatoryAttributes(
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                birthdate: DtpBirthdate.Value,
                gender: Convert.ToString(CmbGender.SelectedItem),
                mail: TxtEmail.Text,
                street: TxtStreet.Text,
                city: TxtCity.Text,
                zip: Convert.ToInt32(TxtZipcode.Text),
                emplnum: Convert.ToInt32(TxtEmplNr.Text),
                departement: Convert.ToString(CmbDepartment.SelectedItem),
                role: TxtRole.Text,
                pens: Convert.ToString(CmbWorkPensum.SelectedItem),
                entrdate: DtpStartDate.Value,
                appyears: Convert.ToString(CmbApprentYears.SelectedItem)
                );
        }

        //Function to set all optional attributes for apprentices
        /*
        public void SetAttributesAppr_optional(Person p)
        {
            //Cast variable p from type "Person" into type "Apprentice" in new variable "appr"
            Trainee appr = (Trainee)p;

            //Call method to set optional attributes
            appr.SetOptionalAttributes(
                    t: TxtTitle.Text,
                    bp: TxtBusinessPhone.Text,
                    bf: TxtBusinessFax.Text,
                    mn: TxtMobileNumber.Text,
                    ahv: TxtAHVNumber.Text,
                    bipl: TxtBirthplace.Text,
                    nat: TxtNationality.Text,
                    mgmtl: Convert.ToString(CmbMgmtLevel.SelectedItem),
                    pf: TxtPrivatePhone.Text,
                    leavedate: Convert.ToString(DtpLeaveDate.Value.ToShortDateString()),
                    capry: Convert.ToString(CmbCurrentApprentYear.SelectedItem)
                    );
        }
        */
        /*---------------------------------------------------------------------
         * Radio Butoons
         * --------------------------------------------------------------------*/
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
            TxtEmplNr.ReadOnly = false;
            TxtBirthplace.ReadOnly = false;
            TxtNationality.ReadOnly = false;
            TxtRole.ReadOnly = false;
            TxtMgmtLevel.ReadOnly = false;
            TxtWorkPensum.ReadOnly = false;
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
            TxtEmplNr.ReadOnly = true;
            TxtBirthplace.ReadOnly = true;
            TxtNationality.ReadOnly = true;
            TxtRole.ReadOnly = true;
            TxtMgmtLevel.ReadOnly = true;
            TxtWorkPensum.ReadOnly = true;
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
            TxtEmplNr.Visible = false;
            TxtBirthplace.Visible = false;
            TxtNationality.Visible = false;
            TxtRole.Visible = false;
            TxtMgmtLevel.Visible = false;
            TxtWorkPensum.Visible = false;
            TxtPrivatePhone.Visible = false;
            LblDepartment.Visible = false;
            LblAHVNumber.Visible = false;
            LblStartDate.Visible = false;
            LblLeaveDate.Visible = false;
            LblEmplNr.Visible = false;
            LblBirthplace.Visible = false;
            LblNationality.Visible = false;
            LblRole.Visible = false;
            LblMgmtLevel.Visible = false;
            LblWorkPensum.Visible = false;
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
            TxtEmplNr.Visible = true;
            TxtBirthplace.Visible = true;
            TxtNationality.Visible = true;
            TxtRole.Visible = true;
            TxtMgmtLevel.Visible = true;
            TxtWorkPensum.Visible = true;
            TxtPrivatePhone.Visible = true;
            LblDepartment.Visible = true;
            LblAHVNumber.Visible = true;
            LblStartDate.Visible = true;
            LblLeaveDate.Visible = true;
            LblEmplNr.Visible = true;
            LblBirthplace.Visible = true;
            LblNationality.Visible = true;
            LblRole.Visible = true;
            LblMgmtLevel.Visible = true;
            LblWorkPensum.Visible = true;
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
            TxtEmplNr.ResetText();
            TxtBirthplace.ResetText();
            TxtNationality.ResetText();
            TxtRole.ResetText();
            TxtMgmtLevel.ResetText();
            TxtWorkPensum.ResetText();
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
            CmbMgmtLevel.Visible = true;
            CmbWorkPensum.Visible = true;
            DtpStartDate.Visible = true;
            DtpLeaveDate.Visible = true;

            //Set default selected item of combo box
            CmbDepartment.SelectedItem = TxtDepartment.Text;
            CmbMgmtLevel.SelectedItem = TxtMgmtLevel.Text;
            //CmbDirectReports.SelectedItem = TxtDirectReports.Text;
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
            CmbMgmtLevel.Visible = false;
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

        private void CmbMgmtLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
