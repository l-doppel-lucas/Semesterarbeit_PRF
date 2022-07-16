using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Semesterarbeit.Controller
{
    public class Database  
    {
        //Create new binding list "contactList" of type "Person"
        //Binding list is used to refresh the datasource of the listbox
        //Source: https://stackoverflow.com/questions/17615069/how-to-refresh-datasource-of-a-listbox
        public BindingList<Person> contactList = new BindingList<Person>();

        //Create new binding list "searchResults" of type "Person"
        public BindingList<Person> searchResults = new BindingList<Person>();


        /***************Methods***********************************************************************/

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

        //Method to return all "Person" values of the list "contactlist" in csv format
        public string ExportListPerson()
        {
            //Initialize string for output (with the header of the csv
            string output = "ID;Salutation;Firstname;Secondname;Lastname;Birthdate;Gender;Title;BusinessPhone;BusinessFax;MobileNumber;Email;" +
                "City;Street;Zipcode;Department;AhvNumber;StartDate;LeaveDate;Denomination;Birthplace;Nationality;Role;MgmtLevel;DirectReports;WorkPensum;" +
                "CivilStatus;PrivatePhone;ApprentYears;CurrentApprentYear;CompanyName;CustomerType;ContactPerson" + Environment.NewLine;
            
            //Append output with a new line per object in contactlist
            foreach (Person data in contactList)
            {
                //All "Person" related attributes
                output += Convert.ToString(data.ID) + ";"
                    + Convert.ToString(data.Salutation) + ";"
                    + Convert.ToString(data.Firstname) + ";"
                    + Convert.ToString(data.Secondname) + ";"
                    + Convert.ToString(data.Lastname) + ";"
                    + Convert.ToString(data.Birthdate) + ";"
                    + Convert.ToString(data.Gender) + ";"
                    + Convert.ToString(data.Title) + ";"
                    + Convert.ToString(data.BusinessPhone) + ";"
                    + Convert.ToString(data.BusinessFax) + ";"
                    + Convert.ToString(data.MobileNumber) + ";"
                    + Convert.ToString(data.Email) + ";"
                    + Convert.ToString(data.City) + ";"
                    + Convert.ToString(data.Street) + ";"
                    + Convert.ToString(data.Zipcode) + ";";

                switch (data.GetClassName())
                {
                    case "Employee":
                        {
                            //Cast the "Person" variable data into a new variable of type "Employee"
                            Employee dataEmployee = (Employee)data;

                            //All "Employee" related attributes
                            output += Convert.ToString(dataEmployee.Department) + ";"
                              + Convert.ToString(dataEmployee.AhvNumber) + ";"
                              + Convert.ToString(dataEmployee.StartDate) + ";"
                              + Convert.ToString(dataEmployee.LeaveDate) + ";"
                              + Convert.ToString(dataEmployee.Denomination) + ";"
                              + Convert.ToString(dataEmployee.Birthplace) + ";"
                              + Convert.ToString(dataEmployee.Nationality) + ";"
                              + Convert.ToString(dataEmployee.Role) + ";"
                              + Convert.ToString(dataEmployee.MgmtLevel) + ";"
                              + Convert.ToString(dataEmployee.DirectReports) + ";"
                              + Convert.ToString(dataEmployee.WorkPensum) + ";"
                              + Convert.ToString(dataEmployee.CivilStatus) + ";"
                              + Convert.ToString(dataEmployee.PrivatePhone)
                              + ";;;;"
                              + Environment.NewLine;
                            break;
                        }
                    case "Apprentice":
                        {
                            //Cast the "Person" variable data into a new variable of type "Apprentice"
                            Apprentice dataApprentice = (Apprentice)data;

                            //All "Apprentice" related attributes
                            output += Convert.ToString(dataApprentice.Department) + ";"
                              + Convert.ToString(dataApprentice.AhvNumber) + ";"
                              + Convert.ToString(dataApprentice.StartDate) + ";"
                              + Convert.ToString(dataApprentice.LeaveDate) + ";"
                              + Convert.ToString(dataApprentice.Denomination) + ";"
                              + Convert.ToString(dataApprentice.Birthplace) + ";"
                              + Convert.ToString(dataApprentice.Nationality) + ";"
                              + Convert.ToString(dataApprentice.Role) + ";"
                              + Convert.ToString(dataApprentice.MgmtLevel) + ";"
                              + Convert.ToString(dataApprentice.DirectReports) + ";"
                              + Convert.ToString(dataApprentice.WorkPensum) + ";"
                              + Convert.ToString(dataApprentice.CivilStatus) + ";"
                              + Convert.ToString(dataApprentice.PrivatePhone) + ";"
                              + Convert.ToString(dataApprentice.ApprentYears) + ";"
                              + Convert.ToString(dataApprentice.CurrentApprentYear)
                              + ";;;"
                              + Environment.NewLine;
                            break;
                        }
                    case "Customer":
                        {
                            //Cast the "Person" variable data into a new variable of type "Customer"
                            Customer dataApprentice = (Customer)data;

                            //All "Customer" related attributes
                            output +=
                            ";;;;;;;;;;;;;;;"
                            + Convert.ToString(dataApprentice.CompanyName) + ";"
                            + Convert.ToString(dataApprentice.CustomerType) + ";"
                            + Convert.ToString(dataApprentice.ContactPerson)
                            + Environment.NewLine;
                            break;
                        }
                }

            }
            return output;
        }

        //Method for the serialisation of all objects of the list "contactlist" 
        public void Serialisation()
        {
            FileStream stream = new FileStream(Environment.CurrentDirectory + @"\person.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, contactList);
            stream.Close();
        }

        //Function for the deserialisation of all objects of the list "contactlist"
        public Boolean Deserialisation()
        {
            try
            {
                FileStream stream = new FileStream(Environment.CurrentDirectory + @"\person.dat", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                contactList = (BindingList<Person>)formatter.Deserialize(stream);
                stream.Close();
                return true;
            }
            catch(FileNotFoundException)
            { return false; }

        }

        //Method that returns the (int) ID of the last element in the list "contactlist"
        public Int32 ReturnLastID()
        {
            int id = 1;

            //If there are already elements in the list, then return the ID of the last element
            //If there are no elements in the list yet, then start the ID on 1000
            try
            {
                Person temp = contactList.Last();
                id = temp.ID;
            }
            catch (System.InvalidOperationException)
            {
                id = 1000;
            }

            return id;
        }

        //Method to add an object of type "Person" to the list "searchResults"
        public void AddSearchResult(Person p)
        {
            searchResults.Add(p);
        }

        //Method to clear the list "searchResults"
        public void ClearSearchResults()
        {
            searchResults.Clear();
        }


    }
}
