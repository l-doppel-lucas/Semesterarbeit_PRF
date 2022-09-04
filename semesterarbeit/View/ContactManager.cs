﻿using semesterarbeit.Controller;
using System;
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

            //Setting the Values in Combobox to the Enum Values
            //source: https://stackoverflow.com/questions/906899/binding-an-enum-to-a-winforms-combo-box-and-then-setting-it
            CmbMgmtLevel.DataSource = Enum.GetValues(typeof(MgmLvl));

            //Setting the Values in Combobox to the Enum Values
            //source: https://stackoverflow.com/questions/906899/binding-an-enum-to-a-winforms-combo-box-and-then-setting-it
            CmbCustomerType.DataSource = Enum.GetValues(typeof(CustType));

            //Import person objects on the start of the program
            if (Db.Deserialisation() == false) { MessageBox.Show("No existing Contacts!"); }

            //Show contact list in database
            LsbOutput.DataSource = Db.contactList;

            //Get the last ID
            id = Db.ReturnLastID();

            //Disable all
            DisableALl();

            //Show dashboard data
            SetDashboardNumbers();

            //Set datasource for Datagrid
            DgrdBrowse.DataSource = Db.contactList;
            DgrdBrowse.ReadOnly = true;
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        /*---------------------------------------------------------------------
        Listbox
        -----------------------------------------------------------------------*/
        private void LsbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hide comboboxes and date pickers
            HideAllCmbPers();

            //disable all fields
            DisableALl();

            //Cast the selected object into  Type "Person"
            Person selectedPerson = (Person)LsbOutput.SelectedItem;

            //Write person fields into text boxes
            TxtSalutation.Text = selectedPerson.Salutation;
            TxtFirstname.Text = selectedPerson.Firstname;
            TxtLastname.Text = selectedPerson.Lastname;
            TxtBirthdate.Text = selectedPerson.Birthdate.ToShortDateString();
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


            // If the object is type of one of the subclasses (Employee, Trainee or Customer) 
            switch (selectedPerson.GetClassName())
            {
                case "Employee":
                    //make all relevant textboxes and lables visible
                    ShowAllEmp();

                    //Hide irrelvant textboxes and lables
                    HideAllCust();
                    HideAllTrnee();

                    //Hide comboboxes and date pickers
                    HideAllCmbEmp();

                    //Cast the selected object of the list into type "Employee" and write into the variable "selectedEmployee"
                    Employee selectedEmployee = (Employee)selectedPerson;

                    //Select radio button
                    RadEmployee.Checked = true;

                    //Write the properties of the object of type "Employee" into the specific textboxes
                    TxtDepartment.Text = selectedEmployee.Departement;
                    TxtAHVNumber.Text = selectedEmployee.Ahv;
                    TxtStartDate.Text = selectedEmployee.Entrydate.ToShortDateString();
                    TxtLeaveDate.Text = selectedEmployee.Exitdate.ToShortDateString();
                    TxtEmplNr.Text = Convert.ToString(selectedEmployee.EmplNr);
                    TxtBirthplace.Text = selectedEmployee.Birthplace;
                    TxtNationality.Text = selectedEmployee.Nationality;
                    TxtRole.Text = selectedEmployee.Role;
                    TxtMgmtLevel.Text = selectedEmployee.Lvl.ToString();
                    TxtWorkPensum.Text = selectedEmployee.Workpensum;
                    TxtPrivatePhone.Text = selectedEmployee.Privatephone;
                    break;
                case "Trainee":
                    //make all relevant textboxes and lables visible
                    ShowAllEmp();
                    ShowAllTrnee();

                    //Hide irrelvant textboxes and lables
                    HideAllCust();

                    //Hide comboboxes and date pickers
                    HideAllCmbTrnee();

                    //Cast the selected object of the list into type "Trainee" and write into the variable "selectedTrainee"
                    Trainee selectedTrainee = (Trainee)selectedPerson;

                    //Select radio button
                    RadTrainee.Checked = true;

                    //Write the properties of the object of type "Trainee" into the specific textboxes
                    TxtDepartment.Text = selectedTrainee.Departement;
                    TxtAHVNumber.Text = selectedTrainee.Ahv;
                    TxtStartDate.Text = Convert.ToString(selectedTrainee.Entrydate);
                    TxtLeaveDate.Text = Convert.ToString(selectedTrainee.Exitdate);
                    TxtEmplNr.Text = Convert.ToString(selectedTrainee.EmplNr);
                    TxtBirthplace.Text = selectedTrainee.Birthplace;
                    TxtNationality.Text = selectedTrainee.Nationality;
                    TxtRole.Text = selectedTrainee.Role;
                    TxtMgmtLevel.Text = Convert.ToString(selectedTrainee.Lvl);
                    TxtWorkPensum.Text = selectedTrainee.Workpensum;
                    TxtPrivatePhone.Text = selectedTrainee.Privatephone;
                    TxtApprentYears.Text = Convert.ToString(selectedTrainee.Appyears);
                    TxtCurrentApprentYear.Text = Convert.ToString(selectedTrainee.Currappyear);
                    break;

                    case "Customer":
                    //make all relevant textboxes and lables visible
                    ShowAllCust();

                    //Hide irrelvant textboxes and lables
                    HideAllEmp();
                    HideAllTrnee();

                    //Hide comboboxes and date pickers
                    HideAllCmbCust();

                    //Cast the selected object of the list into type "Customer" and write into the variable "selectedCustomer"
                    Customer selectedCustomer = (Customer)selectedPerson;

                    //Select radio button
                    RadCustomer.Checked = true;

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

            //Hides all "Trainee", "Customer" and "Employee" related textboxes and labels
            HideAllTrnee();
            HideAllCust();
            HideAllEmp();

            //Disables unusable buttons, combo boxes, and list boxes
            ChkStatus.Enabled = false;
            CmdTakeNotes.Enabled = false;
            LsbOutput.Enabled = false;
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
                {
                        Id = id,
                        Salutation = Convert.ToString(CmbSalutation.SelectedItem),
                        Firstname = TxtFirstname.Text,
                        Lastname = TxtLastname.Text,
                        Birthdate = DtpBirthdate.Value, //Birthdate
                        CreationDate = DateTime.Now, //Creation date
                        Gender = Convert.ToString(CmbGender.SelectedItem),
                        Mail = TxtEmail.Text,
                        Status = true, //User enabled
                        Street = TxtStreet.Text,
                        City = TxtCity.Text,
                        Zipcode = TxtZipcode.Text,
                        ChangeHistory = Convert.ToString(DateTime.Now) + Environment.NewLine, //change history
                        EmplNr = Convert.ToInt32(TxtEmplNr.Text), //EmplNumber
                        Departement = Convert.ToString(CmbDepartment.SelectedItem),
                        Workpensum = CmbWorkPensum.SelectedText,
                        Entrydate = DtpStartDate.Value, //EntryDate
                        Role = TxtRole.Text
                };

                //Add Employee to contact list (database)
                Db.AddPerson(empl1);

                //Call method to save the new object on the harddisk
                Db.Serialisation();

                //Set optional fields
                SetAttributesEmpl_optional(empl1);

            }
            else if (RadTrainee.Checked)
            {
                //Increase the value of the variable id
                id++;

                Trainee train1 = new Trainee
                {
                        Id = id,
                        Salutation = Convert.ToString(CmbSalutation.SelectedItem),
                        Firstname = TxtFirstname.Text,
                        Lastname = TxtLastname.Text,
                        Birthdate = DtpBirthdate.Value, //Birthdate
                        CreationDate = DateTime.Now, //Creation date
                        Gender = Convert.ToString(CmbGender.SelectedItem),
                        Mail = TxtEmail.Text,
                        Status = true, //User enabled
                        Street = TxtStreet.Text,
                        City = TxtCity.Text,
                        Zipcode = TxtZipcode.Text,
                        ChangeHistory = Convert.ToString(DateTime.Now) + Environment.NewLine, //change history
                        EmplNr = Convert.ToInt32(TxtEmplNr.Text), //EmplNumber
                        Departement = Convert.ToString(CmbDepartment.SelectedItem),
                        Workpensum = Convert.ToString(CmbWorkPensum.SelectedItem),
                        Entrydate = DtpStartDate.Value, //EntryDate
                        Role = TxtRole.Text,
                        Appyears = CmbApprentYears.SelectedText
                };

                //Add Customer to contact list (database)
                Db.AddPerson(train1);

                //Call method to save the new object on the harddisk
                Db.Serialisation();

                //Set optional fields
                SetAttributesTrainee_optional(train1);
            }
            else if (RadCustomer.Checked)
            {
                //Increase the value of the variable id
                id++;

                Customer cust1 = new Customer
                {
                    Id = id,
                    Salutation = Convert.ToString(CmbSalutation.SelectedItem),
                    Firstname = TxtFirstname.Text,
                    Lastname = TxtLastname.Text,
                    Birthdate = DtpBirthdate.Value, //Birthdate
                    CreationDate = DateTime.Now, //Creation date
                    Gender = Convert.ToString(CmbGender.SelectedItem),
                    Mail = TxtEmail.Text,
                    Status = true, //User enabled
                    Street = TxtStreet.Text,
                    City = TxtCity.Text,
                    Zipcode = TxtZipcode.Text,
                    ChangeHistory = Convert.ToString(DateTime.Now) + Environment.NewLine, //change history
                    Companyname = TxtCompanyName.Text,
                    Type = (CustType)CmbCustomerType.SelectedValue,
                    Companycontact = TxtContacPerson.Text
                };

                //Add Customer to contact list (database)
                Db.AddPerson(cust1);

                //Call method to save the new object on the harddisk
                Db.Serialisation();

                //Set optional fields
                SetAttributesCust_optional(cust1);
            }
            else
            {
                MessageBox.Show("Please select contact type!");
            }

            //Change buttons
            CmdAddUser.Visible = true;
            CmdEditUser.Visible = true;
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

            //disable all fields
            DisableALl();

            //Update Dashboard Numbers
            SetDashboardNumbers();
        }
        private void CmdEditUser_Click(object sender, EventArgs e)
        {
            CmdAddUser.Visible = false;
            CmdEditUser.Visible = false;
            CmdSave.Visible = true;
            CmdCancel.Visible = true;

            //Show all Comboboxes and enable them
            ShowAllCmbPers();
            EnableAllCmb();


            //Makes all radio buttos visible
            ShowAllRad();

            RadCustomer.Enabled = true;
            RadEmployee.Enabled = true;
            RadTrainee.Enabled = true;

            EnableAllPers();


            if (RadEmployee.Checked)
            {
                DisableALl();
                EnableAllEmp();
            }
            else if (RadTrainee.Checked)
            {
                DisableALl();
                EnableAllTrnee();
            }
            else if (RadCustomer.Checked)
            {
                DisableALl();
                EnableAllCust();
            }


            //Call method to update the Object on the HDD
            Db.Serialisation();
        }

        private void CmdDeleteUser_Click(object sender, EventArgs e)
        {
            //Variable of type "Person" which is containing the object of the currently selected item in the listbox
            Person selectedPerson = (Person)LsbOutput.SelectedItem;

            //Call function to delete the user
            Db.DeletePerson(selectedPerson);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            ShowStartScreen();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControl.SelectedIndex == 0)
            {
                HideButtons();
            }
            else if(TabControl.SelectedIndex == 1)
            {
                ShowButtons();

                ShowStartScreen();
            }
            else if(TabControl.SelectedIndex == 2)
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
        private void SetAttributesEmp_mandatory(Person p)
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
                zip: TxtZipcode.Text,
                changehistory: emp.ChangeHistory + DateTime.Now.ToString() + Environment.NewLine,
                emplnum: Convert.ToInt32(TxtEmplNr.Text),
                departement: Convert.ToString(CmbDepartment.SelectedItem),
                role: TxtRole.Text,
                pens: Convert.ToString(CmbWorkPensum.SelectedItem),
                entrdate: DtpStartDate.Value
                );
        }

        //Set all optional attributes for employees
        private void SetAttributesEmpl_optional(Person p)
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
                    lvl: (MgmLvl) CmbMgmtLevel.SelectedItem
                    );
        }
        
        //Set all mandatory attributes for Customers
        private void SetAttributesCust_mandatory(Person p)
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
                zip: TxtZipcode.Text,
                changehistory: cust.ChangeHistory + DateTime.Now.ToString() + Environment.NewLine,
                compname: TxtCompanyName.Text,
                type: (CustType)CmbCustomerType.SelectedItem
                );
        }

        //Set all optional attributes for customers
        private void SetAttributesCust_optional(Person p)
        {
            //Cast person into customer
            Customer cust = (Customer)p;

            //Call method to set optional attributes
            cust.SetOptionalAttributes(
                    title: TxtTitle.Text,
                    mph: TxtMobileNumber.Text, 
                    bph: TxtBusinessPhone.Text,
                    bfa : TxtBusinessFax.Text,
                    compcont: TxtContacPerson.Text
                    );
        }
        
        //Function to set all mandatory attributes for trainees
        private void SetAttributesTrainee_mandatory(Person p)
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
                zip: TxtZipcode.Text,
                changehistory: appr.ChangeHistory + DateTime.Now.ToString() + Environment.NewLine,
                emplnum: Convert.ToInt32(TxtEmplNr.Text),
                departement: Convert.ToString(CmbDepartment.SelectedItem),
                role: TxtRole.Text,
                pens: Convert.ToString(CmbWorkPensum.SelectedItem),
                entrdate: DtpStartDate.Value,
                appyears: Convert.ToString(CmbApprentYears.SelectedItem)
                );
        }

        //Function to set all optional attributes for trainees
        private void SetAttributesTrainee_optional(Person p)
        {
            //Cast variable p from type "Person" into type "Trainee" in new variable "appr"
            Trainee trnee = (Trainee)p;

            //Call method to set optional attributes
            trnee.SetOptionalAttributes(
                    title: TxtTitle.Text,
                    mph: TxtMobileNumber.Text,
                    bph: TxtBusinessPhone.Text,
                    bfa: TxtBusinessFax.Text,
                    ahv: TxtAHVNumber.Text,
                    pph: TxtPrivatePhone.Text,
                    birthpl: TxtBirthplace.Text,
                    exdate: DtpLeaveDate.Value,
                    lvl: (MgmLvl) CmbMgmtLevel.SelectedItem,
                    currappyear: Convert.ToString(CmbCurrentApprentYear.SelectedItem)
                    );
        }

        private void SetDashboardNumbers()
        {
            LblTotalCount.Text = Convert.ToString(Db.GetNumberOfPers());
            LblCustCount.Text = Convert.ToString(Db.GetNumberofCust());
            LblEmpCount.Text = Convert.ToString(Db.GetNumberofEmpl());
            LblAppCount.Text = Convert.ToString(Db.GetNumberofTrnee());
        }


        
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
            HideAllTrnee();
            HideAllCust();
            HideAllCmbCust();
            HideAllCmbTrnee();
        }

        private void RadTrainee_CheckedChanged(object sender, EventArgs e)
        {
            //Make all Trainee textboxes visible & enabled
            ShowAllEmp();
            EnableAllEmp();
            ShowAllTrnee();
            EnableAllTrnee();
            ShowAllCmbEmp();
            ShowAllCmbTrnee();

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
            HideAllTrnee();
            HideAllEmp();
            HideAllCmbTrnee();
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

        private void ShowStartScreen()
        {
            //Change buttons
            CmdAddUser.Visible = true;
            CmdEditUser.Visible = true;
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

            //Uncheck radio buttons
            UncheckAllRad();

            //Clears all textboxes
            ClearAllTextboxes();

            //Makes all radio buttos visible
            ShowAllRad();

            //Makes all comboboxes visible
            ShowAllCmbPers();

            //Hides all "Trainee", "Customer" and "Employee" related textboxes and labels
            HideAllTrnee();
            HideAllCust();
            HideAllEmp();
            HideAllCmbTrnee();
            HideAllCmbCust();
            HideAllCmbEmp();

            //Disable all boxes
            DisableALl();
        }
        
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

            CmbSalutation.Enabled = true;

            RadCustomer.Enabled = true;
            RadEmployee.Enabled = true;
            RadTrainee.Enabled = true;
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

            CmbDepartment.Enabled = true;
            CmbGender.Enabled = true;
            CmbMgmtLevel.Enabled = true;
            CmbWorkPensum.Enabled = true;
        }

        //Enables all Customer Textboxes
        private void EnableAllCust()
        {
            TxtCompanyName.ReadOnly = false;
            TxtCustomerType.ReadOnly = false;
            TxtContacPerson.ReadOnly = false;

            CmbCustomerType.Enabled = true;
        }

        //Enables all Trainee Textboxes
        private void EnableAllTrnee()
        {
            TxtApprentYears.ReadOnly = false;
            TxtCurrentApprentYear.ReadOnly = false;

            CmbApprentYears.Enabled = true;
            CmbCurrentApprentYear.Enabled = true;
        }

        //Enable all textboxes
        private void EnableAllTxtboxes()
        {
            EnableAllTrnee();
            EnableAllCust();
            EnableAllEmp();
            EnableAllPers();
        }

        //Disable all
        private void DisableALl()
        {
            DisableAllAppr();
            DisableAllCust();
            DisableAllEmp();
            DisableAllPers();

            CmbApprentYears.Enabled = false;
            CmbCurrentApprentYear.Enabled = false;
            CmbCustomerType.Enabled = false;
            CmbDepartment.Enabled = false;
            CmbGender.Enabled = false;
            CmbMgmtLevel.Enabled = false;
            CmbSalutation.Enabled = false;
            CmbWorkPensum.Enabled = false;

            RadCustomer.Enabled = false;
            RadEmployee.Enabled = false;
            RadTrainee.Enabled = false;
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
        private void HideAllTrnee()
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
        private void ShowAllTrnee()
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

            HideAllTrnee();
            HideAllCmbTrnee();
            HideAllCust();
            HideAllCmbCust();
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

        //Enable all Comboboxes
        private void EnableAllCmb()
        {
            CmbSalutation.Enabled = true;
            CmbGender.Enabled = true;
            DtpBirthdate.Enabled = true;

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
        private void ShowAllCmbTrnee()
        {
            CmbApprentYears.Visible = true;
            CmbCurrentApprentYear.Visible = true;

            //Set default selected item of combo box
            CmbApprentYears.SelectedItem = TxtApprentYears.Text;
            CmbCurrentApprentYear.SelectedItem = TxtCurrentApprentYear.Text;
        }

        //Hide all Apprentice combo boxes 
        private void HideAllCmbTrnee()
        {
            CmbApprentYears.Visible = false;
            CmbCurrentApprentYear.Visible = false;
        }

        private void CmbMgmtLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtFirstname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(TxtFirstname.Text))
                {
                    e.Cancel = true;
                    TxtFirstname.Focus();
                    errorProvider1.SetError(TxtFirstname, "Name should not be left blank!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(TxtFirstname, "");
                }
        }

        private void CmbSalutation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
