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

        public Trainee(int id, string sal, string fn, string ln, DateTime birthdate, DateTime crdate, string gender, string mail, Boolean status,
             string street, string city, int zip, string changehistory, int emplnum, string departement, string pens, DateTime entrdate, string role, string appyears) :
                base(id, sal, fn, ln, birthdate, crdate, gender, mail, status, street, 
                city, zip, changehistory, emplnum, departement, pens, entrdate, role)
        {
            Appyears = appyears;
        }


        /*---------------------------------------------------------------------
        Methods
        -----------------------------------------------------------------------*/

        public void SetMandatoryAttributes(string sal, string fn, string ln, DateTime birthdate, string gender, string mail, 
            string street, string city, int zip, string changehistory, int emplnum, string departement, string role, string pens, DateTime entrdate, string appyears)
        {
            base.SetMandatoryAttributes(sal, fn, ln, birthdate, gender, mail, street, city, zip, changehistory, emplnum, departement, role, pens, entrdate);

            Appyears = appyears;
        }

        public void SetOptionalAttributes(string title = "", string mph = "", string bph = "", string bfa = "", string ahv = "", string nat = "",
            string pph = "", string birthpl = "", DateTime exdate = new DateTime(), MgmLvl lvl = 0, string currappyear = "")
        {
            base.SetOptionalAttributes(title, mph, bph, bfa, ahv, pph, birthpl, exdate, lvl);

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
