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
        public string Departement { get; set; }
        public DateTime Entrydate { get; set; }
        public DateTime Exitdate { get; set; }
        public string Employmentlvl { get; set; }
        public string Role { get; set; }
        public MgmLvl Lvl { get; set; }


        /******** Constructor ********/

        public Employee(bool status, int id, string title, string salutation, string firstname, string lastname, DateTime birthdate, string gender, string ahv,
            string nationality, string privatephone, string mobilephone, string businessphone, string businessfax, string mail, string changehistory, 
            string departement, DateTime entrydate, DateTime exitdate, string employmentlvl, string role, MgmLvl lvl) : 

            base(status, id, title, salutation, firstname, lastname, birthdate, gender, 
                 ahv, nationality, privatephone, mobilephone, businessphone, businessfax, mail, changehistory)
            
        {
            Departement = departement;
            Entrydate = entrydate;
            Exitdate = exitdate;
            Employmentlvl = employmentlvl;
            Role = role;
            Lvl = lvl;
        }


    }
}
