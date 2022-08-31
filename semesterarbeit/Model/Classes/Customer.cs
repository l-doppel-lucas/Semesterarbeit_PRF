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
             Methods
        -----------------------------------------------------------------------*/

        public void SetMandatoryAttributes(bool disabled, string sal, string fn, string ln, DateTime birthdate, string gender, string mail, 
            string street, string city, string zip, string changehistory, string compname, CustType type)
        {
            base.SetMandatoryAttributes(disabled, sal, fn, ln, birthdate, gender, mail, street, city, zip, changehistory);

            Companyname = compname;
            Type = type;
        }

        public void SetOptionalAttributes(string title, string mph, string bph, string bfa, string compcont)
        {
            base.SetOptionalAttributes(title, mph, bph, bfa);

            Companycontact = compcont;

        }

        public void TakeNotes(string notes)
        {
            NotesHistory += DateTime.Now + Environment.NewLine +  notes + Environment.NewLine + Environment.NewLine;
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
