using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterarbeit
{
    enum CustType
    {
        A,
        B,
        C,
        D,
        E
    }

    class Customer : Person
    {
        public string Companyname { get; set; }
        public string Companyadress { get; set; }
        public CustType Type { get; set; }
        public bool Companycontact { get; set; }
        public string NotesHistory{ get; set; }

        //Frage an Palmer: Mandatory Fields selbst definieren?


        /******** Constructor ********/

        public Customer(bool status, int id, string title, string salutation, string firstname, string lastname, DateTime birthdate, string gender, string ahv,
            string nationality, string privatephone, string mobilephone, string businessphone, string businessfax,
            string mail, string changehistory, string companyname, string companyadress, CustType type, bool companycontact, string notesHistory) :

            base(status, id, title, salutation, firstname, lastname, birthdate, gender,
            ahv, nationality, privatephone, mobilephone, businessphone, businessfax, mail, changehistory)
        {
            Companyname = companyname;
            Companyadress = companyadress;
            Type = type;
            Companycontact = companycontact;
            NotesHistory = notesHistory;
        }


        /******** Methods ********/

        public override string ToString()
        {
            return base.ToString() + ", " + Companyname + ", " + Companyadress + ", " + Type + ", " + Companycontact;
        }

        public override string PrintAll()
        {
            return base.PrintAll() + ", " + Companyname + ", " + Companyadress + ", " + Type + ", " + Companycontact;
        }

        public override string GetClassName()
        {
            return "Customer";
        }
    }
    
}
