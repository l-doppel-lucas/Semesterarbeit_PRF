using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace semesterarbeit.Controller
{
    [Serializable]
    public class Database
    {
        //Create new binding list "contactList" of type "Person"
        //Binding list is used to refresh the datasource of the listbox
        //Source: https://stackoverflow.com/questions/17615069/how-to-refresh-datasource-of-a-listbox
        public BindingList<Person> contactList = new BindingList<Person>();

        //Create new binding list "searchResults" of type "Person"
        public BindingList<Person> searchResults = new BindingList<Person>();

        /*---------------------------------------------------------------------
            Methods
        -----------------------------------------------------------------------*/
        //Method to add an object of type "Person" to the list "contactList"
        public void AddPerson(Person p)
        {
            contactList.Add(p);
        }

        //Method to remove an object of the list "contactList"
        public void DeletePerson(Person p)
        {
            contactList.Remove(p);
        }

        public int GetNumberOfPers()
        {
            return contactList.Count;
        }

        public int GetNumberofEmpl()
        {
            int NumberOfEmpl = 0;

            foreach (Person p in contactList)
            {
                if (p.GetClassName() == "Employee")
                {
                    NumberOfEmpl++;
                }
            }
            return NumberOfEmpl;
        }

        public int GetNumberofTrnee()
        {
            int NumberOfTrnee = 0;

            foreach (Person p in contactList)
            {
                if (p.GetClassName() == "Trainee")
                {
                    NumberOfTrnee++;
                }
            }
            return NumberOfTrnee;
        }

        public int GetNumberofCust()
        {
            int NumberOfCust = 0;

            foreach (Person p in contactList)
            {
                if (p.GetClassName() == "Customer")
                {
                    NumberOfCust++;
                }
            }
            return NumberOfCust;
        }

        public int ReturnLastID()
        {
            int id = 1;
            try
            {
                Person temp = contactList.Last();
                id = temp.Id;
            }
            catch (System.InvalidOperationException)
            {
                id = 1;
            }

            return id;
        }

        //Method to return all "Person" values of the list "contactlist" in csv format
        public string ExportListPerson()
        {
            //Initialize string for output (with the header of the csv
            string output = "Id;Title;Salutation;Firstname;Lastname;Birthdate;Gender;MobileNumber;BusinessPhone;BusinessFax;Mail;CreationDate;City;Street;Zipcode;ChangeHistory;" +
                "EmplNr;Department;WorkPensum;Ahv;Nationality;Birthplace;PrivatePhone;EntryDate;ExitDate;Role;MgmtLevel;" +
                "Appyears;Currappyear;" +
                "CompanyName;CustomerType;CompanyContact;NotesHistory" + Environment.NewLine;

            //Append output with a new line per object in contactlist
            foreach (Person data in contactList)
            {
                //All "Person" related attributes
                output += Convert.ToString(data.Id) + ";"
                    + Convert.ToString(data.Title) + ";"
                    + Convert.ToString(data.Salutation) + ";"
                    + Convert.ToString(data.Firstname) + ";"
                    + Convert.ToString(data.Lastname) + ";"
                    + Convert.ToString(data.Birthdate) + ";"
                    + Convert.ToString(data.Gender) + ";"
                    + Convert.ToString(data.Mobilephone) + ";"
                    + Convert.ToString(data.Businessphone) + ";"
                    + Convert.ToString(data.Businessfax) + ";"
                    + Convert.ToString(data.Mail) + ";"
                    + Convert.ToString(data.CreationDate) + ";"
                    + Convert.ToString(data.City) + ";"
                    + Convert.ToString(data.Street) + ";"
                    + Convert.ToString(data.Zipcode) + ";"
                    + Convert.ToString(data.ChangeHistory) + ";";

                switch (data.GetClassName())
                {
                    case "Employee":
                        {
                            //Cast the "Person" variable data into a new variable of type "Employee"
                            Employee dataEmployee = (Employee)data;

                            //All "Employee" related attributes
                            output += Convert.ToString(dataEmployee.EmplNr) + ";"
                              + Convert.ToString(dataEmployee.Departement) + ";"
                              + Convert.ToString(dataEmployee.Workpensum) + ";"
                              + Convert.ToString(dataEmployee.Ahv) + ";"
                              + Convert.ToString(dataEmployee.Nationality) + ";"
                              + Convert.ToString(dataEmployee.Birthplace) + ";"
                              + Convert.ToString(dataEmployee.Privatephone) + ";"
                              + Convert.ToString(dataEmployee.Entrydate) + ";"
                              + Convert.ToString(dataEmployee.Exitdate) + ";"
                              + Convert.ToString(dataEmployee.Role) + ";"
                              + Convert.ToString(dataEmployee.Lvl) + ";"
                              + ";;;;;"
                              + Environment.NewLine;
                            break;
                        }
                    case "Trainee":
                        {
                            //Cast the "Person" variable data into a new variable of type "Apprentice"
                            Trainee dataTrainee = (Trainee)data;

                            //All "Apprentice" related attributes
                            output += Convert.ToString(dataTrainee.EmplNr) + ";"
                              + Convert.ToString(dataTrainee.Departement) + ";"
                              + Convert.ToString(dataTrainee.Workpensum) + ";"
                              + Convert.ToString(dataTrainee.Ahv) + ";"
                              + Convert.ToString(dataTrainee.Nationality) + ";"
                              + Convert.ToString(dataTrainee.Birthplace) + ";"
                              + Convert.ToString(dataTrainee.Privatephone) + ";"
                              + Convert.ToString(dataTrainee.Entrydate) + ";"
                              + Convert.ToString(dataTrainee.Exitdate) + ";"
                              + Convert.ToString(dataTrainee.Role) + ";"
                              + Convert.ToString(dataTrainee.Lvl) + ";"
                              + Convert.ToString(dataTrainee.Appyears) + ";"
                              + Convert.ToString(dataTrainee.Currappyear) + ";"
                              + ";;;"
                              + Environment.NewLine;
                            break;
                        }
                    case "Customer":
                        {
                            //Cast the "Person" variable data into a new variable of type "Customer"
                            Customer dataCustomer = (Customer)data;

                            //All "Customer" related attributes
                            output +=
                            ";;;;;;;;;;;;;"
                            + Convert.ToString(dataCustomer.Companyname) + ";"
                            + Convert.ToString(dataCustomer.Type) + ";"
                            + Convert.ToString(dataCustomer.Companycontact) + ";"
                            + Convert.ToString(dataCustomer.NotesHistory)
                            + Environment.NewLine;
                            break;
                        }
                }

            }
            return output;
        }

        public void XmlSerialize()
        {
            string filepath = Environment.CurrentDirectory + @"\contacts.xml";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof BindingList<Person>);
            if (File.Exists(filepath)) File.Delete(filepath);
            TextWriter writer = new StreamWriter(filepath);
            xmlSerializer.Serialize(writer, contactList);
            writer.Close();
        }

        public bool XmlDeserialize(Type dataType)
        {
            string filepath = Environment.CurrentDirectory + @"\contacts.xml";

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(BindingList<Sequence>);
                TextReader textReader = new StringReader(filepath);
                contactList = (BindingList<Person>)XmlSerializer.Deserialize(textReader);
                textReader.Close();
                return true;
            }
            catch (FileNotFoundException)
            { return false; }
        }

        //Method for the serialisation of all objects of the list "contactlist" 
        public void Serialisation()
        {
            FileStream file = new FileStream(Environment.CurrentDirectory + @"\contacts.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, contactList);
            file.Close();
        }

        //Function for the deserialisation of all objects of the list "contactlist"
        public Boolean Deserialisation()
        {
            try
            {
                FileStream stream = new FileStream(Environment.CurrentDirectory + @"\contacts.dat", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                contactList = (BindingList<Person>)formatter.Deserialize(stream);
                stream.Close();
                return true;
            }
            catch (FileNotFoundException)
            { return false; }

        }
    }
 }

