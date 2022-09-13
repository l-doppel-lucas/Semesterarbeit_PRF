using semesterarbeit.Controller;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace semesterarbeit
{
    public partial class Dashboard : Form
    {

        //Create variable for id/EmpID
        private int id;

        //Creat user variables to get username for login 
        private string user;

        //Create Contact List for Listbox
        public Database Db = new Database();

        
        // Create ErrorProvider - mandetory fields
        private System.Windows.Forms.ErrorProvider firstnameErrorProvider;
        private System.Windows.Forms.ErrorProvider lastnameErrorProvider;
        private System.Windows.Forms.ErrorProvider streetErrorProvider;
        private System.Windows.Forms.ErrorProvider cityErrorProvider;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider zipcodeErrorProvider;
        private System.Windows.Forms.ErrorProvider roleErrorProvider;
        private System.Windows.Forms.ErrorProvider salutationErrorProvider;
        private System.Windows.Forms.ErrorProvider genderErrorProvider;
        private System.Windows.Forms.ErrorProvider departmentErrorProvider;
        private System.Windows.Forms.ErrorProvider companynameErrorProvider;
        private System.Windows.Forms.ErrorProvider workpensumErrorProvider;
        private System.Windows.Forms.ErrorProvider apprentyearsErrorProvider;


        // Create ErrorProvider - non mandetory fields
        private System.Windows.Forms.ErrorProvider titleErrorProvider;
        private System.Windows.Forms.ErrorProvider birthplaceErrorProvider;
        private System.Windows.Forms.ErrorProvider businessphoneErrorProvider;
        private System.Windows.Forms.ErrorProvider businessfaxErrorProvider;
        private System.Windows.Forms.ErrorProvider mobilenumberErrorProvider;
        private System.Windows.Forms.ErrorProvider privatephoneErrorProvider;
        private System.Windows.Forms.ErrorProvider nationalityErrorProvider;
        private System.Windows.Forms.ErrorProvider ahvnumberErrorProvider;
        private System.Windows.Forms.ErrorProvider contactpersonErrorProvider;
        private System.Windows.Forms.ErrorProvider currentapprentyearErrorProvider;


        public Dashboard(string us1)
        {

            InitializeComponent();

            //Set user variable
            user = us1;

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
            DisableAll();

            //Show dashboard data
            SetDashboardNumbers();


            // Create and set the ErrorProvider for each data entry control.


            // ErrorProvider firstname

            firstnameErrorProvider = new System.Windows.Forms.ErrorProvider();
            firstnameErrorProvider.SetIconAlignment(this.TxtFirstname, ErrorIconAlignment.MiddleRight);
            firstnameErrorProvider.SetIconPadding(this.TxtFirstname, 2);
            firstnameErrorProvider.BlinkRate = 0;
            firstnameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtFirstname.Validated += new System.EventHandler(this.TxtFirstname_Validated);


            // ErrorProvider lastname

            lastnameErrorProvider = new System.Windows.Forms.ErrorProvider();
            lastnameErrorProvider.SetIconAlignment(this.TxtLastname, ErrorIconAlignment.MiddleRight);
            lastnameErrorProvider.SetIconPadding(this.TxtLastname, 2);
            lastnameErrorProvider.BlinkRate = 0;
            lastnameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtLastname.Validated += new System.EventHandler(this.TxtLastname_Validated);

            // ErrorProvider street

            streetErrorProvider = new System.Windows.Forms.ErrorProvider();
            streetErrorProvider.SetIconAlignment(this.TxtStreet, ErrorIconAlignment.MiddleRight);
            streetErrorProvider.SetIconPadding(this.TxtStreet, 2);
            streetErrorProvider.BlinkRate = 0;
            streetErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtStreet.Validated += new System.EventHandler(this.TxtStreet_Validated);


            // ErrorProvider city

            cityErrorProvider = new System.Windows.Forms.ErrorProvider();
            cityErrorProvider.SetIconAlignment(this.TxtCity, ErrorIconAlignment.MiddleRight);
            cityErrorProvider.SetIconPadding(this.TxtCity, 2);
            cityErrorProvider.BlinkRate = 0;
            cityErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtCity.Validated += new System.EventHandler(this.TxtCity_Validated);

            // ErrorProvider email

            emailErrorProvider = new System.Windows.Forms.ErrorProvider();
            emailErrorProvider.SetIconAlignment(this.TxtEmail, ErrorIconAlignment.MiddleRight);
            emailErrorProvider.SetIconPadding(this.TxtEmail, 2);
            emailErrorProvider.BlinkRate = 0;
            emailErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtEmail.Validated += new System.EventHandler(this.TxtEmail_Validated);


            // ErrorProvider ZIP Code

            zipcodeErrorProvider = new System.Windows.Forms.ErrorProvider();
            zipcodeErrorProvider.SetIconAlignment(this.TxtZipcode, ErrorIconAlignment.MiddleRight);
            zipcodeErrorProvider.SetIconPadding(this.TxtZipcode, 2);
            zipcodeErrorProvider.BlinkRate = 0;
            zipcodeErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtZipcode.Validated += new System.EventHandler(this.TxtZipcode_Validated);


            // ErrorProvider role

            roleErrorProvider = new System.Windows.Forms.ErrorProvider();
            roleErrorProvider.SetIconAlignment(this.TxtRole, ErrorIconAlignment.MiddleRight);
            roleErrorProvider.SetIconPadding(this.TxtRole, 2);
            roleErrorProvider.BlinkRate = 0;
            roleErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtRole.Validated += new System.EventHandler(this.TxtRole_Validated);


            // ErrorProvider salutation

            salutationErrorProvider = new System.Windows.Forms.ErrorProvider();
            salutationErrorProvider.SetIconAlignment(this.CmbSalutation, ErrorIconAlignment.MiddleRight);
            salutationErrorProvider.SetIconPadding(this.CmbSalutation, 2);
            salutationErrorProvider.BlinkRate = 0;
            salutationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.CmbSalutation.Validated += new System.EventHandler(this.CmbSalutation_Validated);

            // ErrorProvider gender

            genderErrorProvider = new System.Windows.Forms.ErrorProvider();
            genderErrorProvider.SetIconAlignment(this.CmbGender, ErrorIconAlignment.MiddleRight);
            genderErrorProvider.SetIconPadding(this.CmbGender, 2);
            genderErrorProvider.BlinkRate = 0;
            genderErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.CmbGender.Validated += new System.EventHandler(this.CmbGender_Validated);


            // ErrorProvider workpensum

            workpensumErrorProvider = new System.Windows.Forms.ErrorProvider();
            workpensumErrorProvider.SetIconAlignment(this.CmbWorkPensum, ErrorIconAlignment.MiddleRight);
            workpensumErrorProvider.SetIconPadding(this.CmbWorkPensum, 2);
            workpensumErrorProvider.BlinkRate = 0;
            workpensumErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.CmbWorkPensum.Validated += new System.EventHandler(this.CmbWorkPensum_Validated);


            // ErrorProvider department

            departmentErrorProvider = new System.Windows.Forms.ErrorProvider();
            departmentErrorProvider.SetIconAlignment(this.CmbDepartment, ErrorIconAlignment.MiddleRight);
            departmentErrorProvider.SetIconPadding(this.CmbDepartment, 2);
            departmentErrorProvider.BlinkRate = 0;
            departmentErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.CmbDepartment.Validated += new System.EventHandler(this.CmbDepartment_Validated);


            // ErrorProvider companyname

            companynameErrorProvider = new System.Windows.Forms.ErrorProvider();
            companynameErrorProvider.SetIconAlignment(this.TxtCompanyName, ErrorIconAlignment.MiddleRight);
            companynameErrorProvider.SetIconPadding(this.TxtCompanyName, 2);
            companynameErrorProvider.BlinkRate = 0;
            companynameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtCompanyName.Validated += new System.EventHandler(this.TxtCompanyName_Validated);


            // ErrorProvider title

            titleErrorProvider = new System.Windows.Forms.ErrorProvider();
            titleErrorProvider.SetIconAlignment(this.TxtTitle, ErrorIconAlignment.MiddleRight);
            titleErrorProvider.SetIconPadding(this.TxtTitle, 2);
            titleErrorProvider.BlinkRate = 0;
            titleErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtTitle.Validated += new System.EventHandler(this.TxtTitle_Validated);


            // ErrorProvider birthplace

            birthplaceErrorProvider = new System.Windows.Forms.ErrorProvider();
            birthplaceErrorProvider.SetIconAlignment(this.TxtBirthplace, ErrorIconAlignment.MiddleRight);
            birthplaceErrorProvider.SetIconPadding(this.TxtBirthplace, 2);
            birthplaceErrorProvider.BlinkRate = 0;
            birthplaceErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtBirthplace.Validated += new System.EventHandler(this.TxtBirthplace_Validated);


            // ErrorProvider businessphone

            businessphoneErrorProvider = new System.Windows.Forms.ErrorProvider();
            businessphoneErrorProvider.SetIconAlignment(this.TxtBusinessPhone, ErrorIconAlignment.MiddleRight);
            businessphoneErrorProvider.SetIconPadding(this.TxtBusinessPhone, 2);
            businessphoneErrorProvider.BlinkRate = 0;
            businessphoneErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtBusinessPhone.Validated += new System.EventHandler(this.TxtBusinessPhone_Validated);


            // ErrorProvider businessfax

            businessfaxErrorProvider = new System.Windows.Forms.ErrorProvider();
            businessfaxErrorProvider.SetIconAlignment(this.TxtBusinessFax, ErrorIconAlignment.MiddleRight);
            businessfaxErrorProvider.SetIconPadding(this.TxtBusinessFax, 2);
            businessfaxErrorProvider.BlinkRate = 0;
            businessfaxErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtBusinessFax.Validated += new System.EventHandler(this.TxtBusinessFax_Validated);


            // ErrorProvider mobilenumber

            mobilenumberErrorProvider = new System.Windows.Forms.ErrorProvider();
            mobilenumberErrorProvider.SetIconAlignment(this.TxtMobileNumber, ErrorIconAlignment.MiddleRight);
            mobilenumberErrorProvider.SetIconPadding(this.TxtMobileNumber, 2);
            mobilenumberErrorProvider.BlinkRate = 0;
            mobilenumberErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtMobileNumber.Validated += new System.EventHandler(this.TxtMobileNumber_Validated);


            // ErrorProvider privatephone

            privatephoneErrorProvider = new System.Windows.Forms.ErrorProvider();
            privatephoneErrorProvider.SetIconAlignment(this.TxtPrivatePhone, ErrorIconAlignment.MiddleRight);
            privatephoneErrorProvider.SetIconPadding(this.TxtPrivatePhone, 2);
            privatephoneErrorProvider.BlinkRate = 0;
            privatephoneErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtPrivatePhone.Validated += new System.EventHandler(this.TxtPrivatePhone_Validated);


            // ErrorProvider nationality

            nationalityErrorProvider = new System.Windows.Forms.ErrorProvider();
            nationalityErrorProvider.SetIconAlignment(this.TxtNationality, ErrorIconAlignment.MiddleRight);
            nationalityErrorProvider.SetIconPadding(this.TxtNationality, 2);
            nationalityErrorProvider.BlinkRate = 0;
            nationalityErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtNationality.Validated += new System.EventHandler(this.TxtNationality_Validated);


            // ErrorProvider ahvnumber

            ahvnumberErrorProvider = new System.Windows.Forms.ErrorProvider();
            ahvnumberErrorProvider.SetIconAlignment(this.TxtAHVNumber, ErrorIconAlignment.MiddleRight);
            ahvnumberErrorProvider.SetIconPadding(this.TxtAHVNumber, 2);
            ahvnumberErrorProvider.BlinkRate = 0;
            ahvnumberErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtAHVNumber.Validated += new System.EventHandler(this.TxtAHVNumber_Validated);


            // ErrorProvider contactperson

            contactpersonErrorProvider = new System.Windows.Forms.ErrorProvider();
            contactpersonErrorProvider.SetIconAlignment(this.TxtContactPerson, ErrorIconAlignment.MiddleRight);
            contactpersonErrorProvider.SetIconPadding(this.TxtContactPerson, 2);
            contactpersonErrorProvider.BlinkRate = 0;
            contactpersonErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.TxtContactPerson.Validated += new System.EventHandler(this.TxtContactPerson_Validated);

            // ErrorProvider apprentyears

            apprentyearsErrorProvider = new System.Windows.Forms.ErrorProvider();
            apprentyearsErrorProvider.SetIconAlignment(this.CmbApprentYears, ErrorIconAlignment.MiddleRight);
            apprentyearsErrorProvider.SetIconPadding(this.CmbApprentYears, 2);
            apprentyearsErrorProvider.BlinkRate = 0;
            apprentyearsErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.CmbApprentYears.Validated += new System.EventHandler(this.CmbApprentYears_Validated);


            // ErrorProvider currentapprentyear

            currentapprentyearErrorProvider = new System.Windows.Forms.ErrorProvider();
            currentapprentyearErrorProvider.SetIconAlignment(this.CmbCurrentApprentYear, ErrorIconAlignment.MiddleRight);
            currentapprentyearErrorProvider.SetIconPadding(this.CmbCurrentApprentYear, 2);
            currentapprentyearErrorProvider.BlinkRate = 0;
            currentapprentyearErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            this.CmbCurrentApprentYear.Validated += new System.EventHandler(this.CmbCurrentApprentYear_Validated);

        }


        /*---------------------------------------------------------------------
        Validation
        -----------------------------------------------------------------------*/

        private void TxtFirstname_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var firstname = this.TxtFirstname.Text;
            Match match = regex.Match(firstname);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                firstnameErrorProvider.SetError(this.TxtFirstname, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                firstnameErrorProvider.SetError(this.TxtFirstname, "Invalid Firstname Format!");
            }
        }


        private void TxtLastname_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var lastname = this.TxtLastname.Text;
            Match match = regex.Match(lastname);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                lastnameErrorProvider.SetError(this.TxtLastname, String.Empty);
            }
            else
            {
                // Set the error if the lastname is not valid.
                lastnameErrorProvider.SetError(this.TxtLastname, "Invalid Lastname Format!");
            }
        }


        private void TxtStreet_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?<name>\w[\s\w]+?)\s*(?<num>\d+\s*[a-z]?)$");
            var street = this.TxtStreet.Text;
            Match match = regex.Match(street);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                streetErrorProvider.SetError(this.TxtStreet, String.Empty);
            }
            else
            {
                // Set the error if the street is not valid.
                streetErrorProvider.SetError(this.TxtStreet, "Invalid Street and Number Format!");
            }
        }


        private void TxtCity_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var city = this.TxtCity.Text;
            Match match = regex.Match(city);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                cityErrorProvider.SetError(this.TxtCity, String.Empty);
            }
            else
            {
                // Set the error if the city is not valid.
                cityErrorProvider.SetError(this.TxtCity, "Invalid City Format!");
            }
        }


        private void TxtEmail_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var mail = this.TxtEmail.Text;
            Match match = regex.Match(mail);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                emailErrorProvider.SetError(this.TxtEmail, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                emailErrorProvider.SetError(this.TxtEmail, "Invalid Email Format!");
            }
        }



        private void TxtZipcode_Validated(object sender, EventArgs e)
        {

            Regex regex = new Regex("^[0-9]{4}(?:-[0-9]{4})?$");
            var zip = this.TxtZipcode.Text;
            Match match = regex.Match(zip);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                zipcodeErrorProvider.SetError(this.TxtZipcode, String.Empty);
            }
            else
            {
                // Set the error if the zip is not valid.
                zipcodeErrorProvider.SetError(this.TxtZipcode, "Invalid ZIP Format!");
            }

        }

        private void TxtRole_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var role = this.TxtRole.Text;
            Match match = regex.Match(role);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                roleErrorProvider.SetError(this.TxtRole, String.Empty);
            }
            else
            {
                // Set the error if the role is not valid.
                roleErrorProvider.SetError(this.TxtRole, "Invalid Role Format!");
            }
        }

        private void TxtCompanyName_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var companyname = this.TxtCompanyName.Text;
            Match match = regex.Match(companyname);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                companynameErrorProvider.SetError(this.TxtCompanyName, String.Empty);
            }
            else
            {
                // Set the error if the companyname is not valid.
                companynameErrorProvider.SetError(this.TxtCompanyName, "Invalid Company Format!");
            }
        }


        private void TxtTitle_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var title = this.TxtTitle.Text;
            Match match = regex.Match(title);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                titleErrorProvider.SetError(this.TxtTitle, String.Empty);
            }
            else
            {
                // Set the error if the title is not valid.
                titleErrorProvider.SetError(this.TxtTitle, "Invalid Title Format!");
            }
        }


        private void TxtBirthplace_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var birthplace = this.TxtBirthplace.Text;
            Match match = regex.Match(birthplace);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                birthplaceErrorProvider.SetError(this.TxtBirthplace, String.Empty);
            }
            else
            {
                // Set the error if the birthplace is not valid.
                birthplaceErrorProvider.SetError(this.TxtBirthplace, "Invalid Birthplace Format!");
            }
        }


        private void TxtBusinessPhone_Validated(object sender, EventArgs e)
        {

            Regex regex = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
            var businessphone = this.TxtBusinessPhone.Text;
            Match match = regex.Match(businessphone);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                businessphoneErrorProvider.SetError(this.TxtBusinessPhone, String.Empty);
            }
            else
            {
                // Set the error if the businessphone is not valid.
                businessphoneErrorProvider.SetError(this.TxtBusinessPhone, "Invalid Business Phone Format!");
            }

        }

        private void TxtBusinessFax_Validated(object sender, EventArgs e)
        {

            Regex regex = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
            var businessfax = this.TxtBusinessFax.Text;
            Match match = regex.Match(businessfax);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                businessfaxErrorProvider.SetError(this.TxtBusinessFax, String.Empty);
            }
            else
            {
                // Set the error if the businessfax is not valid.
                businessfaxErrorProvider.SetError(this.TxtBusinessFax, "Invalid Business Fax Format!");
            }

        }



        private void TxtMobileNumber_Validated(object sender, EventArgs e)
        {

            Regex regex = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
            var mobilenumber = this.TxtMobileNumber.Text;
            Match match = regex.Match(mobilenumber);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                mobilenumberErrorProvider.SetError(this.TxtMobileNumber, String.Empty);
            }
            else
            {
                // Set the error if the mobilenumber is not valid.
                mobilenumberErrorProvider.SetError(this.TxtMobileNumber, "Invalid Mobile Number Format!");
            }

        }

        private void TxtPrivatePhone_Validated(object sender, EventArgs e)
        {

            Regex regex = new Regex("^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
            var privatephone = this.TxtPrivatePhone.Text;
            Match match = regex.Match(privatephone);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                privatephoneErrorProvider.SetError(this.TxtPrivatePhone, String.Empty);
            }
            else
            {
                // Set the error if the mobilenumber is not valid.
                privatephoneErrorProvider.SetError(this.TxtPrivatePhone, "Invalid Private Phone Format!");
            }

        }


        private void TxtNationality_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var nationality = this.TxtNationality.Text;
            Match match = regex.Match(nationality);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                nationalityErrorProvider.SetError(this.TxtNationality, String.Empty);
            }
            else
            {
                // Set the error if the nationality is not valid.
                nationalityErrorProvider.SetError(this.TxtNationality, "Invalid Nationality Format!");
            }
        }


        private void TxtAHVNumber_Validated(object sender, EventArgs e)
        {

            Regex regex = new Regex(@" ^ *[0 - 9\.] + $");
            var ahvnumber = this.TxtAHVNumber.Text;
            Match match = regex.Match(ahvnumber);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                ahvnumberErrorProvider.SetError(this.TxtAHVNumber, String.Empty);
            }
            else
            {
                // Set the error if the ahvnumber is not valid.
                ahvnumberErrorProvider.SetError(this.TxtAHVNumber, "Invalid AHV Number Format!");
            }

        }


        private void TxtContactPerson_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-z]+");
            var contactperson = this.TxtContactPerson.Text;
            Match match = regex.Match(contactperson);

            if (match.Success)
            {
                // Clear the error, if any, in the error provider.
                contactpersonErrorProvider.SetError(this.TxtContactPerson, String.Empty);
            }
            else
            {
                // Set the error if the contactperson is not valid.
                contactpersonErrorProvider.SetError(this.TxtContactPerson, "Invalid Name Format!");
            }
        }




        private bool Validation()
        {
            //validate each field with the error message
            bool validated = true;

            string error = firstnameErrorProvider.GetError(this.TxtFirstname);

            if (error != String.Empty)
            {
                validated = false;
            }


            error = lastnameErrorProvider.GetError(this.TxtLastname);

            if (error != String.Empty)
            {
                validated = false;
            }

            error = cityErrorProvider.GetError(this.TxtCity);

            if (error != String.Empty)
            {
                validated = false;
            }

            error = streetErrorProvider.GetError(this.TxtStreet);

            if (error != String.Empty)
            {
                validated = false;
            }

            error = emailErrorProvider.GetError(this.TxtEmail);

            if (error != String.Empty)
            {
                validated = false;
            }

            error = zipcodeErrorProvider.GetError(this.TxtZipcode);

            if (error != String.Empty)
            {
                validated = false;
            }

            if (RadEmployee.Checked)
            {
                error = roleErrorProvider.GetError(this.TxtRole);

                if (error != String.Empty)
                {
                    validated = false;
                }
            }
            if (RadTrainee.Checked)
            {
                error = roleErrorProvider.GetError(this.TxtRole);

                if (error != String.Empty)
                {
                    validated = false;
                }

            }
            if (RadCustomer.Checked)
            {

            }
            return validated;
        }

        
        private void CmbSalutation_Validated(object sender, EventArgs e)
        {


            if (CmbSalutation.SelectedItem == null)
            {
                salutationErrorProvider.SetError(this.CmbSalutation, "Please select a Salutation!");
            }
            else
            {
                salutationErrorProvider.Clear();
            }
        }

        
        private void CmbGender_Validated(object sender, EventArgs e)
        {
            if (CmbGender.SelectedItem == null)
            {
                genderErrorProvider.SetError(this.CmbGender, "Please select a Gender!"); 
            }
            else
            {
                genderErrorProvider.Clear();
            }
        }



        private void CmbDepartment_Validated(object sender, EventArgs e)
        {
            if (CmbDepartment.SelectedItem == null)
            {
                departmentErrorProvider.SetError(this.CmbDepartment, "Please select a Department!");
            }
            else
            {
                departmentErrorProvider.Clear();
            }
        }

        private void CmbWorkPensum_Validated(object sender, EventArgs e)
        {
            if (CmbWorkPensum.SelectedItem == null)
            {
                workpensumErrorProvider.SetError(this.CmbWorkPensum, "Please select a Work Pensum!");
            }
            else
            {
                workpensumErrorProvider.Clear();
            }
        }


        private void CmbApprentYears_Validated(object sender, EventArgs e)
        {


            if (CmbApprentYears.SelectedItem == null)
            {
                apprentyearsErrorProvider.SetError(this.CmbApprentYears, "Please select a Year!");
            }
            else
            {
                apprentyearsErrorProvider.Clear();
            }
        }


        private void CmbCurrentApprentYear_Validated(object sender, EventArgs e)
        {


            if (CmbCurrentApprentYear.SelectedItem == null)
            {
                currentapprentyearErrorProvider.SetError(this.CmbCurrentApprentYear, "Please select a Year!");
            }
            else
            {
                currentapprentyearErrorProvider.Clear();
            }
        }


        private bool CheckMandetoryFields ()
        {
            //Check if mandetory fields have some input
            bool check = true;

            //Check mandetory person fields
            if(CmbSalutation.SelectedItem == null)
            {
                check = false;
            }
            if(TxtFirstname.Text.Length < 1)
            {
                check = false;
            }
            if(TxtLastname.Text.Length < 1)
            {
                check = false;
            }
            if(CmbGender.SelectedItem == null)
            {
                check = false;
            }
            if (TxtEmail.Text.Length < 1)
            {
                check = false;
            }
            if (TxtStreet.Text.Length < 1)
            {
                check = false;
            }
            if (TxtCity.Text.Length < 1)
            {
                check = false;
            }
            if (TxtZipcode.Text.Length < 1)
            {
                check = false;
            }

            
            if (RadEmployee.Checked || RadTrainee.Checked)
            {
                //Check mandetory employee fields
                if (CmbDepartment.SelectedItem == null)
                {
                    check = false;
                }
                if (TxtRole.Text.Length < 1)
                {
                    check = false;
                }
                if (CmbWorkPensum.SelectedItem == null)
                {
                    check = false;
                }
            }
            if (RadTrainee.Checked)
            {
                //Check mandetory trainee fields
                if (TxtApprentYears.Text.Length < 1)
                {
                    check = false;
                }
                if (TxtCurrentApprentYear.Text.Length < 1)
                {
                    check = false;
                }

            }
            if (RadCustomer.Checked)
            {
                //Check mandetory customer fields
                if (TxtCompanyName.Text.Length < 1)
                {
                    check = false;
                }
                if (CmbCustomerType.SelectedItem == null)
                {
                    check = false;
                }
            }

            return check;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        /*---------------------------------------------------------------------
        Listbox
        -----------------------------------------------------------------------*/
        private void LsbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsbOutput.SelectedIndex >= 0)
            { //Hide comboboxes and date pickers
                HideAllCmbPers();

                //disable all fields
                DisableAll();

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

                //Checkbox
                ChkStatus.Checked = selectedPerson.Disabled;


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
                        TxtStartDate.Text = selectedTrainee.Entrydate.ToShortDateString();
                        TxtLeaveDate.Text = selectedTrainee.Exitdate.ToShortDateString();
                        TxtEmplNr.Text = Convert.ToString(selectedTrainee.EmplNr);
                        TxtBirthplace.Text = selectedTrainee.Birthplace;
                        TxtNationality.Text = selectedTrainee.Nationality;
                        TxtRole.Text = selectedTrainee.Role;
                        TxtMgmtLevel.Text = Convert.ToString(selectedTrainee.Lvl);
                        TxtWorkPensum.Text = selectedTrainee.Workpensum;
                        TxtPrivatePhone.Text = selectedTrainee.Privatephone;
                        TxtApprentYears.Text = selectedTrainee.Appyears;
                        TxtCurrentApprentYear.Text = selectedTrainee.Currappyear;
                        break;

                    case "Customer":
                        //make all relevant textboxes and lables visible
                        ShowAllCust();

                        //Hide irrelvant textboxes and lables
                        HideAllEmp();
                        HideAllTrnee();

                        //Hide comboboxes and date pickers
                        HideAllCmbCust();

                        //enable take notes
                        CmdTakeNotes.Enabled = true;

                        //Cast the selected object of the list into type "Customer" and write into the variable "selectedCustomer"
                        Customer selectedCustomer = (Customer)selectedPerson;

                        //Select radio button
                        RadCustomer.Checked = true;

                        //Write the properties of the object of type "Customer" into the specific textboxes
                        TxtCompanyName.Text = selectedCustomer.Companyname;
                        TxtCustomerType.Text = Convert.ToString(selectedCustomer.Type);
                        TxtContactPerson.Text = selectedCustomer.Companycontact;
                        TxtNotesHistory.Text = selectedCustomer.NotesHistory;
                        break;
                }


                //Check if the user is active or not
                if (selectedPerson.Disabled == true)
                {
                    //Call function for user status inactive
                    DisableAllPers();

                }
                else if (selectedPerson.Disabled == false)
                {
                    //Call function for user status active
                    //EnableAllPers();
                }
            }
        }

        private void LsbOutput_Format(object sender, ListControlConvertEventArgs e)
        {
            string id = ((Person)e.ListItem).Id.ToString();
            string sal = ((Person)e.ListItem).Salutation.ToString();
            string firstname = ((Person)e.ListItem).Firstname.ToString();
            string lastname = ((Person)e.ListItem).Lastname.ToString();
            string type = ((Person)e.ListItem).GetClassName();

            var output = $"{id}: {sal} {firstname} {lastname} - {type}";

            e.Value = output;
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            // Reset search results
            Db.search.Clear();

            //Check if search or cancel search
            if (CmdSearch.Text == "Search")
            {
                if (TxtSearch.Text.Length > 0)
                {
                    foreach (Person p in Db.contactList)
                    {
                        //Serarch in Firstname, Lastname, City, Zip Code, Businessphone and Mobilephone
                        //More attributs can be added to the if statement
                        if
                            (
                                //lower text that the search is not case sensetive (not needed in number fields)
                                p.Firstname.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                p.Lastname.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                p.City.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                p.Zipcode.Contains(TxtSearch.Text)
                            )
                        {
                            Db.AddSearchResult(p);
                        }
                        else if
                            (
                                p.Businessphone != null && p.Businessphone.Contains(TxtSearch.Text)
                            )
                        {
                            Db.AddSearchResult(p);
                        }
                        else if
                            (
                                p.Mobilephone != null && p.Mobilephone.Contains(TxtSearch.Text)
                            )
                        {
                            Db.AddSearchResult(p);
                        }
                    }

                    // Change listbox datasource to Search Results
                    LsbOutput.DataSource = Db.search;

                    //Disables add user and export
                    CmdAddUser.Enabled = false;

                    //Change Button text to cancel
                    CmdSearch.Text = "Cancel Search";
                }
                else
                {
                    MessageBox.Show("Please enter a search string!");
                }
            }
            else
            {
                //Change datasource to all contacts
                LsbOutput.DataSource = Db.contactList;

                //activate add user and export
                CmdAddUser.Enabled = true;

                //Reset Search Text
                TxtSearch.Text = "";

                //Change search button text
                CmdSearch.Text = "Search";
            }

        }

        /*---------------------------------------------------------------------
        Buttons
        -----------------------------------------------------------------------*/
        private void CmdAddUser_Click(object sender, EventArgs e)
        {
            CmdAddUser.Tag = "Clicked";

            LsbOutput.Enabled = false;

            //Disables unusable buttons, combo boxes, and list boxes
            ChkStatus.Enabled = false;
            CmdTakeNotes.Enabled = false;
            CmdDeleteUser.Enabled = false;
            CmdEditUser.Enabled = false;
            CmdSearch.Enabled = false;

            //Change buttons
            CmdAddUser.Visible = false;
            CmdSave.Visible = true;
            CmdCancel.Visible = true;

            //Uncheck radio buttons
            UncheckAllRad();

            //set disable user to unchecked
            ChkStatus.Checked = false;

            //Disable Take notes for customer
            CmdTakeNotes.Enabled = false;

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
    

        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            bool validated = Validation();
            bool check = CheckMandetoryFields();

            if (validated && check)
            {
                if (CmdAddUser.Tag.ToString() == "Clicked")
                {

                    if (RadEmployee.Checked)
                    {
                        //Increase the value of the variable id
                        id++;


                        Employee empl1 = new Employee
                        {
                            Disabled = ChkStatus.Checked, // User enabled
                            Id = id,
                            Salutation = Convert.ToString(CmbSalutation.SelectedItem),
                            Firstname = TxtFirstname.Text,
                            Lastname = TxtLastname.Text,
                            Birthdate = DtpBirthdate.Value, //Birthdate
                            CreationDate = DateTime.Now, //Creation date
                            Gender = Convert.ToString(CmbGender.SelectedItem),
                            Mail = TxtEmail.Text,
                            Street = TxtStreet.Text,
                            City = TxtCity.Text,
                            Zipcode = TxtZipcode.Text,
                            ChangeHistory = Convert.ToString(DateTime.Now) + " - " + user + Environment.NewLine, //change history
                            EmplNr = id, //EmplNumber
                            Departement = Convert.ToString(CmbDepartment.SelectedItem),
                            Workpensum = Convert.ToString(CmbWorkPensum.SelectedItem),
                            Entrydate = DtpStartDate.Value, //EntryDate
                            Exitdate = DtpLeaveDate.Value, //Exitdate
                            Role = TxtRole.Text
                        };

                        //Add Employee to contact list (database)
                        Db.AddPerson(empl1);

                        //Call method to save the new object on the harddisk
                        Db.Serialisation();

                        SetDashboardNumbers();

                        //Set optional fields
                        SetAttributesEmpl_optional(empl1);

                        CmdAddUser.Tag = "";

                        //reset Buttons
                        ResetAddUser();
                    }
                    else if (RadTrainee.Checked)
                    {
                        //Increase the value of the variable id
                        id++;

                        Trainee train1 = new Trainee
                        {
                            Disabled = ChkStatus.Checked, // User enabled
                            Id = id,
                            Salutation = Convert.ToString(CmbSalutation.SelectedItem),
                            Firstname = TxtFirstname.Text,
                            Lastname = TxtLastname.Text,
                            Birthdate = DtpBirthdate.Value, //Birthdate
                            CreationDate = DateTime.Now, //Creation date
                            Gender = Convert.ToString(CmbGender.SelectedItem),
                            Mail = TxtEmail.Text,
                            Street = TxtStreet.Text,
                            City = TxtCity.Text,
                            Zipcode = TxtZipcode.Text,
                            ChangeHistory = Convert.ToString(DateTime.Now) + " - " + user + Environment.NewLine, //change history
                            EmplNr = id, //EmplNumber
                            Departement = Convert.ToString(CmbDepartment.SelectedItem),
                            Workpensum = Convert.ToString(CmbWorkPensum.SelectedItem),
                            Entrydate = DtpStartDate.Value, //EntryDate
                            Exitdate = DtpLeaveDate.Value, //ExitDate
                            Role = TxtRole.Text,
                            Appyears = Convert.ToString(CmbApprentYears.SelectedItem),
                            Currappyear = Convert.ToString(CmbCurrentApprentYear.SelectedItem)
                        };

                        //Add Customer to contact list (database)
                        Db.AddPerson(train1);

                        //Call method to save the new object on the harddisk
                        Db.Serialisation();

                        SetDashboardNumbers();

                        //Set optional fields
                        SetAttributesTrainee_optional(train1);

                        CmdAddUser.Tag = "";

                        //reset Buttons
                        ResetAddUser();
                    }
                    else if (RadCustomer.Checked)
                    {
                        //Increase the value of the variable id
                        id++;

                        Customer cust1 = new Customer
                        {
                            Disabled = ChkStatus.Checked, // User enabled
                            Id = id,
                            Salutation = Convert.ToString(CmbSalutation.SelectedItem),
                            Firstname = TxtFirstname.Text,
                            Lastname = TxtLastname.Text,
                            Birthdate = DtpBirthdate.Value, //Birthdate
                            CreationDate = DateTime.Now, //Creation date
                            Gender = Convert.ToString(CmbGender.SelectedItem),
                            Mail = TxtEmail.Text,
                            Street = TxtStreet.Text,
                            City = TxtCity.Text,
                            Zipcode = TxtZipcode.Text,
                            ChangeHistory = Convert.ToString(DateTime.Now) + " - " + user + Environment.NewLine, //change history
                            Companyname = TxtCompanyName.Text,
                            Type = (CustType)CmbCustomerType.SelectedValue,
                            Companycontact = TxtContactPerson.Text
                        };

                        //Add Customer to contact list (database)
                        Db.AddPerson(cust1);

                        //Call method to save the new object on the harddisk
                        Db.Serialisation();

                        SetDashboardNumbers();

                        //Set optional fields
                        SetAttributesCust_optional(cust1);

                        CmdAddUser.Tag = "";

                        //reset Buttons
                        ResetAddUser();
                    }
                    else
                    {
                        MessageBox.Show("Please select contact type!");
                    }
                }
                else if (CmdEditUser.Tag.ToString() == "Clicked")
                {
                    if (RadCustomer.Checked)
                    {
                        SetAttributesCust_mandatory(LsbOutput.SelectedItem as Customer);
                        SetAttributesCust_optional(LsbOutput.SelectedItem as Customer);

                        Db.Serialisation();
                        SetDashboardNumbers();
                        CmdEditUser.Tag = "";
                    }
                    else if (RadEmployee.Checked)
                    {
                        SetAttributesEmp_mandatory(LsbOutput.SelectedItem as Employee);
                        SetAttributesEmpl_optional(LsbOutput.SelectedItem as Employee);

                        Db.Serialisation();
                        CmdEditUser.Tag = "";
                    }
                    else if (RadTrainee.Checked)
                    {
                        SetAttributesTrainee_mandatory(LsbOutput.SelectedItem as Trainee);
                        SetAttributesTrainee_optional(LsbOutput.SelectedItem as Trainee);

                        Db.Serialisation();
                        SetDashboardNumbers();
                        CmdEditUser.Tag = "";
                    }

                    //reset Buttons
                    ResetAddUser();
                }
            }
            else
            {
                MessageBox.Show("Please check your Data!");
            }

        }

        private void CmdEditUser_Click(object sender, EventArgs e)
        {
            CmdEditUser.Tag = "Clicked";

            LsbOutput.Enabled = false;
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
                EnableAllEmp();
                ShowAllCmbEmp();
            }
            else if (RadTrainee.Checked)
            {
                EnableAllEmp();
                EnableAllTrnee();
                ShowAllCmbEmp();
                ShowAllCmbTrnee();
            }
            else if (RadCustomer.Checked)
            {
                EnableAllCust();
                ShowAllCmbCust();
            }


            //Call method to update the Object on the HDD
            Db.Serialisation();
            SetDashboardNumbers();

        }

        private void CmdDeleteUser_Click(object sender, EventArgs e)
        {
            //Variable of type "Person" which is containing the object of the currently selected item in the listbox
            Person selectedPerson = (Person)LsbOutput.SelectedItem;

            //Call function to delete the user
            Db.DeletePerson(selectedPerson);

            Db.Serialisation();
            SetDashboardNumbers();

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            ShowStartScreen();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                HideButtons();
                HideListBox();
            }
            else if (TabControl.SelectedIndex == 1)
            {
                if (user == "admin")
                {
                    ShowButtons();
                }

                ShowListBox();

            }
            else if (TabControl.SelectedIndex == 2)
            {
                HideButtons();
                ShowListBox();
            }
        }

        private void ShowButtons()
        {
            CmdAddUser.Visible = true;
            CmdDeleteUser.Visible = true;
            CmdEditUser.Visible = true;
        }

        private void HideButtons()
        {
            CmdAddUser.Visible = false;
            CmdDeleteUser.Visible = false;
            CmdEditUser.Visible = false;
        }

        private void ShowListBox()
        {
            LsbOutput.Visible = true;
            TxtSearch.Visible = true;
            TxtSearchHint.Visible = true;
            CmdSearch.Visible = true;
        }

        private void HideListBox()
        {
            LsbOutput.Visible = false;
            TxtSearch.Visible = false;
            TxtSearchHint.Visible = false;
            CmdSearch.Visible = false;
        }

        private void CmdTakeNotes_Click(object sender, EventArgs e)
        {
            if (CmdTakeNotes.Text == "Take notes")
            {
                //Enable Text Box
                TxtNotes.Enabled = true;
                TxtNotes.ReadOnly = false;
                CmdTakeNotes.Text = "Save";
            }
            else if (CmdTakeNotes.Text == "Save")
            {
                //Cast into customer to run Take Notes function
                Customer cust = LsbOutput.SelectedItem as Customer;
                cust.TakeNotes(user + " - " + TxtNotes.Text);

                //Display Changes in Notes History
                TxtNotesHistory.Text = cust.NotesHistory;

                //Save Notes
                Db.Serialisation();

                //Disable Textbox
                TxtNotes.Enabled = false;
                TxtNotes.ReadOnly = true;
                CmdTakeNotes.Text = "Take notes";

                //Reset Textbox
                TxtNotes.ResetText();
            }

        }

        /*---------------------------------------------------------------------
         * Functions
         * -------------------------------------------------------------------*/

        private void ResetAddUser ()
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
            CmdSearch.Enabled = true;

            //disable all fields
            DisableAll();

            //Update Dashboard Numbers
            SetDashboardNumbers();

            //Set Selected Index to 0 
            ShowStartScreen();
        }

        //Set all mandatory attributes for employees
        private void SetAttributesEmp_mandatory(Person p)
        {
            //Cast person into employee
            Employee emp = (Employee)p;

            //Call method to set mandatory attributes
            emp.SetMandatoryAttributes(
                disabled: ChkStatus.Checked,
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                birthdate: DtpBirthdate.Value,
                gender: Convert.ToString(CmbGender.SelectedItem),
                mail: TxtEmail.Text,
                street: TxtStreet.Text,
                city: TxtCity.Text,
                zip: TxtZipcode.Text,
                changehistory: emp.ChangeHistory + DateTime.Now.ToString() + " - " + user + Environment.NewLine,
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
                    lvl: (MgmLvl)CmbMgmtLevel.SelectedItem
                    );
        }

        //Set all mandatory attributes for Customers
        private void SetAttributesCust_mandatory(Person p)
        {
            //Cast person into customer
            Customer cust = (Customer)p;

            //Call method to set mandatory attributes
            cust.SetMandatoryAttributes(
                disabled: ChkStatus.Checked,
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                birthdate: DtpBirthdate.Value,
                gender: Convert.ToString(CmbGender.SelectedItem),
                mail: TxtEmail.Text,
                street: TxtStreet.Text,
                city: TxtCity.Text,
                zip: TxtZipcode.Text,
                changehistory: cust.ChangeHistory + DateTime.Now.ToString() + " - " + user + Environment.NewLine,
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
                    bfa: TxtBusinessFax.Text,
                    compcont: TxtContactPerson.Text
                    );
        }

        //Function to set all mandatory attributes for trainees
        private void SetAttributesTrainee_mandatory(Person p)
        {
            //Cast person into Trainee
            Trainee appr = (Trainee)p;

            //Call method to set mandatory attributes
            appr.SetMandatoryAttributes(
                disabled: ChkStatus.Checked,
                sal: Convert.ToString(CmbSalutation.SelectedItem),
                fn: TxtFirstname.Text,
                ln: TxtLastname.Text,
                birthdate: DtpBirthdate.Value,
                gender: Convert.ToString(CmbGender.SelectedItem),
                mail: TxtEmail.Text,
                street: TxtStreet.Text,
                city: TxtCity.Text,
                zip: TxtZipcode.Text,
                changehistory: appr.ChangeHistory + DateTime.Now.ToString() + " - " + user + Environment.NewLine,
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
                    nat: TxtNationality.Text,
                    birthpl: TxtBirthplace.Text,
                    exdate: DtpLeaveDate.Value,
                    lvl: (MgmLvl)CmbMgmtLevel.SelectedItem,
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
            if (CmdAddUser.Tag.ToString() == "Clicked" || CmdEditUser.Tag.ToString() == "Clicked")
            {
                ShowAllCmbEmp();
                EnableAllEmp();
            }

            //Make all Employee textboxes visible & enabled
            ShowAllEmp();

            //hides all others
            HideAllTrnee();
            HideAllCust();
            HideAllCmbCust();
            HideAllCmbTrnee();
        }

        private void RadTrainee_CheckedChanged(object sender, EventArgs e)
        {
            if (CmdAddUser.Tag.ToString() == "Clicked" || CmdEditUser.Tag.ToString() == "Clicked")
            {
                ShowAllCmbEmp();
                ShowAllCmbTrnee();
                EnableAllTrnee();
                EnableAllEmp();
            }

            //Make all Trainee textboxes visible & enabled
            ShowAllEmp();
            ShowAllTrnee();

            //hides all others
            HideAllCust();
            HideAllCmbCust();
        }
        private void RadCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (CmdAddUser.Tag.ToString() == "Clicked" || CmdEditUser.Tag.ToString() == "Clicked")
            {
                ShowAllCmbCust();
                EnableAllCust();
            }

            //Make all Customer textboxes visible & enabled
            ShowAllCust();

            //hides all others
            HideAllTrnee();
            HideAllEmp();
            HideAllCmbTrnee();
            HideAllCmbEmp();
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
            CmdTakeNotes.Enabled = true;
            LsbOutput.Enabled = true;
            CmdAddUser.Enabled = true;
            CmdDeleteUser.Enabled = true;
            CmdEditUser.Enabled = true;
            CmdSearch.Enabled = true;

            //Deaktivate checkbox
            ChkStatus.Enabled = false;
            ChkStatus.Checked = false;

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
            DisableAll();

            //unselect listbox
            LsbOutput.ClearSelected();
        }

        //Enables all Person Textboxes, Comboboxes and Radio Buttons
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
            CmbGender.Enabled = true;

            ChkStatus.Enabled = true;

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

            //Employee Number is always grayed out
            TxtEmplNr.Enabled = false;
        }

        //Enables all Customer Textboxes
        private void EnableAllCust()
        {
            TxtCompanyName.ReadOnly = false;
            TxtCustomerType.ReadOnly = false;
            TxtContactPerson.ReadOnly = false;

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
        private void DisableAll()
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

            ChkStatus.Enabled = false;
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
            TxtContactPerson.ReadOnly = true;
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
            TxtContactPerson.Visible = false;
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
            TxtContactPerson.Visible = true;
            LblCompanyName.Visible = true;
            LblCustomerType.Visible = true;
            LblContactPerson.Visible = true;
            TxtNotes.Visible = true;
            TxtNotesHistory.Visible = true;
            LblNotesHistory.Visible = true;
            CmdTakeNotes.Visible = true;
            if (CmdAddUser.Tag.ToString() == "Clicked")
            {
                CmdTakeNotes.Enabled = false;
            }
            else
            {
                CmdTakeNotes.Enabled = true;
            }

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
            TxtContactPerson.ResetText();
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
    }
}

