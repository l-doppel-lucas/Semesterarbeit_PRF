using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        public int Zipcode { get; set;}
        public string ChangeHistory{ get; set; }


        /*---------------------------------------------------------------------
        Constructor
        -----------------------------------------------------------------------*/

        public Person(int id, string salutation, string firstname, string lastname, string mail, Boolean status,
            DateTime creationDate, string changehistory)
        {
            Id = id;
            Salutation = salutation;
            Firstname = firstname;
            Lastname = lastname;
            Mail = mail;
            Status = status;
            CreationDate = creationDate;
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

        public void SetOptionalAtt(DateTime bd, string gd, string mph, string bph, string bfa)
        {
            Birthdate = bd;
            Gender = gd;
            Mobilephone = mph;
            Businessphone = bph;
            Businessfax = bfa;

        }

        public void SetMandatoryAtt(string sal, string fn, string ln, string ma)
        {
            Salutation = sal;
            Firstname = fn;
            Lastname = ln;
            Mail = ma;
        }
        
        //Virtual method to return the name of the class as a string - virtual because this is individual for each class
        public virtual string GetClassName()
        {
            return "Person";
        }

    }
}
