using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace semesterarbeit.Controller
{
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

        public Int32 ReturnLastID()
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

    }
}
