using System;

namespace semesterarbeit
{
   public class Person
    {
        public bool Status { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Mobilephone { get; set; }
        public string Businessphone { get; set; }
        public string Businessfax { get; set; }
        public string Mail { get; set; }
        public DateTime CreationDate { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set;}
        public string ChangeHistory{ get; set; }


        /*---------------------------------------------------------------------
        Constructor
        -----------------------------------------------------------------------*/

        public Person(int id, string sal, string fn, string ln, DateTime birthdate, DateTime crdate, string gender, string mail, Boolean status,
             string street, string city, string zip, string changehistory)
        {
            Id = id;
            Salutation = sal;
            Firstname = fn;
            Lastname = ln;
            Birthdate = birthdate;
            Gender = gender;
            Mail = mail;
            Status = status;
            CreationDate = crdate;
            Street = street;
            City = city;
            Zipcode = zip;
            ChangeHistory = changehistory;
        }



        /*---------------------------------------------------------------------
                Methods
        -----------------------------------------------------------------------*/
        public override string ToString()
        {
            return Status + ", " + Id + ", " + Title + ", " + Salutation + ", " + Firstname + ", " + Lastname + ", " + Birthdate.ToShortDateString() 
                + ", " + Gender + ", " + Businessphone + ", " + Businessfax + ", " + Mail;
        }

        public virtual string PrintAll()
        {
            return Status + ", " + Id + ", " + Title + ", " + Salutation + ", " + Firstname + ", " + Lastname + ", " + Birthdate.ToShortDateString()
                + ", " + Gender + ", " + Businessphone + ", " + Businessfax + ", " + Mail + ", " + ChangeHistory;
        }


        public void SetOptionalAttributes(string title = "", string mph = "",  string bph = "", string bfa = "")
        {
            Title = title;
            Mobilephone = mph;
            Businessphone = bph;
            Businessfax = bfa;
        }

        //Method to set all mandatory attributes
        public void SetMandatoryAttributes(string sal, string fn, string ln, DateTime birthdate, string gender, string mail, 
            string street, string city, string zip, string changehistory)
        {
            Salutation = sal;
            Firstname = fn;
            Lastname = ln;
            Birthdate = birthdate;
            Gender = gender;
            Mail = mail;
            Street = street;
            City = city;
            Zipcode = zip;
            ChangeHistory = changehistory;

        }

        //Virtual method to return the name of the class as a string - virtual because this is individual for each class
        public virtual string GetClassName()
        {
            return "Person";
        }

    }
}
