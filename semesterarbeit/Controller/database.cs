using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace semesterarbeit.Controller
{
    [Serializable()]
    public class Database
    {
        //Datasource for the Listbox refreshes with Binding List
        //Source: https://stackoverflow.com/questions/17615069/how-to-refresh-datasource-of-a-listbox
        public BindingList<Person> contactList = new BindingList<Person>();

        //Bindig List for Search results
        public BindingList<Person> search = new BindingList<Person>();

        /*---------------------------------------------------------------------
            Methods
        -----------------------------------------------------------------------*/
        //Add an object of type "Person" to the "contactList"
        public void AddPerson(Person p)
        {
            contactList.Add(p);
        }

        //Remove an object of the "contactList"
        public void DeletePerson(Person p)
        {
            contactList.Remove(p);
        }

        //Count the Number of Persons, Customers, Employees and Trainees
        //to display on Dashboard
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

        //Return ID/Employee Number
        public int ReturnLastID()
        {
            int id;
            try
            {
                Person temp = contactList.Last();
                id = temp.Id;
            }
            catch (System.InvalidOperationException)
            {
                id = 0;
            }

            return id;
        }

        
        //Serialisation of all objects of the "contactlist" 
        public void Serialisation()
        {
            FileStream file = new FileStream(Environment.CurrentDirectory + @"\contacts.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, contactList);
            file.Close();
        }

        

        //Deserialisation of all objects of the "contactlist"
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


        //Method to add Objects to Search Result
        public void AddSearchResult(Person p)
        {
            search.Add(p);
        }

        //Method to reset Search Resuls
        public void ClearSearchResults()
        {
            search.Clear();
        }

    }
}

