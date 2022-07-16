using Semesterarbeit.Controller;
using Semesterarbeit.View;
using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;



namespace Semesterarbeit
{

    public partial class Form1 : Form
    {
        //Create variable for id
        private int id;

        //Create new object "Db" of type "Database" 
        public Database Db = new Database();

        public Form1()
        {
            InitializeComponent();

            //Import person objects on the start of the program
            if (Db.Deserialisation() == false) { MessageBox.Show(Errorhandling.ReturnErrorResponse(0),"Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            //Datasource of the listbox are all objects in the list "contactList"
            LstEntries.DataSource = Db.contactList;

            //ID gets set by the method "ReturnLastID"
            id = Db.ReturnLastID();

            //Call function to disable all text boxes
            DisableAllTxtboxes();
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Define standard text for the combobox "Search Attribute"
            CmbSearch.SelectedText = "-select attribute-";
        }

        /********** L I S T   B O X ****************************************************************************************/

        //Display the objects in the textboxes which are selected in the listbox
        private void LstEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If nothing is selected, then select the first item in the listbox
            if (LstEntries.SelectedItem == null)
            {
                LstEntries.SetSelected(0, true);
            }

            //Cast the selected object of the list into type "Person" and write into the variable "selectedPerson"
            Person selectedPerson = (Person)LstEntries.SelectedItem;

            //Write the properties of the object of type "Person" into the specific textboxes
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
                    TxtDepartment.Text = selectedEmployee.Department;
                    TxtAHVNumber.Text = selectedEmployee.AhvNumber;
                    TxtStartDate.Text = Convert.ToString(selectedEmployee.StartDate);
                    TxtLeaveDate.Text = Convert.ToString(selectedEmployee.LeaveDate);
                    TxtDenomination.Text = selectedEmployee.Denomination;
                    TxtBirthplace.Text = selectedEmployee.Birthplace;
                    TxtNationality.Text = selectedEmployee.Nationality;
                    TxtRole.Text = selectedEmployee.Role;
                    TxtMgmtLevel.Text = Convert.ToString(selectedEmployee.MgmtLevel);
                    TxtDirectReports.Text = Convert.ToString(selectedEmployee.DirectReports);
                    TxtWorkPensum.Text = selectedEmployee.WorkPensum;
                    TxtCivilStatus.Text = selectedEmployee.CivilStatus;
                    TxtPrivatePhone.Text = selectedEmployee.PrivatePhone;
                    break;
                case "Apprentice":
                    //make all relevant textboxes and lables visible
                    ShowAllEmp();
                    ShowAllAppr();

                    //Hide irrelvant textboxes and lables
                    HideAllCust();

                    //Cast the selected object of the list into type "Apprentice" and write into the variable "selectedApprentice"
                    Apprentice selectedApprentice = (Apprentice)selectedPerson;

                    //Write the properties of the object of type "Apprentice" into the specific textboxes
                    TxtDepartment.Text = selectedApprentice.Department;
                    TxtAHVNumber.Text = selectedApprentice.AhvNumber;
                    TxtStartDate.Text = Convert.ToString(selectedApprentice.StartDate);
                    TxtLeaveDate.Text = Convert.ToString(selectedApprentice.LeaveDate);
                    TxtDenomination.Text = selectedApprentice.Denomination;
                    TxtBirthplace.Text = selectedApprentice.Birthplace;
                    TxtNationality.Text = selectedApprentice.Nationality;
                    TxtRole.Text = selectedApprentice.Role;
                    TxtMgmtLevel.Text = Convert.ToString(selectedApprentice.MgmtLevel);
                    TxtDirectReports.Text = Convert.ToString(selectedApprentice.DirectReports);
                    TxtWorkPensum.Text = selectedApprentice.WorkPensum;
                    TxtCivilStatus.Text = selectedApprentice.CivilStatus;
                    TxtPrivatePhone.Text = selectedApprentice.PrivatePhone;
                    TxtApprentYears.Text = Convert.ToString(selectedApprentice.ApprentYears);
                    TxtCurrentApprentYear.Text = Convert.ToString(selectedApprentice.CurrentApprentYear);
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
                    TxtCompanyName.Text = selectedCustomer.CompanyName;
                    TxtCustomerType.Text = selectedCustomer.CustomerType;
                    TxtContacPerson.Text = selectedCustomer.ContactPerson;
                    TxtNotesHistory.Text = selectedCustomer.NotesHistory;
                    break;
            }

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

        }

        //Function to format the listbox entries with multiple fields (ID, Firstname, Lastname, Classdescription)
        private void LstEntriesFormat(object sender, ListControlConvertEventArgs e)
        {
            //Source: https://stackoverflow.com/questions/3098198/bind-listbox-with-multiple-fields

            string id = ((Person)e.ListItem).ID.ToString();
            string firstname = ((Person)e.ListItem).Firstname.ToString();
            string lastname = ((Person)e.ListItem).Lastname.ToString();
            string type = ((Person)e.ListItem).GetClassName();

            //Combine the variables to one string
            string fullname = id + ": " + firstname + " " + lastname + " (" + type + ")";

            //Display full name in the listbox
            e.Value = fullname;
        }

        /********** B U T T O N S *****************************************************************************************/

        //"Add user" button
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if (CmdAdd.Text == "Add a new user")
            {
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
                CmdAdd.Enabled = false;
                CmdDeleteUser.Enabled = false;
                CmdEditUser.Enabled = false;
                CmdExport.Enabled = false;
                CmdSearch.Enabled = false;
                ChkStatus.Enabled = false;
                CmdTakeNotes.Enabled = false;
                LstEntries.Enabled = false;

                // Change display text from "Add a new user" to "Save changes"
                CmdAdd.Text = "Save changes";
            }
            else if (CmdAdd.Text == "Save changes")
            {
                Boolean mandatoryFieldsCorrect = false;

                if (RadEmployees.Checked == true)
                {
                    //Call function to check if all employee releated mandatory fields have the correct input
                    mandatoryFieldsCorrect = CheckMandatoryFields_Emp();

                    if (mandatoryFieldsCorrect == true)
                    { 
                        //Increase the value of the variable id +1
                        id++;

                        //Create new object of type "Employee"
                        Employee emp1 = new Employee
                        (
                            id,
                            Convert.ToString(CmbSalutation.SelectedItem),
                            TxtFirstname.Text,
                            TxtLastname.Text,
                            TxtEmail.Text,
                            true, //User enabled
                            DateTime.Now, //Creation date
                            Convert.ToString(DateTime.Now) + Environment.NewLine, //Last modified
                            Convert.ToString(CmbDepartment.SelectedItem),
                            TxtRole.Text
                        );

                   
                        //Call function to set the optional attributes with parameter "emp1"
                        SetAttributesEmp_optional(emp1);

                        //Add the new object to the list "Db" with the method "AddPerson"
                        Db.AddPerson(emp1);

                        //Deselect the affected radio button
                        RadEmployees.Checked = false;
                    }
                    else
                        MessageBox.Show(Errorhandling.ReturnErrorResponse(1), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (RadApprentice.Checked == true)
                {
                    //Call function to check if all customer releated mandatory fields have the correct input
                    mandatoryFieldsCorrect = CheckMandatoryFields_Appr();

                    if (mandatoryFieldsCorrect == true)
                    {
                        //Increase the value of the variable id +1
                        id++;

                        //Create new object of type "Apprentice"
                        Apprentice appr1 = new Apprentice
                        (
                            id,
                            Convert.ToString(CmbSalutation.SelectedItem),
                            TxtFirstname.Text,
                            TxtLastname.Text,
                            TxtEmail.Text,
                            true, //User enabled
                            DateTime.Now, //Creation date
                            Convert.ToString(DateTime.Now) + Environment.NewLine, //Last modified
                            Convert.ToString(CmbDepartment.SelectedItem),
                            TxtRole.Text,
                            Convert.ToString(CmbApprentYears.SelectedItem)
                        );

                        //Call function to set the optional attributes with parameter "appr1"
                        SetAttributesAppr_optional(appr1);

                        //Add the new object to the list "Db" with the method "AddPerson"
                        Db.AddPerson(appr1);

                        //Deselect the affected radio button
                        RadApprentice.Checked = false;
                    }
                    else
                        MessageBox.Show(Errorhandling.ReturnErrorResponse(1), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (RadCustomers.Checked == true)
                {
                    //Call function to check if all customer releated mandatory fields have the correct input
                    mandatoryFieldsCorrect = CheckMandatoryFields_Cust();

                    if (mandatoryFieldsCorrect == true)
                    {
                        //Increase the value of the variable id +1
                        id++;

                        //Create new object of type "Customer"
                        Customer cust1 = new Customer
                        (
                            id,
                            Convert.ToString(CmbSalutation.SelectedItem),
                            TxtFirstname.Text,
                            TxtLastname.Text,
                            TxtEmail.Text,
                            true, //User enabled
                            DateTime.Now, //Creation date
                            Convert.ToString(DateTime.Now) + Environment.NewLine, //Last modified
                            TxtCompanyName.Text,
                            Convert.ToString(CmbCustomerType.SelectedItem)
                        );

                        //Call function to set the optional attributes with parameter "cust1"
                        SetAttributesCust_optional(cust1);

                        //Add the new object to the list "Db" with the method "AddPerson"
                        Db.AddPerson(cust1);

                        //Deselect the affected radio button
                        RadCustomers.Checked = false;
                    }
                    else
                        MessageBox.Show(Errorhandling.ReturnErrorResponse(1), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (mandatoryFieldsCorrect == true)
                {
                    //Hide all radio buttons
                    HideAllRad();

                    //Hide all comboboxes
                    HideAllCmbPers();
                    HideAllCmbCust();
                    HideAllCmbAppr();
                    HideAllCmbEmp();

                    //Re-enable buttons, combo boxes, list boxes
                    CmdEditUser.Enabled = true;
                    CmdDeleteUser.Enabled = true;
                    CmdExport.Enabled = true;
                    ChkStatus.Enabled = true;
                    CmdSearch.Enabled = true;
                    CmdTakeNotes.Enabled = true;
                    LstEntries.Enabled = true;

                    //Disable all textboxes
                    DisableAllTxtboxes();

                    //Call method to save the new object on the harddisk
                    Db.Serialisation();

                    //Change display text from "Save changes" to "Add a new user"
                    CmdAdd.Text = "Add a new user";
                }
            }
        }

        //"Edit user" button
        private void CmdEditUser_Click(object sender, EventArgs e)
        {
            if (CmdEditUser.Text == "Edit user")
            {
                //Enable all text boxes
                EnableAllTxtboxes();

                //Makes all necessary combo boxes visible 
                ShowAllCmbPers();

                //Variable of type "Person" which is containing the object of the currently selected item in the listbox
                Person selectedPerson = (Person)LstEntries.SelectedItem;

                //Call the corresponding functions to show the right combo boxes depending on the class name
                switch (selectedPerson.GetClassName())
                {
                    case "Customer":
                        {
                            ShowAllCmbCust();
                            break;
                        }
                    case "Apprentice":
                        {
                            ShowAllCmbAppr();
                            ShowAllCmbEmp();
                            break;
                        }
                    case "Employee":
                        {
                            ShowAllCmbEmp();
                            break;
                        }
                }

                //Disables unusable buttons, combo boxes, list boxes
                CmdAdd.Enabled = false;
                CmdDeleteUser.Enabled = false;
                CmdExport.Enabled = false;
                CmdSearch.Enabled = false;
                ChkStatus.Enabled = false;
                CmdTakeNotes.Enabled = false;
                LstEntries.Enabled = false;

                // Change display text from "Edit user" to "Save changes"
                CmdEditUser.Text = "Save changes";
            }
            else if (CmdEditUser.Text == "Save changes")
            {
                //Variable of type "Person" which is containing the object of the currently selected item in the listbox
                Person p = (Person)LstEntries.SelectedItem;

                Boolean mandatoryFieldsCorrect = false;

                //Call the corresponding functions to set the attributes depending on the class name
                switch (p.GetClassName())
                {
                    case "Employee":
                        {
                            //Call function to check if all employee releated mandatory fields have the correct input
                            mandatoryFieldsCorrect = CheckMandatoryFields_Emp();

                            if (mandatoryFieldsCorrect == true)
                            {
                                SetAttributesEmp_mandatory(p);
                                SetAttributesEmp_optional(p);
                            }
                            else
                                MessageBox.Show(Errorhandling.ReturnErrorResponse(1), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case "Customer":
                        {
                            //Call function to check if all employee releated mandatory fields have the correct input
                            mandatoryFieldsCorrect = CheckMandatoryFields_Cust();

                            if (mandatoryFieldsCorrect == true)
                            {
                                SetAttributesCust_mandatory(p);
                                SetAttributesCust_optional(p);
                            }
                            else
                                MessageBox.Show(Errorhandling.ReturnErrorResponse(1), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    case "Apprentice":
                        {

                            //Call function to check if all employee releated mandatory fields have the correct input
                            mandatoryFieldsCorrect = CheckMandatoryFields_Appr();

                            if (mandatoryFieldsCorrect == true)
                            {
                                SetAttributesAppr_mandatory(p);
                                SetAttributesAppr_optional(p);
                            }
                            else
                                MessageBox.Show(Errorhandling.ReturnErrorResponse(1), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        }
                }
                if (mandatoryFieldsCorrect == true)
                {
                    //Append last-modified attribute
                    p.LastModified += Convert.ToString(DateTime.Now) + Environment.NewLine;

                    //Disable all text boxes
                    DisableAllTxtboxes();

                    //Hides all combo boxes
                    HideAllCmbPers();
                    HideAllCmbCust();
                    HideAllCmbEmp();
                    HideAllCmbAppr();

                    //Re-enable buttons, combo boxes, listboxes
                    CmdAdd.Enabled = true;
                    CmdDeleteUser.Enabled = true;
                    CmdExport.Enabled = true;
                    CmdSearch.Enabled = true;
                    ChkStatus.Enabled = true;
                    CmdTakeNotes.Enabled = true;
                    LstEntries.Enabled = true;

                    //Call method to save the new object on the harddisk
                    Db.Serialisation();

                    // Change display text from "Save changes" to "Edit user"
                    CmdEditUser.Text = "Edit user";
                }
            }

        }

        //"Delete user" button
        private void CmdDeleteUser_Click(object sender, EventArgs e)
        {
            //Variable of type "Person" which is containing the object of the currently selected item in the listbox
            Person selectedPerson = (Person)LstEntries.SelectedItem;

            //Call function to delete the user
            Db.DeletePerson(selectedPerson);
        }

        //"Export to CSV" button
        private void CmdExport_Click(object sender, EventArgs e)
        {
            SaveFileChooser.Filter = "csv Dateien (*.csv)|*.csv";
            if (SaveFileChooser.ShowDialog() == DialogResult.OK)
            {
                //Path gets set by the SaveFileChooser 
                string path = SaveFileChooser.FileName;

                //Output texts gets returned by the function "Db.ExportList"                
                string output = Db.ExportListPerson();

                if (!File.Exists(path))
                {
                    File.WriteAllText(path, output, Encoding.UTF8);
                }
                else
                {
                    File.AppendAllText(path, output, Encoding.UTF8);
                }
            }
        }

        //"Start Search" button
        private void CmdSearch_Click(object sender, EventArgs e)
        {
            Boolean searchattributeOk = true;

            //Check if the search attribute has a value
            if(CmbSearch.Text == "-select attribute-")
            {
                searchattributeOk = false;
                MessageBox.Show(Errorhandling.ReturnErrorResponse(2), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(searchattributeOk == true)
            { 
                //Set the selected item of the combo box as the "searchAttribute"
                string searchAttribute = Convert.ToString(CmbSearch.SelectedItem);

                //Compare every attribute of all objects in the list "contactlist" to the searchtext and write it into the list "searchresults"
                foreach (Person p in Db.contactList)
                {
                    switch (searchAttribute)
                    {
                        case "Salutation":
                            {
                                if (p.Salutation == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Firstname":
                            {
                                if (p.Firstname == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Secondname":
                            {
                                if (p.Secondname == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Lastname":
                            {
                                if (p.Lastname == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Birthdate":
                            {
                                if (p.Birthdate == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Gender":
                            {
                                if (p.Gender == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Title":
                            {
                                if (p.Title == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Business Phone":
                            {
                                if (p.BusinessPhone == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Business Fax":
                            {
                                if (p.BusinessFax == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Mobile Number":
                            {
                                if (p.MobileNumber == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Email":
                            {
                                if (p.Email == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "City":
                            {
                                if (p.City == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Street":
                            {
                                if (p.Street == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Zip Code":
                            {
                                if (p.Zipcode == TxtSearch.Text)
                                    Db.AddSearchResult(p);
                                break;
                            }
                        case "Department":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.Department == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "AHV Number":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.AhvNumber == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Start Date":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.StartDate == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Leaving Date":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.LeaveDate == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Denomination":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.Denomination == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Birthplace":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.Birthplace == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Nationality":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.Nationality == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Role":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.Role == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Management Level":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.MgmtLevel == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Direct Reports":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.DirectReports == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Work Pensum":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.WorkPensum == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Civil Status":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.CivilStatus == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Private Phone":
                            {
                                Employee pemp = (Employee)p;
                                if (pemp.PrivatePhone == TxtSearch.Text)
                                    Db.AddSearchResult(pemp);
                                break;
                            }
                        case "Apprenticeship Years":
                            {
                                Apprentice pappr = (Apprentice)p;
                                if (pappr.ApprentYears == TxtSearch.Text)
                                    Db.AddSearchResult(pappr);
                                break;
                            }
                        case "Current Appr Year":
                            {
                                Apprentice pappr = (Apprentice)p;
                                if (pappr.CurrentApprentYear == TxtSearch.Text)
                                    Db.AddSearchResult(pappr);
                                break;
                            }
                        case "Company Name":
                            {
                                Customer pcust = (Customer)p;
                                if (pcust.CompanyName == (TxtSearch.Text))
                                    Db.AddSearchResult(pcust);
                                break;
                            }
                        case "Customer Type":
                            {
                                Customer pcust = (Customer)p;
                                if (pcust.CustomerType == (TxtSearch.Text))
                                    Db.AddSearchResult(pcust);
                                break;
                            }
                        case "Contact Person":
                            {
                                Customer pcust = (Customer)p;
                                if (pcust.ContactPerson == (TxtSearch.Text))
                                    Db.AddSearchResult(pcust);
                                break;
                            }
                    }
                }
                //Datasource of the listbox are all objects in the list "searchResults"
                LstEntries.DataSource = Db.searchResults;

                //Make the button "Reset Search Results" and lable visible
                ShowResetSearchResults();

                //Change lable "ListboxDescription"
                LblListboxDescription.Text = "Search results";

                //Disable "Add a new user" button
                CmdAdd.Enabled = false;
            }
        }

        //"Reset Search Results" button
        private void CmdResetSearchResults_Click(object sender, EventArgs e)
        {
            //Call method to clear all search results
            Db.ClearSearchResults();

            //Call function to hide the button and lable "Reset Search Results"
            HideResetSearchResults();

            //CmbFilter.SelectedText = "(Show all)";
            CmbSearch.ResetText();
            CmbSearch.SelectedText = "-select attribute-";

            //Clear search textbox
            TxtSearch.Text = "";

            //Change lable "ListboxDescription"
            LblListboxDescription.Text = "Contacts";

            //Datasource of the listbox are all objects in the list "contactList"
            LstEntries.DataSource = Db.contactList;

        }

        //"Take Notes" button
        private void CmdTakeNotes_Click(object sender, EventArgs e)
        {
            if (CmdTakeNotes.Text == "Take notes")
            {
                //Enable textbox for taking notes
                TxtNotes.Enabled = true;

                // Change display text from "Take notes" to "Save notes"
                CmdTakeNotes.Text = "Save notes";
            }
            else if (CmdTakeNotes.Text == "Save notes")
            {
                //Cast the "Person" variable p into a new variable of type "Customer"
                Customer pcust = (Customer)LstEntries.SelectedItem;

                //Save the Notes into the notes history
                pcust.NotesHistory += DateTime.Now + ":" + Environment.NewLine + TxtNotes.Text + Environment.NewLine + " " + Environment.NewLine;

                //Disable textbox for taking notes
                TxtNotes.Enabled = false;

                //Clear textbox "Notes"
                TxtNotes.Text = "";

                //Call method to save the new object on the harddisk
                Db.Serialisation();

                // Change display text from "Save notes" to "Take notes"
                CmdTakeNotes.Text = "Take notes";
            }
        }

        /********** R A D I O   B U T T O N S ****************************************************************************/

        //RadioButton Employee
        private void RadEmployees_CheckedChanged(object sender, EventArgs e)
        {
            //Makes all "Employee" related textboxes visible & enabled
            ShowAllEmp();
            EnableAllEmp();
            ShowAllCmbEmp();

            //hides all others
            HideAllAppr();
            HideAllCust();
            HideAllCmbCust();
            HideAllCmbAppr();

            //Enable "Save changes" button
            CmdAdd.Enabled = true;
        }

        //RadioButton Apprentice
        private void RadApprentice_CheckedChanged(object sender, EventArgs e)
        {
            //Makes all "Apprentice" related textboxes visible & enabled
            ShowAllEmp();
            EnableAllEmp();
            ShowAllAppr();
            EnableAllAppr();
            ShowAllCmbEmp();
            ShowAllCmbAppr(); 

            //hides all others
            HideAllCust();
            HideAllCmbCust();

            //Enable "Save changes" button
            CmdAdd.Enabled = true;
        }

        //RadioButton Customer
        private void RadCustomers_CheckedChanged(object sender, EventArgs e)
        {
            //Makes all "Customer" related textboxes visible & enabled
            ShowAllCust();
            EnableAllCust();
            ShowAllCmbCust();

            //hides all others
            HideAllAppr();
            HideAllEmp();
            HideAllCmbAppr();
            HideAllCmbEmp();

            //Enable "Save changes" button
            CmdAdd.Enabled = true;
        }

        /********** C H E C K   B O X E S ********************************************************************************/

        //Checkbox resp. Toggle button "User Status"
        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            //Variable of type "Person" which is containing the object of the currently selected item in the listbox
            Person selectedPerson = (Person)LstEntries.SelectedItem;

            try
            {
                //When the status is changed activate user / deactivate user
                if (ChkStatus.Checked == true)
                {
                    selectedPerson.Status = true;
                    ActivateUser();
                }
                else if (ChkStatus.Checked == false)
                {
                    selectedPerson.Status = false;
                    DeactivateUser();
                }
            }
            catch (System.NullReferenceException)
            {
                //If there is no item in the list: toggle is able to switch, but without any impact
            }


        }


        /********** T E X T   B O X E S   &   L A B L E S ****************************************************************/

        //Function which enables all "Person" related textboxes
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

        //Function which enables all "Employee" related textboxes
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

        //Function which enables all "Customer" related textboxes
        private void EnableAllCust()
        {
            TxtCompanyName.ReadOnly = false;
            TxtCustomerType.ReadOnly = false;
            TxtContacPerson.ReadOnly = false;
        }

        //Function which enables all "Apprentice" related textboxes
        private void EnableAllAppr()
        {
            TxtApprentYears.ReadOnly = false;
            TxtCurrentApprentYear.ReadOnly = false;
        }

        //Function which enables all textboxes
        private void EnableAllTxtboxes()
        {
            EnableAllAppr();
            EnableAllCust();
            EnableAllEmp();
            EnableAllPers();
        }

        //Function which disables all "Person" related textboxes
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

        //Function which disables all "Employee" related textboxes
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

        //Function which disables all "Customer" related textboxes
        private void DisableAllCust()
        {
            TxtCompanyName.ReadOnly = true;
            TxtCustomerType.ReadOnly = true;
            TxtContacPerson.ReadOnly = true;
        }

        //Function which disables all "Apprentice" related textboxes
        private void DisableAllAppr()
        {
            TxtApprentYears.ReadOnly = true;
            TxtCurrentApprentYear.ReadOnly = true;
        }

        //Function which disables all textboxes
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
            RadCustomers.Visible = true;
            RadEmployees.Visible = true;
        }

        //Function which hides all radio buttons 
        private void HideAllRad()
        {
            RadApprentice.Visible = false;
            RadCustomers.Visible = false;
            RadEmployees.Visible = false;
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
            if(TxtBirthdate.Text != "")
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


        /********** F U R T H E R   F U N C T I O N S ****************************************************************/

        //Function to set all mandatory attributes for employees
        public void SetAttributesEmp_mandatory(Person p)
        {
            //Cast variable p from type "Person" into type "Employee" in new variable "emp"
            Employee emp = (Employee)p;

            //Call method to set mandatory attributes
            emp.SetMandatoryAttributes(
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                email: TxtEmail.Text,
                department: Convert.ToString(CmbDepartment.SelectedItem),
                role: TxtRole.Text
                );
        }

        //Function to set all optional attributes for employees
        public void SetAttributesEmp_optional(Person p)
        {
            //Cast variable p from type "Person" into type "Employee" in new variable "emp"
            Employee emp = (Employee)p;

            //Call method to set optional attributes
            emp.SetOptionalAttributes(
                    sn: TxtSecondname.Text,
                    g: Convert.ToString(CmbGender.SelectedItem),
                    t: TxtTitle.Text,
                    bp: TxtBusinessPhone.Text,
                    bf: TxtBusinessFax.Text,
                    mn: TxtMobileNumber.Text,
                    s: TxtStreet.Text,
                    zc: TxtZipcode.Text,
                    c: TxtCity.Text,
                    bdate: Convert.ToString(DtpBirthdate.Value.ToShortDateString()),
                    ahv: TxtAHVNumber.Text,
                    d: TxtDenomination.Text,
                    bipl: TxtBirthplace.Text,
                    nat: TxtNationality.Text,
                    mgmtl: Convert.ToString(CmbMgmtLevel.SelectedItem),
                    dr: Convert.ToString(CmbDirectReports.SelectedItem),
                    wp: Convert.ToString(CmbWorkPensum.SelectedItem),
                    cs: Convert.ToString(CmbCivilStatus.SelectedItem),
                    pf: TxtPrivatePhone.Text,
                    startdate: Convert.ToString(DtpStartDate.Value.ToShortDateString()),
                    leavedate: Convert.ToString(DtpLeaveDate.Value.ToShortDateString())
                    );
        }

        //Function to set all mandatory attributes for Customers
        public void SetAttributesCust_mandatory(Person p)
        {
            //Cast variable p from type "Person" into type "Customer" in new variable "cust"
            Customer cust = (Customer)p;

            //Call method to set mandatory attributes
            cust.SetMandatoryAttributes(
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                email: TxtEmail.Text,
                compn: TxtCompanyName.Text,
                cutype: Convert.ToString(CmbCustomerType.SelectedItem)
                );
        }

        //Function to set all optional attributes for customers
        public void SetAttributesCust_optional(Person p)
        {
            //Cast variable p from type "Person" into type "Customer" in new variable "cust"
            Customer cust = (Customer)p;

            //Call method to set optional attributes
            cust.SetOptionalAttributes(
                    sn: TxtSecondname.Text,
                    g: Convert.ToString(CmbGender.SelectedItem),
                    t: TxtTitle.Text,
                    bp: TxtBusinessPhone.Text,
                    bf: TxtBusinessFax.Text,
                    mn: TxtMobileNumber.Text,
                    s: TxtStreet.Text,
                    zc: TxtZipcode.Text,
                    c: TxtCity.Text,
                    bdate: Convert.ToString(DtpBirthdate.Value.ToShortDateString()),
                    cp: TxtContacPerson.Text
                    );
        }

        //Function to set all mandatory attributes for apprentices
        public void SetAttributesAppr_mandatory(Person p)
        {
            //Cast variable p from type "Person" into type "Apprentice" in new variable "appr"
            Apprentice appr = (Apprentice)p;

            //Call method to set mandatory attributes
            appr.SetMandatoryAttributes(
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                email: TxtEmail.Text,
                department: Convert.ToString(CmbDepartment.SelectedItem),
                role: TxtRole.Text,
                appryear: Convert.ToString(CmbApprentYears.SelectedItem)
                );
        }

        //Function to set all optional attributes for apprentices
        public void SetAttributesAppr_optional(Person p)
        {
            //Cast variable p from type "Person" into type "Apprentice" in new variable "appr"
            Apprentice appr = (Apprentice)p;

            //Call method to set optional attributes
            appr.SetOptionalAttributes(
                    sn: TxtSecondname.Text,
                    g: Convert.ToString(CmbGender.SelectedItem),
                    t: TxtTitle.Text,
                    bp: TxtBusinessPhone.Text,
                    bf: TxtBusinessFax.Text,
                    mn: TxtMobileNumber.Text,
                    s: TxtStreet.Text,
                    zc: TxtZipcode.Text,
                    c: TxtCity.Text,
                    bdate: Convert.ToString(DtpBirthdate.Value.ToShortDateString()),
                    ahv: TxtAHVNumber.Text,
                    d: TxtDenomination.Text,
                    bipl: TxtBirthplace.Text,
                    nat: TxtNationality.Text,
                    mgmtl: Convert.ToString(CmbMgmtLevel.SelectedItem),
                    dr: Convert.ToString(CmbDirectReports.SelectedItem),
                    wp: Convert.ToString(CmbWorkPensum.SelectedItem),
                    cs: Convert.ToString(CmbCivilStatus.SelectedItem),
                    pf: TxtPrivatePhone.Text,
                    startdate: Convert.ToString(DtpStartDate.Value.ToShortDateString()),
                    leavedate: Convert.ToString(DtpLeaveDate.Value.ToShortDateString()),
                    capry: Convert.ToString(CmbCurrentApprentYear.SelectedItem)
                    );
        }

        //Function to activate user 
        private void ActivateUser()
        {
            ChkStatus.Checked = true;
            CmdEditUser.Enabled = true;
            CmdDeleteUser.Enabled = true;
            CmdTakeNotes.Enabled = true;

            //Change the font of the textboxes to "Regular"
            TxtSalutation.Font = new Font(TxtSalutation.Font, FontStyle.Regular);
            TxtFirstname.Font = new Font(TxtFirstname.Font, FontStyle.Regular);
            TxtSecondname.Font = new Font(TxtSecondname.Font, FontStyle.Regular);
            TxtLastname.Font = new Font(TxtLastname.Font, FontStyle.Regular);
            TxtBirthdate.Font = new Font(TxtBirthdate.Font, FontStyle.Regular);
            TxtGender.Font = new Font(TxtGender.Font, FontStyle.Regular);
            TxtTitle.Font = new Font(TxtTitle.Font, FontStyle.Regular);
            TxtBusinessPhone.Font = new Font(TxtBusinessPhone.Font, FontStyle.Regular);
            TxtBusinessFax.Font = new Font(TxtBusinessFax.Font, FontStyle.Regular);
            TxtMobileNumber.Font = new Font(TxtMobileNumber.Font, FontStyle.Regular);
            TxtEmail.Font = new Font(TxtEmail.Font, FontStyle.Regular);
            TxtCity.Font = new Font(TxtCity.Font, FontStyle.Regular);
            TxtStreet.Font = new Font(TxtStreet.Font, FontStyle.Regular);
            TxtZipcode.Font = new Font(TxtZipcode.Font, FontStyle.Regular);
            TxtDepartment.Font = new Font(TxtDepartment.Font, FontStyle.Regular);
            TxtAHVNumber.Font = new Font(TxtAHVNumber.Font, FontStyle.Regular);
            TxtStartDate.Font = new Font(TxtStartDate.Font, FontStyle.Regular);
            TxtLeaveDate.Font = new Font(TxtLeaveDate.Font, FontStyle.Regular);
            TxtDenomination.Font = new Font(TxtDenomination.Font, FontStyle.Regular);
            TxtBirthplace.Font = new Font(TxtBirthplace.Font, FontStyle.Regular);
            TxtNationality.Font = new Font(TxtNationality.Font, FontStyle.Regular);
            TxtRole.Font = new Font(TxtRole.Font, FontStyle.Regular);
            TxtMgmtLevel.Font = new Font(TxtMgmtLevel.Font, FontStyle.Regular);
            TxtDirectReports.Font = new Font(TxtDirectReports.Font, FontStyle.Regular);
            TxtWorkPensum.Font = new Font(TxtWorkPensum.Font, FontStyle.Regular);
            TxtCivilStatus.Font = new Font(TxtCivilStatus.Font, FontStyle.Regular);
            TxtPrivatePhone.Font = new Font(TxtPrivatePhone.Font, FontStyle.Regular);
            TxtNationality.Font = new Font(TxtNationality.Font, FontStyle.Regular);
            TxtApprentYears.Font = new Font(TxtApprentYears.Font, FontStyle.Regular);
            TxtCurrentApprentYear.Font = new Font(TxtCurrentApprentYear.Font, FontStyle.Regular);
            TxtCompanyName.Font = new Font(TxtCompanyName.Font, FontStyle.Regular);
            TxtCustomerType.Font = new Font(TxtCustomerType.Font, FontStyle.Regular);
            TxtContacPerson.Font = new Font(TxtContacPerson.Font, FontStyle.Regular);
            TxtCreationDate.Font = new Font(TxtContacPerson.Font, FontStyle.Regular);
            TxtLastModified.Font = new Font(TxtContacPerson.Font, FontStyle.Regular);
            TxtNotesHistory.Font = new Font(TxtContacPerson.Font, FontStyle.Regular);
        }

        //Function to deactivate user
        private void DeactivateUser()
        {
            ChkStatus.Checked = false;
            CmdEditUser.Enabled = false;
            CmdDeleteUser.Enabled = false;
            CmdTakeNotes.Enabled = false;

            //Change the font of all textboxes to "Strikeout"
            TxtSalutation.Font = new Font(TxtSalutation.Font, FontStyle.Strikeout);
            TxtFirstname.Font = new Font(TxtFirstname.Font, FontStyle.Strikeout);
            TxtSecondname.Font = new Font(TxtSecondname.Font, FontStyle.Strikeout);
            TxtLastname.Font = new Font(TxtLastname.Font, FontStyle.Strikeout);
            TxtBirthdate.Font = new Font(TxtBirthdate.Font, FontStyle.Strikeout);
            TxtGender.Font = new Font(TxtGender.Font, FontStyle.Strikeout);
            TxtTitle.Font = new Font(TxtTitle.Font, FontStyle.Strikeout);
            TxtBusinessPhone.Font = new Font(TxtBusinessPhone.Font, FontStyle.Strikeout);
            TxtBusinessFax.Font = new Font(TxtBusinessFax.Font, FontStyle.Strikeout);
            TxtMobileNumber.Font = new Font(TxtMobileNumber.Font, FontStyle.Strikeout);
            TxtEmail.Font = new Font(TxtEmail.Font, FontStyle.Strikeout);
            TxtCity.Font = new Font(TxtCity.Font, FontStyle.Strikeout);
            TxtStreet.Font = new Font(TxtStreet.Font, FontStyle.Strikeout);
            TxtZipcode.Font = new Font(TxtZipcode.Font, FontStyle.Strikeout);
            TxtDepartment.Font = new Font(TxtDepartment.Font, FontStyle.Strikeout);
            TxtAHVNumber.Font = new Font(TxtAHVNumber.Font, FontStyle.Strikeout);
            TxtStartDate.Font = new Font(TxtStartDate.Font, FontStyle.Strikeout);
            TxtLeaveDate.Font = new Font(TxtLeaveDate.Font, FontStyle.Strikeout);
            TxtDenomination.Font = new Font(TxtDenomination.Font, FontStyle.Strikeout);
            TxtBirthplace.Font = new Font(TxtBirthplace.Font, FontStyle.Strikeout);
            TxtNationality.Font = new Font(TxtNationality.Font, FontStyle.Strikeout);
            TxtRole.Font = new Font(TxtRole.Font, FontStyle.Strikeout);
            TxtMgmtLevel.Font = new Font(TxtMgmtLevel.Font, FontStyle.Strikeout);
            TxtDirectReports.Font = new Font(TxtDirectReports.Font, FontStyle.Strikeout);
            TxtWorkPensum.Font = new Font(TxtWorkPensum.Font, FontStyle.Strikeout);
            TxtCivilStatus.Font = new Font(TxtCivilStatus.Font, FontStyle.Strikeout);
            TxtPrivatePhone.Font = new Font(TxtPrivatePhone.Font, FontStyle.Strikeout);
            TxtNationality.Font = new Font(TxtNationality.Font, FontStyle.Strikeout);
            TxtApprentYears.Font = new Font(TxtApprentYears.Font, FontStyle.Strikeout);
            TxtCurrentApprentYear.Font = new Font(TxtCurrentApprentYear.Font, FontStyle.Strikeout);
            TxtCompanyName.Font = new Font(TxtCompanyName.Font, FontStyle.Strikeout);
            TxtCustomerType.Font = new Font(TxtCustomerType.Font, FontStyle.Strikeout);
            TxtContacPerson.Font = new Font(TxtContacPerson.Font, FontStyle.Strikeout);
            TxtCreationDate.Font = new Font(TxtContacPerson.Font, FontStyle.Strikeout);
            TxtLastModified.Font = new Font(TxtContacPerson.Font, FontStyle.Strikeout);
            TxtNotesHistory.Font = new Font(TxtContacPerson.Font, FontStyle.Strikeout);

        }

        //Function to check if all mandatory fields have the right input
        private Boolean CheckMandatoryFields_Pers()
        {
            Boolean everythingOk = false;
            Boolean salutationOk = true;
            Boolean firstnameOk = true;
            Boolean lastnameOk = true;
            Boolean emailOk = true;

            //Set back color of all text boxes back to white
            CmbSalutation.BackColor = Color.White;
            TxtFirstname.BackColor = Color.White;
            TxtLastname.BackColor = Color.White;
            TxtEmail.BackColor = Color.White;

            //Check if the mandatory textboxes / comboboxes have the right input
            if (string.IsNullOrEmpty(CmbSalutation.Text))
            {
                CmbSalutation.BackColor = Color.LightCoral;
                salutationOk = false;
            }
            if (!isText(TxtFirstname.Text))
            {
                TxtFirstname.BackColor = Color.LightCoral;
                firstnameOk = false;
            }
            if (!isText(TxtLastname.Text))
            {
                TxtLastname.BackColor = Color.LightCoral;
                lastnameOk = false;
            }
            if (!isEmail(TxtEmail.Text))
            {
                TxtEmail.BackColor = Color.LightCoral;
                emailOk = false;
            }

            //If all textboxes / comboboxes have the right input, everything is ok
            if (salutationOk == true && firstnameOk == true && lastnameOk == true && emailOk == true)
            { everythingOk = true; }

            return everythingOk;
        }

        //Function to check if all mandatory fields have the right input
        private Boolean CheckMandatoryFields_Emp()
        {
            Boolean everythingOk = false;
            Boolean personOk = CheckMandatoryFields_Pers(); //Call function "CheckMandatoryFields_Pers()" to check first all person related textboxes
            Boolean departmentOk = true;
            Boolean roleOk = true;

            //Set back color of all text boxes back to white
            CmbDepartment.BackColor = Color.White;
            TxtRole.BackColor = Color.White;

            //Check if the mandatory textboxes / comboboxes have the right input
            if (string.IsNullOrEmpty(CmbDepartment.Text))
            {
                CmbDepartment.BackColor = Color.LightCoral;
                departmentOk = false;
            }
            if (!isText(TxtRole.Text))
            {
                TxtRole.BackColor = Color.LightCoral;
                roleOk = false;
            }

            //If all textboxes / comboboxes have the right input, everything is ok
            if (personOk == true && departmentOk == true && roleOk == true)
            { everythingOk = true; }

            return everythingOk;
        }

        //Function to check if all mandatory fields have the right input
        private Boolean CheckMandatoryFields_Appr()
        {
            Boolean everythingOk = false;
            Boolean employeeOk = CheckMandatoryFields_Emp(); //Call function "CheckMandatoryFields_Emp()" to check first all person related textboxes
            Boolean apprentYearsOK = true;

            //Set back color of all text boxes back to white
            CmbApprentYears.BackColor = Color.White;

            //Check if the mandatory textboxes / comboboxes have the right input
            if (string.IsNullOrEmpty(CmbApprentYears.Text))
            {
                CmbApprentYears.BackColor = Color.LightCoral;
                apprentYearsOK = false;
            }

            if (employeeOk == true && apprentYearsOK == true)
            { everythingOk = true; }

            return everythingOk;
        }

        //Function to check if all mandatory fields have the right input
        private Boolean CheckMandatoryFields_Cust()
        {
            Boolean everythingOk = false;
            Boolean personOk = CheckMandatoryFields_Pers(); //Call function "CheckMandatoryFields_Pers()" to check first all person related textboxes
            Boolean companyNameOk = true;
            Boolean customerTypeOk = true;

            //Set back color of all text boxes back to white
            TxtCompanyName.BackColor = Color.White;
            CmbCustomerType.BackColor = Color.White;

            //Check if the mandatory textboxes / comboboxes have the right input
            if (!isText(TxtCompanyName.Text))
            {
                TxtCompanyName.BackColor = Color.LightCoral;
                companyNameOk = false;
            }
            if (string.IsNullOrEmpty(CmbCustomerType.Text))
            {
                CmbCustomerType.BackColor = Color.LightCoral;
                customerTypeOk = false;
            }

            //If all textboxes / comboboxes have the right input, everything is ok
            if (personOk == true && companyNameOk == true && customerTypeOk == true)
            { everythingOk = true; }

            return everythingOk;
        }

        //Function which checks if the input is text
        private Boolean isText(string input)
        {
            //Returns true if the input string matches the regex
            return Regex.IsMatch(input, "[A - Za - z]");
        }

        //Function which checks if the input is an email address
        private Boolean isEmail(string input)
        {
            //Returns true if the input string matches the regex
            //Regex-Source:https://stackoverflow.com/questions/5342375/regex-email-validation
            return Regex.IsMatch(input, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

    }
}
