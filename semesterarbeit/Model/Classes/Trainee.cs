using System;

namespace semesterarbeit
{ 

    [Serializable()]
class Trainee : Employee
    {

        public string Appyears { get; set; }
        public string Currappyear { get; set; }


       
        /*---------------------------------------------------------------------
        Methods
        -----------------------------------------------------------------------*/

        public void SetMandatoryAttributes(string sal, string fn, string ln, DateTime birthdate, string gender, string mail, 
            string street, string city, string zip, string changehistory, string departement, string role, string pens, DateTime entrdate, string appyears)
        {
            base.SetMandatoryAttributes(sal, fn, ln, birthdate, gender, mail, street, city, zip, changehistory, departement, role, pens, entrdate);

            Appyears = appyears;
        }

        public void SetOptionalAttributes(string title = "", string mph = "", string bph = "", string bfa = "", string ahv = "", string nat = "",
            string pph = "", string birthpl = "", DateTime exdate = new DateTime(), MgmLvl lvl = 0, string currappyear = "")
        {
            base.SetOptionalAttributes(title, mph, bph, bfa, ahv, nat, pph, birthpl, exdate, lvl);

                Currappyear = currappyear;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + Appyears + ", " + Currappyear;
        }

        public override string PrintAll()
        {
            return base.PrintAll() + ", " + Appyears + ", " + Currappyear;
        }


        public override string GetClassName()
        {
            return "Trainee";
        }


    }
}
