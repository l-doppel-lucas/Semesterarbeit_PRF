using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterarbeit
{
    [Serializable()]
    public class Person : IPerson
    {
       
        /***************Properties***********************/

        //Auto-Properties
        public int ID { get; set; }
        public string Salutation { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Lastname { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public string BusinessPhone { get; set; }
        public string BusinessFax { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public Boolean Status { get; set; }
        public DateTime CreationDate { get; set; }
        public string LastModified { get; set; }


        /***************Constructor***********************/

        public Person(int id,string salutation, string firstname, string lastname, string email, Boolean status,
            DateTime creationDate, string lastmodified)
        {
            ID = id;
            Salutation = salutation;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Status = status;
            CreationDate = creationDate;
            LastModified = lastmodified;
        }


        /***************Methods***********************/

        //Method to set all optional attributes
        public void SetOptionalAttributes(string sn = "", string g = "", string t = "", string bp = "", string bf = "",
            string mn = "", string s = "", string zc = "", string c = "", string bdate = "")
        {
            Secondname = sn;
            Birthdate = bdate;
            Gender = g;
            Title = t;
            BusinessPhone = bp;
            BusinessFax = bf;
            MobileNumber = mn;
            Street = s;
            Zipcode = zc;
            City = c;
        }

        //Method to set all mandatory attributes
        public void SetMandatoryAttributes(string sal, string fn, string ln, string email)
        {
            Salutation = sal;
            Firstname = fn;
            Lastname = ln;
            Email = email;
        }


        //Virtual method to return the name of the class as a string - virtual because this is individual for each class
        public virtual string GetClassName()
        {
            return "Person";
        }

    }
}
