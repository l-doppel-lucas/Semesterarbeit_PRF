using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterarbeit
{
    enum MgmLvl
    {
        Level0,
        Level1,
        Level2,
        Level3,
        Level4,
        Level5
    }

    class Employee : Person
    {
        public int EmplNr { get; set; }
        public string Departement { get; set; }
        public string Workpensum { get; set; }
        public string Ahv { get; set;}
        public string Birthplace{ get; set; }
        public string Privatephone { get; set; }
        public DateTime Entrydate { get; set; }
        public DateTime Exitdate { get; set; }
        public string Employmentlvl { get; set; }
        public string Role { get; set; }
        public MgmLvl Lvl { get; set; }


        /*---------------------------------------------------------------------
        Constructor
        -----------------------------------------------------------------------*/
        public Employee(int id, string salutation, string firstname, string lastname, string mail, Boolean status,
            DateTime creationDate, string lastmodified, string department, string role) :
            base(id, salutation, firstname, lastname, mail, status, creationDate, lastmodified)
        {
            Departement = department;
            Role = role;
        }



        /*---------------------------------------------------------------------
        Methods
        -----------------------------------------------------------------------*/

        public void SetMandatoryAttributes(string sal, string fn, string ln, DateTime birthdate, string gender, string mail, string street, string city, int zip, int emplnum, string departement, string role, string pens, DateTime entrdate)
        {
            base.SetMandatoryAttributes(sal, fn, ln, birthdate, gender, mail, street, city, zip);

            EmplNr = emplnum;
            Departement = departement;
            Role = role;
            Workpensum = pens;
            Entrydate = entrdate;
        }


        public override string ToString()
        {
            return base.ToString() + ", " + Departement + ", " + Entrydate + ", " + Exitdate + ", " + Employmentlvl + ", " + Role + ", " + Lvl;
        }

        public override string PrintAll()
        {
            return base.PrintAll() + ", " + Departement + ", " + Entrydate + ", " + Exitdate + ", " + Employmentlvl + ", " + Role + ", " + Lvl;
        }

        public override string GetClassName()
        {
            return "Employee";
        }

    }
}
