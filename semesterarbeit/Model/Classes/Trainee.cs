using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterarbeit
{
    class Trainee : Employee
    {

        public string Appyears { get; set; }
        public string Currappyear { get; set; }


        /*---------------------------------------------------------------------
        Constructor
        -----------------------------------------------------------------------*/

        public Trainee(int id, string salutation, string firstname, string lastname, string email, Boolean status,
             DateTime creationDate, string lastmodified, string department, string role, string appyears) :
             base(id, salutation, firstname, lastname, email, status, creationDate, lastmodified, department, role)
        {
            Appyears = appyears;
        }


        /*---------------------------------------------------------------------
        Methods
        -----------------------------------------------------------------------*/

        public void SetMandatoryAttributes(int id, string sal, string fn, string ln, DateTime birthdate, string gender, string mail, 
            DateTime crdate, string street, string city, int zip, int emplnum, string departement, string role, string pens, DateTime entrdate, string appyears)
        {
            base.SetMandatoryAttributes(id, sal, fn, ln, birthdate, gender, mail, crdate, street, city, zip, emplnum, departement, role, pens, entrdate);

            Appyears = appyears;
        }

        public void SetOptionalAttributes(string title = "", string mph = "", string bph = "", string bfa = "", string chahist = "", string ahv = "",
            string pph = "", string birthpl = "", DateTime exdate = 31.12., string empllvl = "", string appyear = "")
        {
            base.SetOptionalAttributes(title, mph, bph, bfa, chahist, ahv, pph, birthpl, exdate);

                Currappyear = appyear;
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
