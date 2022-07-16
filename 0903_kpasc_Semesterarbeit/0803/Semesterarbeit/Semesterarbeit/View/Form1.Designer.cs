using System.Windows.Forms;

namespace Semesterarbeit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtSalutation = new System.Windows.Forms.TextBox();
            this.LstEntries = new System.Windows.Forms.ListBox();
            this.RadEmployees = new System.Windows.Forms.RadioButton();
            this.RadCustomers = new System.Windows.Forms.RadioButton();
            this.LblSalutation = new System.Windows.Forms.Label();
            this.LblFirstname = new System.Windows.Forms.Label();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.LblSecondname = new System.Windows.Forms.Label();
            this.TxtSecondname = new System.Windows.Forms.TextBox();
            this.LblLastname = new System.Windows.Forms.Label();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.LblBirthdate = new System.Windows.Forms.Label();
            this.TxtBirthdate = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.LblBusinessPhone = new System.Windows.Forms.Label();
            this.TxtBusinessPhone = new System.Windows.Forms.TextBox();
            this.LblBusinessFax = new System.Windows.Forms.Label();
            this.TxtBusinessFax = new System.Windows.Forms.TextBox();
            this.LblMobileNumber = new System.Windows.Forms.Label();
            this.TxtMobileNumber = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LblZipcode = new System.Windows.Forms.Label();
            this.TxtZipcode = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.LblCustomerType = new System.Windows.Forms.Label();
            this.TxtCustomerType = new System.Windows.Forms.TextBox();
            this.LblContactPerson = new System.Windows.Forms.Label();
            this.TxtContacPerson = new System.Windows.Forms.TextBox();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.LblAHVNumber = new System.Windows.Forms.Label();
            this.TxtAHVNumber = new System.Windows.Forms.TextBox();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.TxtStartDate = new System.Windows.Forms.TextBox();
            this.LblLeaveDate = new System.Windows.Forms.Label();
            this.TxtLeaveDate = new System.Windows.Forms.TextBox();
            this.LblDenomination = new System.Windows.Forms.Label();
            this.TxtDenomination = new System.Windows.Forms.TextBox();
            this.LblRole = new System.Windows.Forms.Label();
            this.TxtRole = new System.Windows.Forms.TextBox();
            this.LblBirthplace = new System.Windows.Forms.Label();
            this.TxtBirthplace = new System.Windows.Forms.TextBox();
            this.LblNationality = new System.Windows.Forms.Label();
            this.TxtNationality = new System.Windows.Forms.TextBox();
            this.LblMgmtLevel = new System.Windows.Forms.Label();
            this.TxtMgmtLevel = new System.Windows.Forms.TextBox();
            this.LblDirectReports = new System.Windows.Forms.Label();
            this.TxtDirectReports = new System.Windows.Forms.TextBox();
            this.LblWorkPensum = new System.Windows.Forms.Label();
            this.TxtWorkPensum = new System.Windows.Forms.TextBox();
            this.LblCivilStatus = new System.Windows.Forms.Label();
            this.TxtCivilStatus = new System.Windows.Forms.TextBox();
            this.LblPrivatePhone = new System.Windows.Forms.Label();
            this.TxtPrivatePhone = new System.Windows.Forms.TextBox();
            this.LblApprentYears = new System.Windows.Forms.Label();
            this.TxtApprentYears = new System.Windows.Forms.TextBox();
            this.LblCurrentApprentYear = new System.Windows.Forms.Label();
            this.TxtCurrentApprentYear = new System.Windows.Forms.TextBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.RadApprentice = new System.Windows.Forms.RadioButton();
            this.CmdEditUser = new System.Windows.Forms.Button();
            this.CmdDeleteUser = new System.Windows.Forms.Button();
            this.CmdExport = new System.Windows.Forms.Button();
            this.CmbSearch = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearchAttribute = new System.Windows.Forms.Label();
            this.SaveFileChooser = new System.Windows.Forms.SaveFileDialog();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.LblSearchText = new System.Windows.Forms.Label();
            this.CmdResetSearchResults = new System.Windows.Forms.Button();
            this.LblResetSearchResults = new System.Windows.Forms.Label();
            this.LblListboxDescription = new System.Windows.Forms.Label();
            this.LblUserStatus = new System.Windows.Forms.Label();
            this.CmdTakeNotes = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DtpLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.DtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.CmbWorkPensum = new System.Windows.Forms.ComboBox();
            this.CmbCurrentApprentYear = new System.Windows.Forms.ComboBox();
            this.CmbApprentYears = new System.Windows.Forms.ComboBox();
            this.CmbDirectReports = new System.Windows.Forms.ComboBox();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.CmbCivilStatus = new System.Windows.Forms.ComboBox();
            this.CmbMgmtLevel = new System.Windows.Forms.ComboBox();
            this.CmbCustomerType = new System.Windows.Forms.ComboBox();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.CmbSalutation = new System.Windows.Forms.ComboBox();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblNotesHistory = new System.Windows.Forms.Label();
            this.LblLastmodified = new System.Windows.Forms.Label();
            this.LblCreationDate = new System.Windows.Forms.Label();
            this.TxtNotesHistory = new System.Windows.Forms.TextBox();
            this.TxtLastModified = new System.Windows.Forms.TextBox();
            this.TxtCreationDate = new System.Windows.Forms.TextBox();
            this.ChkStatus = new Semesterarbeit.MyToggleCheckbox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSalutation
            // 
            this.TxtSalutation.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSalutation.Location = new System.Drawing.Point(10, 41);
            this.TxtSalutation.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSalutation.Name = "TxtSalutation";
            this.TxtSalutation.Size = new System.Drawing.Size(138, 20);
            this.TxtSalutation.TabIndex = 3;
            // 
            // LstEntries
            // 
            this.LstEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LstEntries.FormattingEnabled = true;
            this.LstEntries.Location = new System.Drawing.Point(24, 57);
            this.LstEntries.Margin = new System.Windows.Forms.Padding(2);
            this.LstEntries.Name = "LstEntries";
            this.LstEntries.Size = new System.Drawing.Size(278, 589);
            this.LstEntries.TabIndex = 0;
            this.LstEntries.SelectedIndexChanged += new System.EventHandler(this.LstEntries_SelectedIndexChanged);
            this.LstEntries.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.LstEntriesFormat);
            // 
            // RadEmployees
            // 
            this.RadEmployees.AutoSize = true;
            this.RadEmployees.Location = new System.Drawing.Point(8, 3);
            this.RadEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.RadEmployees.Name = "RadEmployees";
            this.RadEmployees.Size = new System.Drawing.Size(71, 17);
            this.RadEmployees.TabIndex = 1;
            this.RadEmployees.Text = "Employee";
            this.RadEmployees.UseVisualStyleBackColor = true;
            this.RadEmployees.Visible = false;
            this.RadEmployees.CheckedChanged += new System.EventHandler(this.RadEmployees_CheckedChanged);
            // 
            // RadCustomers
            // 
            this.RadCustomers.AutoSize = true;
            this.RadCustomers.Location = new System.Drawing.Point(160, 3);
            this.RadCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.RadCustomers.Name = "RadCustomers";
            this.RadCustomers.Size = new System.Drawing.Size(69, 17);
            this.RadCustomers.TabIndex = 2;
            this.RadCustomers.Text = "Customer";
            this.RadCustomers.UseVisualStyleBackColor = true;
            this.RadCustomers.Visible = false;
            this.RadCustomers.CheckedChanged += new System.EventHandler(this.RadCustomers_CheckedChanged);
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalutation.Location = new System.Drawing.Point(7, 26);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(58, 13);
            this.LblSalutation.TabIndex = 4;
            this.LblSalutation.Text = "Salutation*";
            // 
            // LblFirstname
            // 
            this.LblFirstname.AutoSize = true;
            this.LblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstname.Location = new System.Drawing.Point(7, 68);
            this.LblFirstname.Name = "LblFirstname";
            this.LblFirstname.Size = new System.Drawing.Size(56, 13);
            this.LblFirstname.TabIndex = 6;
            this.LblFirstname.Text = "Firstname*";
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.BackColor = System.Drawing.SystemColors.Window;
            this.TxtFirstname.Location = new System.Drawing.Point(10, 83);
            this.TxtFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(138, 20);
            this.TxtFirstname.TabIndex = 5;
            // 
            // LblSecondname
            // 
            this.LblSecondname.AllowDrop = true;
            this.LblSecondname.AutoSize = true;
            this.LblSecondname.Location = new System.Drawing.Point(160, 68);
            this.LblSecondname.Name = "LblSecondname";
            this.LblSecondname.Size = new System.Drawing.Size(70, 13);
            this.LblSecondname.TabIndex = 8;
            this.LblSecondname.Text = "Secondname";
            // 
            // TxtSecondname
            // 
            this.TxtSecondname.AllowDrop = true;
            this.TxtSecondname.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSecondname.Location = new System.Drawing.Point(163, 83);
            this.TxtSecondname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSecondname.Name = "TxtSecondname";
            this.TxtSecondname.Size = new System.Drawing.Size(138, 20);
            this.TxtSecondname.TabIndex = 7;
            // 
            // LblLastname
            // 
            this.LblLastname.AutoSize = true;
            this.LblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastname.Location = new System.Drawing.Point(7, 114);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(57, 13);
            this.LblLastname.TabIndex = 10;
            this.LblLastname.Text = "Lastname*";
            // 
            // TxtLastname
            // 
            this.TxtLastname.BackColor = System.Drawing.SystemColors.Window;
            this.TxtLastname.Location = new System.Drawing.Point(10, 129);
            this.TxtLastname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(138, 20);
            this.TxtLastname.TabIndex = 9;
            // 
            // LblBirthdate
            // 
            this.LblBirthdate.AutoSize = true;
            this.LblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBirthdate.Location = new System.Drawing.Point(7, 178);
            this.LblBirthdate.Name = "LblBirthdate";
            this.LblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.LblBirthdate.TabIndex = 12;
            this.LblBirthdate.Text = "Birthdate";
            // 
            // TxtBirthdate
            // 
            this.TxtBirthdate.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBirthdate.Location = new System.Drawing.Point(10, 194);
            this.TxtBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBirthdate.Name = "TxtBirthdate";
            this.TxtBirthdate.Size = new System.Drawing.Size(138, 20);
            this.TxtBirthdate.TabIndex = 11;
            // 
            // LblTitle
            // 
            this.LblTitle.AllowDrop = true;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(160, 27);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 14;
            this.LblTitle.Text = "Title";
            // 
            // TxtTitle
            // 
            this.TxtTitle.AllowDrop = true;
            this.TxtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTitle.Location = new System.Drawing.Point(163, 42);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(138, 20);
            this.TxtTitle.TabIndex = 13;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.Location = new System.Drawing.Point(7, 224);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(42, 13);
            this.LblGender.TabIndex = 16;
            this.LblGender.Text = "Gender";
            // 
            // TxtGender
            // 
            this.TxtGender.BackColor = System.Drawing.SystemColors.Window;
            this.TxtGender.Location = new System.Drawing.Point(10, 239);
            this.TxtGender.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(138, 20);
            this.TxtGender.TabIndex = 15;
            // 
            // LblBusinessPhone
            // 
            this.LblBusinessPhone.AutoSize = true;
            this.LblBusinessPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBusinessPhone.Location = new System.Drawing.Point(335, 26);
            this.LblBusinessPhone.Name = "LblBusinessPhone";
            this.LblBusinessPhone.Size = new System.Drawing.Size(83, 13);
            this.LblBusinessPhone.TabIndex = 18;
            this.LblBusinessPhone.Text = "Business Phone";
            // 
            // TxtBusinessPhone
            // 
            this.TxtBusinessPhone.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBusinessPhone.Location = new System.Drawing.Point(338, 42);
            this.TxtBusinessPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBusinessPhone.Name = "TxtBusinessPhone";
            this.TxtBusinessPhone.Size = new System.Drawing.Size(138, 20);
            this.TxtBusinessPhone.TabIndex = 17;
            // 
            // LblBusinessFax
            // 
            this.LblBusinessFax.AutoSize = true;
            this.LblBusinessFax.Location = new System.Drawing.Point(501, 26);
            this.LblBusinessFax.Name = "LblBusinessFax";
            this.LblBusinessFax.Size = new System.Drawing.Size(69, 13);
            this.LblBusinessFax.TabIndex = 20;
            this.LblBusinessFax.Text = "Business Fax";
            // 
            // TxtBusinessFax
            // 
            this.TxtBusinessFax.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBusinessFax.Location = new System.Drawing.Point(504, 42);
            this.TxtBusinessFax.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBusinessFax.Name = "TxtBusinessFax";
            this.TxtBusinessFax.Size = new System.Drawing.Size(138, 20);
            this.TxtBusinessFax.TabIndex = 19;
            // 
            // LblMobileNumber
            // 
            this.LblMobileNumber.AutoSize = true;
            this.LblMobileNumber.Location = new System.Drawing.Point(335, 68);
            this.LblMobileNumber.Name = "LblMobileNumber";
            this.LblMobileNumber.Size = new System.Drawing.Size(78, 13);
            this.LblMobileNumber.TabIndex = 22;
            this.LblMobileNumber.Text = "Mobile Number";
            // 
            // TxtMobileNumber
            // 
            this.TxtMobileNumber.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMobileNumber.Location = new System.Drawing.Point(338, 83);
            this.TxtMobileNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMobileNumber.Name = "TxtMobileNumber";
            this.TxtMobileNumber.Size = new System.Drawing.Size(138, 20);
            this.TxtMobileNumber.TabIndex = 21;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(335, 114);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(77, 13);
            this.LblEmail.TabIndex = 24;
            this.LblEmail.Text = "Email Address*";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TxtEmail.Location = new System.Drawing.Point(338, 129);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(304, 20);
            this.TxtEmail.TabIndex = 23;
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(501, 178);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(24, 13);
            this.LblCity.TabIndex = 32;
            this.LblCity.Text = "City";
            // 
            // TxtCity
            // 
            this.TxtCity.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCity.Location = new System.Drawing.Point(504, 194);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(138, 20);
            this.TxtCity.TabIndex = 31;
            // 
            // LblZipcode
            // 
            this.LblZipcode.AutoSize = true;
            this.LblZipcode.Location = new System.Drawing.Point(335, 224);
            this.LblZipcode.Name = "LblZipcode";
            this.LblZipcode.Size = new System.Drawing.Size(46, 13);
            this.LblZipcode.TabIndex = 30;
            this.LblZipcode.Text = "Zipcode";
            // 
            // TxtZipcode
            // 
            this.TxtZipcode.BackColor = System.Drawing.SystemColors.Window;
            this.TxtZipcode.Location = new System.Drawing.Point(338, 240);
            this.TxtZipcode.Margin = new System.Windows.Forms.Padding(2);
            this.TxtZipcode.Name = "TxtZipcode";
            this.TxtZipcode.Size = new System.Drawing.Size(138, 20);
            this.TxtZipcode.TabIndex = 29;
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(335, 178);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(35, 13);
            this.LblStreet.TabIndex = 27;
            this.LblStreet.Text = "Street";
            // 
            // TxtStreet
            // 
            this.TxtStreet.BackColor = System.Drawing.SystemColors.Window;
            this.TxtStreet.Location = new System.Drawing.Point(338, 194);
            this.TxtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(138, 20);
            this.TxtStreet.TabIndex = 26;
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(676, 26);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(86, 13);
            this.LblCompanyName.TabIndex = 34;
            this.LblCompanyName.Text = "Company Name*";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCompanyName.Location = new System.Drawing.Point(679, 41);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(139, 20);
            this.TxtCompanyName.TabIndex = 33;
            // 
            // LblCustomerType
            // 
            this.LblCustomerType.AutoSize = true;
            this.LblCustomerType.Location = new System.Drawing.Point(676, 68);
            this.LblCustomerType.Name = "LblCustomerType";
            this.LblCustomerType.Size = new System.Drawing.Size(82, 13);
            this.LblCustomerType.TabIndex = 36;
            this.LblCustomerType.Text = "Customer Type*";
            // 
            // TxtCustomerType
            // 
            this.TxtCustomerType.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCustomerType.Location = new System.Drawing.Point(679, 83);
            this.TxtCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerType.Name = "TxtCustomerType";
            this.TxtCustomerType.Size = new System.Drawing.Size(139, 20);
            this.TxtCustomerType.TabIndex = 35;
            // 
            // LblContactPerson
            // 
            this.LblContactPerson.AutoSize = true;
            this.LblContactPerson.Location = new System.Drawing.Point(676, 114);
            this.LblContactPerson.Name = "LblContactPerson";
            this.LblContactPerson.Size = new System.Drawing.Size(80, 13);
            this.LblContactPerson.TabIndex = 38;
            this.LblContactPerson.Text = "Contact Person";
            // 
            // TxtContacPerson
            // 
            this.TxtContacPerson.BackColor = System.Drawing.SystemColors.Window;
            this.TxtContacPerson.Location = new System.Drawing.Point(679, 129);
            this.TxtContacPerson.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContacPerson.Name = "TxtContacPerson";
            this.TxtContacPerson.Size = new System.Drawing.Size(139, 20);
            this.TxtContacPerson.TabIndex = 37;
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(7, 385);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(66, 13);
            this.LblDepartment.TabIndex = 42;
            this.LblDepartment.Text = "Department*";
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDepartment.Location = new System.Drawing.Point(10, 400);
            this.TxtDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(138, 20);
            this.TxtDepartment.TabIndex = 41;
            // 
            // LblAHVNumber
            // 
            this.LblAHVNumber.AutoSize = true;
            this.LblAHVNumber.Location = new System.Drawing.Point(7, 281);
            this.LblAHVNumber.Name = "LblAHVNumber";
            this.LblAHVNumber.Size = new System.Drawing.Size(69, 13);
            this.LblAHVNumber.TabIndex = 44;
            this.LblAHVNumber.Text = "AHV Number";
            // 
            // TxtAHVNumber
            // 
            this.TxtAHVNumber.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAHVNumber.Location = new System.Drawing.Point(10, 296);
            this.TxtAHVNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAHVNumber.Name = "TxtAHVNumber";
            this.TxtAHVNumber.Size = new System.Drawing.Size(138, 20);
            this.TxtAHVNumber.TabIndex = 43;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(318, 434);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(55, 13);
            this.LblStartDate.TabIndex = 46;
            this.LblStartDate.Text = "Start Date";
            // 
            // TxtStartDate
            // 
            this.TxtStartDate.BackColor = System.Drawing.SystemColors.Window;
            this.TxtStartDate.Location = new System.Drawing.Point(321, 451);
            this.TxtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStartDate.Name = "TxtStartDate";
            this.TxtStartDate.Size = new System.Drawing.Size(138, 20);
            this.TxtStartDate.TabIndex = 45;
            // 
            // LblLeaveDate
            // 
            this.LblLeaveDate.AutoSize = true;
            this.LblLeaveDate.Location = new System.Drawing.Point(484, 434);
            this.LblLeaveDate.Name = "LblLeaveDate";
            this.LblLeaveDate.Size = new System.Drawing.Size(71, 13);
            this.LblLeaveDate.TabIndex = 48;
            this.LblLeaveDate.Text = "Leaving Date";
            // 
            // TxtLeaveDate
            // 
            this.TxtLeaveDate.BackColor = System.Drawing.SystemColors.Window;
            this.TxtLeaveDate.Location = new System.Drawing.Point(487, 451);
            this.TxtLeaveDate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLeaveDate.Name = "TxtLeaveDate";
            this.TxtLeaveDate.Size = new System.Drawing.Size(138, 20);
            this.TxtLeaveDate.TabIndex = 47;
            // 
            // LblDenomination
            // 
            this.LblDenomination.AutoSize = true;
            this.LblDenomination.Location = new System.Drawing.Point(7, 331);
            this.LblDenomination.Name = "LblDenomination";
            this.LblDenomination.Size = new System.Drawing.Size(72, 13);
            this.LblDenomination.TabIndex = 50;
            this.LblDenomination.Text = "Denomination";
            // 
            // TxtDenomination
            // 
            this.TxtDenomination.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDenomination.Location = new System.Drawing.Point(10, 346);
            this.TxtDenomination.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDenomination.Name = "TxtDenomination";
            this.TxtDenomination.Size = new System.Drawing.Size(138, 20);
            this.TxtDenomination.TabIndex = 49;
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Location = new System.Drawing.Point(160, 384);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(33, 13);
            this.LblRole.TabIndex = 52;
            this.LblRole.Text = "Role*";
            // 
            // TxtRole
            // 
            this.TxtRole.BackColor = System.Drawing.SystemColors.Window;
            this.TxtRole.Location = new System.Drawing.Point(163, 399);
            this.TxtRole.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(138, 20);
            this.TxtRole.TabIndex = 51;
            // 
            // LblBirthplace
            // 
            this.LblBirthplace.AutoSize = true;
            this.LblBirthplace.Location = new System.Drawing.Point(160, 178);
            this.LblBirthplace.Name = "LblBirthplace";
            this.LblBirthplace.Size = new System.Drawing.Size(54, 13);
            this.LblBirthplace.TabIndex = 54;
            this.LblBirthplace.Text = "Birthplace";
            // 
            // TxtBirthplace
            // 
            this.TxtBirthplace.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBirthplace.Location = new System.Drawing.Point(163, 194);
            this.TxtBirthplace.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBirthplace.Name = "TxtBirthplace";
            this.TxtBirthplace.Size = new System.Drawing.Size(138, 20);
            this.TxtBirthplace.TabIndex = 53;
            // 
            // LblNationality
            // 
            this.LblNationality.AutoSize = true;
            this.LblNationality.Location = new System.Drawing.Point(160, 224);
            this.LblNationality.Name = "LblNationality";
            this.LblNationality.Size = new System.Drawing.Size(56, 13);
            this.LblNationality.TabIndex = 56;
            this.LblNationality.Text = "Nationality";
            // 
            // TxtNationality
            // 
            this.TxtNationality.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNationality.Location = new System.Drawing.Point(163, 239);
            this.TxtNationality.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNationality.Name = "TxtNationality";
            this.TxtNationality.Size = new System.Drawing.Size(138, 20);
            this.TxtNationality.TabIndex = 55;
            // 
            // LblMgmtLevel
            // 
            this.LblMgmtLevel.AutoSize = true;
            this.LblMgmtLevel.Location = new System.Drawing.Point(7, 434);
            this.LblMgmtLevel.Name = "LblMgmtLevel";
            this.LblMgmtLevel.Size = new System.Drawing.Size(62, 13);
            this.LblMgmtLevel.TabIndex = 58;
            this.LblMgmtLevel.Text = "Mgmt Level";
            // 
            // TxtMgmtLevel
            // 
            this.TxtMgmtLevel.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMgmtLevel.Location = new System.Drawing.Point(10, 449);
            this.TxtMgmtLevel.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMgmtLevel.Name = "TxtMgmtLevel";
            this.TxtMgmtLevel.Size = new System.Drawing.Size(138, 20);
            this.TxtMgmtLevel.TabIndex = 57;
            // 
            // LblDirectReports
            // 
            this.LblDirectReports.AutoSize = true;
            this.LblDirectReports.Location = new System.Drawing.Point(160, 434);
            this.LblDirectReports.Name = "LblDirectReports";
            this.LblDirectReports.Size = new System.Drawing.Size(75, 13);
            this.LblDirectReports.TabIndex = 60;
            this.LblDirectReports.Text = "Direct Reports";
            // 
            // TxtDirectReports
            // 
            this.TxtDirectReports.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDirectReports.Location = new System.Drawing.Point(163, 451);
            this.TxtDirectReports.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDirectReports.Name = "TxtDirectReports";
            this.TxtDirectReports.Size = new System.Drawing.Size(138, 20);
            this.TxtDirectReports.TabIndex = 59;
            // 
            // LblWorkPensum
            // 
            this.LblWorkPensum.AutoSize = true;
            this.LblWorkPensum.Location = new System.Drawing.Point(318, 385);
            this.LblWorkPensum.Name = "LblWorkPensum";
            this.LblWorkPensum.Size = new System.Drawing.Size(74, 13);
            this.LblWorkPensum.TabIndex = 62;
            this.LblWorkPensum.Text = "Work Pensum";
            // 
            // TxtWorkPensum
            // 
            this.TxtWorkPensum.BackColor = System.Drawing.SystemColors.Window;
            this.TxtWorkPensum.Location = new System.Drawing.Point(321, 400);
            this.TxtWorkPensum.Margin = new System.Windows.Forms.Padding(2);
            this.TxtWorkPensum.Name = "TxtWorkPensum";
            this.TxtWorkPensum.Size = new System.Drawing.Size(138, 20);
            this.TxtWorkPensum.TabIndex = 61;
            // 
            // LblCivilStatus
            // 
            this.LblCivilStatus.AutoSize = true;
            this.LblCivilStatus.Location = new System.Drawing.Point(160, 281);
            this.LblCivilStatus.Name = "LblCivilStatus";
            this.LblCivilStatus.Size = new System.Drawing.Size(59, 13);
            this.LblCivilStatus.TabIndex = 64;
            this.LblCivilStatus.Text = "Civil Status";
            // 
            // TxtCivilStatus
            // 
            this.TxtCivilStatus.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCivilStatus.Location = new System.Drawing.Point(163, 296);
            this.TxtCivilStatus.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCivilStatus.Name = "TxtCivilStatus";
            this.TxtCivilStatus.Size = new System.Drawing.Size(138, 20);
            this.TxtCivilStatus.TabIndex = 63;
            // 
            // LblPrivatePhone
            // 
            this.LblPrivatePhone.AutoSize = true;
            this.LblPrivatePhone.Location = new System.Drawing.Point(501, 68);
            this.LblPrivatePhone.Name = "LblPrivatePhone";
            this.LblPrivatePhone.Size = new System.Drawing.Size(74, 13);
            this.LblPrivatePhone.TabIndex = 66;
            this.LblPrivatePhone.Text = "Private Phone";
            // 
            // TxtPrivatePhone
            // 
            this.TxtPrivatePhone.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPrivatePhone.Location = new System.Drawing.Point(504, 83);
            this.TxtPrivatePhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrivatePhone.Name = "TxtPrivatePhone";
            this.TxtPrivatePhone.Size = new System.Drawing.Size(138, 20);
            this.TxtPrivatePhone.TabIndex = 65;
            // 
            // LblApprentYears
            // 
            this.LblApprentYears.AutoSize = true;
            this.LblApprentYears.Location = new System.Drawing.Point(7, 488);
            this.LblApprentYears.Name = "LblApprentYears";
            this.LblApprentYears.Size = new System.Drawing.Size(123, 13);
            this.LblApprentYears.TabIndex = 68;
            this.LblApprentYears.Text = "Years of Apprenticeship*";
            // 
            // TxtApprentYears
            // 
            this.TxtApprentYears.BackColor = System.Drawing.SystemColors.Window;
            this.TxtApprentYears.Location = new System.Drawing.Point(10, 503);
            this.TxtApprentYears.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApprentYears.Name = "TxtApprentYears";
            this.TxtApprentYears.Size = new System.Drawing.Size(138, 20);
            this.TxtApprentYears.TabIndex = 67;
            // 
            // LblCurrentApprentYear
            // 
            this.LblCurrentApprentYear.AutoSize = true;
            this.LblCurrentApprentYear.Location = new System.Drawing.Point(160, 488);
            this.LblCurrentApprentYear.Name = "LblCurrentApprentYear";
            this.LblCurrentApprentYear.Size = new System.Drawing.Size(151, 13);
            this.LblCurrentApprentYear.TabIndex = 70;
            this.LblCurrentApprentYear.Text = "Current Year of Apprenticeship";
            // 
            // TxtCurrentApprentYear
            // 
            this.TxtCurrentApprentYear.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCurrentApprentYear.Location = new System.Drawing.Point(163, 503);
            this.TxtCurrentApprentYear.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCurrentApprentYear.Name = "TxtCurrentApprentYear";
            this.TxtCurrentApprentYear.Size = new System.Drawing.Size(138, 20);
            this.TxtCurrentApprentYear.TabIndex = 69;
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(324, 12);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(95, 41);
            this.CmdAdd.TabIndex = 71;
            this.CmdAdd.Text = "Add a new user";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // RadApprentice
            // 
            this.RadApprentice.AutoSize = true;
            this.RadApprentice.Location = new System.Drawing.Point(80, 3);
            this.RadApprentice.Margin = new System.Windows.Forms.Padding(2);
            this.RadApprentice.Name = "RadApprentice";
            this.RadApprentice.Size = new System.Drawing.Size(76, 17);
            this.RadApprentice.TabIndex = 74;
            this.RadApprentice.Text = "Apprentice";
            this.RadApprentice.UseVisualStyleBackColor = true;
            this.RadApprentice.Visible = false;
            this.RadApprentice.CheckedChanged += new System.EventHandler(this.RadApprentice_CheckedChanged);
            // 
            // CmdEditUser
            // 
            this.CmdEditUser.Location = new System.Drawing.Point(425, 12);
            this.CmdEditUser.Name = "CmdEditUser";
            this.CmdEditUser.Size = new System.Drawing.Size(100, 41);
            this.CmdEditUser.TabIndex = 75;
            this.CmdEditUser.Text = "Edit user";
            this.CmdEditUser.UseVisualStyleBackColor = true;
            this.CmdEditUser.Click += new System.EventHandler(this.CmdEditUser_Click);
            // 
            // CmdDeleteUser
            // 
            this.CmdDeleteUser.Location = new System.Drawing.Point(531, 12);
            this.CmdDeleteUser.Name = "CmdDeleteUser";
            this.CmdDeleteUser.Size = new System.Drawing.Size(100, 41);
            this.CmdDeleteUser.TabIndex = 76;
            this.CmdDeleteUser.Text = "Delete user";
            this.CmdDeleteUser.UseVisualStyleBackColor = true;
            this.CmdDeleteUser.Click += new System.EventHandler(this.CmdDeleteUser_Click);
            // 
            // CmdExport
            // 
            this.CmdExport.Location = new System.Drawing.Point(637, 12);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(100, 41);
            this.CmdExport.TabIndex = 77;
            this.CmdExport.Text = "Export all users to CSV file";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Click += new System.EventHandler(this.CmdExport_Click);
            // 
            // CmbSearch
            // 
            this.CmbSearch.FormattingEnabled = true;
            this.CmbSearch.Items.AddRange(new object[] {
            "Salutation",
            "Firstname",
            "Secondname",
            "Lastname",
            "Birthdate",
            "Gender",
            "Title",
            "Business Phone",
            "Business Fax",
            "Mobile Number",
            "Email",
            "City",
            "Street",
            "Zip Code",
            "Department",
            "AHV Number",
            "Start Date",
            "Leaving Date",
            "Denomination",
            "Birthplace",
            "Nationality",
            "Role",
            "Management Level",
            "Direct Reports",
            "Work Pensum",
            "Civil Status",
            "Private Phone",
            "Apprenticeship Years",
            "Current Appr Year",
            "Company Name",
            "Customer Type",
            "Contact Person"});
            this.CmbSearch.Location = new System.Drawing.Point(803, 32);
            this.CmbSearch.Name = "CmbSearch";
            this.CmbSearch.Size = new System.Drawing.Size(121, 21);
            this.CmbSearch.TabIndex = 78;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(930, 32);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(176, 20);
            this.TxtSearch.TabIndex = 79;
            // 
            // LblSearchAttribute
            // 
            this.LblSearchAttribute.AutoSize = true;
            this.LblSearchAttribute.Location = new System.Drawing.Point(800, 16);
            this.LblSearchAttribute.Name = "LblSearchAttribute";
            this.LblSearchAttribute.Size = new System.Drawing.Size(83, 13);
            this.LblSearchAttribute.TabIndex = 80;
            this.LblSearchAttribute.Text = "Search Attribute";
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(1112, 32);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(100, 21);
            this.CmdSearch.TabIndex = 84;
            this.CmdSearch.Text = "Start search";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // LblSearchText
            // 
            this.LblSearchText.AutoSize = true;
            this.LblSearchText.Location = new System.Drawing.Point(927, 16);
            this.LblSearchText.Name = "LblSearchText";
            this.LblSearchText.Size = new System.Drawing.Size(65, 13);
            this.LblSearchText.TabIndex = 85;
            this.LblSearchText.Text = "Search Text";
            // 
            // CmdResetSearchResults
            // 
            this.CmdResetSearchResults.Location = new System.Drawing.Point(278, 22);
            this.CmdResetSearchResults.Name = "CmdResetSearchResults";
            this.CmdResetSearchResults.Size = new System.Drawing.Size(24, 23);
            this.CmdResetSearchResults.TabIndex = 86;
            this.CmdResetSearchResults.Text = "X";
            this.CmdResetSearchResults.UseVisualStyleBackColor = true;
            this.CmdResetSearchResults.Visible = false;
            this.CmdResetSearchResults.Click += new System.EventHandler(this.CmdResetSearchResults_Click);
            // 
            // LblResetSearchResults
            // 
            this.LblResetSearchResults.AutoSize = true;
            this.LblResetSearchResults.Location = new System.Drawing.Point(168, 27);
            this.LblResetSearchResults.Name = "LblResetSearchResults";
            this.LblResetSearchResults.Size = new System.Drawing.Size(110, 13);
            this.LblResetSearchResults.TabIndex = 87;
            this.LblResetSearchResults.Text = "Reset Search Results";
            this.LblResetSearchResults.Visible = false;
            // 
            // LblListboxDescription
            // 
            this.LblListboxDescription.AutoSize = true;
            this.LblListboxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListboxDescription.Location = new System.Drawing.Point(20, 22);
            this.LblListboxDescription.Name = "LblListboxDescription";
            this.LblListboxDescription.Size = new System.Drawing.Size(82, 24);
            this.LblListboxDescription.TabIndex = 89;
            this.LblListboxDescription.Text = "Contacts";
            // 
            // LblUserStatus
            // 
            this.LblUserStatus.AutoSize = true;
            this.LblUserStatus.Location = new System.Drawing.Point(826, 5);
            this.LblUserStatus.Name = "LblUserStatus";
            this.LblUserStatus.Size = new System.Drawing.Size(62, 13);
            this.LblUserStatus.TabIndex = 90;
            this.LblUserStatus.Text = "User Status";
            // 
            // CmdTakeNotes
            // 
            this.CmdTakeNotes.Enabled = false;
            this.CmdTakeNotes.Location = new System.Drawing.Point(679, 178);
            this.CmdTakeNotes.Name = "CmdTakeNotes";
            this.CmdTakeNotes.Size = new System.Drawing.Size(75, 23);
            this.CmdTakeNotes.TabIndex = 91;
            this.CmdTakeNotes.Text = "Take notes";
            this.CmdTakeNotes.UseVisualStyleBackColor = true;
            this.CmdTakeNotes.Click += new System.EventHandler(this.CmdTakeNotes_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(307, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 589);
            this.tabControl1.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.DtpLeaveDate);
            this.tabPage1.Controls.Add(this.DtpStartDate);
            this.tabPage1.Controls.Add(this.DtpBirthdate);
            this.tabPage1.Controls.Add(this.CmbWorkPensum);
            this.tabPage1.Controls.Add(this.CmbCurrentApprentYear);
            this.tabPage1.Controls.Add(this.CmbApprentYears);
            this.tabPage1.Controls.Add(this.CmbDirectReports);
            this.tabPage1.Controls.Add(this.CmbDepartment);
            this.tabPage1.Controls.Add(this.CmbCivilStatus);
            this.tabPage1.Controls.Add(this.CmbMgmtLevel);
            this.tabPage1.Controls.Add(this.CmbCustomerType);
            this.tabPage1.Controls.Add(this.CmbGender);
            this.tabPage1.Controls.Add(this.CmbSalutation);
            this.tabPage1.Controls.Add(this.TxtNotes);
            this.tabPage1.Controls.Add(this.CmdTakeNotes);
            this.tabPage1.Controls.Add(this.LblUserStatus);
            this.tabPage1.Controls.Add(this.LblSalutation);
            this.tabPage1.Controls.Add(this.ChkStatus);
            this.tabPage1.Controls.Add(this.LblFirstname);
            this.tabPage1.Controls.Add(this.LblLastname);
            this.tabPage1.Controls.Add(this.LblBirthdate);
            this.tabPage1.Controls.Add(this.TxtCurrentApprentYear);
            this.tabPage1.Controls.Add(this.TxtSalutation);
            this.tabPage1.Controls.Add(this.TxtFirstname);
            this.tabPage1.Controls.Add(this.RadApprentice);
            this.tabPage1.Controls.Add(this.LblAHVNumber);
            this.tabPage1.Controls.Add(this.TxtLastname);
            this.tabPage1.Controls.Add(this.RadEmployees);
            this.tabPage1.Controls.Add(this.TxtBirthdate);
            this.tabPage1.Controls.Add(this.TxtGender);
            this.tabPage1.Controls.Add(this.TxtBusinessPhone);
            this.tabPage1.Controls.Add(this.RadCustomers);
            this.tabPage1.Controls.Add(this.TxtLeaveDate);
            this.tabPage1.Controls.Add(this.TxtContacPerson);
            this.tabPage1.Controls.Add(this.LblContactPerson);
            this.tabPage1.Controls.Add(this.TxtCustomerType);
            this.tabPage1.Controls.Add(this.TxtDirectReports);
            this.tabPage1.Controls.Add(this.TxtCompanyName);
            this.tabPage1.Controls.Add(this.TxtCivilStatus);
            this.tabPage1.Controls.Add(this.LblCustomerType);
            this.tabPage1.Controls.Add(this.TxtDenomination);
            this.tabPage1.Controls.Add(this.TxtPrivatePhone);
            this.tabPage1.Controls.Add(this.LblCompanyName);
            this.tabPage1.Controls.Add(this.TxtDepartment);
            this.tabPage1.Controls.Add(this.LblPrivatePhone);
            this.tabPage1.Controls.Add(this.LblCivilStatus);
            this.tabPage1.Controls.Add(this.LblDirectReports);
            this.tabPage1.Controls.Add(this.TxtNationality);
            this.tabPage1.Controls.Add(this.LblCurrentApprentYear);
            this.tabPage1.Controls.Add(this.TxtBirthplace);
            this.tabPage1.Controls.Add(this.TxtMobileNumber);
            this.tabPage1.Controls.Add(this.LblApprentYears);
            this.tabPage1.Controls.Add(this.LblLeaveDate);
            this.tabPage1.Controls.Add(this.TxtEmail);
            this.tabPage1.Controls.Add(this.LblDenomination);
            this.tabPage1.Controls.Add(this.TxtCity);
            this.tabPage1.Controls.Add(this.TxtStreet);
            this.tabPage1.Controls.Add(this.TxtApprentYears);
            this.tabPage1.Controls.Add(this.LblNationality);
            this.tabPage1.Controls.Add(this.TxtBusinessFax);
            this.tabPage1.Controls.Add(this.LblDepartment);
            this.tabPage1.Controls.Add(this.TxtZipcode);
            this.tabPage1.Controls.Add(this.TxtAHVNumber);
            this.tabPage1.Controls.Add(this.LblBirthplace);
            this.tabPage1.Controls.Add(this.LblWorkPensum);
            this.tabPage1.Controls.Add(this.TxtSecondname);
            this.tabPage1.Controls.Add(this.TxtTitle);
            this.tabPage1.Controls.Add(this.TxtStartDate);
            this.tabPage1.Controls.Add(this.TxtRole);
            this.tabPage1.Controls.Add(this.TxtMgmtLevel);
            this.tabPage1.Controls.Add(this.LblMgmtLevel);
            this.tabPage1.Controls.Add(this.TxtWorkPensum);
            this.tabPage1.Controls.Add(this.LblGender);
            this.tabPage1.Controls.Add(this.LblBusinessPhone);
            this.tabPage1.Controls.Add(this.LblMobileNumber);
            this.tabPage1.Controls.Add(this.LblCity);
            this.tabPage1.Controls.Add(this.LblEmail);
            this.tabPage1.Controls.Add(this.LblStartDate);
            this.tabPage1.Controls.Add(this.LblRole);
            this.tabPage1.Controls.Add(this.LblStreet);
            this.tabPage1.Controls.Add(this.LblBusinessFax);
            this.tabPage1.Controls.Add(this.LblZipcode);
            this.tabPage1.Controls.Add(this.LblTitle);
            this.tabPage1.Controls.Add(this.LblSecondname);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // DtpLeaveDate
            // 
            this.DtpLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpLeaveDate.Location = new System.Drawing.Point(487, 451);
            this.DtpLeaveDate.Name = "DtpLeaveDate";
            this.DtpLeaveDate.Size = new System.Drawing.Size(138, 20);
            this.DtpLeaveDate.TabIndex = 105;
            this.DtpLeaveDate.Visible = false;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpStartDate.Location = new System.Drawing.Point(321, 451);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(138, 20);
            this.DtpStartDate.TabIndex = 104;
            this.DtpStartDate.Visible = false;
            // 
            // DtpBirthdate
            // 
            this.DtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpBirthdate.Location = new System.Drawing.Point(10, 194);
            this.DtpBirthdate.Name = "DtpBirthdate";
            this.DtpBirthdate.Size = new System.Drawing.Size(138, 20);
            this.DtpBirthdate.TabIndex = 103;
            this.DtpBirthdate.Visible = false;
            // 
            // CmbWorkPensum
            // 
            this.CmbWorkPensum.FormattingEnabled = true;
            this.CmbWorkPensum.Items.AddRange(new object[] {
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%",
            ""});
            this.CmbWorkPensum.Location = new System.Drawing.Point(321, 400);
            this.CmbWorkPensum.Name = "CmbWorkPensum";
            this.CmbWorkPensum.Size = new System.Drawing.Size(138, 21);
            this.CmbWorkPensum.TabIndex = 102;
            this.CmbWorkPensum.Visible = false;
            // 
            // CmbCurrentApprentYear
            // 
            this.CmbCurrentApprentYear.FormattingEnabled = true;
            this.CmbCurrentApprentYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            ""});
            this.CmbCurrentApprentYear.Location = new System.Drawing.Point(163, 502);
            this.CmbCurrentApprentYear.Name = "CmbCurrentApprentYear";
            this.CmbCurrentApprentYear.Size = new System.Drawing.Size(138, 21);
            this.CmbCurrentApprentYear.TabIndex = 101;
            this.CmbCurrentApprentYear.Visible = false;
            // 
            // CmbApprentYears
            // 
            this.CmbApprentYears.FormattingEnabled = true;
            this.CmbApprentYears.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            ""});
            this.CmbApprentYears.Location = new System.Drawing.Point(10, 502);
            this.CmbApprentYears.Name = "CmbApprentYears";
            this.CmbApprentYears.Size = new System.Drawing.Size(138, 21);
            this.CmbApprentYears.TabIndex = 100;
            this.CmbApprentYears.Visible = false;
            // 
            // CmbDirectReports
            // 
            this.CmbDirectReports.FormattingEnabled = true;
            this.CmbDirectReports.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            ""});
            this.CmbDirectReports.Location = new System.Drawing.Point(163, 450);
            this.CmbDirectReports.Name = "CmbDirectReports";
            this.CmbDirectReports.Size = new System.Drawing.Size(138, 21);
            this.CmbDirectReports.TabIndex = 99;
            this.CmbDirectReports.Visible = false;
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Items.AddRange(new object[] {
            "Production",
            "Research and Development (R&D)",
            "Purchasing",
            "Marketing",
            "Human Resources (HR)",
            "Accounting and Finance",
            "IT",
            "Administration",
            ""});
            this.CmbDepartment.Location = new System.Drawing.Point(10, 399);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(138, 21);
            this.CmbDepartment.TabIndex = 98;
            this.CmbDepartment.Visible = false;
            // 
            // CmbCivilStatus
            // 
            this.CmbCivilStatus.FormattingEnabled = true;
            this.CmbCivilStatus.Items.AddRange(new object[] {
            "single",
            "married",
            "divorced",
            "widowed",
            ""});
            this.CmbCivilStatus.Location = new System.Drawing.Point(163, 296);
            this.CmbCivilStatus.Name = "CmbCivilStatus";
            this.CmbCivilStatus.Size = new System.Drawing.Size(138, 21);
            this.CmbCivilStatus.TabIndex = 97;
            this.CmbCivilStatus.Visible = false;
            // 
            // CmbMgmtLevel
            // 
            this.CmbMgmtLevel.FormattingEnabled = true;
            this.CmbMgmtLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.CmbMgmtLevel.Location = new System.Drawing.Point(10, 449);
            this.CmbMgmtLevel.Name = "CmbMgmtLevel";
            this.CmbMgmtLevel.Size = new System.Drawing.Size(138, 21);
            this.CmbMgmtLevel.TabIndex = 96;
            this.CmbMgmtLevel.Visible = false;
            // 
            // CmbCustomerType
            // 
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            ""});
            this.CmbCustomerType.Location = new System.Drawing.Point(679, 83);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(139, 21);
            this.CmbCustomerType.TabIndex = 95;
            this.CmbCustomerType.Visible = false;
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            ""});
            this.CmbGender.Location = new System.Drawing.Point(10, 239);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(138, 21);
            this.CmbGender.TabIndex = 94;
            this.CmbGender.Visible = false;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Mrs",
            ""});
            this.CmbSalutation.Location = new System.Drawing.Point(10, 41);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(138, 21);
            this.CmbSalutation.TabIndex = 93;
            this.CmbSalutation.Visible = false;
            // 
            // TxtNotes
            // 
            this.TxtNotes.Enabled = false;
            this.TxtNotes.Location = new System.Drawing.Point(679, 208);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(216, 349);
            this.TxtNotes.TabIndex = 92;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.LblNotesHistory);
            this.tabPage2.Controls.Add(this.LblLastmodified);
            this.tabPage2.Controls.Add(this.LblCreationDate);
            this.tabPage2.Controls.Add(this.TxtNotesHistory);
            this.tabPage2.Controls.Add(this.TxtLastModified);
            this.tabPage2.Controls.Add(this.TxtCreationDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            // 
            // LblNotesHistory
            // 
            this.LblNotesHistory.AutoSize = true;
            this.LblNotesHistory.Location = new System.Drawing.Point(239, 15);
            this.LblNotesHistory.Name = "LblNotesHistory";
            this.LblNotesHistory.Size = new System.Drawing.Size(70, 13);
            this.LblNotesHistory.TabIndex = 6;
            this.LblNotesHistory.Text = "Notes History";
            // 
            // LblLastmodified
            // 
            this.LblLastmodified.AutoSize = true;
            this.LblLastmodified.Location = new System.Drawing.Point(13, 66);
            this.LblLastmodified.Name = "LblLastmodified";
            this.LblLastmodified.Size = new System.Drawing.Size(69, 13);
            this.LblLastmodified.TabIndex = 5;
            this.LblLastmodified.Text = "Last modified";
            // 
            // LblCreationDate
            // 
            this.LblCreationDate.AutoSize = true;
            this.LblCreationDate.Location = new System.Drawing.Point(13, 15);
            this.LblCreationDate.Name = "LblCreationDate";
            this.LblCreationDate.Size = new System.Drawing.Size(59, 13);
            this.LblCreationDate.TabIndex = 4;
            this.LblCreationDate.Text = "Created on";
            // 
            // TxtNotesHistory
            // 
            this.TxtNotesHistory.Location = new System.Drawing.Point(242, 34);
            this.TxtNotesHistory.Multiline = true;
            this.TxtNotesHistory.Name = "TxtNotesHistory";
            this.TxtNotesHistory.ReadOnly = true;
            this.TxtNotesHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotesHistory.Size = new System.Drawing.Size(599, 533);
            this.TxtNotesHistory.TabIndex = 3;
            // 
            // TxtLastModified
            // 
            this.TxtLastModified.Location = new System.Drawing.Point(13, 82);
            this.TxtLastModified.Multiline = true;
            this.TxtLastModified.Name = "TxtLastModified";
            this.TxtLastModified.ReadOnly = true;
            this.TxtLastModified.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLastModified.Size = new System.Drawing.Size(201, 485);
            this.TxtLastModified.TabIndex = 2;
            // 
            // TxtCreationDate
            // 
            this.TxtCreationDate.Location = new System.Drawing.Point(13, 34);
            this.TxtCreationDate.Name = "TxtCreationDate";
            this.TxtCreationDate.ReadOnly = true;
            this.TxtCreationDate.Size = new System.Drawing.Size(201, 20);
            this.TxtCreationDate.TabIndex = 1;
            // 
            // ChkStatus
            // 
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Location = new System.Drawing.Point(842, 21);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Padding = new System.Windows.Forms.Padding(6);
            this.ChkStatus.Size = new System.Drawing.Size(44, 25);
            this.ChkStatus.TabIndex = 0;
            this.ChkStatus.CheckedChanged += new System.EventHandler(this.ChkStatus_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 649);
            this.Controls.Add(this.LblListboxDescription);
            this.Controls.Add(this.LblResetSearchResults);
            this.Controls.Add(this.CmdResetSearchResults);
            this.Controls.Add(this.LblSearchText);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.LblSearchAttribute);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmbSearch);
            this.Controls.Add(this.CmdExport);
            this.Controls.Add(this.CmdDeleteUser);
            this.Controls.Add(this.CmdEditUser);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.LstEntries);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtSalutation;
        private System.Windows.Forms.ListBox LstEntries;
        private System.Windows.Forms.RadioButton RadEmployees;
        private System.Windows.Forms.RadioButton RadCustomers;
        private System.Windows.Forms.Label LblSalutation;
        private System.Windows.Forms.Label LblFirstname;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.Label LblSecondname;
        private System.Windows.Forms.TextBox TxtSecondname;
        private System.Windows.Forms.Label LblLastname;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.Label LblBirthdate;
        private System.Windows.Forms.TextBox TxtBirthdate;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.TextBox TxtGender;
        private System.Windows.Forms.Label LblBusinessPhone;
        private System.Windows.Forms.TextBox TxtBusinessPhone;
        private System.Windows.Forms.Label LblBusinessFax;
        private System.Windows.Forms.TextBox TxtBusinessFax;
        private System.Windows.Forms.Label LblMobileNumber;
        private System.Windows.Forms.TextBox TxtMobileNumber;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label LblZipcode;
        private System.Windows.Forms.TextBox TxtZipcode;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Label LblCustomerType;
        private System.Windows.Forms.TextBox TxtCustomerType;
        private System.Windows.Forms.Label LblContactPerson;
        private System.Windows.Forms.TextBox TxtContacPerson;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.TextBox TxtDepartment;
        private System.Windows.Forms.Label LblAHVNumber;
        private System.Windows.Forms.TextBox TxtAHVNumber;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.TextBox TxtStartDate;
        private System.Windows.Forms.Label LblLeaveDate;
        private System.Windows.Forms.TextBox TxtLeaveDate;
        private System.Windows.Forms.Label LblDenomination;
        private System.Windows.Forms.TextBox TxtDenomination;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.TextBox TxtRole;
        private System.Windows.Forms.Label LblBirthplace;
        private System.Windows.Forms.TextBox TxtBirthplace;
        private System.Windows.Forms.Label LblNationality;
        private System.Windows.Forms.TextBox TxtNationality;
        private System.Windows.Forms.Label LblMgmtLevel;
        private System.Windows.Forms.TextBox TxtMgmtLevel;
        private System.Windows.Forms.Label LblDirectReports;
        private System.Windows.Forms.TextBox TxtDirectReports;
        private System.Windows.Forms.Label LblWorkPensum;
        private System.Windows.Forms.TextBox TxtWorkPensum;
        private System.Windows.Forms.Label LblCivilStatus;
        private System.Windows.Forms.TextBox TxtCivilStatus;
        private System.Windows.Forms.Label LblPrivatePhone;
        private System.Windows.Forms.TextBox TxtPrivatePhone;
        private System.Windows.Forms.Label LblApprentYears;
        private System.Windows.Forms.TextBox TxtApprentYears;
        private System.Windows.Forms.Label LblCurrentApprentYear;
        private System.Windows.Forms.TextBox TxtCurrentApprentYear;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.RadioButton RadApprentice;
        private System.Windows.Forms.Button CmdEditUser;
        private System.Windows.Forms.Button CmdDeleteUser;
        private System.Windows.Forms.Button CmdExport;
        private System.Windows.Forms.ComboBox CmbSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearchAttribute;
        private System.Windows.Forms.SaveFileDialog SaveFileChooser;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.Label LblSearchText;
        private System.Windows.Forms.Button CmdResetSearchResults;
        private System.Windows.Forms.Label LblResetSearchResults;
        private System.Windows.Forms.Label LblListboxDescription;
        private MyToggleCheckbox ChkStatus;
        private Label LblUserStatus;
        private Button CmdTakeNotes;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox TxtNotes;
        private TextBox TxtNotesHistory;
        private TextBox TxtLastModified;
        private TextBox TxtCreationDate;
        private Label LblLastmodified;
        private Label LblCreationDate;
        private Label LblNotesHistory;
        private ComboBox CmbSalutation;
        private ComboBox CmbGender;
        private ComboBox CmbCustomerType;
        private ComboBox CmbWorkPensum;
        private ComboBox CmbCurrentApprentYear;
        private ComboBox CmbApprentYears;
        private ComboBox CmbDirectReports;
        private ComboBox CmbDepartment;
        private ComboBox CmbCivilStatus;
        private ComboBox CmbMgmtLevel;
        private DateTimePicker DtpBirthdate;
        private DateTimePicker DtpLeaveDate;
        private DateTimePicker DtpStartDate;
    }
}

