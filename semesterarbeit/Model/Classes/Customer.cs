using System;

namespace semesterarbeit
{
    public enum CustType
    {
        A,
        B,
        C,
        D,
        E
    }

    [Serializable()]
    class Customer : Person
    {
        public string Companyname { get; set; }
        public CustType Type { get; set; }
        public string Companycontact { get; set; }
        public string NotesHistory { get; set; }



        /*---------------------------------------------------------------------
             Constructor
        -----------------------------------------------------------------------*/
        public Customer(int id, string salutation, string firstname, string lastname, DateTime birthdate, DateTime crdate, string gender, string mail, Boolean status,
             string street, string city, string zip, string changehistory, string companyname, CustType type, string companycontact)
            
            :base(id, salutation, firstname, lastname, birthdate, crdate, gender, mail, status,
             street, city, zip, changehistory)
        {
            Companyname = companyname;
            Type = type;
            Companycontact = companycontact;
        }


        /*---------------------------------------------------------------------
             Methods
        -----------------------------------------------------------------------*/

        public void SetMandatoryAttributes(string sal, string fn, string ln, DateTime birthdate, string gender, string mail, 
            string street, string city, string zip, string changehistory, string compname, CustType type)
        {
            base.SetMandatoryAttributes(sal, fn, ln, birthdate, gender, mail, street, city, zip, changehistory);

            Companyname = compname;
            Type = type;
        }

        public void SetOptionalAttributes(string title = "", string mph = "", string bph = "", string bfa = "", string compcont = "")
        {
            base.SetOptionalAttributes(title, mph, bph, bfa);

            Companycontact = compcont;

        }

        public override string ToString()
        {
            return base.ToString() + ", " + Companyname + ", " + Type + ", " + Companycontact;
        }

        public override string PrintAll()
        {
            return base.PrintAll() + ", " + Companyname + ", " + Type + ", " + Companycontact;
        }

        public override string GetClassName()
        {
            return "Customer";
        }
    }
    
}
