using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterarbeit
{
    [Serializable()]
    class Apprentice : Employee
    {
        /***************Properties***********************/
        //(Auto-)Properties
        public string ApprentYears { get; set; }
        public string CurrentApprentYear { get; set; }

        /***************Constructor***********************/

        public Apprentice(int id, string salutation, string firstname, string lastname,string email, Boolean status,
            DateTime creationDate, string lastmodified, string department, string role,  string apprentyears) :
            base(id, salutation, firstname, lastname, email, status, creationDate, lastmodified, department, role)
        {
            ApprentYears = apprentyears;            
        }

        /***************Methods***********************/

        //Method to set all optional attributes
        public void SetOptionalAttributes(string sn = "", string g = "", string t = "", string bp = "", string bf = "",
             string mn = "", string s = "", string zc = "", string c = "", string bdate = "", string ahv = "", string d = "", string bipl = "", string nat = "",
            string mgmtl = "", string dr = "", string wp = "", string cs = "", string pf = "", string startdate = "", string leavedate = "", string capry =  "")
        {
            base.SetOptionalAttributes(sn, g, t, bp, bf, mn, s, zc, c, bdate, ahv, d, bipl, nat, mgmtl, dr, wp, cs, pf, startdate, leavedate);

            CurrentApprentYear = capry;
        }

        //Method to set all mandatory attributes
        public void SetMandatoryAttributes(string sal, string fn, string ln, string email, string department, string role, string appryear)
        {
            base.SetMandatoryAttributes(sal, fn, ln, email, department, role);

            ApprentYears = appryear;
        }

        //Override method to return the name of the class as a string
        public override string GetClassName()
        {
            return "Apprentice";
        }

    }
}
