using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterarbeit
{
   class Person
    {
        /******** AutoProperties ********/
        public bool Status { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Ahv { get; set; }
        public string Nationality { get; set; }
        public string Privatephone { get; set; }
        public string Mobilephone { get; set; }
        public string Businessphone { get; set; }
        public string Businessfax { get; set; }
        public string Mail { get; set; }
        public string ChangeHistory{ get; set; }


        /******** Constructor ********/

        public Person(bool status, int id, string title, string salutation, string firstname, string lastname, DateTime birthdate, string gender, string ahv,
            string nationality, string privatephone, string mobilephone, string businessphone, string businessfax, string mail, string changehistory)
        {
            Status = status;
            Id = id;
            Title = title;
            Salutation = salutation;
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
            Gender = gender;
            Ahv = ahv;
            Nationality = nationality;
            Privatephone = privatephone;
            Businessphone = businessphone;
            Businessfax = businessfax;
            Mail = mail;
            ChangeHistory = changehistory;
        }



        /******** Methods ********/

        
    }
}
