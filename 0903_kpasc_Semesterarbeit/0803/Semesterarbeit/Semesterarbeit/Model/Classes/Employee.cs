using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterarbeit
{
    [Serializable()]
    class Employee : Person
    {

        /***************Properties***********************/
        //(Auto-)Properties
        public string Department { get; set; }
        public string AhvNumber { get; set; }
        public string StartDate { get; set; }
        public string LeaveDate { get; set; }
        public string Denomination { get; set; }
        public string Birthplace { get; set; }
        public string Nationality { get; set; }
        public string Role { get; set; }
        public string MgmtLevel { get; set; }
        public string DirectReports { get; set; }
        public string WorkPensum { get; set; }
        public string CivilStatus { get; set; }
        public string PrivatePhone { get; set; }


        /***************Constructor***********************/
        public Employee(int id, string salutation, string firstname, string lastname, string email, Boolean status,
            DateTime creationDate, string lastmodified, string department, string role ):
            base (id,salutation,firstname, lastname, email, status, creationDate, lastmodified )
        {
            Department = department;
            Role = role;
        }

        /***************Methods***********************/

        //Method to set all optional attributes
        public void SetOptionalAttributes(string sn = "", string g = "", string t = "", string bp = "", string bf = "",
            string mn = "", string s = "", string zc = "", string c = "", string bdate = "", string ahv = "", string d = "", string bipl = "", string nat = "",
            string mgmtl = "", string dr = "", string wp = "", string cs = "", string pf = "", string startdate = "", string leavedate = "")
        {
            base.SetOptionalAttributes(sn, g, t, bp, bf, mn, s, zc, c, bdate);

            AhvNumber = ahv;
            Denomination = d;
            Birthplace = bipl;
            Nationality = nat;
            MgmtLevel = mgmtl;
            DirectReports = dr;
            WorkPensum = wp;
            CivilStatus = cs;
            PrivatePhone = pf;
            StartDate = startdate;
            LeaveDate = leavedate;
        }

        //Method to set all mandatory attributes
        public void SetMandatoryAttributes(string sal, string fn, string ln, string email, string department, string role)
        {
            base.SetMandatoryAttributes(sal, fn, ln, email);

            Department = department;
            Role = role;
        }

        //Override method to return the name of the class as a string
        public override string GetClassName()
        {
            return "Employee";
        }

    }
}
