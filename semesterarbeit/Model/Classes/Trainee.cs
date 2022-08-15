using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace semesterarbeit
{
    class Trainee : Employee
    {

        public string Appyears { get; set; }
        public string Currappyear { get; set; }


        /*---------------------------------------------------------------------
        Constructor
        -----------------------------------------------------------------------*/

        public Trainee(int id, string salutation, string firstname, string lastname, DateTime birthdate, DateTime crdate, string gender, string mail, Boolean status,
             string street, string city, int zip, string changehistory, int emplnum, string departement, string pens, DateTime entrdate, string role, string appyears) :
            base(id, salutation, firstname, lastname, birthdate, crdate, gender, mail, status,
             street, city, zip, changehistory, emplnum, departement, pens, entrdate, role)
        {
            Appyears = appyears;
        }


        /*---------------------------------------------------------------------
        Methods
        -----------------------------------------------------------------------*/

        public void SetMandatoryAttributes(string sal, string fn, string ln, DateTime birthdate, string gender, string mail, 
            string street, string city, int zip, int emplnum, string departement, string role, string pens, DateTime entrdate, string appyears)
        {
            base.SetMandatoryAttributes(sal, fn, ln, birthdate, gender, mail, street, city, zip, emplnum, departement, role, pens, entrdate);

            Appyears = appyears;
        }

        public void SetOptionalAttributes(string title = "", string mph = "", string bph = "", string bfa = "", string chahist = "", string ahv = "",
            string pph = "", string birthpl = "", DateTime exdate = new DateTime(), string empllvl = "", string appyear = "")
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
