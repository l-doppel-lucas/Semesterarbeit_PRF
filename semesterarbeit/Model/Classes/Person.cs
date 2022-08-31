using System;
using System.Windows.Forms;

namespace semesterarbeit
{
    [Serializable()]
    public class Person
    {
        public bool Disabled { get; set; }
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
                Methods
        -----------------------------------------------------------------------*/
        public override string ToString()
        {
            return Disabled + ", " + Id + ", " + Title + ", " + Salutation + ", " + Firstname + ", " + Lastname + ", " + Birthdate.ToShortDateString() 
                + ", " + Gender + ", " + Businessphone + ", " + Businessfax + ", " + Mail;
        }

        public virtual string PrintAll()
        {
            return Disabled + ", " + Id + ", " + Title + ", " + Salutation + ", " + Firstname + ", " + Lastname + ", " + Birthdate.ToShortDateString()
                + ", " + Gender + ", " + Businessphone + ", " + Businessfax + ", " + Mail + ", " + ChangeHistory;
        }

        public string ShortText()
        {
            return Id + " - " + Firstname + " " + Lastname;
        }


        public void SetOptionalAttributes(string title = "", string mph = "",  string bph = "", string bfa = "")
        {
            Title = title;
            Mobilephone = mph;
            Businessphone = bph;
            Businessfax = bfa;
        }

        //Method to set all mandatory attributes
        public void SetMandatoryAttributes(bool disabled, string sal, string fn, string ln, DateTime birthdate, string gender, string mail, 
            string street, string city, string zip, string changehistory)
        {
            Disabled = disabled;
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

        public void ActivateUser()
        {
            Disabled = false;
        }

        public void DeactivateUser()
        {
            Disabled = true;
        }

        //Virtual method to return the name of the class as a string - virtual because this is individual for each class
        public virtual string GetClassName()
        {
            return "Person";
        }

    }
}
